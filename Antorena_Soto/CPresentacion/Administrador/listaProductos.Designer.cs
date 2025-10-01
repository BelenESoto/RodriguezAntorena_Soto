﻿namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class listaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaProductos));
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.BEditarProd = new System.Windows.Forms.Button();
            this.BEliminarProd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarProducto = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolCodigoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNombreProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarProducto = new System.Windows.Forms.ToolStripTextBox();
            this.BTSBusquedaProd = new FontAwesome.Sharp.IconButton();
            this.bImprimir = new System.Windows.Forms.Button();
            this.LAgregarventas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Location = new System.Drawing.Point(7, 159);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(548, 188);
            this.DGVListaProd.TabIndex = 1;
            this.DGVListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProd_CellContentClick_1);
            // 
            // BEditarProd
            // 
            this.BEditarProd.BackColor = System.Drawing.Color.White;
            this.BEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BEditarProd.Location = new System.Drawing.Point(69, 366);
            this.BEditarProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(124, 43);
            this.BEditarProd.TabIndex = 2;
            this.BEditarProd.Text = "EDITAR";
            this.BEditarProd.UseVisualStyleBackColor = false;
            this.BEditarProd.Click += new System.EventHandler(this.BEditarProd_Click);
            // 
            // BEliminarProd
            // 
            this.BEliminarProd.BackColor = System.Drawing.Color.White;
            this.BEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminarProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BEliminarProd.Location = new System.Drawing.Point(357, 362);
            this.BEliminarProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BEliminarProd.Name = "BEliminarProd";
            this.BEliminarProd.Size = new System.Drawing.Size(130, 45);
            this.BEliminarProd.TabIndex = 3;
            this.BEliminarProd.Text = "ELIMINAR";
            this.BEliminarProd.UseVisualStyleBackColor = false;
            this.BEliminarProd.Click += new System.EventHandler(this.BEliminarProd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarProducto,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TBBuscarProducto});
            this.toolStrip1.Location = new System.Drawing.Point(-4, 79);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 35);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCodigoProd,
            this.toolNombreProd});
            this.BBuscarProducto.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
            this.BBuscarProducto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarProducto.Image")));
            this.BBuscarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(155, 32);
            this.BBuscarProducto.Text = "BUSCAR PRODUCTO";
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // toolCodigoProd
            // 
            this.toolCodigoProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolCodigoProd.Name = "toolCodigoProd";
            this.toolCodigoProd.Size = new System.Drawing.Size(180, 22);
            this.toolCodigoProd.Text = "POR CODIGO";
            this.toolCodigoProd.Click += new System.EventHandler(this.toolCodigoProd_Click);
            // 
            // toolNombreProd
            // 
            this.toolNombreProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolNombreProd.Name = "toolNombreProd";
            this.toolNombreProd.Size = new System.Drawing.Size(180, 22);
            this.toolNombreProd.Text = "POR NOMBRE";
            this.toolNombreProd.Click += new System.EventHandler(this.toolNombreProd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 32);
            // 
            // TBBuscarProducto
            // 
            this.TBBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarProducto.Name = "TBBuscarProducto";
            this.TBBuscarProducto.Size = new System.Drawing.Size(276, 35);
            this.TBBuscarProducto.Click += new System.EventHandler(this.TBBuscarCliente_Click);
            // 
            // BTSBusquedaProd
            // 
            this.BTSBusquedaProd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusquedaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusquedaProd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
            this.BTSBusquedaProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BTSBusquedaProd.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusquedaProd.IconColor = System.Drawing.Color.Black;
            this.BTSBusquedaProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusquedaProd.IconSize = 36;
            this.BTSBusquedaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusquedaProd.Location = new System.Drawing.Point(441, 79);
            this.BTSBusquedaProd.Name = "BTSBusquedaProd";
            this.BTSBusquedaProd.Size = new System.Drawing.Size(125, 35);
            this.BTSBusquedaProd.TabIndex = 9;
            this.BTSBusquedaProd.Text = "Buscar";
            this.BTSBusquedaProd.UseVisualStyleBackColor = false;
            this.BTSBusquedaProd.Click += new System.EventHandler(this.BTSBusquedaProd_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.White;
            this.bImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.Location = new System.Drawing.Point(219, 365);
            this.bImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(124, 43);
            this.bImprimir.TabIndex = 10;
            this.bImprimir.Text = "IMPRIMIR";
            this.bImprimir.UseVisualStyleBackColor = false;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // LAgregarventas
            // 
            this.LAgregarventas.BackColor = System.Drawing.Color.MidnightBlue;
            this.LAgregarventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAgregarventas.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarventas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LAgregarventas.Image = ((System.Drawing.Image)(resources.GetObject("LAgregarventas.Image")));
            this.LAgregarventas.Location = new System.Drawing.Point(0, 0);
            this.LAgregarventas.Margin = new System.Windows.Forms.Padding(0);
            this.LAgregarventas.Name = "LAgregarventas";
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.LAgregarventas.Size = new System.Drawing.Size(566, 79);
            this.LAgregarventas.TabIndex = 11;
            this.LAgregarventas.Text = "INFORMACIÓN PRODUCTO";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(566, 583);
            this.Controls.Add(this.LAgregarventas);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.BTSBusquedaProd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BEliminarProd);
            this.Controls.Add(this.BEditarProd);
            this.Controls.Add(this.DGVListaProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "listaProductos";
            this.Text = "listaProductos";
            this.Load += new System.EventHandler(this.listaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.Button BEditarProd;
        private System.Windows.Forms.Button BEliminarProd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton BBuscarProducto;
        private System.Windows.Forms.ToolStripMenuItem toolCodigoProd;
        private System.Windows.Forms.ToolStripMenuItem toolNombreProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private FontAwesome.Sharp.IconButton BTSBusquedaProd;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.ToolStripTextBox TBBuscarProducto;
        public System.Windows.Forms.Label LAgregarventas;
    }
}