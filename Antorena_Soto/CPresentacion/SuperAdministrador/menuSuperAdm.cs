using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.SuperAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class menuSuperAdm : Form
    {
        private Form _formActual = null;
        public menuSuperAdm()
        {
            InitializeComponent();
            BTAltaUsuario.Click += BTAltaUsuario_Click;
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

            private void BTAltaUsuario_Click(object sender, EventArgs e)
            {
                var form = new agregarVendedor();
                AbrirFormEnPanel(form);
            }

            public void AgregarUsuario(string nombre, string dni, DateTime fechaNac)
            {
            //DGVListaVendedor.Rows.Add(nombre, dni, fechaNac.ToShortDateString());
            //DGVListaVendedor.Show();
            //DGVListaVendedor.BringToFront();
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

            private void BTBajaUsuario_Click(object sender, EventArgs e)
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


            private void BTListaUsuario_Click(object sender, EventArgs e)
            {
            //DGVListaVendedor.Show();
            //DGVListaVendedor.BringToFront();
        }

        private void DGVListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTBajaUsuario_Click_1(object sender, EventArgs e)
        {

        }

        private void DGVListaVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void apellidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
    }
