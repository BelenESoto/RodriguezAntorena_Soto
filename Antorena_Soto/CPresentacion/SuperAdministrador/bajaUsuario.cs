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
    public partial class bajaUsuario : Form
    {

        private readonly UsuarioBLL usuarioBLL;
        private bool buscarPorDni = true;

        public bajaUsuario()
        {
            InitializeComponent();
            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            usuarioBLL = new UsuarioBLL(conexionString);
        }

        public void ConfigurarDataGridView()
        {
            DGVListaUsuario.Columns.Clear();

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Dni",
                HeaderText = "DNI",
                DataPropertyName = "id_dni_usuario"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "nomYApe_usuario"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Provincia",
                HeaderText = "Provincia",
                DataPropertyName = "provincia"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ciudad",
                HeaderText = "Ciudad",
                DataPropertyName = "ciudad"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Domicilio",
                HeaderText = "Domicilio",
                DataPropertyName = "domicilio"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Tel",
                HeaderText = "Teléfono",
                DataPropertyName = "telefono"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Correo",
                HeaderText = "Correo",
                DataPropertyName = "correo"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FechaNac",
                HeaderText = "Fecha de Nacimiento",
                DataPropertyName = "fecha_nacimiento"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cuit",
                HeaderText = "CUIT",
                DataPropertyName = "cuit"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FechaIng",
                HeaderText = "Fecha de Ingreso",
                DataPropertyName = "fecha_ingreso"
            });

            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TipoUsuario",
                HeaderText = "Tipo Usuario",
                DataPropertyName = "tipo_Usuario"
            });
            DGVListaUsuario.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado"
            });

            DGVListaUsuario.AutoGenerateColumns = false; 
        }
        private void bajaUsuario_Load_1(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }
        private void bajaUsuario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }

        private void BTSDni_Click(object sender, EventArgs e)
        {
            buscarPorDni = true;
            TBBuscador.Clear();
            BTSDni.Checked = true;
            BTSNomYApe.Checked = false;
        }

        private void BTSNomyApe_Click(object sender, EventArgs e)
        {
            buscarPorDni = false;
            TBBuscador.Clear();
            BTSDni.Checked = false;
            BTSNomYApe.Checked = true;
        }
        //metodo para buscar usuario
        private void BTSBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = TBBuscador.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    MessageBox.Show("Ingrese un valor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (buscarPorDni && !int.TryParse(criterio, out int _))
                {
                    MessageBox.Show("Ingrese un DNI válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DGVListaUsuario.DataSource = null;

                DataTable resultado = this.usuarioBLL.BuscarUsuariosBLL(criterio, buscarPorDni);
                DGVListaUsuario.DataSource = resultado;

                if (resultado.Rows.Count == 0)
                    MessageBox.Show("No se encontraron usuarios con ese criterio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTON BORRAR USUARIO
        private void BBorrar_Click_1(object sender, EventArgs e)
        {
            if (DGVListaUsuario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista para borrar.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int dniUsuario = Convert.ToInt32(DGVListaUsuario.CurrentRow.Cells["Dni"].Value);

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar a este Usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = usuarioBLL.BajaUsuarioBLL(dniUsuario);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        DataTable usuarioActualizado = usuarioBLL.BuscarUsuariosBLL(dniUsuario.ToString(), true);
                        DGVListaUsuario.DataSource = usuarioActualizado;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar usuario: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void TBuscadorAdmin_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {

        }

        private void DGVListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
