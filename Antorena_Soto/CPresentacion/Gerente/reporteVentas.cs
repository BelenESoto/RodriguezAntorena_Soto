
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class reporteVentas : Form
    {
        private string modoBusqueda = "Fecha";
        private List<Venta> Ventas;
        private PrintDocument printDocument;
        private string textoAImprimir;

        public reporteVentas(List<Venta> ventas)
        {
            InitializeComponent();
            this.Ventas = ventas;
        }

        private void reporteVentas_Load_1(object sender, EventArgs e)
        {
            // Configurar columnas si no existen
            if (DGVentas.Columns.Count == 0)
            {
                DGVentas.Columns.Add("CodigoVenta", "Código Venta");
                DGVentas.Columns.Add("Cliente", "Nombre Cliente");
                DGVentas.Columns.Add("FechaVenta", "Fecha Venta");
                DGVentas.Columns.Add("Vendedor", "Nombre Vendedor");
                DGVentas.Columns.Add("Productos", "Productos");
                DGVentas.Columns.Add("Total", "Total");
            }

            // Cargar todas las ventas al iniciar
            CargarVentas(Ventas);
        }

        private void CargarVentas(List<Venta> ventas)
        {
            DGVentas.Rows.Clear();
            foreach (var v in ventas)
            {
                string productosConcatenados = string.Join(", ", v.Productos.Select(p => p.Nombre));

                DGVentas.Rows.Add(
                    v.CodigoVenta,
                    v.NombreCliente,
                    v.FechaVenta.ToString("dd/MM/yyyy"),
                    v.NombreVendedor,
                    productosConcatenados,
                    v.Total.ToString("C")
                );
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

        // Botón de búsqueda
        private void BTSBusquedaProd_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarProducto.Text.Trim();

            // Validar que se ingrese algo
            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IEnumerable<Venta> resultado = Ventas;

            switch (modoBusqueda)
            {
                case "Fecha":
                    // Validar que sea una fecha válida
                    if (!DateTime.TryParse(criterio, out DateTime fechaBuscada))
                    {
                        MessageBox.Show("Ingrese una fecha válida (ej: 30/09/2025).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultado = Ventas.Where(v => v.FechaVenta.Date == fechaBuscada.Date);
                    break;

                case "Cliente":
                    // Validar solo letras y espacios
                    if (!criterio.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("No se permiten números ni caracteres especiales en el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultado = Ventas.Where(v => v.NombreCliente.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;

                case "Vendedor":
                    // Validar solo letras y espacios
                    if (!criterio.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("No se permiten números ni caracteres especiales en el nombre del vendedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultado = Ventas.Where(v => v.NombreVendedor.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;

                case "CodVenta":
                    // Validar que sea número
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("Solo se permiten números en el código de la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultado = Ventas.Where(v => v.CodigoVenta.ToString().Contains(criterio));
                    break;

                default:
                    MessageBox.Show("Criterio de búsqueda no válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Convertir a lista y mostrar resultados
            var lista = resultado.ToList();
            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas con ese criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CargarVentas(lista);
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
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            e.Graphics.DrawString(textoAImprimir, fuente, Brushes.Black, new RectangleF(x, y, e.MarginBounds.Width, e.MarginBounds.Height));
            e.HasMorePages = false;
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
    }

    // 📌 Clase auxiliar: debe existir en tu modelo real
    public class Venta
    {
        public int CodigoVenta { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NombreVendedor { get; set; }
        public List<Productox> Productos { get; set; }
        public decimal Total { get; set; }
    }

    public class Producto
    {
        public string Nombre { get; set; }
    }
}


