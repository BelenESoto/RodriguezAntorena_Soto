namespace Antorena_Soto.CPresentacion.Administrador
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
            this.Nombre_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModif_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DGVListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_prod,
            this.codigo_prod,
            this.estado_prod,
            this.descripcion_prod,
            this.categoria_prod,
            this.precio_prod,
            this.stock_prod,
            this.imagen_prod,
            this.fechaModif_prod});
            this.DGVListaProd.Location = new System.Drawing.Point(12, 183);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(731, 231);
            this.DGVListaProd.TabIndex = 1;
            this.DGVListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProd_CellContentClick_1);
            // 
            // Nombre_prod
            // 
            this.Nombre_prod.DataPropertyName = "nombre_prod";
            this.Nombre_prod.HeaderText = "Nombre";
            this.Nombre_prod.MinimumWidth = 6;
            this.Nombre_prod.Name = "Nombre_prod";
            this.Nombre_prod.Width = 125;
            // 
            // codigo_prod
            // 
            this.codigo_prod.DataPropertyName = "codigo_prod";
            this.codigo_prod.HeaderText = "Codigo";
            this.codigo_prod.MinimumWidth = 6;
            this.codigo_prod.Name = "codigo_prod";
            this.codigo_prod.Width = 125;
            // 
            // estado_prod
            // 
            this.estado_prod.DataPropertyName = "estado_prod";
            this.estado_prod.HeaderText = "Estado";
            this.estado_prod.MinimumWidth = 6;
            this.estado_prod.Name = "estado_prod";
            this.estado_prod.Width = 125;
            // 
            // descripcion_prod
            // 
            this.descripcion_prod.DataPropertyName = "descripcion_prod";
            this.descripcion_prod.HeaderText = "Descripcion";
            this.descripcion_prod.MinimumWidth = 6;
            this.descripcion_prod.Name = "descripcion_prod";
            this.descripcion_prod.Width = 125;
            // 
            // categoria_prod
            // 
            this.categoria_prod.DataPropertyName = "categoria_prod";
            this.categoria_prod.HeaderText = "Categoria";
            this.categoria_prod.MinimumWidth = 6;
            this.categoria_prod.Name = "categoria_prod";
            this.categoria_prod.Width = 125;
            // 
            // precio_prod
            // 
            this.precio_prod.DataPropertyName = "precio_prod";
            this.precio_prod.HeaderText = "Precio";
            this.precio_prod.MinimumWidth = 6;
            this.precio_prod.Name = "precio_prod";
            this.precio_prod.Width = 125;
            // 
            // stock_prod
            // 
            this.stock_prod.DataPropertyName = "stock_prod";
            this.stock_prod.HeaderText = "Stock";
            this.stock_prod.MinimumWidth = 6;
            this.stock_prod.Name = "stock_prod";
            this.stock_prod.Width = 125;
            // 
            // imagen_prod
            // 
            this.imagen_prod.DataPropertyName = "imagen_prod";
            this.imagen_prod.HeaderText = "Imagen";
            this.imagen_prod.MinimumWidth = 6;
            this.imagen_prod.Name = "imagen_prod";
            this.imagen_prod.Width = 125;
            // 
            // fechaModif_prod
            // 
            this.fechaModif_prod.DataPropertyName = "fechaModif_prod";
            this.fechaModif_prod.HeaderText = "Fecha Modif";
            this.fechaModif_prod.MinimumWidth = 6;
            this.fechaModif_prod.Name = "fechaModif_prod";
            this.fechaModif_prod.Width = 125;
            // 
            // BEditarProd
            // 
            this.BEditarProd.BackColor = System.Drawing.Color.White;
            this.BEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BEditarProd.Location = new System.Drawing.Point(92, 450);
            this.BEditarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(165, 53);
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
            this.BEliminarProd.Location = new System.Drawing.Point(476, 446);
            this.BEliminarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEliminarProd.Name = "BEliminarProd";
            this.BEliminarProd.Size = new System.Drawing.Size(173, 55);
            this.BEliminarProd.TabIndex = 3;
            this.BEliminarProd.Text = "ELIMINAR";
            this.BEliminarProd.UseVisualStyleBackColor = false;
            this.BEliminarProd.Click += new System.EventHandler(this.BEliminarProdBD_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(-5, 97);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 43);
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
            this.BBuscarProducto.Size = new System.Drawing.Size(188, 40);
            this.BBuscarProducto.Text = "BUSCAR PRODUCTO";
            // 
            // toolCodigoProd
            // 
            this.toolCodigoProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolCodigoProd.Name = "toolCodigoProd";
            this.toolCodigoProd.Size = new System.Drawing.Size(224, 26);
            this.toolCodigoProd.Text = "POR CODIGO";
            this.toolCodigoProd.Click += new System.EventHandler(this.toolCodigoProd_Click);
            // 
            // toolNombreProd
            // 
            this.toolNombreProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolNombreProd.Name = "toolNombreProd";
            this.toolNombreProd.Size = new System.Drawing.Size(224, 26);
            this.toolNombreProd.Text = "POR NOMBRE";
            this.toolNombreProd.Click += new System.EventHandler(this.toolNombreProd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 40);
            // 
            // TBBuscarProducto
            // 
            this.TBBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarProducto.Name = "TBBuscarProducto";
            this.TBBuscarProducto.Size = new System.Drawing.Size(367, 43);
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
            this.BTSBusquedaProd.Location = new System.Drawing.Point(576, 97);
            this.BTSBusquedaProd.Margin = new System.Windows.Forms.Padding(4);
            this.BTSBusquedaProd.Name = "BTSBusquedaProd";
            this.BTSBusquedaProd.Size = new System.Drawing.Size(167, 43);
            this.BTSBusquedaProd.TabIndex = 9;
            this.BTSBusquedaProd.Text = "Buscar";
            this.BTSBusquedaProd.UseVisualStyleBackColor = false;
            this.BTSBusquedaProd.Click += new System.EventHandler(this.BTSBusquedaProdBD_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.White;
            this.bImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.Location = new System.Drawing.Point(292, 449);
            this.bImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(165, 53);
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
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.LAgregarventas.Size = new System.Drawing.Size(755, 97);
            this.LAgregarventas.TabIndex = 11;
            this.LAgregarventas.Text = "INFORMACIÓN PRODUCTO";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LAgregarventas.Click += new System.EventHandler(this.LAgregarventas_Click);
            // 
            // listaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(755, 718);
            this.Controls.Add(this.LAgregarventas);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.BTSBusquedaProd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BEliminarProd);
            this.Controls.Add(this.BEditarProd);
            this.Controls.Add(this.DGVListaProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModif_prod;
    }
}