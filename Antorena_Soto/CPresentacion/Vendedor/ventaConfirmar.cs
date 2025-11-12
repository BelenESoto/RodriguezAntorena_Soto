// --- AÑADIR ESTOS USINGS ---
using Antorena_Soto.CDatos;   // Para la clase Factura
using Antorena_Soto.CLogica; // Para ClienteBLL y (asumo) FacturaBLL
using FontAwesome.Sharp;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;           // Para DataRow
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Antorena_Soto.CLogica.UsuarioBLL;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class ventaConfirmar : Form
    {
        private bool buscarPorDni = false;
        private bool buscarPorNombre = false;

        private readonly ClienteBLL clienteBLL;

       
        private readonly FacturaBLL facturaBLL; 
        private DataRow clienteActual = null; // Para guardar el cliente encontrado

       
        // Estas propiedades reciben los datos de'ventaAgregar'
        public List<DetalleVentaDTO> ItemsCarrito { get; set; }
        public decimal TotalVenta { get; set; }

        public ventaConfirmar()
        {
            InitializeComponent();
            ItemsCarrito = new List<DetalleVentaDTO>();

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
            // 1. Validaciones
            if (clienteActual == null)
            {
                MessageBox.Show("Debe buscar y cargar un cliente antes de facturar.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ItemsCarrito == null || ItemsCarrito.Count == 0)
            {
                MessageBox.Show("Error: No hay productos en el carrito.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ... (resto de validaciones: forma_pago, tipo_factura) ...

            // 2. Crear el objeto Factura
            Factura nuevaFactura = new Factura
            {
                tipo_factura = TBTipoFact.Text.Trim(),
                id_cliente = Convert.ToInt32(clienteActual["dni_cliente"]),
                fecha_factura = DTFechaAct.Value,
                forma_pago = TBMedioPagoFact.Text.Trim(),
                monto_total = (long)TotalVenta, // O decimal si cambiaste la BBDD
                estado_factura = 1,
                vendedor_id = UsuarioBLL.SesionUsuario.DniUsuario
                // <-- Usamos el ID de la sesión
            };

            MessageBox.Show("Objeto Factura creado");
            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            Detalle_VentaBLL detalleBLL = new Detalle_VentaBLL(conexionString);

            try
            {
                // 3. Guardar la Factura (Maestro)
                Factura facturaGuardada = facturaBLL.AgregarFactura(nuevaFactura);
                MessageBox.Show("Factura guardada");
                // 4. Guardar los Detalles (Hijos)
                foreach (var item in ItemsCarrito)
                {
                    Detalle_venta nuevoDetalle = new Detalle_venta
                    {
                        id_factura = facturaGuardada.nro_factura, // <-- ID de la factura guardada
                        id_producto = item.IdProducto,
                        cantidad = item.Cantidad,
                        precio = (double)item.Precio // Cast de decimal a double
                    };

                    // Guardar cada detalle en la BBDD
                    detalleBLL.AgregarDetalle(nuevoDetalle);
                }

                // 5. Éxito y abrir el form de la factura
                MessageBox.Show($"Factura N° {facturaGuardada.nro_factura} creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                facturaVenta formFactura = new facturaVenta();
                formFactura.FacturaMostrada = facturaGuardada;
                formFactura.ClienteMostrado = clienteActual;
                // Opcional: Pasar también los detalles
                // formFactura.ItemsMostrados = ItemsCarrito; 
                formFactura.ShowDialog();

                // ... (Limpiar campos) ...
            }
            catch (Exception ex)
            {
                string errorReal = ex.Message; // El error de C#
                if (ex.InnerException != null)
                {
                    errorReal = ex.InnerException.Message; // ¡El error de SQL Server!
                }

                MessageBox.Show($"Error al guardar: {errorReal}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearBotonesFactura()
        {
           
        }


        private void ventaConfirmar_Load(object sender, EventArgs e)
        {
            // Al cargar, mostramos el total que recibimos del carrito
            TBMontoFact.Text = TotalVenta.ToString("0.00");
            // Opcional: hacer el monto de solo lectura para que no se pueda cambiar
            TBMontoFact.ReadOnly = true;
        }
    }
}