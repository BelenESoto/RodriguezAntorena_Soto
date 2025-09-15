using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class AltaProductos : Form
    {
        public AltaProductos()
        {
            InitializeComponent();
        }

        //validadiones 
       
        private void TBNombreProductos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nombreProducto = TBNombreProducto.Text.Trim();
             if (string.IsNullOrEmpty(nombreProducto))
             {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
               }
              else if (nombreProducto.All(char.IsDigit))
            {
                 MessageBox.Show("El nombre no puede ser númerico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 e.Cancel = true;
               }
            }
        private void TBCategoriaProducto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string categoriaProducto = CBCategoriaProducto.Text.Trim();
            if (string.IsNullOrEmpty(categoriaProducto))
            {
                MessageBox.Show("El campo categoría no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void TBPrecioProducto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {   string precioProducto = TBPrecioProducto.Text.Trim();
            if (String.IsNullOrEmpty(precioProducto))
            {
                MessageBox.Show("El campo precio no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!decimal.TryParse(precioProducto, out _))
            {
                MessageBox.Show("El campo precio solo acepta números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (decimal.TryParse(precioProducto, out decimal precio) && precio < 0)
            {
                MessageBox.Show("El campo precio no puede ser negativo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void TBStockProducto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string stockProducto = TBStockProducto.Text.Trim();
            if (String.IsNullOrEmpty(stockProducto))
            {
                MessageBox.Show("El campo stock no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(stockProducto, out _))
            {
                MessageBox.Show("El campo stock solo acepta números enteros.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (int.TryParse(stockProducto, out int stock) && stock < 0)
            {
                MessageBox.Show("El campo stock no puede ser negativo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void DTFechaModifProd_Validating(object sender, CancelEventArgs e)
        {
            DateTime fechaSeleccionada = DTFechaModifProd.Value.Date;
            DateTime fechaActual = DateTime.Now.Date;

            if (fechaSeleccionada != fechaActual)
            {
                MessageBox.Show("La fecha de modificación debe ser la fecha actual.",
                                "Error de Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void PBImagenProducto_Validating(object sender, CancelEventArgs e)
        { 
            string rutaArchivo = PBImagenProducto.ImageLocation;
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Debe seleccionar una imagen para el producto.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            string extension = Path.GetExtension(rutaArchivo).ToLower();
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
            {
                MessageBox.Show("Solo se permiten imágenes JPG o PNG.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            FileInfo fileInfo = new FileInfo(rutaArchivo);
            if (fileInfo.Length > 2 * 1024 * 1024) // 2 MB
            {
                MessageBox.Show("La imagen no puede superar los 2 MB.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            try
            {
                using (Image img = Image.FromFile(rutaArchivo))
                {
                    if (img.Width > 800 || img.Height > 600) // ejemplo: máximo 800x600 px
                    {
                        MessageBox.Show("La imagen no puede superar 800x600 píxeles.",
                                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen. El archivo puede estar dañado.",
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

        }

        private void CBCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PBImagenProducto_Click(object sender, EventArgs e)
        {

        }

        private void TBNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDescripcionProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBStockProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTFechaModifProd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
