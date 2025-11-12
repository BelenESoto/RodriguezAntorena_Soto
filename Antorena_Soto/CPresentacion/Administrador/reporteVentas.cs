
using Antorena_Soto.CDatos;
using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class reporteVentas : Form
    {
        private string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
        private DataTable ventasTabla;   // Para almacenar resultados

        private string modoBusqueda = "Fecha";
        // private List<Venta> Ventas;
        private PrintDocument printDocument;
        private string textoAImprimir;


        public reporteVentas()
        {
            InitializeComponent();
        }

        private void reporteVentas_Load_1(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            DGVentas.ColumnHeadersVisible = true;
            DGVentas.EnableHeadersVisualStyles = false;
            DGVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            DGVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DGVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            CargarVentasDesdeBD();
        }

        private void ConfigurarColumnas()
        {
            DGVentas.Columns.Clear();

            DGVentas.Columns.Add("CodigoVenta", "Código Venta");
            DGVentas.Columns.Add("Cliente", "Nombre Cliente");
            DGVentas.Columns.Add("FechaVenta", "Fecha Venta");
            DGVentas.Columns.Add("Vendedor", "Nombre Vendedor");
            DGVentas.Columns.Add("Total", "Total");

            // Botón Ver Detalle
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.Name = "Detalle";
            colBtn.DefaultCellStyle.NullValue = "Ver";
            colBtn.HeaderText = "VerDetale";
            //colBtn.Text = "Ver";
            colBtn.UseColumnTextForButtonValue = true;
            colBtn.Width = 120;
            DGVentas.Columns.Add(colBtn);
            (DGVentas.Columns["Detalle"] as DataGridViewButtonColumn).UseColumnTextForButtonValue = true;
        }

        private void CargarVentasDesdeBD()
        {
            string consulta = @"
        SELECT 
            F.nro_factura AS CodigoVenta,
            C.nomYApe_cliente AS Cliente,
            F.fecha_factura AS FechaVenta,
            U.nomYApe_usuario AS Vendedor,
            F.monto_total AS Total
        FROM Factura F
        INNER JOIN Cliente C ON F.id_cliente = C.dni_cliente
        INNER JOIN Usuario U ON F.vendedor_id = U.id_dni_usuario
        ORDER BY F.fecha_factura DESC";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlDataAdapter da = new SqlDataAdapter(consulta, con))
            {
                ventasTabla = new DataTable();
                da.Fill(ventasTabla);

                DGVentas.Rows.Clear();

                foreach (DataRow row in ventasTabla.Rows)
                {
                    DGVentas.Rows.Add(
                        row["CodigoVenta"],
                        row["Cliente"],
                        Convert.ToDateTime(row["FechaVenta"]).ToString("dd/MM/yyyy"),
                        row["Vendedor"],
                       Convert.ToDecimal(row["Total"]).ToString("$#,##0.00")
                    );
                }
            }
        }


        private void toolFecha_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Fecha";
            tsdFiltroBusqueda.Text = "Fecha";
            TBBuscarProducto.Clear();
        }

        private void toolCliente_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Cliente";
            tsdFiltroBusqueda.Text = "Cliente";
            TBBuscarProducto.Clear();
        }

        private void toolVendedor_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Vendedor";
            tsdFiltroBusqueda.Text = "Vendedor";
            TBBuscarProducto.Clear();
        }

        private void toolProducto_Click(object sender, EventArgs e)
        {
            modoBusqueda = "CodVenta";
            tsdFiltroBusqueda.Text = "Cod de Venta";
            TBBuscarProducto.Clear();
        }

        private void BTSBusquedaProd_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BuscarVentasDesdeBD(criterio);
        }

        private void BuscarVentasDesdeBD(string criterio)
        {
            string where = "";
            SqlCommand cmd = new SqlCommand();

            switch (modoBusqueda)
            {
                case "Fecha":
                    if (!DateTime.TryParse(criterio, out DateTime fecha))
                    {
                        MessageBox.Show("Ingrese una fecha válida.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE CONVERT(date, F.fecha_factura) = @Fecha";
                    cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                    break;

                case "Cliente":
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("El DNI del cliente debe ser numérico.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE C.dni_cliente = @DNICliente";
                    cmd.Parameters.AddWithValue("@DNICliente", criterio);
                    break;

                case "Vendedor":
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("El DNI del vendedor debe ser numérico.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE U.id_dni_usuario = @DNIVend";
                    cmd.Parameters.AddWithValue("@DNIVend", criterio);
                    break;

                case "CodVenta":
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("El código debe ser numérico.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE F.nro_factura = @Cod";
                    cmd.Parameters.AddWithValue("@Cod", int.Parse(criterio));
                    break;
            }

            string consulta = $@"
                SELECT 
                    F.nro_factura AS CodigoVenta,
                    C.nomYApe_cliente AS Cliente,
                    F.fecha_factura AS FechaVenta,
                    U.nomYApe_usuario AS Vendedor,
                    F.monto_total AS Total
                FROM Factura F
                INNER JOIN Cliente C ON F.id_cliente = C.dni_cliente
                INNER JOIN Usuario U ON F.vendedor_id = U.id_usuarios
                {where}
                ORDER BY F.fecha_factura DESC";

            cmd.CommandText = consulta;
            cmd.Connection = new SqlConnection(conexionString);

            DataTable resultado = new DataTable();

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }

            DGVentas.Rows.Clear();

            foreach (DataRow row in resultado.Rows)
            {
                DGVentas.Rows.Add(
                    row["CodigoVenta"],
                    row["Cliente"],
                    Convert.ToDateTime(row["FechaVenta"]).ToString("dd/MM/yyyy"),
                    row["Vendedor"],
                    Convert.ToDecimal(row["Total"]).ToString("$#,##0.00")
                );
            }
        }
        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVentas.Columns[e.ColumnIndex].Name == "Detalle")
            {
                int codigoVenta = Convert.ToInt32(
                    DGVentas.Rows[e.RowIndex].Cells["CodigoVenta"].Value);

                // Abrir tu formulario REAL
                facturaVenta form = new facturaVenta(codigoVenta);
                form.ShowDialog();
            }
        }
        // Botón Imprimir
        private void bImprimir_Click(object sender, EventArgs e)
        {
            if (DGVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("REPORTE DE VENTAS");
            sb.AppendLine(new string('=', 100));
            sb.AppendLine($"{"Código",-10} {"Cliente",-20} {"Fecha",-12} {"Vendedor",-20} {"Total",-10}");
            sb.AppendLine(new string('-', 100));

            foreach (DataGridViewRow row in DGVentas.Rows)
            {
                if (row.IsNewRow) continue;
                sb.AppendLine(
                    $"{row.Cells["CodigoVenta"].Value,-10} " +
                    $"{row.Cells["Cliente"].Value,-20} " +
                    $"{row.Cells["FechaVenta"].Value,-12} " +
                    $"{row.Cells["Vendedor"].Value,-20} " +
                    $"{row.Cells["Total"].Value,-10}"
                );
            }

            textoAImprimir = sb.ToString();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.StartPosition = FormStartPosition.CenterScreen;
            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Consolas", 10);
            e.Graphics.DrawString(textoAImprimir, fuente, Brushes.Black,
                new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top,
                e.MarginBounds.Width, e.MarginBounds.Height));
        }

        private void pReporteVenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsdFiltroBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void toolStripRepVenta_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TBBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void lReporteVentas_Click(object sender, EventArgs e)
        {

        }
    }

    public class Venta
    {
        public int CodigoVenta { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NombreVendedor { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Total { get; set; }
    }

    public class Producto
    {
        public string Nombre { get; set; }
    }
}