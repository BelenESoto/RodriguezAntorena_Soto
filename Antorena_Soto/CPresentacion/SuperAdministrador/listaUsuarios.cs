using Antorena_Soto.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.SuperAdministrador
{
    public partial class listaUsuarios : Form
    {
        private readonly UsuarioBLL usuarioBLL;

        public listaUsuarios()
        {
            InitializeComponent();
            string conexionString = "Data Source=DESKTOP-IDH7B7D/SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            usuarioBLL = new UsuarioBLL(conexionString);
        }

        private void listaUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                DataTable usuarios = usuarioBLL.ListarUsuariosBLL();
                DGVListaVendedor.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVListaVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
