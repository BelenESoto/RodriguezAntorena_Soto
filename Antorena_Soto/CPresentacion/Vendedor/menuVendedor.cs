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

        private void LMenuVentas_Click(object sender, EventArgs e)
        {

        }

        private void LVentas_Click(object sender, EventArgs e)
        {

        }

        private void BAgregarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new agregarVenta());
        }

        private void BListarVenta_Click(object sender, EventArgs e)
        {

        }

        private void BAgregarDatoCliente_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel(new agregarCliente());
        }

        private void BVerInfoCliente_Click(object sender, EventArgs e)
        {

        }

        private void BVerProducto_Click(object sender, EventArgs e)
        {

        }

        private void BListarProducto_Click(object sender, EventArgs e)
        {

        }

        private void TBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {

        }


        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el contenido actual
            DGVListaVentas.Controls.Clear();

            // Configurar formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agregar al panel y mostrar
            DGVListaVentas.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void DGVListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
