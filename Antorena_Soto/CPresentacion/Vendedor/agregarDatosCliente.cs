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
        public DataRow ClienteParaEditar { get; set; }
        public agregarDatosCliente()
        {
            InitializeComponent();
        }

        
        private void agregarDatosCliente_Load(object sender, EventArgs e)
        {
            if (ClienteParaEditar != null)
            {
                this.Text = "Editar Cliente";
                BAgregarCliente.Text = "Editar Cliente";
                CargarDatosParaEdicion();
            }
            else
            {
                this.Text = "Agregar Nuevo Cliente";
                BAgregarCliente.Text = "Agregar Cliente";
            }
        }

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
                e.Cancel = true; 
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


         void BAgregarCliente_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                ClienteBLL clienteBLL = new ClienteBLL(conexionString);

                if (ClienteParaEditar == null)
                {
                    // MODO AGREGAR
                    bool ok = clienteBLL.AgregarCliente(
                        TBNombreCliente.Text.Trim(),
                        TBDniCliente.Text.Trim(),
                        TBProvinciaCliente.Text.Trim(),
                        TBCiudadCliente.Text.Trim(),
                        TBDomicilioCliente.Text.Trim(),
                        long.Parse(TBCuitCliente.Text.Trim()),
                        long.Parse(TBNumCliente.Text.Trim()),
                        TBCorreoCliente.Text.Trim(),
                        DTFechaModifCliente.Value,
                        1 //este es el estado del cliente, al crearse es 1
                    );

                    if (ok)
                    {
                        MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar al Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // MODO EDITAR
                    int estado = Convert.ToInt32(ClienteParaEditar["estado"]);

                    bool ok = clienteBLL.ActualizarCliente(
                        TBNombreCliente.Text.Trim(),
                        TBDniCliente.Text.Trim(), 
                        TBProvinciaCliente.Text.Trim(),
                        TBCiudadCliente.Text.Trim(),
                        TBDomicilioCliente.Text.Trim(),
                        long.Parse(TBCuitCliente.Text.Trim()),
                        long.Parse(TBNumCliente.Text.Trim()),
                        TBCorreoCliente.Text.Trim(),
                        DTFechaModifCliente.Value,
                        estado
                    );

                    if (ok)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar al Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LAgregarventas_Click(object sender, EventArgs e)
        {

        }

        //Metodo para cargar los datos en modo edicion
        private void CargarDatosParaEdicion()
        {
            if (ClienteParaEditar == null) return;

            TBNombreCliente.Text = Convert.ToString(ClienteParaEditar["nomYApe_cliente"]);
            TBDniCliente.Text = Convert.ToString(ClienteParaEditar["dni_cliente"]);
            TBProvinciaCliente.Text = Convert.ToString(ClienteParaEditar["provincia"]);
            TBCiudadCliente.Text = Convert.ToString(ClienteParaEditar["ciudad"]);
            TBDomicilioCliente.Text = Convert.ToString(ClienteParaEditar["domicilio"]);
            TBCuitCliente.Text = Convert.ToString(ClienteParaEditar["cuit"]);
            TBNumCliente.Text = Convert.ToString(ClienteParaEditar["telefono"]);
            TBCorreoCliente.Text = Convert.ToString(ClienteParaEditar["correo"]);

            if (ClienteParaEditar["fecha_ingreso"] != DBNull.Value)
            {
                DTFechaModifCliente.Value = Convert.ToDateTime(ClienteParaEditar["fecha_ingreso"]);
            }
            TBDniCliente.ReadOnly = true;
            TBDniCliente.BackColor = System.Drawing.Color.LightGray;
        }
    } }


        
