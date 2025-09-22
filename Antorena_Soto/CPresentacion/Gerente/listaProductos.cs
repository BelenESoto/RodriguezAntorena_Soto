

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{

    public partial class listaProductos : Form
    {
        private string modoBusqueda = "Codigo";
        private bool textoLimpiado = false;

        public List<Producto> Productos { get; private set; }

        private string modo; // "Ver" o "Editar"
        private int codigo;

        public listaProductos(List<Producto> productos, string modo = "Ver")
        {
            InitializeComponent();
            this.modo = modo;
            this.Productos = productos;
        }


        private void listaProductos_Load(object sender, EventArgs e)
        {
            if (DGVListaProd.Columns.Count == 0)
            {
                DGVListaProd.Columns.Add("Codigo", "Código Producto");
                DGVListaProd.Columns.Add("Nombre", "Nombre Producto");
                DGVListaProd.Columns.Add("Precio", "Precio");
                DGVListaProd.Columns.Add("Categoria", "Categoría");
                DGVListaProd.Columns.Add("Stock", "Stock");
                DGVListaProd.Columns.Add("Descripcion", "Descripción");
                DGVListaProd.Columns.Add("Imagen", "Imagen");
            }

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
            DGVListaProd.Rows.Clear();
            foreach (var p in Productos)
            {
                DGVListaProd.Rows.Add(
                    p.Codigo,
                    p.Nombre,
                    p.Precio,
                    p.Categoria,
                    p.Stock,
                    p.FechaModificacion
                   // p.Imagen 
                );
            }
        }

        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {
            string criterio = TBBuscarProd.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Debe ingresar un criterio de búsqueda.");
                return;
            }

            // Validaciones 
            if (modoBusqueda == "Codigo")
            {
                if (!criterio.All(char.IsDigit))
                {
                    MessageBox.Show("Cuando busca por CÓDIGO, solo se permiten números.");
                    return;
                }
            }
            else if (modoBusqueda == "Nombre")
            {
                if (!criterio.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("Cuando busca por NOMBRE, solo se permiten letras y espacios.");
                    return;
                }
            }
            DGVListaProd.ClearSelection();

            bool encontrado = false;

            bool hasCodigo = DGVListaProd.Columns.Contains("Codigo");
            bool hasNombre = DGVListaProd.Columns.Contains("Nombre");

            foreach (DataGridViewRow fila in DGVListaProd.Rows)
            {
                if (fila.IsNewRow) continue;

                if (modoBusqueda == "Codigo")
                {
                    if (hasCodigo)
                    {
                        var val = fila.Cells["Codigo"].Value;
                        if (val != null && val.ToString().Contains(criterio))
                        {
                            fila.Selected = true;
                            DGVListaProd.CurrentCell = fila.Cells[0];
                            encontrado = true;
                            break;
                        }
                    }
                    else
                    {
                        if (fila.Cells.Count > 0 && fila.Cells[0].Value != null &&
                            fila.Cells[0].Value.ToString().Contains(criterio))
                        {
                            fila.Selected = true;
                            DGVListaProd.CurrentCell = fila.Cells[0];
                            encontrado = true;
                            break;
                        }
                    }
                }
                else
                {
                    if (hasNombre)
                    {
                        var val = fila.Cells["Nombre"].Value;
                        if (val != null && val.ToString().IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            fila.Selected = true;
                            int idx = hasCodigo ? DGVListaProd.Columns["Codigo"].Index : 0;
                            if (fila.Cells.Count > idx) DGVListaProd.CurrentCell = fila.Cells[idx];
                            encontrado = true;
                            break;
                        }
                    }
                    else
                    {
                        if (fila.Cells.Count > 1 && fila.Cells[1].Value != null &&
                            fila.Cells[1].Value.ToString().IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            fila.Selected = true;
                            DGVListaProd.CurrentCell = fila.Cells[1];
                            encontrado = true;
                            break;
                        }
                    }
                }
            }

            if (!encontrado)
                MessageBox.Show("No se encontró ningún producto con ese criterio.");
        }

        /*private void BEditarProd_Click_1(object sender, EventArgs e)
        {
            if (DGVListaProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.");
                return;
            }

            DataGridViewRow fila = DGVListaProd.SelectedRows[0];
            int codigoInt;
            if (!int.TryParse(fila.Cells["Codigo"].Value.ToString(), out codigoInt))
            {
                MessageBox.Show("Código de producto inválido.");
                return;
            }

            var prod = Productos.FirstOrDefault(p => p.Codigo == codigoInt);




            if (prod != null)
            {
                using (AltaProductos formAlta = new AltaProductos(prod))
                {
                    if (formAlta.ShowDialog() == DialogResult.OK)
                    {
                        prod.Nombre = formAlta.NombreEditado;
                        prod.Precio = decimal.Parse(formAlta.PrecioEditado);
                        prod.Categoria = formAlta.CategoriaEditada;
                        prod.Stock = formAlta.StockEditado;
                        prod.Descripcion = formAlta.DescripcionEditada;
                        prod.Imagen = formAlta.ImagenEditada;

                        CargarProductos();
                    }
                }
            }
        }
        */

        private void BEditarProd_Click_1(object sender, EventArgs e)
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
                        prod.Nombre = formAlta.NombreProducto;
                        prod.Precio = formAlta.PrecioProducto;
                        prod.Categoria = formAlta.CategoriaProducto;
                        prod.Stock = formAlta.StockProducto;
                        prod.Descripcion = formAlta.DescripcionProducto;
                        prod.Imagen = formAlta.ImagenProducto;

                        // Refrescamos la grilla
                        CargarProductos();
                    }
                }
            }
        }


        private void BEliminarProd_Click_1(object sender, EventArgs e)
        {
            if (DGVListaProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar.");
                return;
            }

            var fila = DGVListaProd.SelectedRows[0];
            int codigoInt;
            if (!int.TryParse(fila.Cells["Codigo"].Value.ToString(), out codigoInt))
            {
                MessageBox.Show("Código de producto inválido.");
                return;
            }

            var prod = Productos.FirstOrDefault(p => p.Codigo == codigoInt); // <-- usar codigoInt

            if (prod != null)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea eliminar el producto seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Productos.Remove(prod);
                    CargarProductos(); // refresca la grilla
                    MessageBox.Show("Producto eliminado correctamente.");
                }
            }
        }


        private void nombreProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Nombre";
            BBuscarPor.Text = "Buscar por: Nombre";
            TBBuscarProd.Clear();
            textoLimpiado = false;
        }

        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Codigo";
            BBuscarPor.Text = "Buscar por: Código";
            TBBuscarProd.Clear();
            textoLimpiado = false;
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
    }
}
