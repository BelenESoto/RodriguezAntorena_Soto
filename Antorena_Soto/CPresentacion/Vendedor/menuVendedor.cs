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
    public partial class menuVendedor : Form
    {
        public menuVendedor()
        {
            InitializeComponent();
        }

        private void verListadoComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MAgregarVenta_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {

            String cantidad = TCantidad.Text;
            String producto = TProducto.Text;


            if (string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(producto))
            {
                MessageBox.Show("Debe ingresar la cantidad y el producto.");
                return;
            }
            else
            {
                MessageBox.Show("Producto Agregado correctamente!", "Agregar Producto", MessageBoxButtons.OK);
            }

            DGDetalle_Venta.Rows.Add(0, producto, cantidad, 10000);

            //FOR para sumar los subtotales y despues mostrar en label TOTAL
            double suma = 0;

            for (int i = 0; i < DGDetalle_Venta.Rows.Count; i++)
            {
                if (DGDetalle_Venta.Rows[i].IsNewRow) continue;
                suma += Convert.ToDouble(DGDetalle_Venta.Rows[i].Cells[3].Value);
            }

            string total = suma.ToString("N2");
            LTotal.Text = "TOTAL:" + total;

            DialogResult ask = MessageBox.Show("¿Desea ingresar otro producto?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                TProducto.Clear();
                TCantidad.Clear();
            }
            else
            {
                MessageBox.Show("Inserción cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TDetalleVenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TProducto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(TProducto.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

        }

        private void TCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if (String.IsNullOrEmpty(TCantidad.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(TCantidad.Text, out _))
            {
                MessageBox.Show("El campo Cantidad solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DGDetalle_Venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
