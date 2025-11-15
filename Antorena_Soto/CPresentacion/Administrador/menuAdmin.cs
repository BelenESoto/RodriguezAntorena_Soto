using Antorena_Soto.CLogica;
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
        string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";

        public menuAdmin()
        {
            InitializeComponent();
        }

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


        // Editar productos bd
        private void BEditarProducto_Click(object sender, EventArgs e)
        {
            var form = new listaProductos();

            var botonEliminar = form.Controls.Find("BEliminarProd", true).FirstOrDefault();
            var botonEditar = form.Controls.Find("BEditarProd", true).FirstOrDefault();

            if (botonEliminar != null) botonEliminar.Visible = false;
            if (botonEditar != null) botonEditar.Visible = true;

            AbrirFormularioEnPanel(form);
            form.CargarProductosBD();
        }


        // Ver reportes
        private void BVerReportes_Click(object sender, EventArgs e)
        {
            try
            {
                reporteVentas formReporte = new reporteVentas();
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
           
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            
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
