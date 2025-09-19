using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class FormMenuGerente : Form
    {
            private Form _formActual = null;
            public FormMenuGerente()
        {
            InitializeComponent();
        }
        public FormMenuGerente(string titulo) : this()
        {
            this.Text = titulo;
        }

        private void AbrirFormEnPanel(Form formHijo)
        {
            try
            {
                // Cierra el anterior si existe
                if (_formActual != null)
                {
                    _formActual.Close();
                    _formActual.Dispose();
                    _formActual = null;
                }

                _formActual = formHijo;

                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;

                PGerente2.Controls.Clear();
                PGerente2.Controls.Add(formHijo);
                PGerente2.Tag = formHijo;

                formHijo.Show();
                formHijo.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error abriendo formulario en panel:\n" + ex.Message + "\n\n" + ex.StackTrace,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       /* }
        private void BTAltaVendedor_Click(object sender, EventArgs e)
        {
            var form = new agregarVendedor(); 
            AbrirFormEnPanel(form);
        }

        public void AgregarVendedor(string nombre, string dni, DateTime fechaNac)
        {
            DGVListaProd.Rows.Add(nombre, dni, fechaNac.ToShortDateString());
            DGVListaProd.Show();
            DGVListaProd.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BTBajaVendedor_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
                "¿Está a punto de eliminar los datos",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("los datos se eliminaron correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operación Cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        */
        private void LMenuGerente_Click(object sender, EventArgs e)
        {

        }

        private void BAltaProductos_Click(object sender, EventArgs e)
        {

            PGerente2.Controls.Clear();
            AltaProductos formAlta = new AltaProductos();
            formAlta.TopLevel = false; 
            formAlta.FormBorderStyle = FormBorderStyle.None; 
            formAlta.Dock = DockStyle.Fill; // ajusta al tamaño del panel

            PGerente2.Controls.Add(formAlta);
            PGerente2.Tag = formAlta;
            formAlta.Show();
        }

        private void FormMenuGerente_Load(object sender, EventArgs e)
        {

        }

        private void BTListaVendedores_Click(object sender, EventArgs e)
        {
            DGVListaProd.Show();
            DGVListaProd.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BListarProductos_Click(object sender, EventArgs e)
        {
            FormMenuGerente formListaProd = new FormMenuGerente("Lista de productos");
            AbrirFormEnPanel(formListaProd);
        }

        private void PGerente2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


