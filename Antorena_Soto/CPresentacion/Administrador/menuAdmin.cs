using Antorena_Soto.CLogica;
using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.SuperAdministrador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class menuAdmin : Form
    {
        private Form _formActual = null;
        string conexionString = "Data Source=HP-BELENS\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";

        public menuAdmin()
        {
            InitializeComponent();
        }

        // Método general para abrir un formulario dentro del panel
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (_formActual != null)
                _formActual.Close();

            _formActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            PAdmin.Controls.Clear();
            PAdmin.Controls.Add(formHijo);
            PAdmin.Tag = formHijo;
            formHijo.Show();
        }

        // Alta de productos
        private void BAltaProductos_Click(object sender, EventArgs e)
        {
            AltaProductos formAlta = new AltaProductos();
            AbrirFormularioEnPanel(formAlta);

        }

        // Listar productos QUEDA <--
        private void BTListaProductosBD_Click_1(object sender, EventArgs e)
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


        // SE VA <--
        private void BListarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "Data Source=HP-BELENS\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                CN_Producto productoBLL = new CN_Producto(conexion);

                DataTable dt = productoBLL.ListarProductos(); // devuelve DataTable desde DAL

                // Convertir DataTable a List<Productox>
                List<Productox> lista = dt.AsEnumerable().Select(fila => new Productox
                {
                    Codigo = Convert.ToInt32(fila["Codigo"]),
                    Nombre = fila["Nombre"].ToString(),
                    Categoria = fila["Categoria"].ToString(),

                    Precio = Convert.ToDecimal(fila["Precio"]),
                    Stock = Convert.ToInt32(fila["Stock"]),
                    Descripcion = fila["Descripcion"].ToString(),
                    Estado = Convert.ToBoolean(fila["Estado"]),
                    FechaModificacion = Convert.ToDateTime(fila["FechaModificacion"]),
                    Imagen = fila["Imagen"] != DBNull.Value
                                ? (Image)new ImageConverter().ConvertFrom(fila["Imagen"])
                                : null
                }).ToList();

                listaProductos formListaProd = new listaProductos(lista, "Editar");
                AbrirFormularioEnPanel(formListaProd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Editar productos
        private void BEditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Producto productoBLL = new CN_Producto(conexionString);

                DataTable dt = productoBLL.ListarProductos();

                // Convertimos DataTable a List<Productox>
                List<Productox> lista = dt.AsEnumerable().Select(fila => new Productox
                {

                    Nombre = fila["Nombre"].ToString(),
                    Codigo = Convert.ToInt32(fila["Codigo"]),
                    Categoria = fila["Categoria"].ToString(), // si Productox.Categoria es int, usar Convert.ToInt32
                    Precio = Convert.ToDecimal(fila["Precio"]),
                    Stock = Convert.ToInt32(fila["Stock"]),
                    Descripcion = fila["Descripcion"].ToString(),
                    Estado = Convert.ToBoolean(fila["Estado"]),
                    FechaModificacion = Convert.ToDateTime(fila["FechaModificacion"]),
                    Imagen = fila["Imagen"] != DBNull.Value
                                ? (Image)new ImageConverter().ConvertFrom(fila["Imagen"])
                                : null
                }).ToList();

                // Abrimos el formulario con la lista ya convertida
                listaProductos formListaProd = new listaProductos(lista, "Editar");
                AbrirFormularioEnPanel(formListaProd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos para edición: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Ver reportes
        private void BVerReportes_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Traer datos reales desde CN_Ventas cuando tengas implementada la capa
                List<Venta> ventas = new List<Venta>();
                reporteVentas formReporte = new reporteVentas(ventas);
                AbrirFormularioEnPanel(formReporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reportes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Estadísticas de ventas
        private void btEstadVenta_Click(object sender, EventArgs e)
        {
            FormRecaudacion formRecaudacion = new FormRecaudacion();
            AbrirFormularioEnPanel(formRecaudacion);
        }

        private void PAdmin_Paint(object sender, PaintEventArgs e)
        {
            // Opcional: personalización de panel
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            // Opcional: inicializar algo al cargar
        }

        private void PGerente1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEliminarProductoBD_Click(object sender, EventArgs e)
        {
            var form = new listaProductos();
            // oculta el botón de imprimir y editar 
            var botonImprimir = form.Controls.Find("bImprimir", true).FirstOrDefault();
            var botonEditar = form.Controls.Find("BEditarProd", true).FirstOrDefault();

            if (botonImprimir != null && botonEditar != null)
                botonImprimir.Visible = false;
            botonEditar.Visible = false;
            AbrirFormularioEnPanel(form);

            form.CargarProductosBD();

        }
    }
}
    


