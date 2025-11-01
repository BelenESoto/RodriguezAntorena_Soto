using Antorena_Soto.CPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class menuGerente : Form
    {
        public menuGerente()
        {
            InitializeComponent();
        }

        private void menuGerente_Load(object sender, EventArgs e)
        {

        }

        private void BListarProductos_Click(object sender, EventArgs e)
        {
            // Limpiar panel
            PGerente.Controls.Clear();

            // Crear instancia del formulario
            FormRecaudacion FormRecaudacion = new FormRecaudacion();
            FormRecaudacion.TopLevel = false;            // Esto es clave para poder incrustarlo en un Panel
            FormRecaudacion.FormBorderStyle = FormBorderStyle.None;
            FormRecaudacion.Dock = DockStyle.Fill;

            // Agregar al panel
            PGerente.Controls.Add(FormRecaudacion);
            FormRecaudacion.Show();
        }       
            private void BVerReportes_Click(object sender, EventArgs e)
        {
            PGerente.Controls.Clear();


            List<Venta> ventas = new List<Venta>(); 
            

            reporteVentas formReporte = new reporteVentas(ventas);
            formReporte.TopLevel = false;
            formReporte.FormBorderStyle = FormBorderStyle.None;
            formReporte.Dock = DockStyle.Fill;

            PGerente.Controls.Add(formReporte);
            PGerente.Tag = formReporte;
            formReporte.Show();
        }

        private void PGerente1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PGerente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

