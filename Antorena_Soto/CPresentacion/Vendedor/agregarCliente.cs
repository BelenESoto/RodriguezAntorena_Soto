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
    public partial class agregarCliente : Form
    {
            public agregarCliente()
            {
                InitializeComponent();
            }
            //aca validaciones 

            private void TBNombreCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
                if (String.IsNullOrEmpty(TBNombreCliente.Text))
                {
                    MessageBox.Show("El campo nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }

        private void TBDniCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TBDniCliente.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(TBDniCliente.Text, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (TBDniCliente.Text.Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener exactamente 8 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }


        private void TBAgregarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void PAgregarCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PAgregarClienteFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void LAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
