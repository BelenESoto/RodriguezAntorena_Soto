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
                MostrarGraficoProductos(fecha, fecha);
                MostrarGraficoCategorias(fecha, fecha);
            }
            else
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;
                MostrarGraficoProductos(desde, hasta);
                MostrarGraficoCategorias(desde, hasta);

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

           
            lblMonto.Text = $"Total: ${ultimoMonto}";
            lblCantidad.Text = $"Unidades: {ultimaCantidad}";
        }

        //Metodo con la consulta para obtener la recaudacion  
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

                DataRow[] fila = datos.Select($"Fecha = '{dia:yyyy-MM-dd}'");

                decimal monto = fila.Length > 0 ? Convert.ToDecimal(fila[0]["Monto"]) : 0;

                int idx = serie.Points.AddXY(dia.ToString("ddd dd"), monto);

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

        private DataTable ObtenerDatosMensuales(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

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

            int anchoImprimir = 700; 
            int xCentrado = (e.PageBounds.Width - anchoImprimir) / 2;
            int paddingGrafico = 30; 


            Image graficoBarras = CapturarControl(chartRecaudacion);
            if (graficoBarras.Width > 0)
            {
                int altoImprimirBarras = (int)(graficoBarras.Height * (anchoImprimir / (double)graficoBarras.Width));
                Rectangle destinoBarras = new Rectangle(xCentrado, (int)offsetY, anchoImprimir, altoImprimirBarras);
                e.Graphics.DrawImage(graficoBarras, destinoBarras);

                offsetY += altoImprimirBarras + paddingGrafico;
            }


            Image graficoProductos = CapturarControl(chartProductos);
            if (graficoProductos.Width > 0)
            {
                int altoImprimirProductos = (int)(graficoProductos.Height * (anchoImprimir / (double)graficoProductos.Width));
                Rectangle destinoProductos = new Rectangle(xCentrado, (int)offsetY, anchoImprimir, altoImprimirProductos);
                e.Graphics.DrawImage(graficoProductos, destinoProductos);

                offsetY += altoImprimirProductos + paddingGrafico;
            }

            Image graficoCategorias = CapturarControl(chartCategorias);
            if (graficoCategorias.Width > 0)
            {
                int altoImprimirCategorias = (int)(graficoCategorias.Height * (anchoImprimir / (double)graficoCategorias.Width));
                Rectangle destinoCategorias = new Rectangle(xCentrado, (int)offsetY, anchoImprimir, altoImprimirCategorias);
                e.Graphics.DrawImage(graficoCategorias, destinoCategorias);
            }
        }
        
        private Image CapturarControl(Control control)
        {
            if (control.Width <= 0 || control.Height <= 0)
            {
                return new Bitmap(1, 1);
            }

            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
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

        private void lRecaudacion_Click(object sender, EventArgs e)
        {

        }

        //NUEVAS FUNCIONES PARA GRAFICO : 
        
        private DataTable ObtenerProductosMasVendidos(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            string consulta = @"
        SELECT TOP 5 
            P.nombre_prod AS Producto,
            SUM(DV.cantidad) AS CantidadVendida
        FROM Detalle_venta DV
        INNER JOIN Producto P ON DV.id_producto = P.codigo_prod
        INNER JOIN Factura F ON F.nro_factura = DV.id_factura
        WHERE CONVERT(date, F.fecha_factura) BETWEEN @Desde AND @Hasta
        GROUP BY P.nombre_prod
        ORDER BY CantidadVendida DESC";

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

        //MOSTRAR GRAFICO DE PRODUCTO MAS VENDIDOSS
        private void MostrarGraficoProductos(DateTime desde, DateTime hasta)
        {
            DataTable datos = ObtenerProductosMasVendidos(desde, hasta);

            chartProductos.Series.Clear();
            chartProductos.ChartAreas.Clear();
            chartProductos.ChartAreas.Add(new ChartArea("AreaProductos"));

            Series serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "{0}";

            chartProductos.Series.Add(serie);

            foreach (DataRow row in datos.Rows)
            {
                string producto = row["Producto"].ToString();
                int cantidad = Convert.ToInt32(row["CantidadVendida"]);
                serie.Points.AddXY(producto, cantidad);
            }

            chartProductos.Titles.Clear();
            chartProductos.Titles.Add("Productos más vendidos");
        }

        // CATEGORIA MAS VENDIDA 
        private DataTable ObtenerCategoriasMasVendidas(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            string consulta = @"
        SELECT TOP 5 
            C.nombre_categoria AS Categoria,
            SUM(DV.cantidad) AS CantidadVendida
        FROM Detalle_venta DV
        INNER JOIN Producto P ON DV.id_producto = P.codigo_prod
        INNER JOIN Categoria C ON P.categoria_prod = C.id_categoria
        INNER JOIN Factura F ON F.nro_factura = DV.id_factura
        WHERE CONVERT(date, F.fecha_factura) BETWEEN @Desde AND @Hasta
        GROUP BY C.nombre_categoria
        ORDER BY CantidadVendida DESC";

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
        //MOSTRAR GRAFICO DE CATEGORIA MAS VENDIDOSS

        private void MostrarGraficoCategorias(DateTime desde, DateTime hasta)
        {
            DataTable datos = ObtenerCategoriasMasVendidas(desde, hasta);

            chartCategorias.Series.Clear();
            chartCategorias.ChartAreas.Clear();
            chartCategorias.ChartAreas.Add(new ChartArea("AreaCategorias"));

            Series serie = new Series("Categorías");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "{0}";

            chartCategorias.Series.Add(serie);

            foreach (DataRow row in datos.Rows)
            {
                string categoria = row["Categoria"].ToString();
                int cantidad = Convert.ToInt32(row["CantidadVendida"]);
                serie.Points.AddXY(categoria, cantidad);
            }

            chartCategorias.Titles.Clear();
            chartCategorias.Titles.Add("Categorías más vendidas");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}


