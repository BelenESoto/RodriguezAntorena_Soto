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
    public partial class agregarVendedor : Form
    {
        public agregarVendedor()
        {
            InitializeComponent();
        }

        private void agregarVendedor_Load(object sender, EventArgs e)
        {

        }

        //aca las validaciones 
        private void LNombreVendedor_Click(object sender, EventArgs e)
        {
        }
        private void TBNombreVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nombre = TBNombreVendedor.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (nombre.All(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede ser númerico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }


        private void TBNombreVendedor_TextChanged(object sender, EventArgs e)
        {

        }
         private void TBDniVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
          {
             if (String.IsNullOrEmpty(TBDniVendedor.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
               }
             else if (!int.TryParse(TBDniVendedor.Text, out _))
              {
                  MessageBox.Show("El campo DNI solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  e.Cancel = true;
                 }
              else if (TBDniVendedor.Text.Length != 8)
                 {                      MessageBox.Show("El campo DNI debe tener exactamente 8 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                  }
              }

              private void TBProvinciaVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
              {

              }
              private void TBCiudadVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
              {

              }

              private void TBDomicilioVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
              {

              }

              private void TBNumVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
              {
                  string telefono = TBNumVendedor.Text.Trim();

                  if (string.IsNullOrEmpty(telefono))
                  {
                      MessageBox.Show("El campo teléfono no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      e.Cancel = true;
                  }
                  else if (!telefono.All(char.IsDigit))
                  {
                      MessageBox.Show("El teléfono solo debe contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      e.Cancel = true;
                  }
                  else if (telefono.Length < 7 || telefono.Length > 15)
                  {
                      MessageBox.Show("El teléfono debe tener entre 7 y 15 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      e.Cancel = true;
                  }
              }

              private void TBCorreoVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
              {

              }

              private void BAgregarVendedor_Click(object sender, EventArgs e)
              {

              }

           

              private void LAgregarVendedor_Click(object sender, EventArgs e)
              {

              } 
    }
}


