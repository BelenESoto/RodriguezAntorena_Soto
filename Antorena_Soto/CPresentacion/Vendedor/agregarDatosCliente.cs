using CPresentacion.Vendedor;

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
        private Cliente clienteEnEdicion;  // 🚀 guarda referencia del cliente en edición
        private bool esEdicion = false;
        public event EventHandler<ClienteEventArgs> ClienteAgregado;
        public agregarDatosCliente()
        {
            InitializeComponent();
        }

        // 🚀 Constructor para EDICIÓN
        public agregarDatosCliente(Cliente cliente) : this()
        {
            esEdicion = true;
            clienteEnEdicion = cliente;

            // cargar datos del cliente en los textboxes
            TBNombreCliente.Text = cliente.Nombre;
            TBDniCliente.Text = cliente.DNI;
            TBProvinciaCliente.Text = cliente.Provincia;
            TBCiudadCliente.Text = cliente.Ciudad;
            TBDomicilioCliente.Text = cliente.Domicilio;
            TBCuitCliente.Text = cliente.Cuit.ToString();
            TBNumCliente.Text = cliente.NumeroTelefono;
            TBCorreoCliente.Text = cliente.Correo;
            DTFechaModifCliente.Value = cliente.FechaIng;

            // opcional: cambiar el texto del botón para que diga "Guardar cambios"
            BAgregarCliente.Text = "Guardar cambios";
        }
        private void agregarDatosCliente_Load(object sender, EventArgs e)
        {

        }
        //validaciopnes
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
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

        private void TBDomicilioCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void TBNumCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBProvinciaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void LAgregarVendedor_Click(object sender, EventArgs e)
        {

        }

        private void PAgregarProducto_Paint(object sender, PaintEventArgs e)
        {

        }
        protected virtual void OnClienteAgregado(Cliente cliente)
        {
            ClienteAgregado?.Invoke(this, new ClienteEventArgs(cliente));
        }


        private void BAgregarCliente_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (esEdicion)
                {
                    // 🚀 actualizar cliente existente
                    clienteEnEdicion.Nombre = TBNombreCliente.Text.Trim();
                    clienteEnEdicion.DNI = TBDniCliente.Text.Trim();
                    clienteEnEdicion.Provincia = TBProvinciaCliente.Text.Trim();
                    clienteEnEdicion.Ciudad = TBCiudadCliente.Text.Trim();
                    clienteEnEdicion.Domicilio = TBDomicilioCliente.Text.Trim();
                    clienteEnEdicion.Cuit = long.Parse(TBCuitCliente.Text.Trim());
                    clienteEnEdicion.NumeroTelefono = TBNumCliente.Text.Trim();
                    clienteEnEdicion.Correo = TBCorreoCliente.Text.Trim();
                    clienteEnEdicion.FechaIng = DTFechaModifCliente.Value;

                    MessageBox.Show("Cliente actualizado con éxito.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // 🚀 alta de nuevo cliente
                    Cliente nuevo = new Cliente
                    {
                        Nombre = TBNombreCliente.Text.Trim(),
                        DNI = TBDniCliente.Text.Trim(),
                        Provincia = TBProvinciaCliente.Text.Trim(),
                        Ciudad = TBCiudadCliente.Text.Trim(),
                        Domicilio = TBDomicilioCliente.Text.Trim(),
                        Cuit = long.Parse(TBCuitCliente.Text.Trim()),
                        NumeroTelefono = TBNumCliente.Text.Trim(),
                        Correo = TBCorreoCliente.Text.Trim(),
                        FechaIng = DTFechaModifCliente.Value
                    };

                   // RepositorioClientes.ListaClientes.Add(nuevo);
                    MessageBox.Show("Cliente agregado con éxito.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); // cerrar form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clase para pasar información del cliente en el evento
        public class ClienteEventArgs : EventArgs
        {
            public Cliente Cliente { get; }

            public ClienteEventArgs(Cliente cliente)
            {
                Cliente = cliente;
            }
        }

        private void TBNombreCliente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LDescripcionProducto_Click(object sender, EventArgs e)
        {

        }

        private void TBCiudadCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCuitCliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TBCuitCliente.Text))
            {
                MessageBox.Show("El campo CUIT no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!long.TryParse(TBCuitCliente.Text, out _))
            {
                MessageBox.Show("El campo CUIT solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (TBCuitCliente.Text.Length != 11)
            {
                MessageBox.Show("El campo CUIT debe tener exactamente 11 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        
    } }


        
