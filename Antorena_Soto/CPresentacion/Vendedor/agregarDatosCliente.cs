using Antorena_Soto.CLogica;
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
    public partial class agregarDatosCliente : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();
        public event Action<Cliente> ClienteAgregado;

        public agregarDatosCliente()
        {
            InitializeComponent();
        }
        public class Cliente
        {
            public string Dni { get; set; }
            public string Nombre { get; set; }
            public string Provincia { get; set; }
            public string Ciudad { get; set; }
            public string Domicilio { get; set; }
            public long Telefono { get; set; }
            public string Correo { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public DateTime FechaIngreso { get; set; }
        }
       
            private void TBNombreCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nombreCliente = TBNombreCliente.Text.Trim();
            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (nombreCliente.All(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede ser númerico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void TBDniCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string dniCliente = TBDniCliente.Text.Trim();
            if (String.IsNullOrEmpty(dniCliente))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(dniCliente, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (dniCliente.Length != 8)
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

        private void DTFechaNacCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime fechaNacimiento = DTFechaNacCliente.Value;
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento > hoy.AddYears(-edad)) edad--;
            if (edad < 18)
            {
                MessageBox.Show("El cliente debe ser mayor de 18 años.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void DTFechaIngCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime fechaIngreso = DTFechaIngCliente.Value;
            DateTime hoy = DateTime.Now;
            if (fechaIngreso > hoy)
            {
                MessageBox.Show("La fecha de ingreso no puede ser futura.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void TBNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }
       

            private void BAgregarCliente_Click(object sender, EventArgs e)
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("Por favor, corrija los errores antes de continuar.",
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto cliente
                Cliente nuevoCliente = new Cliente()
                {
                    Dni = TBDniCliente.Text.Trim(),
                    Nombre = TBNombreCliente.Text.Trim(),
                    Provincia = TBProvinciaCliente.Text.Trim(),
                    Ciudad = TBCiudadCliente.Text.Trim(),
                    Domicilio = TBDomicilioCliente.Text.Trim(),
                    Telefono = long.TryParse(TBNumCliente.Text.Trim(), out long tel) ? tel : 0,
                    Correo = TBCorreoCliente.Text.Trim(),
                    FechaNacimiento = DTFechaNacCliente.Value,
                    FechaIngreso = DTFechaIngCliente.Value
                };

                MessageBox.Show("Cliente agregado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disparar el evento al menú
                ClienteAgregado?.Invoke(nuevoCliente);

                this.Close(); 
            }

        private void DTFechaIngCliente_ValueChanged(object sender, EventArgs e)
        {

        }
    }


    }


