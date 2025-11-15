
using Antorena_Soto.CDatos;
using Antorena_Soto.CLogica;
using Antorena_Soto.CPresentacion.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;

namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class AltaProductos : Form
    {
        private readonly CN_Producto cn_Producto;
        private readonly string conexionString;
        private bool esEdicion = false;         
        private int CodigoOriginal;            
        private List<Productox> _productos;
        private Productox _producto;
        private string _modo;

        public AltaProductos()
        {
            InitializeComponent();
            this.conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            
            cn_Producto = new CN_Producto(conexionString);
            esEdicion = false;
            BAgregarProducto.Text = "Guardar";
        }

        public AltaProductos(Productox prodExistente, string modo, string conexionString)
        {
            InitializeComponent();
            this.conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
         
            cn_Producto = new CN_Producto(conexionString);

            esEdicion = modo.Trim().Equals("Editar", StringComparison.OrdinalIgnoreCase);

            TBNombreProducto.Text = prodExistente.Nombre;
            tbCodigoProducto.Text = prodExistente.Codigo.ToString();
            CBEstadoProd.Text = prodExistente.Estado ? "Activo" : "Inactivo";
            TBDescripcionProducto.Text = prodExistente.Descripcion;
            CBCategoriaProducto.Text = prodExistente.Categoria;
            TBPrecioProducto.Text = prodExistente.Precio.ToString();
            TBStockProducto.Text = prodExistente.Stock.ToString();

            PBImagenProducto.Image = prodExistente.Imagen;
            DTFechaModifProd.Value = DateTime.Now;
            if (esEdicion)
            {
                this.Text = "Editar Producto";
                lAltaProd.Text = "Editar Producto";
                BAgregarProducto.Text = "Guardar Cambios";
            }

            else
                BAgregarProducto.Text = "Guardar";
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
            string codigoProducto = tbCodigoProducto.Text.Trim();
            if (string.IsNullOrEmpty(codigoProducto))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!int.TryParse(codigoProducto, out _))
            {
                MessageBox.Show("El código del producto debe ser un número entero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else if (!ValidarCodigoProducto())
            {
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

        //Boton para agregar o guardar cambios en el producto
        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Por favor, corrija los errores antes de continuar.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CN_Producto productoBLL = new CN_Producto(this.conexionString);

                if (!int.TryParse(tbCodigoProducto.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Código inválido. Ingrese un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(TBPrecioProducto.Text.Trim(), out decimal precio))
                {
                    MessageBox.Show("Precio inválido. Ingrese un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CBCategoriaProducto.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //para el combo box de categoria
                string seleccion = CBCategoriaProducto.SelectedItem.ToString();
                string[] partes = seleccion.Split('-');

                if (partes.Length == 0)
                {
                    MessageBox.Show("Categoría inválida. El formato debe ser '1 - Texto'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(partes[0].Trim(), out int categoria))
                {
                    MessageBox.Show($"No se pudo convertir '{partes[0].Trim()}' a número.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(TBStockProducto.Text.Trim(), out int stock))
                {
                    MessageBox.Show("Stock inválido. Ingrese un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] imagenBytes = PBImagenProducto.Image != null ? ConvertirImagenAByte(PBImagenProducto.Image) : null;

                if (esEdicion)
                {
                    // --- MODO EDICIÓN ---
                    bool ok = productoBLL.ModificarProductoBBL(
                        codigo: tbCodigoProducto.Text.Trim(),
                        nombre: TBNombreProducto.Text.Trim(),
                        categoria: categoria.ToString(),
                        precio: TBPrecioProducto.Text.Trim(),
                        descripcion: TBDescripcionProducto.Text.Trim(),
                        stock: TBStockProducto.Text.Trim(),
                        estado: CBEstadoProd.Text == "Activo",
                        fechaModif: DateTime.Now,
                        imagen: imagenBytes
                    );

                    if (ok)
                    {
                        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // --- MODO ALTA ---
                    bool ok = productoBLL.AgregarProducto(
                        codigo: tbCodigoProducto.Text.Trim(),
                        nombre: TBNombreProducto.Text.Trim(),
                        categoria: categoria.ToString(),
                        descripcion: TBDescripcionProducto.Text.Trim(),
                        precio: TBPrecioProducto.Text.Trim(),
                        stock: TBStockProducto.Text.Trim(),
                        imagen: imagenBytes,
                        fechaModif: DateTime.Now,
                        estado: true
                    );

                    if (ok)
                    {
                        MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private byte[] ConvertirImagenAByte(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
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

        private void tbCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreProducto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CBCategoriaProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {

        }

        private void PBImagenProducto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Seleccionar imagen del producto";
                openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen seleccionada en el PictureBox
                    PBImagenProducto.Image = Image.FromFile(openFile.FileName);
                    PBImagenProducto.ImageLocation = openFile.FileName;
                }
            }
        }
    }
}




