
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
        private List<Productox> _productos;


        public int CodigoProducto { get; internal set; }
        public string NombreProducto => TBNombreProducto.Text.Trim();
        public decimal PrecioProducto => decimal.Parse(TBPrecioProducto.Text.Trim());
        public string CategoriaProducto => CBCategoriaProducto.Text.Trim();
        public int StockProducto => int.Parse(TBStockProducto.Text.Trim());
        public string DescripcionProducto => TBDescripcionProducto.Text.Trim();
        public Image ImagenProducto => PBImagenProducto.Image;
        public object EstadoProducto { get; internal set; }

        // Constructor para alta
        public AltaProductos()
        {
            InitializeComponent();
            esEdicion = false;
        }
       
        public AltaProductos(List<Productox> productos)
        {
            InitializeComponent();
            _productos = productos;
        }

        // Constructor para edición: recibe el producto existente
        public AltaProductos(Productox prodExistente)
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
            DTFechaModifProd.Value = DateTime.Now;
            CBEstadoProd.Text = prodExistente.Estado ? "Activo" : "Inactivo";

            BAgregarProducto.Text = "Guardar Cambios";
        }

        private bool ValidarCodigoProducto()
        {
            string texto = tbCodigoProducto.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("El código del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCodigoProducto.Focus();
                return false;
            }
            if (!int.TryParse(texto, out int codigo))
            {
                MessageBox.Show("El código del producto debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCodigoProducto.Focus();
                return false;
            }

            if (_productos != null)
            {
                if (!esEdicion) 
                {
                    if (_productos.Any(p => p.Codigo == codigo))
                    {
                        MessageBox.Show("El código ya existe. Debe ingresar un código diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbCodigoProducto.Focus();
                        return false;
                    }
                }
                else 
                {
                    if (_productos.Any(p => p.Codigo == codigo && p.Codigo != CodigoOriginal))
                    {
                        MessageBox.Show("El código ya pertenece a otro producto. Cambie el código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbCodigoProducto.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void TBCodigoProducto_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ValidarCodigoProducto())
                e.Cancel = true; 
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
        private void CBEstadoProd_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb == null) return;

            if (cb.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cb.Text))
            {
                MessageBox.Show("Seleccione un estado (Activo/Inactivo).", "Error de validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
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
            if (!ValidarCodigoProducto())
                return;

            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
              int codigo = int.Parse(tbCodigoProducto.Text.Trim());

            if (esEdicion)
            {
                // Modificar el producto existente
                Productox prod = _productos.First(p => p.Codigo == CodigoOriginal);
                prod.Codigo = codigo;
                prod.Nombre = NombreProducto;
                prod.Precio = PrecioProducto;
                prod.Categoria = CategoriaProducto;
                prod.Stock = StockProducto;
                prod.Descripcion = DescripcionProducto;
                prod.Imagen = ImagenProducto;
                prod.FechaModificacion = DateTime.Now;
                prod.Estado = CBEstadoProd.Text == "Activo";
            }
            else
            {
                // Crear nuevo producto
                Productox nuevo = new Productox
                {
                    Codigo = codigo,
                    Nombre = NombreProducto,
                    Precio = PrecioProducto,
                    Categoria = CategoriaProducto,
                    Stock = StockProducto,
                    Descripcion = DescripcionProducto,
                    Imagen = ImagenProducto,
                    FechaModificacion = DateTime.Now,
                    Estado = CBEstadoProd.Text == "Activo"

                };
                MessageBox.Show($"Producto modificado correctamente");

                _productos.Add(nuevo);
            }

            MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tBEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBEstadoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool activo = CBEstadoProd.Text == "Activo";

        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void PAgregarProducto_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}



