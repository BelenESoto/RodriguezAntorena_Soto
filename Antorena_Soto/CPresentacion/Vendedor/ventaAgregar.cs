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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class ventaAgregar : Form
    {

        private bool buscarPorCodigo = false;
        private bool buscarPorNombre = false;
        

        private CN_Producto productoBLL; 
        private DataRow productoSeleccionado; 
        private decimal totalVentaDecimal = 0;
        public ventaAgregar()
        {
            InitializeComponent();

            try
            {
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                productoBLL = new CN_Producto(conexionString); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la BBDD de productos: " + ex.Message);
            }
        }


        private void ventaAgregar_Load(object sender, EventArgs e)
        {
            ConfigurarDGVCarrito();
            TBBuscarCliente.Text = "Ingrese CÓDIGO de producto";
        }

        private void ConfigurarDGVCarrito()
        {
            DGVListaProdVentas.DefaultCellStyle.ForeColor = Color.Black;
            DGVListaProdVentas.Columns.Clear();
            DGVListaProdVentas.AutoGenerateColumns = false; 

            DGVListaProdVentas.Columns.Add("Codigo", "Código");
            DGVListaProdVentas.Columns.Add("Nombre", "Nombre");
            DGVListaProdVentas.Columns.Add("Descripción", "Descripción");
            DGVListaProdVentas.Columns.Add("Precio", "Precio Unit.");
            DGVListaProdVentas.Columns.Add("Cantidad", "Cantidad");
            DGVListaProdVentas.Columns.Add("Subtotal", "Subtotal");

            DGVListaProdVentas.Columns["Precio"].DefaultCellStyle.Format = "$#,##0.00";
            DGVListaProdVentas.Columns["Subtotal"].DefaultCellStyle.Format = "$#,##0.00";
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
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe buscar y seleccionar un producto válido primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TBNombreProd.Text != productoSeleccionado["codigo_prod"].ToString())
            {
                MessageBox.Show("El código de producto no coincide con el producto buscado. Por favor, busque de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TBCantidadProd.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida (número entero mayor a 0).");
                return;
            }

            int stockDisponible = Convert.ToInt32(productoSeleccionado["stock_prod"]);
            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"Stock insuficiente. Solo quedan {stockDisponible} unidades.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //despeus de validar todo, agregamos al DGV
            int codigo = Convert.ToInt32(productoSeleccionado["codigo_prod"]);
            string nombre = Convert.ToString(productoSeleccionado["nombre_prod"]);
            string descripcion = Convert.ToString(productoSeleccionado["descripcion_prod"]);
            decimal precio = Convert.ToDecimal(productoSeleccionado["precio_prod"]); 
            decimal subtotal = precio * cantidad;

            DGVListaProdVentas.Rows.Add(
                codigo,
                nombre,
                descripcion,
                precio,
                cantidad,
                subtotal
            );

            CalcularTotal();

            TBNombreProd.Clear();
            TBCantidadProd.Clear();
            TBBuscarCliente.Clear();
            productoSeleccionado = null; 
            TBBuscarCliente.Focus();
        }

        //metodo que edita productos en el DGV
        private void BEditarProd_Click(object sender, EventArgs e)
        {
            if (DGVListaProdVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila de la planilla para editar.");
                return;
            }

            var fila = DGVListaProdVentas.SelectedRows[0];

            if (string.IsNullOrWhiteSpace(TBCantidadProd.Text) || !int.TryParse(TBCantidadProd.Text, out int nuevaCantidad) || nuevaCantidad < 0)
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida para editar en el campo 'Cantidad'.");
                return;
            }
            
            if (nuevaCantidad == 0){
                   
              DGVListaProdVentas.Rows.Remove(fila);
              TBCantidadProd.Clear();
              CalcularTotal(); 
              }else{  
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    fila.Cells["Cantidad"].Value = nuevaCantidad;
                    fila.Cells["Subtotal"].Value = precio * nuevaCantidad;

           
                CalcularTotal();

                TBCantidadProd.Clear();
                DGVListaProdVentas.ClearSelection();
                }
            }

        private void TBTotalVenta_TextChanged(object sender, EventArgs e)
        {

        }

        // Método para calcular total de la venta
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

            totalVentaDecimal = total;
            TBTotalVenta.Text = totalVentaDecimal.ToString("$#,##0.00");
        }

        //Boton para continuar a la confirmacion de venta, guardando los datos de los productos, cantidad, subtotal
        public void BContinuar_Click(object sender, EventArgs e)
        {
            if (DGVListaProdVentas.Rows.Count == 0 || (DGVListaProdVentas.Rows.Count == 1 && DGVListaProdVentas.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<DetalleVentaDTO> carrito = new List<DetalleVentaDTO>();
            HashSet<int> idsProductosAgregados = new HashSet<int>();

            foreach (DataGridViewRow row in DGVListaProdVentas.Rows)
            {
                if (row.IsNewRow) continue;
                int idActual = Convert.ToInt32(row.Cells["Codigo"].Value);

                if (!idsProductosAgregados.Add(idActual))
                {
                    string nombreProducto = row.Cells["Nombre"].Value?.ToString() ?? "Producto";
                    MessageBox.Show($"Producto '{nombreProducto}' Repetido, debe ingresar una única vez.", "Producto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DetalleVentaDTO item = new DetalleVentaDTO
                {
                    IdProducto = idActual,
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Precio = Convert.ToDecimal(row.Cells["Precio"].Value)
                };
                carrito.Add(item);
            }

            PConfirmar.Controls.Clear();

            ventaConfirmar formVenta = new ventaConfirmar();
            formVenta.ItemsCarrito = carrito;
            formVenta.TotalVenta = totalVentaDecimal; 
            formVenta.OnVolverAtras += FormVenta_OnVolverAtras;
            formVenta.OnVentaFinalizada += FormVenta_OnVentaFinalizada;

            formVenta.TopLevel = false;
            formVenta.FormBorderStyle = FormBorderStyle.None;
            formVenta.Dock = DockStyle.Fill;
            PConfirmar.Controls.Add(formVenta);

            formVenta.Show();
            PConfirmar.Visible = true;
            PConfirmar.BringToFront();
        }

        //Metodo para manejar el evento de volver atras
        private void FormVenta_OnVolverAtras(object sender, EventArgs e)
        {
            PConfirmar.Visible = false;
            PConfirmar.Controls.Clear();
        }

        //Metodo para manejar el evento de venta finalizada, una vez que se confirma la venta y crea la factura, se borra el DGV y se resetean los textBox
        private void FormVenta_OnVentaFinalizada(object sender, EventArgs e)
        {
            PConfirmar.Visible = false;
            PConfirmar.Controls.Clear();

            LimpiarFormularioVentaAgregar();
        }

        private void LimpiarFormularioVentaAgregar()
        {
            DGVListaProdVentas.Rows.Clear();

            LTotal.Text = "$ 0.00"; 
            totalVentaDecimal = 0;
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

        //Boton para buscar el producto por codigo o nombre desde la BD
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
                
                DataTable resultado = productoBLL.BuscarProductosBLL(input, buscarPorCodigo);

                if (resultado.Rows.Count > 0)
                {
                    
                    if (resultado.Rows[0]["estado_prod"] is bool estado && !estado)
                    {
                        MessageBox.Show("El producto está inactivo, seleccione otro producto.");
                        productoSeleccionado = null;
                        TBNombreProd.Clear();
                        return;
                    }

                   
                    productoSeleccionado = resultado.Rows[0];

                   
                    TBNombreProd.Text = productoSeleccionado["codigo_prod"].ToString(); 
                    TBStockProd.Text = productoSeleccionado["stock_prod"].ToString();

                    MessageBox.Show($"Producto encontrado: {productoSeleccionado["nombre_prod"]}. Ingrese la cantidad.");
                    TBCantidadProd.Focus(); 
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

        private void DGVListaProdVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

