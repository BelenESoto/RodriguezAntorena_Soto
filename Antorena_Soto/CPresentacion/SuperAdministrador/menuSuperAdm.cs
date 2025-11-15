using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.SuperAdministrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class menuSuperAdm : Form
    {
        private Form _formActual = null;
        public menuSuperAdm()
        {
            InitializeComponent();
            BTAltaUsuario.Click += BTAltaUsuario_Click;
        }
        //Metodo para abrir formularios dentro de un panel
        private void AbrirFormEnPanel(Form formHijo)
            {
                try
                {
                    if (_formActual != null)
                    {
                        _formActual.Close();
                        _formActual.Dispose();
                        _formActual = null;
                    }

                    _formActual = formHijo;

                    formHijo.TopLevel = false;
                    formHijo.FormBorderStyle = FormBorderStyle.None;
                    formHijo.Dock = DockStyle.Fill;

                    PGerente2.Controls.Clear();
                    PGerente2.Controls.Add(formHijo);
                    PGerente2.Tag = formHijo;

                    formHijo.Show();
                    formHijo.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error abriendo formulario en panel:\n" + ex.Message + "\n\n" + ex.StackTrace,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        //Boton para abrir el formulario de alta de usuario
        private void BTAltaUsuario_Click(object sender, EventArgs e)
            {
                var form = new agregarVendedor();
                AbrirFormEnPanel(form);
            }

            public void AgregarUsuario(string nombre, string dni, DateTime fechaNac)
            {
        }

        private void label1_Click(object sender, EventArgs e)
            {

            }

            private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void BTBajaUsuario_Click(object sender, EventArgs e)
            {
                DialogResult ask = MessageBox.Show(
                    "¿Está a punto de eliminar los datos",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("los datos se eliminaron correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operación Cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            private void BTListaUsuario_Click(object sender, EventArgs e)
            {
           
        }

        private void DGVListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Boton para abrir el formulario de baja de usuario
        private void BTBajaUsuario_Click_1(object sender, EventArgs e)
        {
            var form = new bajaUsuario();
            AbrirFormEnPanel(form);
        }

        private void DGVListaVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void apellidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        //Boton para abrir el formulario de lista de usuario
        private void BTListaUsuario_Click_1(object sender, EventArgs e)
        {
            var form = new listaUsuario();
            AbrirFormEnPanel(form);

            form.CargarUsuarios();

        }

        private void PGerente2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BEditarUsuario_Click(object sender, EventArgs e)
        {

        }

        //Boton para hacer backup de la base de datos
        private void btnBack_Click(object sender, EventArgs e)
        {
            HacerBackupBaseDatos();
        }

        private void HacerBackupBaseDatos()
        {
            try
            {
                
                string carpetaBackup = @"C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\Backup";

                
                if (!Directory.Exists(carpetaBackup))
                {
                    Directory.CreateDirectory(carpetaBackup);
                }

                string nombreArchivo = $"RodriguezAntorena_Soto_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                string rutaBackup = Path.Combine(carpetaBackup, nombreArchivo);

         
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";

                string query = $@"
            BACKUP DATABASE RodriguezAntorena_Soto
            TO DISK = '{rutaBackup}'
            WITH INIT, 
                 FORMAT, 
                 NAME = 'Backup automático RodriguezAntorena_Soto';";

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Backup realizado correctamente.\nRuta: {rutaBackup}",
                    "Copia de seguridad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el backup:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    }
