// --- NUEVO ---
// Importamos la capa de Lógica de Negocio para poder usarla
using Antorena_Soto.CLogica;
// --- FIN NUEVO ---

using FontAwesome.Sharp;
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
    public partial class ventaConfirmar : Form
    {

        private bool buscarPorDni = false;
        private bool buscarPorNombre = false;

        // --- NUEVO ---
        // Instancia de la BLL que se usará en este formulario
        private readonly ClienteBLL clienteBLL;
        // --- FIN NUEVO ---

        public ventaConfirmar()
        {
            InitializeComponent();

            // --- NUEVO ---
            // Inicializamos la BLL en el constructor, pasando la cadena de conexión
            try
            {
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                clienteBLL = new ClienteBLL(conexionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fatal al inicializar la lógica de negocio: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Si la BLL no puede iniciarse, es probable que el formulario no deba cargarse
                this.Load += (s, e) => this.Close();
            }
            // --- FIN NUEVO ---
        }

        private void LDatosBajaUs_Click(object sender, EventArgs e)
        {

        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscarCliente_Click(object sender, EventArgs e)
        {
            // --- NUEVO ---
            // Limpia el placeholder si el usuario hace click
            if (TBBuscarCliente.Text == "Ingrese DNI" || TBBuscarCliente.Text == "Ingrese Nombre/Apellido")
            {
                TBBuscarCliente.Text = "";
                TBBuscarCliente.ForeColor = Color.Black;
            }
            // --- FIN NUEVO ---
        }

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPorDni = true;
            buscarPorNombre = false;
            // --- MODIFICADO ---
            // Añadimos un placeholder para guiar al usuario
            TBBuscarCliente.Text = "Ingrese DNI";
            TBBuscarCliente.ForeColor = Color.Gray;
            // --- FIN MODIFICADO ---
            MessageBox.Show("Búsqueda configurada por DNI.");
        }

        private void pORNOMBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPorDni = false;
            buscarPorNombre = true;
            // --- MODIFICADO ---
            TBBuscarCliente.Text = "Ingrese Nombre/Apellido";
            TBBuscarCliente.ForeColor = Color.Gray;
            // --- FIN MODIFICADO ---
            MessageBox.Show("Búsqueda configurada por NOMBRE.");
        }

        // --- MÉTODO PRINCIPAL MODIFICADO ---
        private void BTSBusquedaCliente_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarCliente.Text.Trim();

            // 1. Validar que se haya seleccionado un tipo de búsqueda
            if (!buscarPorDni && !buscarPorNombre)
            {
                MessageBox.Show("Debe seleccionar si desea buscar por DNI o por NOMBRE (en el menú '...').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el campo no esté vacío o sea el placeholder
            if (string.IsNullOrEmpty(criterio) || criterio == "Ingrese DNI" || criterio == "Ingrese Nombre/Apellido")
            {
                MessageBox.Show("El campo de búsqueda de cliente no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Limpiar los campos de factura antes de buscar
            LimpiarCamposCliente();

            // 4. Ejecutar la búsqueda
            try
            {
                // Llamamos a la BLL
                DataTable resultado = clienteBLL.BuscarClientesBLL(criterio, buscarPorDni);

                // 5. Procesar los resultados
                if (resultado.Rows.Count > 0)
                {
                    // Si hay más de un resultado (ej. búsqueda por nombre "Perez"),
                    // cargamos el primero.
                    if (resultado.Rows.Count > 1)
                    {
                        MessageBox.Show("Se encontraron múltiples clientes. Se cargarán los datos del primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Tomamos la primera fila
                    DataRow filaCliente = resultado.Rows[0];

                    // 6. Poblamos los TextBoxes de la factura con los datos
                    TBDniFact.Text = Convert.ToString(filaCliente["dni_cliente"]);
                    TBCuitFact.Text = Convert.ToString(filaCliente["cuit"]);
                    TBNombreFact.Text = Convert.ToString(filaCliente["nomYApe_cliente"]);
                    TBCiudadFact.Text = Convert.ToString(filaCliente["ciudad"]);

                    MessageBox.Show("Cliente encontrado y cargado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No se encontró ningún cliente
                    MessageBox.Show("Cliente no encontrado. Verifique los datos e intente de nuevo.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Captura de cualquier error de la BLL (ej. DNI no numérico, error de BBDD)
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // --- FIN MÉTODO MODIFICADO ---

        // --- NUEVO ---
        // Método helper para limpiar los campos del cliente
        private void LimpiarCamposCliente()
        {
            TBDniFact.Text = "";
            TBCuitFact.Text = "";
            TBNombreFact.Text = "";
            TBCiudadFact.Text = "";
        }
        // --- FIN NUEVO ---


        private void TBDniFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCuitFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBCiudadFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBMedioPagoFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBTipoFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBMontoFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTFechaNacVendedor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            // Validaciones de factura
            // (Tu código de validación existente está bien)
            if (string.IsNullOrWhiteSpace(TBNombreFact.Text))
            {
                MessageBox.Show("Debe completar el Nombre para la factura (puede buscarlo).");
                return;
            }
            // ... (resto de tus validaciones) ...

            // Si todo está correcto:
            MessageBox.Show("Factura creada con éxito.");

            CrearBotonesFactura();

            // (Tu código de creación de Venta y guardado en lista)
            // ...
        }


        private void CrearBotonesFactura()
        {
            // (Tu código existente para crear botones)
            // ...
        }


        private void ventaConfirmar_Load(object sender, EventArgs e)
        {

        }
    }
}