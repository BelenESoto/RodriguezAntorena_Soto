using Antorena_Soto.CPresentacion.Gerente;
using CPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Antorena_Soto.CPresentacion.Vendedor.agregarDatosCliente;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class menuVendedor : Form
    {
        public menuVendedor()
        {
            InitializeComponent();
        }

        private List<Producto> productos;
        private List<Cliente> listaClientes = new List<Cliente>();
        public static class ListaProductosHelper
        {
        public static List<Producto> listaProductos()
            {
                return new List<Producto>();
            }
        }
        

        public menuVendedor(List<Producto> lista)
        {
            InitializeComponent();
            productos = lista;
        }
        


        private void LMenuVentas_Click(object sender, EventArgs e)
        {

        }

        private void LVentas_Click(object sender, EventArgs e)
        {

        }

        private void BAgregarVenta_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();
            ventaAgregar formVenta = new ventaAgregar();
            formVenta.TopLevel = false;                  
            formVenta.FormBorderStyle = FormBorderStyle.None; // Sin borde
            formVenta.Dock = DockStyle.Fill;             // Ocupa todo el panel

            // Agregar al panel
            PVendedor2.Controls.Add(formVenta);
            formVenta.Show();
        }

        

        private void BListarVenta_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();
           listaVentas formVenta = new listaVentas();
            formVenta.TopLevel = false;
            formVenta.FormBorderStyle = FormBorderStyle.None; // Sin borde
            formVenta.Dock = DockStyle.Fill;             // Ocupa todo el panel

            // Agregar al panel
            PVendedor2.Controls.Add(formVenta);
            formVenta.Show();
        }

           private void BAgregarDatoCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            agregarDatosCliente agregarCliente = new agregarDatosCliente();

            // Suscribirse correctamente al evento
            agregarCliente.ClienteAgregado += (s, eArgs) =>
            {
                // eArgs.Cliente contiene el cliente agregado
                listaClientes.Add(eArgs.Cliente);
            };

            agregarCliente.TopLevel = false;
            agregarCliente.FormBorderStyle = FormBorderStyle.None;
            agregarCliente.Dock = DockStyle.Fill;

            PVendedor2.Controls.Add(agregarCliente);
            agregarCliente.Show();
        }

        private void BVerInfoCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            // Crear instancia del formulario listaClientes
            listaClientes frmClientes = new listaClientes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Agregar al panel
            PVendedor2.Controls.Add(frmClientes);
            frmClientes.Show();
        }
/*
        private void BVerInfoCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();
            
            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgv.DataSource = null;
            dgv.DataSource = listaClientes;

            PVendedor2.Controls.Add(dgv);
        }




        */



       
        private void BVerProducto_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();
            verProductos verProd = new verProductos();

            verProd.TopLevel = false;  //  embebido dentro de otro contenedor
            verProd.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            verProd.Dock = DockStyle.Fill; // Se ajusta al tamaño del panel
            PVendedor2.Controls.Add(verProd);
            verProd.Show();

        }
     
        private void BListarProducto_Click(object sender, EventArgs e)
        {

           // listaProductos formLista = new listaProductos(productos);
            //formLista.MostrarProductos(DGVProductosVendedor, productos); // llamás a la función desde la instancia
            //formLista.Show();


        }
        private void TBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void BBuscar_Click(object sender, EventArgs e)
        {

        }


        

        private void DGVListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void PVendedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            listaClientes formLista = new listaClientes();
            formLista.TopLevel = false;
            formLista.FormBorderStyle = FormBorderStyle.None;
            formLista.Dock = DockStyle.Fill;

            PVendedor2.Controls.Add(formLista);
            formLista.Show();
        }
    }
}
