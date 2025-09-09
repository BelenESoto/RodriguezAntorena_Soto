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

            BTAltaVendedor.Click += BTAltaVendedor_Click;
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

                // IMPORTANT: TopLevel = false antes de añadirlo a Controls
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

        private void BTAltaVendedor_Click(object sender, EventArgs e)
        {
           
            var form = new agregarVendedor(); 
            AbrirFormEnPanel(form);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        }
    }

