using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.Vendedor;
using Antorena_Soto.CPresentacion.Administrador;

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
    public partial class ventaAgregar : Form
    {

        private bool buscarPorCodigo = false;
        private bool buscarPorNombre = false;

        // ⭐ Nueva propiedad para recibir la lista de productos
        private List<Productox> productos; // ⭐

        // ⭐ Constructor que recibe la lista de productos
        public ventaAgregar(List<Productox> productos) // ⭐
        {
            InitializeComponent();
            this.productos = productos; // ⭐ Guardamos la lista recibida
        }

        private void ventaAgregar_Load(object sender, EventArgs e)
        {
            // ⭐ Cargar la lista de productos al iniciar el form
            CargarProductosEnVenta(); // ⭐
        }

        // ⭐ Método para cargar los productos en DGVListaProdVentas
        private void CargarProductosEnVenta()
        {
            if (DGVListaProdVentas.Columns.Count == 0) // Evita columnas duplicadas
            {
                DGVListaProdVentas.Columns.Add("nOrden", "Orden Producto");
                DGVListaProdVentas.Columns.Add("Codigo", "Código Producto");
                DGVListaProdVentas.Columns.Add("Nombre", "Nombre Producto");
                DGVListaProdVentas.Columns.Add("Precio", "Precio");
                DGVListaProdVentas.Columns.Add("Categoria", "Categoría");
                DGVListaProdVentas.Columns.Add("Stock", "Stock");
                DGVListaProdVentas.Columns.Add("Descripcion", "Descripción");
                DGVListaProdVentas.Columns.Add("Imagen", "Imagen");
                DGVListaProdVentas.Columns.Add("Estado", "Estado");

                // ⭐ Nuevas columnas para venta
                DGVListaProdVentas.Columns.Add("Cantidad", "Cantidad");
                DGVListaProdVentas.Columns.Add("Subtotal", "Subtotal");
            }

            DGVListaProdVentas.Rows.Clear(); // Limpia antes de cargar
            int contador = 1;

            foreach (var p in productos) // ⭐ usamos la lista recibida
            {
                DGVListaProdVentas.Rows.Add(
                    contador++,
                    p.Codigo,
                    p.Nombre,
                    p.Precio,
                    p.Categoria,
                    p.Stock,
                    p.Descripcion,
                    p.Imagen,
                    p.Estado ? "Activo" : "Inactivo"
                );
            }
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
            int codigo = int.Parse(TBNombreProd.Text.Trim());
            int cantidad = int.Parse(TBCantidadProd.Text.Trim());
            if (string.IsNullOrWhiteSpace(TBNombreProd.Text))
            {
                MessageBox.Show("El campo 'Nombre Vendedor' es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBCantidadProd.Text) || !int.TryParse(TBCantidadProd.Text, out _))
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida (número entero).");
                return;
            }

            MessageBox.Show("Producto agregado correctamente.");

            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto == null)
            {
                MessageBox.Show("No se encontró un producto con ese CÓDIGO.");
                return;
            }

            // Calcular subtotal
            decimal subtotal = producto.Precio * cantidad;

            // Agregar fila al DGV
            int nOrden = DGVListaProdVentas.Rows.Count + 1;
            DGVListaProdVentas.Rows.Add(
                nOrden,
                producto.Codigo,
                producto.Nombre,
                producto.Precio,
                producto.Categoria,
                producto.Stock,
                producto.Descripcion,
                producto.Imagen,
                producto.Estado ? "Activo" : "Inactivo",
                cantidad,       // ⭐ Cantidad
                subtotal        // ⭐ Subtotal
            );

            // Recalcular total
            CalcularTotal();

            // Limpiar campos de entrada
            TBNombreProd.Clear();
            TBCantidadProd.Clear();
        }

        private void BEditarProd_Click(object sender, EventArgs e)
        {
            if (DGVListaProdVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para editar.");
                return;
            }

            var fila = DGVListaProdVentas.SelectedRows[0];

            // Validar cantidad nueva
            if (string.IsNullOrWhiteSpace(TBCantidadProd.Text) || !int.TryParse(TBCantidadProd.Text, out int nuevaCantidad) || nuevaCantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida para editar.");
                return;
            }

            // Actualizar cantidad y subtotal
            decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
            fila.Cells["Cantidad"].Value = nuevaCantidad;
            fila.Cells["Subtotal"].Value = precio * nuevaCantidad;

            // Recalcular total
            CalcularTotal();

            TBCantidadProd.Clear();
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
            string nombreProd = TBNombreProd.Text.Trim();
            string cantidadProd = TBCantidadProd.Text.Trim();
            if (!int.TryParse(nombreProd, out _))
            {
                MessageBox.Show("El campo 'Codigo Producto' debe ser numérico.");
                return;
            }

            if (!int.TryParse(cantidadProd, out _))
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida (número entero).");
                return;
            }
            else
            {
                PAgregarVendedor.Controls.Clear();
                ventaConfirmar formVenta = new ventaConfirmar();
                formVenta.TopLevel = false;
                formVenta.FormBorderStyle = FormBorderStyle.None; // Sin borde
                formVenta.Dock = DockStyle.Fill;

                PAgregarVendedor.Controls.Add(formVenta);
                formVenta.Show();
            }
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

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo de búsqueda no puede estar vacío.");
                return;
            }

            if (buscarPorCodigo)
            {
                if (!int.TryParse(input, out _))
                {
                    MessageBox.Show("Debe ingresar un valor numérico válido para el CÓDIGO.");
                    return;
                }
                MessageBox.Show($"Buscando producto por código: {input}");
            }
            else if (buscarPorNombre)
            {
                if (int.TryParse(input, out _))
                {
                    MessageBox.Show("El NOMBRE no puede ser un número.");
                    return;
                }
                MessageBox.Show($"Buscando producto por nombre: {input}");
            }
            else
            {
                MessageBox.Show("Debe seleccionar si desea buscar por CÓDIGO o por NOMBRE.");
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

