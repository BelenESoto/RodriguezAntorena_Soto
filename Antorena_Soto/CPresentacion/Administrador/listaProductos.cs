using Antorena_Soto.CDatos;
using Antorena_Soto.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
       
namespace Antorena_Soto.CPresentacion.Administrador
{ 
    //    private bool buscarPorCodigo = true;
        public partial class listaProductos : Form
    {

        private readonly CN_Producto cn_Producto;
        private readonly string conexionString;
        private bool buscarPorCod = true;
        private string _modo = "Codigo";

        private List<Productox> _productos; // lista de productos borrar
        
        private bool textoLimpiado = false; 
        private string textoAImprimir; 
        private PrintDocument printDocument;

        public listaProductos()
        {
            InitializeComponent();
            conexionString = "Data Source=HP-BELENS\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";

            // Inicializa la capa lógica con la conexión
             cn_Producto = new CN_Producto(conexionString);
          
        }

        
        public listaProductos(List<Productox> productos, string modo)
        {
            InitializeComponent();
            _productos = productos;
            _modo = modo;

            CargarGrilla();
        }
        
        private void CargarGrilla()
        {
            DGVListaProd.Rows.Clear();
            int contador = 1;

            foreach (var p in _productos) // <-- usamos _productos
            {
                DGVListaProd.Rows.Add(
                    contador,
                    p.Nombre,
                    p.Codigo,
                    p.Estado ? "Activo" : "Inactivo",
                    p.Descripcion,
                    p.Categoria,
                    p.Precio,
                    p.Stock,
                    p.Imagen,
                    p.FechaModificacion
                );
                contador++;
            }
        }
        

        public void CargarProductosBD()
        { 
            try
            {
                DGVListaProd.DefaultCellStyle.ForeColor = Color.Black;
                // Traer datos desde la BLL
                DataTable productos = cn_Producto.ListarProductosBLL();

                // Cargar en el DataGridView
                DGVListaProd.DataSource = productos;

                // Mostrar cantidad de filas cargadas
                MessageBox.Show($"Se cargaron {productos.Rows.Count} productos.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        public void CargarProductos()
        {
            if (_modo == "Ver")
            {
                BEditarProd.Visible = false;
                BEliminarProd.Visible = false;
            }
            else if (_modo == "Editar")
            {
                BEditarProd.Visible = true;
                BEliminarProd.Visible = true;
            }

            int contador = 1;

            DGVListaProd.Rows.Clear();
            foreach (var p in _productos)
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

        private void BEditarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVListaProd.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto para editar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear objeto Productox desde la fila seleccionada
                Productox prodSeleccionado = new Productox
                {
                    Nombre = DGVListaProd.CurrentRow.Cells["nombre_prod"].Value.ToString(),
                    Codigo = Convert.ToInt32(DGVListaProd.CurrentRow.Cells["codigo_prod"].Value),
                    Estado = DGVListaProd.CurrentRow.Cells["estado_prod"].Value != DBNull.Value
                        && Convert.ToBoolean(DGVListaProd.CurrentRow.Cells["estado_prod"].Value),
                    Descripcion = DGVListaProd.CurrentRow.Cells["descripcion_prod"].Value.ToString(),
                    Categoria = DGVListaProd.CurrentRow.Cells["categoria_prod"].Value.ToString(),

                    Precio = Convert.ToDecimal(DGVListaProd.CurrentRow.Cells["precio_prod"].Value),
                    Stock = Convert.ToInt32(DGVListaProd.CurrentRow.Cells["stock_prod"].Value),
                    Imagen = DGVListaProd.CurrentRow.Cells["imagen_prod"].Value != DBNull.Value
                        ? (Image)new ImageConverter().ConvertFrom(DGVListaProd.CurrentRow.Cells["imagen_prod"].Value)
                        : null,
                    FechaModificacion = DGVListaProd.CurrentRow.Cells["fechaModif_prod"].Value != DBNull.Value
                        ? Convert.ToDateTime(DGVListaProd.CurrentRow.Cells["fechaModif_prod"].Value)
                        : DateTime.Now
                };

                // Abrir el formulario de alta en modo edición
                AltaProductos formEditar = new AltaProductos(prodSeleccionado, "Editar", conexionString);

                formEditar.ShowDialog(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void TBBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void toolCodigoProd_Click(object sender, EventArgs e)
        {
            _modo = "Codigo";
            buscarPorCod = true;
            BBuscarProducto.Text = "Buscar por: Código";
            TBBuscarProducto.Clear();
            textoLimpiado = false;
        }

        private void toolNombreProd_Click(object sender, EventArgs e)
        {
            _modo = "Nombre";
            buscarPorCod = false;
            BBuscarProducto.Text = "Buscar por: Nombre";
            TBBuscarProducto.Clear();
            textoLimpiado = false;
        }

        // BOTON DE BUSQUEDA
        private void BTSBusquedaProdBD_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = TBBuscarProducto.Text.Trim();
                if (string.IsNullOrWhiteSpace(criterio)) {
                    MessageBox.Show("Ingrese un valor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return; 
                }
                // Si buscamos por codigo, validar que sea numérico
                if (buscarPorCod && !int.TryParse(criterio, out int _)) 
                { MessageBox.Show("Ingrese un Codigo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                } 
                // Limpiar DataGridView antes de buscar
                DGVListaProd.DataSource = null; 
                DGVListaProd.Rows.Clear();
                DataTable resultado = this.cn_Producto.BuscarProductosBLL(criterio, buscarPorCod);
               // DGVListaProd.AutoGenerateColumns = false; 
                DGVListaProd.DataSource = resultado;

                if (resultado.Rows.Count == 0)
                    MessageBox.Show("No se encontraron productos con ese criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) { 
                MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } } 

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Código")
            {
                _modo = "Codigo";
            }
            else if (e.ClickedItem.Text == "Nombre")
            {
                _modo = "Nombre";
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

            var prod = _productos.FirstOrDefault(p => p.Codigo == codigoInt);

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

        
        //BORRAR PRODUCTO DE LA BD 
        private void BEliminarProdBD_Click(object sender, EventArgs e)
        {
            if (DGVListaProd.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la lista para borrar.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            // Tomar el valor de la celda "Codigo"
            int codigo_prod = Convert.ToInt32(DGVListaProd.CurrentRow.Cells["codigo_prod"].Value);

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar a este Producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = cn_Producto.BajaProductoBLL(codigo_prod);

                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        DataTable productoActualizado = cn_Producto.BuscarProductosBLL(codigo_prod.ToString(), true);
                        DGVListaProd.DataSource = productoActualizado;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar producto: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
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

            DialogResult dr = MessageBox.Show("¿Desea imprimir solo la selección?\n\n(Si selecciona NO, se imprimirá toda la lista)",
                                              "Imprimir productos",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Cancel) return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LISTADO DE PRODUCTOS");
            sb.AppendLine(new string('=', 70));
            sb.AppendLine($"{"Código",-10} {"Nombre",-20} {"Precio",-10} {"Categoría",-15} {"Stock",-8} {"Estado",-10}");
            sb.AppendLine(new string('-', 70));

            var filas = dr == DialogResult.Yes && DGVListaProd.SelectedRows.Count > 0
                ? DGVListaProd.SelectedRows.Cast<DataGridViewRow>()
                : DGVListaProd.Rows.Cast<DataGridViewRow>();

            foreach (DataGridViewRow row in filas)
            {
                if (row.IsNewRow) continue;

                sb.AppendLine(
                    $"{row.Cells["codigo_prod"].Value,-10} " +
                    $"{row.Cells["nombre_prod"].Value,-20} " +
                    $"{row.Cells["precio_prod"].Value,-10} " +
                    $"{row.Cells["categoria_prod"].Value,-15} " +
                    $"{row.Cells["stock_prod"].Value,-8} " +
                    $"{row.Cells["estado_prod"].Value,-10}"
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
            preview.UseAntiAlias = true;

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


        
        private void DGVListaProd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LAgregarventas_Click(object sender, EventArgs e)
        {

        }

        private void listaProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
    


    






