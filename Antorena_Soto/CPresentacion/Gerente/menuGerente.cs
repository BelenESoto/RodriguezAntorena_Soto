using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void BVerReportes_Click(object sender, EventArgs e)
        {
            PGerente.Controls.Clear();
            reporteVentas formReporte = new reporteVentas(); 

            formReporte.TopLevel = false; // importante para que no sea ventana independiente
            formReporte.FormBorderStyle = FormBorderStyle.None; // sin bordes
            formReporte.Dock = DockStyle.Fill; // ocupa todo el panel

            PGerente.Controls.Add(formReporte);
            PGerente.Tag = formReporte; 

            formReporte.Show();
        }

    }
}

