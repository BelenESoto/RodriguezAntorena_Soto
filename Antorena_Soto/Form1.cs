using Antorena_Soto.CLogica;
using Antorena_Soto.CPresentacion.Vendedor;
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

namespace Antorena_Soto
{
    public partial class Form1 : Form
    {

        private readonly UsuarioBLL usuarioBLL;

        public Form1()
        {
            InitializeComponent();
 
            try
            {
                string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
                usuarioBLL = new UsuarioBLL(conexionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fatal al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); 
            }

        }

        //VALIDACIONES

        private void TBDni_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TBDni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(TBDni.Text, out _))
            {
                MessageBox.Show("El campo DNI solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (TBDni.Text.Length != 8)
            {
                MessageBox.Show("El campo DNI debe tener exactamente 8 dígitos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void TBContrasenia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TBContrasenia.Text))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (TBContrasenia.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            string dniInput = TBDni.Text.Trim();
            string contraseniaInput = TBContrasenia.Text;

            // Validación de DNI
            if (!int.TryParse(dniInput, out int dniNum))
            {
                MessageBox.Show("El DNI ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                DataTable dtUsuario = usuarioBLL.BuscarUsuariosBLL(dniInput, true); // true = buscar por DNI

                if (dtUsuario.Rows.Count == 0)
                {
                    MessageBox.Show("DNI no encontrado.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow filaUsuario = dtUsuario.Rows[0];
                int tipoUsuario = Convert.ToInt32(filaUsuario["tipo_Usuario"]);
                string estado = Convert.ToString(filaUsuario["Estado"]);
                int idDniBD = Convert.ToInt32(filaUsuario["id_dni_usuario"]); // Este es tu 'vendedor_id'

                // Validar el Estado "Activo", sino no puede ingresar
                if (estado.ToUpper() != "ACTIVO")
                {
                    MessageBox.Show("Este usuario se encuentra inactivo. Contacte al administrador.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Contraseña con tres de prototipo
                string contraseniaCorrecta = "";
                switch (tipoUsuario)
                {
                    case 1: // Vendedor
                        contraseniaCorrecta = "111111";
                        break;
                    case 2: // Admin
                        contraseniaCorrecta = "222222";
                        break;
                    case 3: // SuperAdmin
                        contraseniaCorrecta = "333333";
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (contraseniaInput != contraseniaCorrecta)
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UsuarioBLL.SesionUsuario.Login(filaUsuario);

                switch (tipoUsuario)
                {
                    case 1: // Vendedor
                        menuVendedor formVendedor = new menuVendedor();
                        formVendedor.Show();
                        this.Hide();
                        break;
                    case 2: // Admin
                        MessageBox.Show("Abriendo perfil Administrador"); // "Gerente" en tu código, "Admin" en la DB
                        CPresentacion.Administrador.menuAdmin formAdmin = new CPresentacion.Administrador.menuAdmin();
                        formAdmin.Show();
                        this.Hide();
                        break;
                    case 3: // SuperAdmin
                        MessageBox.Show("Abriendo perfil Super Administrador");
                        CPresentacion.Administrador.menuSuperAdm formSuperAdm = new CPresentacion.Administrador.menuSuperAdm();
                        formSuperAdm.Show();
                        this.Hide();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado durante el login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            String dni = TBDni.Text;

            DialogResult ask = MessageBox.Show("¿Está a punto de eliminar los datos " + dni, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                dni = "";
                MessageBox.Show("los datos" + dni + " se eliminaron correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operación Cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void PFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PFondoLogin_Click(object sender, EventArgs e)
        {
            PFondoLogin.Image = Image.FromFile("C:\\Users\\belen\\source\\repos\\Proy_RodriguezA_Soto\\Antorena_Soto\\Resources\\DSC08269 (1) (1).jpg");

            PFondoLogin.SizeMode = PictureBoxSizeMode.Zoom;

            HacerPictureBoxRedondo(PFondoLogin);
        }

        private void HacerPictureBoxRedondo(PictureBox pictureBox)
        {

            int size = Math.Min(pictureBox.Width, pictureBox.Height);
            pictureBox.Width = size;
            pictureBox.Height = size;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, size, size);
            pictureBox.Region = new Region(path);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
