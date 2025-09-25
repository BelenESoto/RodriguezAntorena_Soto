using Antorena_Soto.CPresentacion.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class verProductos : Form
    {
        public verProductos()
        {
            InitializeComponent();
        }

        private string modoBusqueda = "Codigo";
        private bool textoLimpiado = false;

        public List<Producto> Productos { get; private set; }

        private string modo; // "Ver" o "Editar"
        private int codigo;

        public verProductos(List<Producto> productos, string modo = "Ver")
        {
            InitializeComponent();
            this.modo = modo;
            this.Productos = productos;
        }

        private void DGVListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBBuscarProd_Click_1(object sender, EventArgs e)
        {

        }

        private void TBuscadorProd_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BBuscarPor_ButtonClick_1(object sender, EventArgs e)
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
    }

    }

       

