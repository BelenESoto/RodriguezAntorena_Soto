using Antorena_Soto.CPresentacion.Gerente;
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
        public Form1()
        {
            InitializeComponent();
        }

        //aca vañidaciones 

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
            string dni = TBDni.Text.Trim();
            string contrasenia = TBContrasenia.Text;
            string dniGerente = "11111111";
            string contraseniaGerente = "111111";
            string dniVendedor = "00000000";
            string contraseniaVendedor = "000000";
            string dniSuperAdmin = "22222222";
            string contraseniaSuperAdmin = "222222";


            if (dni.Equals(dniGerente, StringComparison.Ordinal) && contrasenia.Equals(contraseniaGerente, StringComparison.Ordinal))
            {
                //aca redirigir a ventana admin
                MessageBox.Show("Abriendo perfil Gerente");

                CPresentacion.Gerente.menuAdmin formGerente = new CPresentacion.Gerente.menuAdmin();
                formGerente.Show();
                this.Hide(); // oculta el formulario actual
            }

            else if (dni.Equals(dniVendedor, StringComparison.Ordinal) && contrasenia.Equals(contraseniaVendedor, StringComparison.Ordinal))
            {

                menuVendedor formVendedor = new menuVendedor();
                formVendedor.Show();
                this.Hide();
            }
            else if (dni.Equals(dniSuperAdmin, StringComparison.Ordinal) && contrasenia.Equals(contraseniaSuperAdmin, StringComparison.Ordinal))
            {
                MessageBox.Show("Abriendo perfil Administrador");
                CPresentacion.Administrador.menuSuperAdm formSuperAdm = new CPresentacion.Administrador.menuSuperAdm();
                formSuperAdm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dni y/o contraseña no son correctos");

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

        // hasta aca 

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
