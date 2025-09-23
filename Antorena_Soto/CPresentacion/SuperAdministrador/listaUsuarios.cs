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
            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            usuarioBLL = new UsuarioBLL(conexionString);
        }

        private void listaUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            try
            {
                // Obtener los datos desde la capa lógica
                DataTable usuarios = usuarioBLL.ListarUsuariosBLL();
                MessageBox.Show($"Filas cargadas: {usuarios.Rows.Count}");

                // Configurar el DataGridView
                DGVListaVendedor.AutoGenerateColumns = false;  // importante
                DGVListaVendedor.Columns.Clear();              // limpiar columnas existentes

                // Agregar columnas
                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Dni",
                    HeaderText = "DNI",
                    DataPropertyName = "id_dni_usuario"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Nombre",
                    HeaderText = "Nombre y Apellido",
                    DataPropertyName = "nomYApe_usuario"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Provincia",
                    HeaderText = "Provincia",
                    DataPropertyName = "provincia"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Ciudad",
                    HeaderText = "Ciudad",
                    DataPropertyName = "ciudad"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Domicilio",
                    HeaderText = "Domicilio",
                    DataPropertyName = "domicilio"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Tel",
                    HeaderText = "Teléfono",
                    DataPropertyName = "telefono"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Correo",
                    HeaderText = "Correo",
                    DataPropertyName = "correo"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FechaNac",
                    HeaderText = "Fecha de Nacimiento",
                    DataPropertyName = "fecha_nacimiento",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd-MM-yyyy" }
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cuit",
                    HeaderText = "CUIT",
                    DataPropertyName = "cuit"
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FechaIng",
                    HeaderText = "Fecha de Ingreso",
                    DataPropertyName = "fecha_ingreso",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd-MM-yyyy" }
                });

                DGVListaVendedor.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TipoUsuario",
                    HeaderText = "Tipo de Usuario",
                    DataPropertyName = "tipo_Usuario"
                });

                // Asignar el DataSource
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
