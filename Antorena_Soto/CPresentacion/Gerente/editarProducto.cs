using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class editarProducto : Form
    {
        private string modoBusqueda = "Codigo";
        private bool textoLimpiado = false;
        public editarProducto()
        {
            InitializeComponent();
        }

        private void editarProducto_Load_1(object sender, EventArgs e)
        {
            if (DGVListaProd.Columns.Count == 0)
            {
                DGVListaProd.Columns.Add("Codigo", "Código Producto");
                DGVListaProd.Columns.Add("Nombre", "Nombre Producto");
                DGVListaProd.Columns.Add("Precio", "Precio");
            }

            // filas de ejemplo 
            DGVListaProd.Rows.Add("001", "Aros Mary", "5000");
            DGVListaProd.Rows.Add("002", "Collar Eva", "8000");
        }

        private void BBuscarPorEditar_ButtonClick_1(object sender, EventArgs e)
        {
            string criterio = TBEditarProd.Text.Trim();
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


                    if (!encontrado)
                    {
                        MessageBox.Show("No se encontró ningún producto con ese criterio.");
                    }

                    if (string.IsNullOrEmpty(modoBusqueda))
                    {
                        MessageBox.Show("Primero debe elegir un criterio de búsqueda (Código o Nombre).");
                        return;
                    }

                    if (!textoLimpiado)
                    {
                        TBEditarProd.Clear();
                        textoLimpiado = true;
                    }
                }

            }
        }
        private void BEditarProd_Click_1(object sender, EventArgs e)
        {
            if (DGVListaProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.");
                return;
            }

            DataGridViewRow fila = DGVListaProd.SelectedRows[0];

            string codigo = fila.Cells["Codigo"].Value.ToString();
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string precio = fila.Cells["Precio"].Value.ToString();

            AltaProductos formAlta = new AltaProductos(codigo, nombre, precio);
            formAlta.ShowDialog();
        }

        private void BEliminarProd_Click_1(object sender, EventArgs e)
        {
            if (DGVListaProd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DGVListaProd.Rows.RemoveAt(DGVListaProd.SelectedRows[0].Index);
                MessageBox.Show("Producto eliminado correctamente.");
            }
        }

        private void LDatosBajaProd_Click(object sender, EventArgs e)
        {

        }

        private void LBajaProducto_Click(object sender, EventArgs e)
        {

        }

        private void TBuscador_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      
    }
}


