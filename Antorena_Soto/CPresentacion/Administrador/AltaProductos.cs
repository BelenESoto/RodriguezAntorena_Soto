
using Antorena_Soto.CLogica;
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
        private bool esEdicion = false;           // Variable de clase
        private int CodigoOriginal;            // Para mantener el código en edición
        private List<Producto> _productos;
        public string NombreProducto => TBNombreProducto.Text.Trim();
        public decimal PrecioProducto => decimal.Parse(TBPrecioProducto.Text.Trim());
        public string CategoriaProducto => CBCategoriaProducto.Text.Trim();
        public int StockProducto => int.Parse(TBStockProducto.Text.Trim());
        public string DescripcionProducto => TBDescripcionProducto.Text.Trim();
        public Image ImagenProducto => PBImagenProducto.Image;

        // Constructor para alta
        public AltaProductos()
        {
            InitializeComponent();
            esEdicion = false;
        }
       
        public AltaProductos(List<Producto> productos)
        {
            InitializeComponent();
            _productos = productos;
        }

        // Constructor para edición: recibe el producto existente
        public AltaProductos(Producto prodExistente)
        {
            InitializeComponent();
            esEdicion = true;

            CodigoOriginal = prodExistente.Codigo;

            TBNombreProducto.Text = prodExistente.Nombre;
            TBPrecioProducto.Text = prodExistente.Precio.ToString();
            CBCategoriaProducto.Text = prodExistente.Categoria;
            TBStockProducto.Text = prodExistente.Stock.ToString();
            TBDescripcionProducto.Text = prodExistente.Descripcion;
            PBImagenProducto.Image = prodExistente.Imagen;

            BAgregarProducto.Text = "Guardar Cambios";
        }
       

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
        {
            string precioProducto = TBPrecioProducto.Text.Trim();
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
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Genera el código incremental
            int nuevoCodigo = 1;
            if (!esEdicion && _productos != null && _productos.Count > 0)
            {
                nuevoCodigo = _productos.Max(p => p.Codigo) + 1;
            }
            // Crea el Producto
            Producto nuevoProducto = new Producto()
            {
                Codigo = esEdicion ? CodigoOriginal : nuevoCodigo,
                Nombre = TBNombreProducto.Text.Trim(),
                Precio = decimal.Parse(TBPrecioProducto.Text.Trim()),
                Categoria = CBCategoriaProducto.Text.Trim(),
                Stock = int.Parse(TBStockProducto.Text.Trim()),
                Descripcion = TBDescripcionProducto.Text.Trim(),
                Imagen = PBImagenProducto.Image,
                FechaModificacion = DateTime.Now.Date
            };

            // Si estamos en Alta, agregamos a la lista compartida
            if (!esEdicion && _productos != null)
            {
                _productos.Add(nuevoProducto);
                MessageBox.Show($"Producto '{nuevoProducto.Nombre}' agregado correctamente");
            }
            else
            {
                MessageBox.Show($"Producto '{nuevoProducto.Nombre}' modificado correctamente");
            }

            // Devolver el objeto al formulario llamador
            this.Tag = nuevoProducto;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

   

        private void LAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void LPrecioProducto_Click(object sender, EventArgs e)
        {

        }

        private void PAgregarProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LStockProducto_Click(object sender, EventArgs e)
        {

        }

        private void lAltaProd_Click(object sender, EventArgs e)
        {

        }

        private void panelProd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



