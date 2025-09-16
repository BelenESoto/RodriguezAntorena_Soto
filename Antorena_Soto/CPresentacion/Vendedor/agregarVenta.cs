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
    public partial class agregarVenta : Form
    {
        public agregarVenta()
        {
            InitializeComponent();
        }

        private void TBNombreProd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TBNombreProd.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

 

        private void TBCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if (String.IsNullOrEmpty(TBCantidad.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(TBCantidad.Text, out _))
            {
                MessageBox.Show("El campo Cantidad solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void BAgregarVendedor_Click(object sender, EventArgs e)
        {
            String cantidad = TBCantidad.Text;
            String producto = TBNombreProd.Text;
        }
    }
}
