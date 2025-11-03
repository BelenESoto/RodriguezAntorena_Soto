using System;

namespace Antorena_Soto.CPresentacion.Administrador
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
            this.PAgregarProducto = new System.Windows.Forms.Panel();
            this.tbCodigoProducto = new System.Windows.Forms.TextBox();
            this.lCodigo = new System.Windows.Forms.Label();
            this.CBEstadoProd = new System.Windows.Forms.ComboBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.lAltaProd = new System.Windows.Forms.Label();
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
            this.panelProd = new System.Windows.Forms.Panel();
            this.PAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProducto)).BeginInit();
            this.panelProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAgregarProducto
            // 
            this.PAgregarProducto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PAgregarProducto.Controls.Add(this.tbCodigoProducto);
            this.PAgregarProducto.Controls.Add(this.lCodigo);
            this.PAgregarProducto.Controls.Add(this.CBEstadoProd);
            this.PAgregarProducto.Controls.Add(this.lEstado);
            this.PAgregarProducto.Controls.Add(this.lAltaProd);
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
            this.PAgregarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.PAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PAgregarProducto.Name = "PAgregarProducto";
            this.PAgregarProducto.Size = new System.Drawing.Size(566, 583);
            this.PAgregarProducto.TabIndex = 1;
            this.PAgregarProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarProducto_Paint);
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoProducto.Location = new System.Drawing.Point(27, 131);
            this.tbCodigoProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCodigoProducto.MaxLength = 100;
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.Size = new System.Drawing.Size(301, 26);
            this.tbCodigoProducto.TabIndex = 42;
            this.tbCodigoProducto.TextChanged += new System.EventHandler(this.tbCodigoProducto_TextChanged);
            this.tbCodigoProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TBCodigoProducto_Validating);
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.ForeColor = System.Drawing.Color.Black;
            this.lCodigo.Location = new System.Drawing.Point(24, 104);
            this.lCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(69, 19);
            this.lCodigo.TabIndex = 41;
            this.lCodigo.Text = "Codigo";
            // 
            // CBEstadoProd
            // 
            this.CBEstadoProd.FormattingEnabled = true;
            this.CBEstadoProd.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstadoProd.Location = new System.Drawing.Point(332, 131);
            this.CBEstadoProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBEstadoProd.Name = "CBEstadoProd";
            this.CBEstadoProd.Size = new System.Drawing.Size(204, 21);
            this.CBEstadoProd.TabIndex = 40;
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.Black;
            this.lEstado.Location = new System.Drawing.Point(348, 104);
            this.lEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(69, 19);
            this.lEstado.TabIndex = 39;
            this.lEstado.Text = "Estado";
            // 
            // lAltaProd
            // 
            this.lAltaProd.AutoSize = true;
            this.lAltaProd.BackColor = System.Drawing.Color.White;
            this.lAltaProd.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltaProd.Location = new System.Drawing.Point(194, 19);
            this.lAltaProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAltaProd.Name = "lAltaProd";
            this.lAltaProd.Size = new System.Drawing.Size(238, 22);
            this.lAltaProd.TabIndex = 38;
            this.lAltaProd.Text = "   Alta Producto   ";
            // 
            // PBImagenProducto
            // 
            this.PBImagenProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PBImagenProducto.Location = new System.Drawing.Point(27, 246);
            this.PBImagenProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBImagenProducto.Name = "PBImagenProducto";
            this.PBImagenProducto.Size = new System.Drawing.Size(212, 278);
            this.PBImagenProducto.TabIndex = 37;
            this.PBImagenProducto.TabStop = false;
            // 
            // CBCategoriaProducto
            // 
            this.CBCategoriaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBCategoriaProducto.FormattingEnabled = true;
            this.CBCategoriaProducto.Items.AddRange(new object[] {
            "1 - Collares",
            "2 - Aros",
            "3 - Otros"});
            this.CBCategoriaProducto.Location = new System.Drawing.Point(261, 246);
            this.CBCategoriaProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBCategoriaProducto.Name = "CBCategoriaProducto";
            this.CBCategoriaProducto.Size = new System.Drawing.Size(268, 21);
            this.CBCategoriaProducto.TabIndex = 36;
            this.CBCategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.CBCategoriaProducto_SelectedIndexChanged_1);
            this.CBCategoriaProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TBCategoriaProducto_Validating);
            // 
            // DTFechaModifProd
            // 
            this.DTFechaModifProd.Location = new System.Drawing.Point(268, 459);
            this.DTFechaModifProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTFechaModifProd.Name = "DTFechaModifProd";
            this.DTFechaModifProd.Size = new System.Drawing.Size(260, 20);
            this.DTFechaModifProd.TabIndex = 35;
            // 
            // LFechaModificacionProd
            // 
            this.LFechaModificacionProd.AutoSize = true;
            this.LFechaModificacionProd.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaModificacionProd.ForeColor = System.Drawing.Color.Black;
            this.LFechaModificacionProd.Location = new System.Drawing.Point(266, 429);
            this.LFechaModificacionProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFechaModificacionProd.Name = "LFechaModificacionProd";
            this.LFechaModificacionProd.Size = new System.Drawing.Size(189, 19);
            this.LFechaModificacionProd.TabIndex = 30;
            this.LFechaModificacionProd.Text = "Fecha Modificacion";
            // 
            // BAgregarProducto
            // 
            this.BAgregarProducto.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarProducto.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.BAgregarProducto.Location = new System.Drawing.Point(332, 514);
            this.BAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BAgregarProducto.Name = "BAgregarProducto";
            this.BAgregarProducto.Size = new System.Drawing.Size(143, 32);
            this.BAgregarProducto.TabIndex = 25;
            this.BAgregarProducto.Text = "Agregar Producto";
            this.BAgregarProducto.UseVisualStyleBackColor = false;
            this.BAgregarProducto.Click += new System.EventHandler(this.BAgregarProducto_Click);
            // 
            // TBStockProducto
            // 
            this.TBStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProducto.Location = new System.Drawing.Point(268, 388);
            this.TBStockProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBStockProducto.MaxLength = 10;
            this.TBStockProducto.Name = "TBStockProducto";
            this.TBStockProducto.Size = new System.Drawing.Size(260, 26);
            this.TBStockProducto.TabIndex = 24;
            // 
            // LStockProducto
            // 
            this.LStockProducto.AutoSize = true;
            this.LStockProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockProducto.ForeColor = System.Drawing.Color.Black;
            this.LStockProducto.Location = new System.Drawing.Point(266, 353);
            this.LStockProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LStockProducto.Name = "LStockProducto";
            this.LStockProducto.Size = new System.Drawing.Size(59, 19);
            this.LStockProducto.TabIndex = 23;
            this.LStockProducto.Text = "Stock";
            // 
            // LImagenProducto
            // 
            this.LImagenProducto.AutoSize = true;
            this.LImagenProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LImagenProducto.ForeColor = System.Drawing.Color.Black;
            this.LImagenProducto.Location = new System.Drawing.Point(24, 215);
            this.LImagenProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LImagenProducto.Name = "LImagenProducto";
            this.LImagenProducto.Size = new System.Drawing.Size(69, 19);
            this.LImagenProducto.TabIndex = 21;
            this.LImagenProducto.Text = "Imagen";
            // 
            // TBPrecioProducto
            // 
            this.TBPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecioProducto.Location = new System.Drawing.Point(268, 319);
            this.TBPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPrecioProducto.MaxLength = 8;
            this.TBPrecioProducto.Name = "TBPrecioProducto";
            this.TBPrecioProducto.Size = new System.Drawing.Size(260, 26);
            this.TBPrecioProducto.TabIndex = 20;
            // 
            // LPrecioProducto
            // 
            this.LPrecioProducto.AutoSize = true;
            this.LPrecioProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.LPrecioProducto.Location = new System.Drawing.Point(266, 287);
            this.LPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPrecioProducto.Name = "LPrecioProducto";
            this.LPrecioProducto.Size = new System.Drawing.Size(69, 19);
            this.LPrecioProducto.TabIndex = 18;
            this.LPrecioProducto.Text = "Precio";
            // 
            // LCategoriaProducto
            // 
            this.LCategoriaProducto.AutoSize = true;
            this.LCategoriaProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaProducto.ForeColor = System.Drawing.Color.Black;
            this.LCategoriaProducto.Location = new System.Drawing.Point(266, 215);
            this.LCategoriaProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCategoriaProducto.Name = "LCategoriaProducto";
            this.LCategoriaProducto.Size = new System.Drawing.Size(99, 19);
            this.LCategoriaProducto.TabIndex = 17;
            this.LCategoriaProducto.Text = "Categoria";
            // 
            // TBDescripcionProducto
            // 
            this.TBDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcionProducto.Location = new System.Drawing.Point(27, 188);
            this.TBDescripcionProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBDescripcionProducto.MaxLength = 200;
            this.TBDescripcionProducto.Name = "TBDescripcionProducto";
            this.TBDescripcionProducto.Size = new System.Drawing.Size(502, 26);
            this.TBDescripcionProducto.TabIndex = 16;
            // 
            // LDescripcionProducto
            // 
            this.LDescripcionProducto.AutoSize = true;
            this.LDescripcionProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProducto.Location = new System.Drawing.Point(24, 158);
            this.LDescripcionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDescripcionProducto.Name = "LDescripcionProducto";
            this.LDescripcionProducto.Size = new System.Drawing.Size(119, 19);
            this.LDescripcionProducto.TabIndex = 15;
            this.LDescripcionProducto.Text = "Descripcion";
            // 
            // TBNombreProducto
            // 
            this.TBNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProducto.Location = new System.Drawing.Point(27, 77);
            this.TBNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNombreProducto.MaxLength = 100;
            this.TBNombreProducto.Name = "TBNombreProducto";
            this.TBNombreProducto.Size = new System.Drawing.Size(508, 26);
            this.TBNombreProducto.TabIndex = 14;
            this.TBNombreProducto.TextChanged += new System.EventHandler(this.TBNombreProducto_TextChanged_1);
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Location = new System.Drawing.Point(24, 56);
            this.LNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(159, 19);
            this.LNombreProducto.TabIndex = 11;
            this.LNombreProducto.Text = "Nombre Producto";
            // 
            // panelProd
            // 
            this.panelProd.BackColor = System.Drawing.Color.Black;
            this.panelProd.Controls.Add(this.PAgregarProducto);
            this.panelProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProd.Location = new System.Drawing.Point(0, 0);
            this.panelProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(566, 583);
            this.panelProd.TabIndex = 3;
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(566, 583);
            this.Controls.Add(this.panelProd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            this.Load += new System.EventHandler(this.AltaProductos_Load);
            this.PAgregarProducto.ResumeLayout(false);
            this.PAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenProducto)).EndInit();
            this.panelProd.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
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
        private System.Windows.Forms.Panel panelProd;
        private System.Windows.Forms.Label lAltaProd;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.ComboBox CBEstadoProd;
        private System.Windows.Forms.TextBox tbCodigoProducto;
        private System.Windows.Forms.Label lCodigo;
    }
}