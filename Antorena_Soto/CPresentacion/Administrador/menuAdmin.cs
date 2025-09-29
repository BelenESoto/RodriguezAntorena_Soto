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
    public partial class menuAdmin : Form
    {
        private List<Producto> _productos;

        private Form _formActual = null;
            public menuAdmin()
        {
            InitializeComponent();

            // Inicializamos la lista con productos de ejemplo
            _productos = new List<Producto>
        {
            new Producto { Codigo = 1, Nombre = "Aros Mary", Precio = 5000, Categoria="Accesorios", Stock=10, Descripcion="Aros de acero", FechaModificacion=DateTime.Now, Imagen=null },
            new Producto { Codigo = 2, Nombre = "Collar Eva", Precio = 8000, Categoria="Accesorios", Stock=5, Descripcion="Collar con piedra", FechaModificacion=DateTime.Now, Imagen=null }
        };
      }
    

       
        private void LMenuGerente_Click(object sender, EventArgs e)
        {

        }
          private void BAltaProductos_Click(object sender, EventArgs e)
        {
            
            PAdmin.Controls.Clear();

            AltaProductos formAlta = new AltaProductos(_productos);

            formAlta.TopLevel = false;
            formAlta.FormBorderStyle = FormBorderStyle.None;
            formAlta.Dock = DockStyle.Fill;

            PAdmin.Controls.Add(formAlta);
            formAlta.Show();
        }

        


        private void FormMenuGerente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BListarProductos_Click(object sender, EventArgs e)
        {
            PAdmin.Controls.Clear();
            listaProductos formListaProd = new listaProductos(_productos, "Ver");
            formListaProd.TopLevel = false;
            formListaProd.FormBorderStyle = FormBorderStyle.None;
            formListaProd.Dock = DockStyle.Fill;
            PAdmin.Controls.Add(formListaProd);
            formListaProd.Show();

        }


        private void PGerente2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BEditarProducto_Click(object sender, EventArgs e)
        {
            PAdmin.Controls.Clear();
            listaProductos formModif = new listaProductos(_productos, "Editar");
            formModif.TopLevel = false;  //  embebido dentro de otro contenedor
            formModif.FormBorderStyle = FormBorderStyle.None; // Quita los bordes
            formModif.Dock = DockStyle.Fill; // Se ajusta al tamaño del panel
            PAdmin.Controls.Add(formModif);
            formModif.Show();
          //  formModif.ShowDialog();
        }

        private void pBLogoHerram_Click(object sender, EventArgs e)
        {

        }

        private void LProductosGest_Click(object sender, EventArgs e)
        {

        }

        private void lAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void PGerente1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



