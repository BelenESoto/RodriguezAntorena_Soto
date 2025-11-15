
using Antorena_Soto.CDatos;  
using Antorena_Soto.CLogica; 
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
using static Antorena_Soto.CLogica.UsuarioBLL;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class ventaConfirmar : Form
    {
       
        private bool buscarPorDni = false;
        private bool buscarPorNombre = false;
        public event EventHandler OnVolverAtras;
        public event EventHandler OnVentaFinalizada;

        private readonly ClienteBLL clienteBLL;

        
        private readonly FacturaBLL facturaBLL; 
        private DataRow clienteActual = null; 
        private readonly CN_Producto productoBLL;

        //Hicimos una lista temporal para guardar los items de los productos de Detalle_venta hasta que se creen los otros datos de la Factura
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
                productoBLL = new CN_Producto(conexionString);

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
            
            if (TBBuscarCliente.Text == "Ingrese DNI" || TBBuscarCliente.Text == "Ingrese Nombre/Apellido")
            {
                TBBuscarCliente.Text = "";
                TBBuscarCliente.ForeColor = Color.Black;
            }
            
        }

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPorDni = true;
            buscarPorNombre = false;
            
            TBBuscarCliente.Text = "Ingrese DNI";
            TBBuscarCliente.ForeColor = Color.Gray;
            
            MessageBox.Show("Búsqueda configurada por DNI.");
        }

        private void pORNOMBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPorDni = false;
            buscarPorNombre = true;
            
            TBBuscarCliente.Text = "Ingrese Nombre/Apellido";
            TBBuscarCliente.ForeColor = Color.Gray;
            
            MessageBox.Show("Búsqueda configurada por NOMBRE.");
        }

        //Método para buscar el cliente y cargar sus datos en los campos correspondientes
        private void BTSBusquedaCliente_Click(object sender, EventArgs e)
        {
           
            LimpiarCamposCliente();

            try
            {
                DataTable resultado = clienteBLL.BuscarClientesBLL(TBBuscarCliente.Text.Trim(), buscarPorDni);

                if (resultado.Rows.Count > 0)
                {
                    DataRow filaCliente = resultado.Rows[0];

                    clienteActual = filaCliente;
                   
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
            
            clienteActual = null; 
            
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
        //Método del botón para confirmar la venta y  crear la factura, pero quedó con el nombre de un botón anterior
        private void BBorrar_Click(object sender, EventArgs e)
        {
           
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
            if (CBMedioPagoFact.SelectedItem == null || string.IsNullOrEmpty(CBMedioPagoFact.Text))
            {
                MessageBox.Show("Debe seleccionar un medio de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CBTipoFact.SelectedItem == null || string.IsNullOrEmpty(CBTipoFact.Text))
            {
                MessageBox.Show("Debe seleccionar un tipo de factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Factura nuevaFactura = new Factura
            {
                tipo_factura = CBTipoFact.Text,
                id_cliente = Convert.ToInt32(clienteActual["dni_cliente"]),
                fecha_factura = DTFechaAct.Value,
                forma_pago = CBMedioPagoFact.Text,
                monto_total = (long)TotalVenta,
                estado_factura = 1,
                vendedor_id = SesionUsuario.DniUsuario
            };

            MessageBox.Show("Objeto Factura creado");
            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            FacturaBLL facturaBLL = new FacturaBLL(conexionString);
            Detalle_VentaBLL detalleBLL = new Detalle_VentaBLL(conexionString);
            CN_Producto productoBLL = new CN_Producto(conexionString);

            try
            {
                
                Factura facturaGuardada = facturaBLL.AgregarFactura(nuevaFactura);
                MessageBox.Show("Factura guardada");

               
                foreach (var item in ItemsCarrito)
                {
                    Detalle_venta nuevoDetalle = new Detalle_venta
                    {
                        id_factura = facturaGuardada.nro_factura,
                        id_producto = item.IdProducto,
                        cantidad = item.Cantidad,
                        precio = (double)item.Precio
                    };
                    detalleBLL.AgregarDetalle(nuevoDetalle);

                    try
                    {
                        productoBLL.ActualizarStockBLL(item.IdProducto, item.Cantidad);
                    }
                    catch (Exception stockEx)
                    {
                        MessageBox.Show($"Error al actualizar stock para producto {item.IdProducto}: {stockEx.Message}", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                MessageBox.Show($"Factura N° {facturaGuardada.nro_factura} creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                facturaVenta formFactura = new facturaVenta();
                formFactura.FacturaMostrada = facturaGuardada;
                formFactura.ClienteMostrado = clienteActual;
                formFactura.ShowDialog();

                LimpiarFormulario(); 
                
                OnVentaFinalizada?.Invoke(this, EventArgs.Empty);
                
            }
            catch (Exception ex)
            {
                string errorReal = ex.Message;
                if (ex.InnerException != null)
                {
                    errorReal = ex.InnerException.Message;
                }
                MessageBox.Show($"Error al guardar: {errorReal}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }



       
        private void LimpiarFormulario()
        {
            clienteActual = null;
            ItemsCarrito.Clear();
            TotalVenta = 0;

            TBBuscarCliente.Text = string.Empty;
            TBDniFact.Text = string.Empty;
            TBCuitFact.Text = string.Empty;
            TBNombreFact.Text = string.Empty;
            TBCiudadFact.Text = string.Empty;
           
            CBTipoFact.SelectedIndex = -1;
            CBMedioPagoFact.SelectedIndex = -1;
            
            TBMontoFact.Text = string.Empty; 
            DTFechaAct.Value = DateTime.Now;
        }
        
        private void ventaConfirmar_Load(object sender, EventArgs e)
        {
            CBMedioPagoFact.Items.Add("Efectivo");
            CBMedioPagoFact.Items.Add("Tarjeta");
            CBMedioPagoFact.Items.Add("Mercado Pago");
            CBMedioPagoFact.SelectedIndex = 0; 
            CBTipoFact.Items.Add("A");
            CBTipoFact.Items.Add("B");
            CBTipoFact.Items.Add("C");
            CBTipoFact.SelectedIndex = 0;

            TBMontoFact.Text = TotalVenta.ToString("$#,##0.00");
          
            TBMontoFact.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Boton para volver al panel anterior sin confirmar la venta.
        //Se oculta el form actual y lanza un evento para visualizar el form anterior
        private void BVolverAtras_Click(object sender, EventArgs e)
        {
            OnVolverAtras?.Invoke(this, EventArgs.Empty);
        }
    }
}