using System;

using Antorena_Soto.CPresentacion.Vendedor;
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
        public ventaAgregar()
        {
            InitializeComponent();
        }

        private void ventaAgregar_Load(object sender, EventArgs e)
        {

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
        }

        private void BEditarProd_Click(object sender, EventArgs e)
        {

        }

        private void TBTotalVenta_TextChanged(object sender, EventArgs e)
        {

        }

        public void BContinuar_Click(object sender, EventArgs e)
        {

            string nombreProd = TBNombreProd.Text.Trim();
            string cantidadProd = TBCantidadProd.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreProd))
            {
                MessageBox.Show("El campo 'Nombre Producto' es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cantidadProd) || !int.TryParse(cantidadProd, out _))
            {
                MessageBox.Show("Debe ingresar una CANTIDAD válida (número entero).");
                return;
            } else
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
                // Aquí iría la lógica real de búsqueda en BD por código
                MessageBox.Show($"Buscando producto por código: {input}");
            }
            else if (buscarPorNombre)
            {
                // Validación básica de texto
                if (int.TryParse(input, out _))
                {
                    MessageBox.Show("El NOMBRE no puede ser un número.");
                    return;
                }
                // Aquí iría la lógica real de búsqueda en BD por nombre
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
    }
}

