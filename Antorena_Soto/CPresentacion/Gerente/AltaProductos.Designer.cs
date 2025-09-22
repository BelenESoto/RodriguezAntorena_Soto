using System;

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
            this.LAgregarProducto = new System.Windows.Forms.Label();
            this.PAgregarProducto = new System.Windows.Forms.Panel();
            this.PBImagenProducto = new System.Windows.Forms.PictureBox();
            this.CBCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.DTFechaModifProd = new System.Windows.Forms.DateTimePicker();
            this.LFechaModificacionProd = new System.Windows.Forms.Label();
            this.BAgregarProducto = new System.Windows.Forms.Button();
            this.TBStockProducto = new System.Windows.Forms.TextBox();
            this.LStockProducto = new System.Windows.Forms.Label();
            this.LImagenProducto = new System.Windows.Forms.Label();
            this.TBPrecioProducto = new System.Windows.Forms.TextBox();
            this.LPrecioProducto = new System.Windows.Forms.Label();
            this.LCategoriaProducto = new System.Windows.Forms.Label();
            this.TBDescripcionProducto = new System.Windows.Forms.TextBox();
            this.LDescripcionProducto = new System.Windows.Forms.Label();
            this.TBNombreProducto = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAgregarProducto
            // 
            this.LAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarProducto.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarProducto.Location = new System.Drawing.Point(-1, 7);
            this.LAgregarProducto.Name = "LAgregarProducto";
            this.LAgregarProducto.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.LAgregarProducto.Size = new System.Drawing.Size(739, 44);
            this.LAgregarProducto.TabIndex = 2;
            this.LAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.LAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAgregarProducto
            // 
            this.PAgregarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.PAgregarProducto.Controls.Add(this.PBImagenProducto);
            this.PAgregarProducto.Controls.Add(this.CBCategoriaProducto);
            this.PAgregarProducto.Controls.Add(this.DTFechaModifProd);
            this.PAgregarProducto.Controls.Add(this.LFechaModificacionProd);
            this.PAgregarProducto.Controls.Add(this.BAgregarProducto);
            this.PAgregarProducto.Controls.Add(this.TBStockProducto);
            this.PAgregarProducto.Controls.Add(this.LStockProducto);
            this.PAgregarProducto.Controls.Add(this.LImagenProducto);
            this.PAgregarProducto.Controls.Add(this.TBPrecioProducto);
            this.PAgregarProducto.Controls.Add(this.LPrecioProducto);
            this.PAgregarProducto.Controls.Add(this.LCategoriaProducto);
            this.PAgregarProducto.Controls.Add(this.TBDescripcionProducto);
            this.PAgregarProducto.Controls.Add(this.LDescripcionProducto);
            this.PAgregarProducto.Controls.Add(this.TBNombreProducto);
            this.PAgregarProducto.Controls.Add(this.LNombreProducto);
            this.PAgregarProducto.Location = new System.Drawing.Point(-15, 57);
            this.PAgregarProducto.Name = "PAgregarProducto";
            this.PAgregarProducto.Size = new System.Drawing.Size(753, 421);
            this.PAgregarProducto.TabIndex = 1;
            // 
            // PBImagenProducto
            // 
            this.PBImagenProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PBImagenProducto.Location = new System.Drawing.Point(21, 154);
            this.PBImagenProducto.Name = "PBImagenProducto";
            this.PBImagenProducto.Size = new System.Drawing.Size(242, 237);
            this.PBImagenProducto.TabIndex = 37;
            this.PBImagenProducto.TabStop = false;
            this.PBImagenProducto.Click += new System.EventHandler(this.PBImagenProducto_Click);
            this.PBImagenProducto.Validating += new System.ComponentModel.CancelEventHandler(this.PBImagenProducto_Validating);
            // 
            // CBCategoriaProducto
            // 
            this.CBCategoriaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBCategoriaProducto.FormattingEnabled = true;
            this.CBCategoriaProducto.Items.AddRange(new object[] {
            "1-Collares",
            "2-Aros",
            "3-Otros"});
            this.CBCategoriaProducto.Location = new System.Drawing.Point(269, 154);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(446, 24);
            this.CBCategoriaProducto.TabIndex = 36;
            this.CBCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.CBCategoriaProducto_SelectedIndexChanged);
            // 
            // DTFechaModifProd
            // 
            this.DTFechaModifProd.Location = new System.Drawing.Point(268, 325);
            this.DTFechaModifProd.Name = "DTFechaModifProd";
            this.DTFechaModifProd.Size = new System.Drawing.Size(451, 22);
            this.DTFechaModifProd.TabIndex = 35;
            this.DTFechaModifProd.ValueChanged += new System.EventHandler(this.DTFechaModifProd_ValueChanged);
            this.DTFechaModifProd.Validating += new System.ComponentModel.CancelEventHandler(this.DTFechaModifProd_Validating);
            // 
            // LFechaModificacionProd
            // 
            this.LFechaModificacionProd.AutoSize = true;
            this.LFechaModificacionProd.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaModificacionProd.ForeColor = System.Drawing.Color.Black;
            this.LFechaModificacionProd.Location = new System.Drawing.Point(269, 299);
            this.LFechaModificacionProd.Name = "LFechaModificacionProd";
            this.LFechaModificacionProd.Size = new System.Drawing.Size(226, 23);
            this.LFechaModificacionProd.TabIndex = 30;
            this.LFechaModificacionProd.Text = "Fecha Modificacion";
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarProducto.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.BAgregarProducto.Location = new System.Drawing.Point(383, 354);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(191, 40);
            this.BAgregarProducto.TabIndex = 25;
            this.BAgregarProducto.Text = "Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = false;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // TBStockProducto
            // 
            this.TBStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProducto.Location = new System.Drawing.Point(269, 266);
            this.TBStockProducto.MaxLength = 10;
            this.TBStockProducto.Name = "TBStockProducto";
            this.TBStockProducto.Size = new System.Drawing.Size(450, 30);
            this.TBStockProducto.TabIndex = 24;
            this.TBStockProducto.TextChanged += new System.EventHandler(this.TBStockProducto_TextChanged);
            // 
            // LStockProducto
            // 
            this.LStockProducto.AutoSize = true;
            this.LStockProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockProducto.ForeColor = System.Drawing.Color.Black;
            this.LStockProducto.Location = new System.Drawing.Point(269, 240);
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
            this.TBPrecioProducto.Location = new System.Drawing.Point(273, 207);
            this.TBPrecioProducto.MaxLength = 8;
            this.TBPrecioProducto.Name = "TBPrecioProducto";
            this.TBPrecioProducto.Size = new System.Drawing.Size(446, 30);
            this.TBPrecioProducto.TabIndex = 20;
            this.TBPrecioProducto.TextChanged += new System.EventHandler(this.TBPrecioProducto_TextChanged);
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.LPrecioProducto.Location = new System.Drawing.Point(269, 181);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(82, 23);
            this.LPrecioProducto.TabIndex = 18;
            this.LPrecioProducto.Text = "Precio";
            this.LPrecioProducto.Click += new System.EventHandler(this.LPrecioProducto_Click);
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.LCategoriaProducto.Location = new System.Drawing.Point(269, 128);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(118, 23);
            this.LCategoriaProducto.TabIndex = 17;
            this.LCategoriaProducto.Text = "Categoria";
            // 
            // TBDescripcionProducto
            // 
            this.TBDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcionProducto.Location = new System.Drawing.Point(19, 95);
            this.TBDescripcionProducto.MaxLength = 200;
            this.TBDescripcionProducto.Name = "TBDescripcionProducto";
            this.TBDescripcionProducto.Size = new System.Drawing.Size(700, 30);
            this.TBDescripcionProducto.TabIndex = 16;
            this.TBDescripcionProducto.TextChanged += new System.EventHandler(this.TBDescripcionProducto_TextChanged);
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
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.Location = new System.Drawing.Point(21, 36);
            this.TBNombreProducto.MaxLength = 100;
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(698, 30);
            this.TBNombreProducto.TabIndex = 14;
            this.TBNombreProducto.TextChanged += new System.EventHandler(this.TBNombreProducto_TextChanged);
            this.TBNombreProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombreProductos_Validating);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.PAgregarProducto);
            this.panel1.Controls.Add(this.LAgregarProducto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 500);
            this.panel1.TabIndex = 3;
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(742, 453);
            this.Controls.Add(this.panel1);
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            this.PAgregarProducto.ResumeLayout(false);
            this.PAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        public System.Windows.Forms.Label LAgregarProducto;
        private System.Windows.Forms.Panel PAgregarProducto;
        private System.Windows.Forms.DateTimePicker DTFechaModifProd;
        private System.Windows.Forms.Label LFechaModificacionProd;
        private System.Windows.Forms.Button BAgregarProducto;
        private System.Windows.Forms.TextBox TBStockProducto;
        private System.Windows.Forms.Label LStockProducto;
        private System.Windows.Forms.Label LImagenProducto;
        private System.Windows.Forms.TextBox TBPrecioProducto;
        private System.Windows.Forms.Label LPrecioProducto;
        private System.Windows.Forms.Label LCategoriaProducto;
        private System.Windows.Forms.TextBox TBDescripcionProducto;
        private System.Windows.Forms.Label LDescripcionProducto;
        private System.Windows.Forms.TextBox TBNombreProducto;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.ComboBox CBCategoriaProducto;
        private System.Windows.Forms.PictureBox PBImagenProducto;
        private System.Windows.Forms.Panel panel1;
    }
}