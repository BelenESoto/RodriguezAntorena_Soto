using Antorena_Soto.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.SuperAdministrador
{
    public partial class listaUsuario : Form
    {
        private enum TipoBusqueda { None, Dni, Apellido, Estado }
        private TipoBusqueda tipoBusquedaSeleccionado = TipoBusqueda.None;

        private readonly UsuarioBLL usuarioBLL;
        public listaUsuario()
        {
            InitializeComponent();    
            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";

            usuarioBLL = new UsuarioBLL(conexionString);
        }
       
        private void listaUsuario_Load_1(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        

        public void CargarUsuarios()
        {
            try
            {
                DGVListaUsuarios.DefaultCellStyle.ForeColor = Color.Black;
                DataTable usuarios = usuarioBLL.ListarUsuariosBLL();
                DGVListaUsuarios.DataSource = usuarios;

                MessageBox.Show($"Se cargaron {usuarios.Rows.Count} usuarios.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DGVListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BBuscarDni_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Dni;
            TBBuscarr.Text = "";
            TBBuscarr.Text = "Ingrese DNI";
        }

        private void BBuscarApe_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Apellido;
            TBBuscarr.Text = "";
            TBBuscarr.Text = "Ingrese Apellido o Nombre";
        }

        private void BBuscarEstado_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Estado;
            TBBuscarr.Text = "";
            TBBuscarr.Text = "Activo, Inactivo o Vacío";
        }

        //Metodo para el boton de busqueda por apellido, dni o estado
        private void BTSBusquedaUs_Click(object sender, EventArgs e)
        {
            if (tipoBusquedaSeleccionado == TipoBusqueda.None)
            {
                MessageBox.Show("Seleccione un tipo de búsqueda primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = TBBuscarr.Text.Trim();
            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable resultado = null;

            try
            {
                switch (tipoBusquedaSeleccionado)
                {
                    case TipoBusqueda.Dni:
                        if (!int.TryParse(criterio, out int dni))
                        {
                            MessageBox.Show("DNI inválido. Ingrese solo números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        resultado = usuarioBLL.BuscarUsuariosBLL(criterio, true); // true → buscar por DNI
                        break;

                    case TipoBusqueda.Apellido:
                        if (!criterio.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                        {
                            MessageBox.Show("El nombre o apellido sólo puede contener letras.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        resultado = usuarioBLL.BuscarUsuariosBLL(criterio, false); // false → buscar por nombre
                        break;

                    case TipoBusqueda.Estado:
                        string estadoUpper = criterio.ToUpper();
                        if (estadoUpper != "ACTIVO" && estadoUpper != "INACTIVO" && estadoUpper != "")
                        {
                            MessageBox.Show("El estado debe ser 'Activo', 'Inactivo' o vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        resultado = FiltrarPorEstado(estadoUpper);
                        break;
                }

                // Cargar en el DataGridView
                DGVListaUsuarios.DataSource = resultado;

                MessageBox.Show($"Se encontraron {resultado.Rows.Count} usuario(s).", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable FiltrarPorEstado(string estado)
        {
            DataTable todosUsuarios = usuarioBLL.ListarUsuariosBLL();

            if (string.IsNullOrWhiteSpace(estado))
                return todosUsuarios; // retorna todos si no hay estado

            DataRow[] filasFiltradas = todosUsuarios.Select($"Estado = '{estado}'");
            if (filasFiltradas.Length == 0)
                return todosUsuarios.Clone(); // tabla vacía con misma estructura

            DataTable dtFiltrado = filasFiltradas.CopyToDataTable();
            return dtFiltrado;
        }

        private void LAgregarventas_Click(object sender, EventArgs e)
        {

        }
    }
}
