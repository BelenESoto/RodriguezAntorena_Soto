using Antorena_Soto.CLogica;
using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class ventaAgregar : Form
    {

        private bool buscarPorCodigo = false;
        private bool buscarPorNombre = false;

        private CN_Producto productoBLL; // BLL para productos
        private DataRow productoSeleccionado; // Guarda el producto de la búsqueda

        public ventaAgregar()
        {
            InitializeComponent();

            // Inicializamos la BLL (asumiendo que tienes una cadena de conexión)
            try
            {
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                productoBLL = new CN_Producto(conexionString); // Asumo que tienes ProductoBLL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BBDD de productos: " + ex.Message);
            }
        }


        private void ventaAgregar_Load(object sender, EventArgs e)
        {
            // Al cargar, solo configuramos las columnas del DGV (el carrito)
            ConfigurarDGVCarrito();
            // Damos la bienvenida al buscador
            TBBuscarCliente.Text = "Ingrese CÓDIGO de producto";
        }

        private void ConfigurarDGVCarrito()
        {
            DGVListaProdVentas.Columns.Clear();
            DGVListaProdVentas.AutoGenerateColumns = false; // Importante

            DGVListaProdVentas.Columns.Add("Codigo", "Código");
            DGVListaProdVentas.Columns.Add("Nombre", "Nombre");
            DGVListaProdVentas.Columns.Add("Precio", "Precio Unit.");
            DGVListaProdVentas.Columns.Add("Cantidad", "Cantidad");
            DGVListaProdVentas.Columns.Add("Subtotal", "Subtotal");

            // Formatear columnas
            DGVListaProdVentas.Columns["Precio"].DefaultCellStyle.Format = "C2"; // Moneda
            DGVListaProdVentas.Columns["Subtotal"].DefaultCellStyle.Format = "C2"; // Moneda
        }

        private void BBuscarProd_ButtonClick(object sender, EventArgs e)
        {

        }

        private void TBBuscadorProd_Click(object sender, EventArgs e)
        {

        }
        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {
        }
        private void TBNombreProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCantidadProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado un producto
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un producto válido primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el código en el TextBox coincida (seguridad)
            if (TBNombreProd.Text != productoSeleccionado["codigo_prod"].ToString())
            {
                MessageBox.Show("El código de producto no coincide con el producto buscado. Por favor, busque de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Validar la cantidad
            if (!int.TryParse(TBCantidadProd.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida (número entero mayor a 0).");
                return;
            }

            // 4. (Opcional) Validar Stock
            int stockDisponible = Convert.ToInt32(productoSeleccionado["stock_prod"]);
            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"Stock insuficiente. Solo quedan {stockDisponible} unidades.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Obtener datos del producto seleccionado
            int codigo = Convert.ToInt32(productoSeleccionado["codigo_prod"]);
            string nombre = Convert.ToString(productoSeleccionado["nombre_prod"]);
            decimal precio = Convert.ToDecimal(productoSeleccionado["precio_prod"]); 
            decimal subtotal = precio * cantidad;

            // 6. Agregar fila al DGV (el carrito)
            DGVListaProdVentas.Rows.Add(
                codigo,
                nombre,
                precio,
                cantidad,
                subtotal
            );

            // 7. Recalcular total
            CalcularTotal();

            // 8. Limpiar campos de entrada
            TBNombreProd.Clear();
            TBCantidadProd.Clear();
            TBBuscarCliente.Clear();
            productoSeleccionado = null; // Listo para el siguiente producto
            TBBuscarCliente.Focus();
        }

        private void BEditarProd_Click(object sender, EventArgs e)
        {
            if (DGVListaProdVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila del carrito para editar.");
                return;
            }

            var fila = DGVListaProdVentas.SelectedRows[0];

            if (string.IsNullOrWhiteSpace(TBCantidadProd.Text) || !int.TryParse(TBCantidadProd.Text, out int nuevaCantidad) || nuevaCantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida para editar en el campo 'Cantidad'.");
                return;
            }

            // Actualizar cantidad y subtotal
            decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
            fila.Cells["Cantidad"].Value = nuevaCantidad;
            fila.Cells["Subtotal"].Value = precio * nuevaCantidad;

            // Recalcular total
            CalcularTotal();

            TBCantidadProd.Clear();
            DGVListaProdVentas.ClearSelection();
        }

        private void TBTotalVenta_TextChanged(object sender, EventArgs e)
        {

        }

        // ⭐ Método para calcular total de la venta
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DGVListaProdVentas.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            TBTotalVenta.Text = total.ToString("0.00");
        }

        public void BContinuar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el carrito (DGV) no esté vacío
            if (DGVListaProdVentas.Rows.Count == 0 || (DGVListaProdVentas.Rows.Count == 1 && DGVListaProdVentas.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Crear la lista de items del carrito
            List<DetalleVentaDTO> carrito = new List<DetalleVentaDTO>();

            foreach (DataGridViewRow row in DGVListaProdVentas.Rows)
            {
                // Evitar la fila 'nueva' al final del DGV
                if (row.IsNewRow) continue;

                DetalleVentaDTO item = new DetalleVentaDTO
                {
                    // Leemos los valores de las celdas del DGV
                    IdProducto = Convert.ToInt32(row.Cells["Codigo"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Precio = Convert.ToDecimal(row.Cells["Precio"].Value) // Precio Unitario
                };
                carrito.Add(item);
            }

            // 3. Obtener el total. Lo parseamos desde el TextBox
            // Usamos NumberStyles.Currency para quitar el símbolo "$" y las comas
            decimal totalVenta = 0;
            if (decimal.TryParse(TBTotalVenta.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalParseado))
            {
                totalVenta = totalParseado;
            }
            else
            {
                MessageBox.Show("Error al leer el monto total.");
                return; // No continuar si el total no es válido
            }

            // 4. Abrir ventaConfirmar y pasar los datos
            PAgregarVendedor.Controls.Clear();
            ventaConfirmar formVenta = new ventaConfirmar();

            // 5. Setear las propiedades públicas (que crearemos en el siguiente paso)
            formVenta.ItemsCarrito = carrito;
            formVenta.TotalVenta = totalVenta;

            // 6. Mostrar el form
            formVenta.TopLevel = false;
            formVenta.FormBorderStyle = FormBorderStyle.None;
            formVenta.Dock = DockStyle.Fill;
            PAgregarVendedor.Controls.Add(formVenta);
            formVenta.Show();
        }
        private void DGVListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTSCodigo_Click(object sender, EventArgs e)
        {
            buscarPorCodigo = true;
            buscarPorNombre = false;
            MessageBox.Show("Búsqueda configurada por CÓDIGO.");
        }

        private void BTSNombreProd_Click(object sender, EventArgs e)
        {
            buscarPorCodigo = false;
            buscarPorNombre = true;
            MessageBox.Show("Búsqueda configurada por NOMBRE.");
        }

        private void PAgregarVendedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void BTSBusquedaCliente_Click(object sender, EventArgs e)
        {
            string input = TBBuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(input) || input == "Ingrese CÓDIGO de producto" || input == "Ingrese NOMBRE de producto")
            {
                MessageBox.Show("El campo de búsqueda no puede estar vacío.");
                return;
            }

            try
            {
                // Llamamos a la BLL de Producto (asumo que se llama BuscarProductosBLL)
                DataTable resultado = productoBLL.BuscarProductosBLL(input, buscarPorCodigo);

                if (resultado.Rows.Count > 0)
                {
                    // Encontramos el producto y lo guardamos
                    productoSeleccionado = resultado.Rows[0];

                    // Ponemos el CÓDIGO (PK) en el TextBox, como pediste
                    TBNombreProd.Text = productoSeleccionado["codigo_prod"].ToString(); // Asumo nombre de la PK

                    MessageBox.Show($"Producto encontrado: {productoSeleccionado["nombre_prod"]}. Ingrese la cantidad.");
                    TBCantidadProd.Focus(); // Mover el cursor a Cantidad
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese criterio.");
                    productoSeleccionado = null;
                    TBNombreProd.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
                productoSeleccionado = null;
                TBNombreProd.Clear();
            }
        }

        private void BTSPorNombreV_Click(object sender, EventArgs e)
        {
            buscarPorCodigo = false;
            buscarPorNombre = true;
            MessageBox.Show("Búsqueda configurada por NOMBRE.");
        }

        private void BTSCodigoV_Click(object sender, EventArgs e)
        {
            buscarPorCodigo = true;
            buscarPorNombre = false;
            MessageBox.Show("Búsqueda configurada por CÓDIGO.");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

