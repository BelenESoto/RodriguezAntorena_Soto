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

        }

       
            private void BVerReportes_Click(object sender, EventArgs e)
        {
            PGerente.Controls.Clear();


            List<Venta> ventas = new List<Venta>(); 
            ventas.Add(new Venta
            {
                CodigoVenta = 123,
                NombreCliente = "Juan Perez",
                FechaVenta = DateTime.Now.AddDays(-2),
                NombreVendedor = "Carlos Gomez",
                Productos = new List<Productox>
                {
                   new Productox { Nombre = "Aros Mary", Precio = 5000 },
                   new Productox { Nombre = "Collar Eva", Precio = 8000 }
                },
                Total = 13000
            });
            ventas.Add(new Venta
            {
                CodigoVenta = 456,
                NombreCliente = "Maria Lopez",
                FechaVenta = DateTime.Now.AddDays(-1),
                NombreVendedor = "Ana Torres",
                Productos = new List<Productox>
                {
                   new Productox { Nombre = "Pulsera Luna", Precio = 3500 },
                   new Productox { Nombre = "Anillo Sol", Precio = 6000 }
                },
                Total = 9500
            });

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

