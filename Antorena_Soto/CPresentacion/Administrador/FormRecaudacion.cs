using Antorena_Soto.CDatos;
using Antorena_Soto.CLogica;
using Antorena_Soto.CPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Forms.DataVisualization.Charting;


namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class FormRecaudacion : Form
    {
        private readonly CN_Producto cn_Producto;
        private readonly string conexionString;
        private bool busquedaPorFecha = true;
        private decimal ultimoMonto = 0;
        private int ultimaCantidad = 0;

        private PrintDocument printDocument;

        public FormRecaudacion()
        {
            InitializeComponent();
            this.conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            InicializarEventosYDocumentos();
        }

        private void FormRecaudacion_Load(object sender, EventArgs e)
        {
            // Estado inicial → visible solo la búsqueda por fecha
            dtpFecha.Visible = false;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private void InicializarEventosYDocumentos()
        {
            // Eventos
            btnPorFecha.Click += BtnPorFecha_Click;
            btnPorPeriodo.Click += BtnPorPeriodo_Click;
            this.btnBuscar.Click += btnBuscar_Click; 
            btnImprimir.Click += BtnImprimir_Click;

            // Documento de impresión
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void BtnPorFecha_Click(object sender, EventArgs e)
        {
            busquedaPorFecha = true;
            dtpFecha.Visible = true;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private void BtnPorPeriodo_Click(object sender, EventArgs e)
        {
            busquedaPorFecha = false;
            dtpFecha.Visible = false;
            dtpDesde.Visible = true;
            dtpHasta.Visible = true;
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        { 
            DateTime hoy = DateTime.Today;

            // Reset
            ultimoMonto = 0;
            ultimaCantidad = 0;

            if (busquedaPorFecha)
            {
                DateTime fecha = dtpFecha.Value.Date;

                if (fecha > hoy)
                {
                    MessageBox.Show("La fecha no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                (ultimoMonto, ultimaCantidad) =
                    ObtenerRecaudacion(fecha, fecha);
                MostrarGraficoSemana(fecha);
            }
            else
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (desde > hoy || hasta > hoy)
                {
                    MessageBox.Show("No se pueden seleccionar fechas futuras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                (ultimoMonto, ultimaCantidad) =
                    ObtenerRecaudacion(desde, hasta);
                MostrarGraficoMensual(desde, hasta);
            }

            // Mostrar resultados
            lblMonto.Text = $"Total: ${ultimoMonto}";
            lblCantidad.Text = $"Unidades: {ultimaCantidad}";
        }


        private (decimal totalMonto, int totalCantidad) ObtenerRecaudacion(DateTime desde, DateTime hasta)
        {
            decimal totalMonto = 0;
            int totalCantidad = 0;

            string consulta = @"
        SELECT 
            ISNULL(SUM(monto_total),0) AS TotalMonto,
            ISNULL(SUM(DV.cantidad),0) AS TotalCantidad
        FROM Factura F
        LEFT JOIN Detalle_venta DV ON F.nro_factura = DV.id_factura
        WHERE CONVERT(date, F.fecha_factura) BETWEEN @Desde AND @Hasta";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        totalMonto = Convert.ToDecimal(dr.GetValue(0));
                        totalCantidad = dr.GetInt32(1);
                    }
                }
            }

            return (totalMonto, totalCantidad);
        }

        private DataTable ObtenerDatosSemana(DateTime fecha)
        {
            // Determinar lunes y domingo de la semana
            int delta = DayOfWeek.Monday - fecha.DayOfWeek;
            DateTime lunes = fecha.AddDays(delta);
            DateTime domingo = lunes.AddDays(6);

            DataTable tabla = new DataTable();

            string consulta = @"
        SELECT 
            CONVERT(date, F.fecha_factura) AS Fecha,
            SUM(F.monto_total) AS Monto
        FROM Factura F
        WHERE CONVERT(date, F.fecha_factura) BETWEEN @Desde AND @Hasta
        GROUP BY CONVERT(date, F.fecha_factura)
        ORDER BY Fecha";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlCommand cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@Desde", lunes);
                cmd.Parameters.AddWithValue("@Hasta", domingo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        private void MostrarGraficoSemana(DateTime fechaSeleccionada)
        {
            DataTable datos = ObtenerDatosSemana(fechaSeleccionada);

            chartRecaudacion.Series.Clear();
            chartRecaudacion.ChartAreas.Clear();
            chartRecaudacion.ChartAreas.Add(new ChartArea("Area1"));

            Series serie = new Series("Recaudación Semanal");
            serie.ChartType = SeriesChartType.Column;

            chartRecaudacion.Series.Add(serie);

            // Recorremos lunes–domingo
            DateTime inicio = fechaSeleccionada.AddDays(DayOfWeek.Monday - fechaSeleccionada.DayOfWeek);

            for (int i = 0; i < 7; i++)
            {
                DateTime dia = inicio.AddDays(i);

                // Buscar el dato del día
                DataRow[] fila = datos.Select($"Fecha = '{dia:yyyy-MM-dd}'");

                decimal monto = fila.Length > 0 ? Convert.ToDecimal(fila[0]["Monto"]) : 0;

                int idx = serie.Points.AddXY(dia.ToString("ddd dd"), monto);

                // Destacar el día seleccionado
                if (dia.Date == fechaSeleccionada.Date)
                {
                    serie.Points[idx].Color = Color.Blue;
                    serie.Points[idx].BorderWidth = 3;
                    serie.Points[idx].Label = $"{monto:C}";
                }
                else
                {
                    serie.Points[idx].Label = $"{monto:C}";
                }
            }
        }

        /*private DataTable ObtenerDatosMensuales(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            string consulta = @"
        SELECT 
            FORMAT(F.fecha_factura, 'yyyy-MM') AS Mes,
            SUM(F.monto_total) AS Monto
        FROM Factura F
        WHERE CONVERT(date, F.fecha_factura) BETWEEN @Desde AND @Hasta
        GROUP BY FORMAT(F.fecha_factura, 'yyyy-MM')
        ORDER BY Mes";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlCommand cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }*/
        private DataTable ObtenerDatosMensuales(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            // --- CONSULTA MODIFICADA ---
            // Se reemplazó FORMAT() por CONVERT() para compatibilidad
            // con versiones de SQL Server anteriores a 2012.
            // El estilo 120 (o 126) da el formato 'YYYY-MM-DD', 
            // y VARCHAR(7) lo corta a 'YYYY-MM'.
            string consulta = @"
    SELECT 
        CONVERT(VARCHAR(7), F.fecha_factura, 120) AS Mes,
        SUM(F.monto_total) AS Monto
    FROM Factura F
    WHERE CONVERT(date, F.fecha_factura) BETWEEN @Desde AND @Hasta
    GROUP BY CONVERT(VARCHAR(7), F.fecha_factura, 120)
    ORDER BY Mes";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlCommand cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        private void MostrarGraficoMensual(DateTime desde, DateTime hasta)
        {
            DataTable datos = ObtenerDatosMensuales(desde, hasta);

            chartRecaudacion.Series.Clear();
            chartRecaudacion.ChartAreas.Clear();
            chartRecaudacion.ChartAreas.Add(new ChartArea("Area1"));

            Series serie = new Series("Recaudación Mensual");
            serie.ChartType = SeriesChartType.Column;

            chartRecaudacion.Series.Add(serie);

            foreach (DataRow row in datos.Rows)
            {
                string mes = row["Mes"].ToString();
                decimal monto = Convert.ToDecimal(row["Monto"]);

                serie.Points.AddXY(mes, monto);
            }
        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float margenX = 80;
            float margenY = 80;
            float offsetY = margenY;

            Font fontTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fontTexto = new Font("Arial", 12);

            e.Graphics.DrawString("Reporte de Recaudación", fontTitulo, Brushes.Black, margenX, offsetY);
            offsetY += 40;

            e.Graphics.DrawString(lblMonto.Text, fontTexto, Brushes.Black, margenX, offsetY);
            offsetY += 25;

            e.Graphics.DrawString(lblCantidad.Text, fontTexto, Brushes.Black, margenX, offsetY);
            offsetY += 40;

            e.Graphics.DrawString("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                                  fontTexto, Brushes.Black, margenX, offsetY);
            offsetY += 40;

            Image grafico = CapturarGrafico();

            int anchoImprimir = 700;   // ajustable
            int altoImprimir = (int)(grafico.Height * (700.0 / grafico.Width));

            //Rectangle destino = new Rectangle((int)margenX, (int)offsetY, anchoImprimir, altoImprimir);
            int xCentrado = (e.PageBounds.Width - anchoImprimir) / 2;
            Rectangle destino = new Rectangle(xCentrado, (int)offsetY, anchoImprimir, altoImprimir);

            e.Graphics.DrawImage(grafico, destino);
        }

        private Image CapturarGrafico()
        {
            Bitmap bmp = new Bitmap(chartRecaudacion.Width, chartRecaudacion.Height);
            chartRecaudacion.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
        private void btnBuscar_CursorChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void btnPorPeriodo_Click_1(object sender, EventArgs e)
        {

        }

        private void lRecaudacionB_Click(object sender, EventArgs e)
        {

        }

        private void montoRec_Click(object sender, EventArgs e)
        {

        }
    }
}


