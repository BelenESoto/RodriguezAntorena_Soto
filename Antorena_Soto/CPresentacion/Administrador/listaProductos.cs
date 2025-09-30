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

    public partial class listaProductos : Form
    {
        private string modoBusqueda = "Codigo";
        private bool textoLimpiado = false;

        public List<Productox> Productos { get; private set; }

        private string modo; // "Ver" o "Editar"
        private int codigo;
        private PrintDocument printDocument;
        private string textoAImprimir;

        public listaProductos(List<Productox> productos, string modo = "Ver")
        {
            InitializeComponent();
            this.modo = modo;
            this.Productos = productos;
        }


        private void listaProductos_Load(object sender, EventArgs e)
        {
            if (DGVListaProd.Columns.Count == 0)
            {
                DGVListaProd.Columns.Add("nOrden", "Orden Producto");
                DGVListaProd.Columns.Add("Codigo", "Código Producto");
                DGVListaProd.Columns.Add("Nombre", "Nombre Producto");
                DGVListaProd.Columns.Add("Precio", "Precio");
                DGVListaProd.Columns.Add("Categoria", "Categoría");
                DGVListaProd.Columns.Add("Stock", "Stock");
                DGVListaProd.Columns.Add("Descripcion", "Descripción");
                DGVListaProd.Columns.Add("Imagen", "Imagen");
                DGVListaProd.Columns.Add("Estado", "Estado");
            }
            modoBusqueda = "Codigo";
            BBuscarProducto.Text = "Buscar por: Código";
            CargarProductos();
        }

        public void CargarProductos()
        {
            if (modo == "Ver")
            {
                BEditarProd.Visible = false;
                BEliminarProd.Visible = false;
            }
            else if (modo == "Editar")
            {
                BEditarProd.Visible = true;
                BEliminarProd.Visible = true;
            }

            int contador = 1;

            DGVListaProd.Rows.Clear();
            foreach (var p in Productos)
            {
                DGVListaProd.Rows.Add(

                    contador,
                    p.Codigo,
                    p.Nombre,
                    p.Precio,
                    p.Categoria,
                    p.Stock,
                    p.FechaModificacion,
                    p.Imagen,
                    p.Estado ? "Activo" : "Inactivo"
                );
                contador++;
            }
        }

        private void DGVListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBBuscarProd_Click(object sender, EventArgs e)
        {

        }
        private void TBuscadorProd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BEditarProd_Click(object sender, EventArgs e)
        {
            if (DGVListaProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.");
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow fila = DGVListaProd.SelectedRows[0];

            // Tomar el código del producto
            int codigoInt;
            if (!int.TryParse(fila.Cells["Codigo"].Value.ToString(), out codigoInt))
            {
                MessageBox.Show("Código de producto inválido.");
                return;
            }

            // Buscar el producto en la lista
            var prod = Productos.FirstOrDefault(p => p.Codigo == codigoInt);

            if (prod != null)
            {
                // Abrimos el formulario AltaProductos en modo edición
                using (AltaProductos formAlta = new AltaProductos(prod))
                {
                    if (formAlta.ShowDialog() == DialogResult.OK)
                    {
                        // Asignamos los valores editados al producto original
                        prod.Codigo = formAlta.CodigoProducto;
                        prod.Nombre = formAlta.NombreProducto;
                        prod.Precio = formAlta.PrecioProducto;
                        prod.Categoria = formAlta.CategoriaProducto;
                        prod.Stock = formAlta.StockProducto;
                        prod.Descripcion = formAlta.DescripcionProducto;
                        prod.FechaModificacion = DateTime.Now;
                        prod.Imagen = formAlta.ImagenProducto;
                        prod.Estado = (bool)formAlta.EstadoProducto;

                        // Refrescamos la grilla
                        CargarProductos();
                    }
                }
            }
        }


        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
        }

        private void TBBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void toolCodigoProd_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Codigo";
            BBuscarProducto.Text = "Buscar por: Código";
            TBBuscarProducto.Clear();
            textoLimpiado = false;
        }

        private void toolNombreProd_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Nombre";
            BBuscarProducto.Text = "Buscar por: Nombre";
            TBBuscarProducto.Clear();
            textoLimpiado = false;
        }

        private void BTSBusquedaProd_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validaciones
            if (modoBusqueda == "Codigo" && !int.TryParse(criterio, out _))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (modoBusqueda == "Nombre" && !criterio.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Ingrese un nombre válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar en la lista
            List<Productox> resultado;
            if (modoBusqueda == "Codigo")
            {
                resultado = Productos.Where(p => p.Codigo.ToString().Contains(criterio)).ToList();
            }
            else
            {
                resultado = Productos.Where(p => p.Nombre.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            // Mostrar resultados
            DGVListaProd.Rows.Clear();
            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con ese criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int contador = 1;
            foreach (var p in resultado)
            {
                DGVListaProd.Rows.Add(
                    contador++,
                    p.Codigo,
                    p.Nombre,
                    p.Precio,
                    p.Categoria,
                    p.Stock,
                    p.Descripcion,
                    p.Imagen,
                    p.Estado ? "Activo" : "Inactivo"
                );
            }
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Código")
            {
                modoBusqueda = "Codigo";
            }
            else if (e.ClickedItem.Text == "Nombre")
            {
                modoBusqueda = "Nombre";
            }
        }

        private void BEliminarProd_Click(object sender, EventArgs e)
        {
            if (DGVListaProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar.");
                return;
            }

            var fila = DGVListaProd.SelectedRows[0];

            if (!int.TryParse(fila.Cells["Codigo"].Value.ToString(), out int codigoInt))
            {
                MessageBox.Show("Código de producto inválido.");
                return;
            }

            var prod = Productos.FirstOrDefault(p => p.Codigo == codigoInt);

            if (prod != null)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea dar de baja este producto?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    prod.Estado = false;
                    prod.FechaModificacion = DateTime.Now;

                    CargarProductos(); // refresca la grilla
                    MessageBox.Show("Producto dado de baja correctamente.", "Baja lógica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            if (DGVListaProd.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Elegir qué imprimir
            DialogResult dr = MessageBox.Show("¿Desea imprimir solo la selección?\n\n(Si selecciona NO, se imprimirá toda la lista)",
                                              "Imprimir productos",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel) return;

            // Construir el texto a imprimir
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LISTADO DE PRODUCTOS");
            sb.AppendLine(new string('=', 70));

            // Encabezados
            sb.AppendLine($"{"Código",-10} {"Nombre",-20} {"Precio",-10} {"Categoría",-15} {"Stock",-8} {"Estado",-10}");
            sb.AppendLine(new string('-', 70));

            // Filas a imprimir
            var filas = dr == DialogResult.Yes && DGVListaProd.SelectedRows.Count > 0
                ? DGVListaProd.SelectedRows.Cast<DataGridViewRow>()
                : DGVListaProd.Rows.Cast<DataGridViewRow>();

            foreach (DataGridViewRow row in filas)
            {
                if (row.IsNewRow) continue;

                sb.AppendLine(
                    $"{row.Cells["Codigo"].Value,-10} " +
                    $"{row.Cells["Nombre"].Value,-20} " +
                    $"{row.Cells["Precio"].Value,-10} " +
                    $"{row.Cells["Categoria"].Value,-15} " +
                    $"{row.Cells["Stock"].Value,-8} " +
                    $"{row.Cells["Estado"].Value,-10}"
                );
            }

            textoAImprimir = sb.ToString();

            // Crear y configurar el PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Mostrar vista previa
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.StartPosition = FormStartPosition.CenterScreen;

            preview.ShowDialog();
        }


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fuente y posición inicial
            Font fuente = new Font("Consolas", 10);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Dibujar el texto
            e.Graphics.DrawString(textoAImprimir, fuente, Brushes.Black, new RectangleF(x, y, e.MarginBounds.Width, e.MarginBounds.Height));

            // Si el texto no entra en una sola página, podrías manejar paginación aquí.
            e.HasMorePages = false;
        }

        private void DGVListaProd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    


    






