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
        // private List<Productox> _productos; //EL DE BELEN
        public menuVendedor()
        {

            InitializeComponent();
            /*_productos = new List<Productox>
    {
    new Productox { Codigo = 123, Nombre = "Aros Mary", Precio = 5000, Categoria = "Accesorios", Stock = 10, Descripcion = "Aros de acero", FechaModificacion = DateTime.Now, Imagen = null, Estado = true },
    new Productox { Codigo = 456, Nombre = "Collar Eva", Precio = 8000, Categoria = "Accesorios", Stock = 5, Descripcion = "Collar con piedra", FechaModificacion = DateTime.Now, Imagen = null, Estado = true },
    new Productox { Codigo = 789, Nombre = "Pulsera Luna", Precio = 3500, Categoria = "Accesorios", Stock = 15, Descripcion = "Pulsera de cuero", FechaModificacion = DateTime.Now, Imagen = null, Estado = true },
    new Productox { Codigo = 321, Nombre = "Anillo Sol", Precio = 6000, Categoria = "Accesorios", Stock = 8, Descripcion = "Anillo de plata", FechaModificacion = DateTime.Now, Imagen = null, Estado = true },
    new Productox { Codigo = 654, Nombre = "Broche Estrella", Precio = 2000, Categoria = "Accesorios", Stock = 20, Descripcion = "Broche esmaltado", FechaModificacion = DateTime.Now, Imagen = null, Estado = true }
        };*/
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

        private void BAgregarVenta_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            // ⭐ Obtener o instanciar la lista de productos
            // Lo ideal es que esta lista venga de listaProductos o de una capa lógica común
            List<Productox> listaProductos = ObtenerProductos(); // ⭐ Método que devuelve la lista

            // ⭐ Pasamos la lista al constructor de ventaAgregar
            ventaAgregar formVenta = new ventaAgregar(); // ⭐

            formVenta.TopLevel = false;
            formVenta.FormBorderStyle = FormBorderStyle.None; // Sin borde
            formVenta.Dock = DockStyle.Fill;             // Ocupa todo el panel

            // Agregar al panel
            PVendedor2.Controls.Add(formVenta);
            formVenta.Show();
        }

        // ⭐ Método de ejemplo para recuperar productos (puede ser de BD, lista estática, etc.)
        private List<Productox> ObtenerProductos()
        {
            // 🔹 Si ya tenés la lista cargada en listaProductos, la podés pasar directamente.
            // 🔹 Aquí te pongo un ejemplo básico:
            return new List<Productox>
    {
        new Productox { Codigo = 1, Nombre = "Producto A", Precio = 100, Categoria = "Cat1", Stock = 10, Descripcion = "Desc A", Estado = true },
        new Productox { Codigo = 2, Nombre = "Producto B", Precio = 200, Categoria = "Cat2", Stock = 5, Descripcion = "Desc B", Estado = true }
    };
        }



        private void BListarVenta_Click(object sender, EventArgs e)
        {
            
           var form = new listaVentas();
            AbrirFormularioEnPanel(form);
            form.CargarVentasBD();
        }

           private void BAgregarDatoCliente_Click(object sender, EventArgs e)
        {
            PVendedor2.Controls.Clear();

            agregarDatosCliente agregarCliente = new agregarDatosCliente();
            agregarCliente.TopLevel = false;
            agregarCliente.FormBorderStyle = FormBorderStyle.None;
            agregarCliente.Dock = DockStyle.Fill;

            PVendedor2.Controls.Add(agregarCliente);
            agregarCliente.Show();
            /*
            // Suscribirse correctamente al evento
            agregarCliente.ClienteAgregado += (s, eArgs) =>
            {
                // eArgs.Cliente contiene el cliente agregado
                listaClientes.Add(eArgs.Cliente);
            };

           ;*/
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

        private void menuVendedor_Load(object sender, EventArgs e)
        {

        }

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
