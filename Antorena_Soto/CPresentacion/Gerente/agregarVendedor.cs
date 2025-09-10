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

        //aca las validaciones
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

        private void TBCiutVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TBCuitVendedor.Text))
            {
                MessageBox.Show("El campo CUIT no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!long.TryParse(TBCuitVendedor.Text.Trim(), out _))
            {
                MessageBox.Show("El campo CUIT solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (TBCuitVendedor.Text.Length != 11)
            {
                MessageBox.Show("El campo CUIT debe tener exactamente 11 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            } 
        }

        private void TBProvinciaVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
            string provincia = TBProvinciaVendedor.Text.Trim();

            if (string.IsNullOrEmpty(provincia))
            {
                MessageBox.Show("El campo provincia no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (provincia.All(char.IsDigit))
            {
                MessageBox.Show("La provincia no puede ser númerico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void TBCiudadVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string ciudad = TBCiudadVendedor.Text.Trim();

            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("El campo ciudad no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (ciudad.All(char.IsDigit))
            {
                MessageBox.Show("La ciudad no puede ser númerico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

         private void TBDomicilioVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
            string domicilio = TBDomicilioVendedor.Text.Trim();

            if (string.IsNullOrEmpty(domicilio))
            {
                MessageBox.Show("El campo domicilio no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (domicilio.All(char.IsDigit))
            {
                MessageBox.Show("El domicilio no puede ser solo números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
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
           string correo = TBCorreoVendedor.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("El campo correo no puede estar vacío.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // evita salir del control si hay error
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(
                         correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo ingresado no tiene un formato válido.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void DTFechaNacVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime fechaNacimiento = DTFechaNacVendedor.Value;
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento > hoy.AddYears(-edad)) edad--;
            if (edad < 18)
            {
                MessageBox.Show("El vendedor debe ser mayor de 18 años.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void DTFechaIngVendedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime fechaIngreso = DTFechaIngVendedor.Value;
            DateTime hoy = DateTime.Today;
            if (fechaIngreso > hoy)
            {
                MessageBox.Show("La fecha de ingreso no puede ser futura.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        //fin vañidaciones 

        private void LNombreVendedor_Click(object sender, EventArgs e)
        {
        }
        private void TBNombreVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarVendedor_Click(object sender, EventArgs e)
              {

              }

        private void LAgregarVendedor_Click(object sender, EventArgs e)
              {

              }

        private void TBCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBProvinciaVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCiudadVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTFechaNacVendedor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTFechaIngVendedor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarVendedor_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = TBNombreVendedor.Text.Trim();
            string dni = TBDniVendedor.Text.Trim();
            string provincia = TBProvinciaVendedor.Text.Trim();
            string ciudad = TBCiudadVendedor.Text.Trim();
            string domicilio = TBDomicilioVendedor.Text.Trim();
            string telefono = TBNumVendedor.Text.Trim();
            string correo = TBCorreoVendedor.Text.Trim();
            DateTime fechaNac = DTFechaNacVendedor.Value;
            DateTime fechaIng = DTFechaIngVendedor.Value;
            string cuit = TBCuitVendedor.Text.Trim();
            // con estos nombres guardo en la base de datos 


            FormMenuGerente formGerente = Application.OpenForms.OfType<FormMenuGerente>().FirstOrDefault();
            if (formGerente == null)
            {
                formGerente = new FormMenuGerente(); //si no hay lo creo
            }
            formGerente.AgregarVendedor(nombre, dni, fechaNac);
            formGerente.Show();
            formGerente.BringToFront();
            //con esto cargo y muestro los datos 


            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
           /* TBNombreVendedor.Clear();
            TBDniVendedor.Clear();
            TBProvinciaVendedor.Clear();
            TBCiudadVendedor.Clear();
            TBDomicilioVendedor.Clear();
            TBNumVendedor.Clear();
            TBCorreoVendedor.Clear();
            TBCuitVendedor.Clear(); */

        }

        private void PAgregarVendedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    



