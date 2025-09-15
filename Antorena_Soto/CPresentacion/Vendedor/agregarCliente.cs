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
            string nombre = TBNombreCliente.Text.Trim();

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

        private void TBProvinciaCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string provincia = TBProvinciaCliente.Text.Trim();

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
        private void TBCiudadCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string ciudad = TBCiudadCliente.Text.Trim();

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

         private void TBDomicilioCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string domicilio = TBDomicilioCliente.Text.Trim();

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

        private void TBNumCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string telefono = TBNumCliente.Text.Trim();

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

        private void TBCorreoCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string correo = TBCorreoCliente.Text.Trim();

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

        //FIN DE VALIDACIONES 
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

        private void TBDomicilioCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = TBNombreCliente.Text.Trim();
            string dni = TBDniCliente.Text.Trim();
            string provincia = TBProvinciaCliente.Text.Trim();
            string ciudad = TBCiudadCliente.Text.Trim();
            string domicilio = TBDomicilioCliente.Text.Trim();
            string telefono = TBNumCliente.Text.Trim();
            string correo = TBCorreoCliente.Text.Trim();

            // GuardarCliente(nombre, dni, provincia, ciudad, domicilio, telefono, correo);
            //donde guardo?
            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TBNombreCliente.Clear();
            TBDniCliente.Clear();
            TBProvinciaCliente.Clear();
            TBCiudadCliente.Clear();
            TBDomicilioCliente.Clear();
            TBNumCliente.Clear();
            TBCorreoCliente.Clear();
        }

        private void agregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void TBNumCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBProvinciaCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
