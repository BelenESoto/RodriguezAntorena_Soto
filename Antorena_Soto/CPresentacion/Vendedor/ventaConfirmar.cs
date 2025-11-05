// --- AÑADIR ESTOS USINGS ---
using Antorena_Soto.CLogica; // Para ClienteBLL y (asumo) FacturaBLL
using Antorena_Soto.CDatos;   // Para la clase Factura
using System.Data;           // Para DataRow

using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private readonly ClienteBLL clienteBLL;

        // --- NUEVO ---
        private readonly FacturaBLL facturaBLL; // Asumimos que esta BLL existe
        private DataRow clienteActual = null; // Para guardar el cliente encontrado
        // --- FIN NUEVO ---

        public ventaConfirmar()
        {
            InitializeComponent();

            try
            {
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                clienteBLL = new ClienteBLL(conexionString);
                facturaBLL = new FacturaBLL(conexionString);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close();
            }
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

        private void BTSBusquedaCliente_Click(object sender, EventArgs e)
        {
            // ... (Tus validaciones de búsqueda) ...

            // 3. Limpiar los campos de factura antes de buscar
            LimpiarCamposCliente();

            try
            {
                DataTable resultado = clienteBLL.BuscarClientesBLL(TBBuscarCliente.Text.Trim(), buscarPorDni);

                if (resultado.Rows.Count > 0)
                {
                    DataRow filaCliente = resultado.Rows[0];

                    // --- NUEVO ---
                    // Guardamos el cliente completo para usarlo en la factura
                    clienteActual = filaCliente;
                    // --- FIN NUEVO ---

                    // 6. Poblamos los TextBoxes
                    TBDniFact.Text = Convert.ToString(filaCliente["dni_cliente"]);
                    TBCuitFact.Text = Convert.ToString(filaCliente["cuit"]);
                    TBNombreFact.Text = Convert.ToString(filaCliente["nomYApe_cliente"]);
                    TBCiudadFact.Text = Convert.ToString(filaCliente["ciudad"]);

                    MessageBox.Show("Cliente encontrado y cargado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposCliente()
        {
            TBDniFact.Text = "";
            TBCuitFact.Text = "";
            TBNombreFact.Text = "";
            TBCiudadFact.Text = "";
            // --- NUEVO ---
            clienteActual = null; // Limpiamos el cliente guardado
            // --- FIN NUEVO ---
        }


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

        // --- MÉTODO 'FINALIZAR PAGO' MODIFICADO ---
        private void BBorrar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de factura
            // --- NUEVA VALIDACIÓN ---
            if (clienteActual == null)
            {
                MessageBox.Show("Debe buscar y cargar un cliente antes de facturar.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // --- FIN NUEVA VALIDACIÓN ---

            if (string.IsNullOrWhiteSpace(TBMedioPagoFact.Text))
            {
                MessageBox.Show("Debe seleccionar un Medio de Pago.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBTipoFact.Text))
            {
                MessageBox.Show("Debe completar el Tipo de Factura.");
                return;
            }
            if (!long.TryParse(TBMontoFact.Text, out long monto))
            {
                MessageBox.Show("Debe ingresar un Monto válido (numérico).");
                return;
            }
            // ... (resto de tus validaciones) ...

            // 2. Crear el objeto Factura
            Factura nuevaFactura = new Factura
            {
                // nro_factura se asignará por la BBDD (IDENTITY)
                tipo_factura = TBTipoFact.Text.Trim(),
                id_cliente = Convert.ToInt32(clienteActual["dni_cliente"]), // Obtenido del cliente guardado
                fecha_factura = DTFechaAct.Value,
                forma_pago = TBMedioPagoFact.Text.Trim(),
                monto_total = monto
            };

            try
            {
                // 3. Guardar en la Base de Datos
                //    (ASUMIMOS que FacturaBLL y este método existen)
                //    (ASUMIMOS que devuelve la factura con el Nro de factura asignado)
                Factura facturaGuardada = facturaBLL.AgregarFactura(nuevaFactura);

                if (facturaGuardada != null)
                {
                    MessageBox.Show($"Factura N° {facturaGuardada.nro_factura} creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Abrir el formulario 'facturaVenta' y pasarle los datos
                    facturaVenta formFactura = new facturaVenta();

                    // Pasamos la factura (con nro_factura) y el cliente
                    formFactura.FacturaMostrada = facturaGuardada;
                    formFactura.ClienteMostrado = clienteActual;

                    formFactura.ShowDialog();

                    // Opcional: Limpiar todo para una nueva venta
                    LimpiarCamposCliente();
                    TBBuscarCliente.Text = "";
                    TBMedioPagoFact.Text = "";
                    TBTipoFact.Text = "";
                    TBMontoFact.Text = "";
                }
                else
                {
                    MessageBox.Show("Error: La factura no pudo ser guardada.", "Error BBDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // (Tu código de 'CrearBotonesFactura' y 'Venta' puede ir aquí si aún lo necesitas,
            // aunque 'CrearBotonesFactura' parece que ahora debería estar DENTRO del try)
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