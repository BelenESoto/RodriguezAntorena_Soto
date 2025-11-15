using Antorena_Soto.CPresentacion.Gerente;
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
using static Antorena_Soto.CPresentacion.Vendedor.agregarDatosCliente;


namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class menuVendedor : Form
    {
        private Form _formActual = null;
        public menuVendedor()
        {

            InitializeComponent();
            
        }

        private List<Producto> productos;
        
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

        //Boton para abrir el formulario de agregar venta
        private void BAgregarVenta_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            List<Productox> listaProductos = ObtenerProductos(); 

            ventaAgregar formVenta = new ventaAgregar(); 

            formVenta.TopLevel = false;
            formVenta.FormBorderStyle = FormBorderStyle.None; 
            formVenta.Dock = DockStyle.Fill;            

            PVendedor2.Controls.Add(formVenta);
            formVenta.Show();
        }

        //Metodo de carga manual que utilizabamos para probar el DataGridView antes de conectar la base de datos
        private List<Productox> ObtenerProductos()
        {
            return new List<Productox>
    {
        new Productox { Codigo = 1, Nombre = "Producto A", Precio = 100, Categoria = "Cat1", Stock = 10, Descripcion = "Desc A", Estado = true },
        new Productox { Codigo = 2, Nombre = "Producto B", Precio = 200, Categoria = "Cat2", Stock = 5, Descripcion = "Desc B", Estado = true }
    };
        }


        //Boton para abrir el formulario de listar ventas
        private void BListarVenta_Click(object sender, EventArgs e)
        {
            
           var form = new listaVentas();
            AbrirFormularioEnPanel(form);
            form.CargarVentasBD();
        }

        //Boton para abrir el formulario de agregar cliente
        private void BAgregarDatoCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            agregarDatosCliente agregarCliente = new agregarDatosCliente();
            agregarCliente.TopLevel = false;
            agregarCliente.FormBorderStyle = FormBorderStyle.None;
            agregarCliente.Dock = DockStyle.Fill;

            PVendedor2.Controls.Add(agregarCliente);
            agregarCliente.Show();
         
        }

        //Boton para abrir el formulario de ver clientes
        private void BVerInfoCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            listaClientes frmClientes = new listaClientes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            PVendedor2.Controls.Add(frmClientes);
            frmClientes.Show();
        }



        //Boton para abrir el formulario de ver productos
        private void BVerProducto_Click(object sender, EventArgs e)
        {
            var form = new listaProductos();

            // oculta el botón de eliminar y editar
            var botonEliminar = form.Controls.Find("BEliminarProd", true).FirstOrDefault();
            var botonEditar = form.Controls.Find("BEditarProd", true).FirstOrDefault();

            if (botonEliminar != null && botonEditar != null)
                botonEliminar.Visible = false;
            botonEditar.Visible = false;
            AbrirFormularioEnPanel(form);

            form.CargarProductosBD();

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
        private void DGVListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void PVendedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Boton para editar cliente de la lista
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

        private void menuVendedor_Load(object sender, EventArgs e)
        {

        }

        //Metodo para abrir formularios dentro del panel PVendedor2
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (_formActual != null)
                _formActual.Close();

            _formActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            PVendedor2.Controls.Clear();
            PVendedor2.Controls.Add(formHijo);
            PVendedor2.Tag = formHijo;
            formHijo.Show();
        }
    }
}
