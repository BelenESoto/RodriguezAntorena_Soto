namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class AltaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PAgregarClienteFondo = new System.Windows.Forms.Panel();
            this.LAgregarProducto = new System.Windows.Forms.Label();
            this.PAgregarProducto = new System.Windows.Forms.Panel();
            this.DTFechaIngVendedor = new System.Windows.Forms.DateTimePicker();
            this.LFechaModificacion = new System.Windows.Forms.Label();
            this.BAgregarVendedor = new System.Windows.Forms.Button();
            this.TBStockProducto = new System.Windows.Forms.TextBox();
            this.LStockProducto = new System.Windows.Forms.Label();
            this.LImagenProducto = new System.Windows.Forms.Label();
            this.TBPrecioProducto = new System.Windows.Forms.TextBox();
            this.LPrecioProducto = new System.Windows.Forms.Label();
            this.LCategoriaProducto = new System.Windows.Forms.Label();
            this.TBDescripcionProducto = new System.Windows.Forms.TextBox();
            this.LDescripcionProducto = new System.Windows.Forms.Label();
            this.TBNombreVendedor = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.CBCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.PBImagenProducto = new System.Windows.Forms.PictureBox();
            this.PAgregarClienteFondo.SuspendLayout();
            this.PAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // PAgregarClienteFondo
            // 
            this.PAgregarClienteFondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PAgregarClienteFondo.Controls.Add(this.LAgregarProducto);
            this.PAgregarClienteFondo.Controls.Add(this.PAgregarProducto);
            this.PAgregarClienteFondo.Location = new System.Drawing.Point(0, 0);
            this.PAgregarClienteFondo.Name = "PAgregarClienteFondo";
            this.PAgregarClienteFondo.Size = new System.Drawing.Size(801, 451);
            this.PAgregarClienteFondo.TabIndex = 2;
            // 
            // LAgregarProducto
            // 
            this.LAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarProducto.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarProducto.Location = new System.Drawing.Point(5, 9);
            this.LAgregarProducto.Name = "LAgregarProducto";
            this.LAgregarProducto.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.LAgregarProducto.Size = new System.Drawing.Size(793, 35);
            this.LAgregarProducto.TabIndex = 2;
            this.LAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.LAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LAgregarProducto.Click += new System.EventHandler(this.LAgregarVendedor_Click);
            // 
            // PAgregarProducto
            // 
            this.PAgregarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.PAgregarProducto.Controls.Add(this.PBImagenProducto);
            this.PAgregarProducto.Controls.Add(this.CBCategoriaProducto);
            this.PAgregarProducto.Controls.Add(this.DTFechaIngVendedor);
            this.PAgregarProducto.Controls.Add(this.LFechaModificacion);
            this.PAgregarProducto.Controls.Add(this.BAgregarVendedor);
            this.PAgregarProducto.Controls.Add(this.TBStockProducto);
            this.PAgregarProducto.Controls.Add(this.LStockProducto);
            this.PAgregarProducto.Controls.Add(this.LImagenProducto);
            this.PAgregarProducto.Controls.Add(this.TBPrecioProducto);
            this.PAgregarProducto.Controls.Add(this.LPrecioProducto);
            this.PAgregarProducto.Controls.Add(this.LCategoriaProducto);
            this.PAgregarProducto.Controls.Add(this.TBDescripcionProducto);
            this.PAgregarProducto.Controls.Add(this.LDescripcionProducto);
            this.PAgregarProducto.Controls.Add(this.TBNombreVendedor);
            this.PAgregarProducto.Controls.Add(this.LNombreProducto);
            this.PAgregarProducto.Location = new System.Drawing.Point(3, 47);
            this.PAgregarProducto.Name = "PAgregarProducto";
            this.PAgregarProducto.Size = new System.Drawing.Size(795, 404);
            this.PAgregarProducto.TabIndex = 1;
            // 
            // DTFechaIngVendedor
            // 
            this.DTFechaIngVendedor.Location = new System.Drawing.Point(384, 325);
            this.DTFechaIngVendedor.Name = "DTFechaIngVendedor";
            this.DTFechaIngVendedor.Size = new System.Drawing.Size(384, 22);
            this.DTFechaIngVendedor.TabIndex = 35;
            // 
            // LFechaModificacion
            // 
            this.LFechaModificacion.AutoSize = true;
            this.LFechaModificacion.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaModificacion.ForeColor = System.Drawing.Color.Black;
            this.LFechaModificacion.Location = new System.Drawing.Point(383, 299);
            this.LFechaModificacion.Name = "LFechaModificacion";
            this.LFechaModificacion.Size = new System.Drawing.Size(226, 23);
            this.LFechaModificacion.TabIndex = 30;
            this.LFechaModificacion.Text = "Fecha Modificacion";
            // 
            // BAgregarVendedor
            // 
            this.BAgregarVendedor.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarVendedor.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarVendedor.ForeColor = System.Drawing.Color.Black;
            this.BAgregarVendedor.Location = new System.Drawing.Point(561, 353);
            this.BAgregarVendedor.Name = "BAgregarVendedor";
            this.BAgregarVendedor.Size = new System.Drawing.Size(191, 40);
            this.BAgregarVendedor.TabIndex = 25;
            this.BAgregarVendedor.Text = "Agregar Producto";
            this.BAgregarVendedor.UseVisualStyleBackColor = false;
            // 
            // TBStockProducto
            // 
            this.TBStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProducto.Location = new System.Drawing.Point(387, 266);
            this.TBStockProducto.MaxLength = 10;
            this.TBStockProducto.Name = "TBStockProducto";
            this.TBStockProducto.Size = new System.Drawing.Size(381, 30);
            this.TBStockProducto.TabIndex = 24;
            // 
            // LStockProducto
            // 
            this.LStockProducto.AutoSize = true;
            this.LStockProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockProducto.ForeColor = System.Drawing.Color.Black;
            this.LStockProducto.Location = new System.Drawing.Point(383, 240);
            this.LStockProducto.Name = "LStockProducto";
            this.LStockProducto.Size = new System.Drawing.Size(70, 23);
            this.LStockProducto.TabIndex = 23;
            this.LStockProducto.Text = "Stock";
            // 
            // LImagenProducto
            // 
            this.LImagenProducto.AutoSize = true;
            this.LImagenProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagenProducto.ForeColor = System.Drawing.Color.Black;
            this.LImagenProducto.Location = new System.Drawing.Point(17, 128);
            this.LImagenProducto.Name = "LImagenProducto";
            this.LImagenProducto.Size = new System.Drawing.Size(82, 23);
            this.LImagenProducto.TabIndex = 21;
            this.LImagenProducto.Text = "Imagen";
            // 
            // TBPrecioProducto
            // 
            this.TBPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioProducto.Location = new System.Drawing.Point(387, 207);
            this.TBPrecioProducto.MaxLength = 8;
            this.TBPrecioProducto.Name = "TBPrecioProducto";
            this.TBPrecioProducto.Size = new System.Drawing.Size(381, 30);
            this.TBPrecioProducto.TabIndex = 20;
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.LPrecioProducto.Location = new System.Drawing.Point(383, 181);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(82, 23);
            this.LPrecioProducto.TabIndex = 18;
            this.LPrecioProducto.Text = "Precio";
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.LCategoriaProducto.Location = new System.Drawing.Point(380, 128);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(118, 23);
            this.LCategoriaProducto.TabIndex = 17;
            this.LCategoriaProducto.Text = "Categoria";
            // 
            // TBDescripcionProducto
            // 
            this.TBDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcionProducto.Location = new System.Drawing.Point(21, 95);
            this.TBDescripcionProducto.MaxLength = 8;
            this.TBDescripcionProducto.Name = "TBDescripcionProducto";
            this.TBDescripcionProducto.Size = new System.Drawing.Size(747, 30);
            this.TBDescripcionProducto.TabIndex = 16;
            // 
            // LDescripcionProducto
            // 
            this.LDescripcionProducto.AutoSize = true;
            this.LDescripcionProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProducto.Location = new System.Drawing.Point(17, 69);
            this.LDescripcionProducto.Name = "LDescripcionProducto";
            this.LDescripcionProducto.Size = new System.Drawing.Size(142, 23);
            this.LDescripcionProducto.TabIndex = 15;
            this.LDescripcionProducto.Text = "Descripcion";
            this.LDescripcionProducto.Click += new System.EventHandler(this.LDniVendedor_Click);
            // 
            // TBNombreVendedor
            // 
            this.TBNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreVendedor.Location = new System.Drawing.Point(21, 36);
            this.TBNombreVendedor.MaxLength = 8;
            this.TBNombreVendedor.Name = "TBNombreVendedor";
            this.TBNombreVendedor.Size = new System.Drawing.Size(747, 30);
            this.TBNombreVendedor.TabIndex = 14;
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Location = new System.Drawing.Point(17, 10);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(190, 23);
            this.LNombreProducto.TabIndex = 11;
            this.LNombreProducto.Text = "Nombre Producto";
            // 
            // CBCategoriaProducto
            // 
            this.CBCategoriaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBCategoriaProducto.FormattingEnabled = true;
            this.CBCategoriaProducto.Items.AddRange(new object[] {
            "1-Collares",
            "2-Aros",
            "3-Otros"});
            this.CBCategoriaProducto.Location = new System.Drawing.Point(387, 154);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(381, 24);
            this.CBCategoriaProducto.TabIndex = 36;
            // 
            // PBImagenProducto
            // 
            this.PBImagenProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PBImagenProducto.Location = new System.Drawing.Point(21, 154);
            this.PBImagenProducto.Name = "PBImagenProducto";
            this.PBImagenProducto.Size = new System.Drawing.Size(336, 237);
            this.PBImagenProducto.TabIndex = 37;
            this.PBImagenProducto.TabStop = false;
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PAgregarClienteFondo);
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            this.PAgregarClienteFondo.ResumeLayout(false);
            this.PAgregarProducto.ResumeLayout(false);
            this.PAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAgregarClienteFondo;
        public System.Windows.Forms.Label LAgregarProducto;
        private System.Windows.Forms.Panel PAgregarProducto;
        private System.Windows.Forms.DateTimePicker DTFechaIngVendedor;
        private System.Windows.Forms.Label LFechaModificacion;
        private System.Windows.Forms.Button BAgregarVendedor;
        private System.Windows.Forms.TextBox TBStockProducto;
        private System.Windows.Forms.Label LStockProducto;
        private System.Windows.Forms.Label LImagenProducto;
        private System.Windows.Forms.TextBox TBPrecioProducto;
        private System.Windows.Forms.Label LPrecioProducto;
        private System.Windows.Forms.Label LCategoriaProducto;
        private System.Windows.Forms.TextBox TBDescripcionProducto;
        private System.Windows.Forms.Label LDescripcionProducto;
        private System.Windows.Forms.TextBox TBNombreVendedor;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.ComboBox CBCategoriaProducto;
        private System.Windows.Forms.PictureBox PBImagenProducto;
    }
}