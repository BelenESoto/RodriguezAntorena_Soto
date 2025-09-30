namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class verProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verProductos));
            this.pVerProd = new System.Windows.Forms.Panel();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.TBBuscarVenta = new System.Windows.Forms.ToolStripTextBox();
            this.LItems = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BBuscarVenta = new System.Windows.Forms.ToolStripSplitButton();
            this.TSPorCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSPorNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.TSPorFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTSBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.pVerProd.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pVerProd
            // 
            this.pVerProd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pVerProd.Controls.Add(this.BTSBusquedaCliente);
            this.pVerProd.Controls.Add(this.LAgregarventas);
            this.pVerProd.Controls.Add(this.LItems);
            this.pVerProd.Controls.Add(this.toolStrip1);
            this.pVerProd.Controls.Add(this.DGVListaProd);
            this.pVerProd.Location = new System.Drawing.Point(1, 0);
            this.pVerProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pVerProd.Name = "pVerProd";
            this.pVerProd.Size = new System.Drawing.Size(561, 428);
            this.pVerProd.TabIndex = 0;
            // 
            // LAgregarventas
            // 
            this.LAgregarventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarventas.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarventas.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarventas.Location = new System.Drawing.Point(4, 3);
            this.LAgregarventas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAgregarventas.Name = "LAgregarventas";
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.LAgregarventas.Size = new System.Drawing.Size(553, 36);
            this.LAgregarventas.TabIndex = 45;
            this.LAgregarventas.Text = "LISTADO PRODUCTOS";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBBuscarVenta
            // 
            this.TBBuscarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarVenta.Name = "TBBuscarVenta";
            this.TBBuscarVenta.Size = new System.Drawing.Size(276, 62);
            // 
            // LItems
            // 
            this.LItems.BackColor = System.Drawing.Color.White;
            this.LItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LItems.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LItems.ForeColor = System.Drawing.Color.Black;
            this.LItems.Location = new System.Drawing.Point(4, 112);
            this.LItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LItems.Name = "LItems";
            this.LItems.Padding = new System.Windows.Forms.Padding(3);
            this.LItems.Size = new System.Drawing.Size(553, 31);
            this.LItems.TabIndex = 48;
            this.LItems.Text = "ITEMS ";
            this.LItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.BBuscarVenta,
            this.toolStripSeparator2,
            this.TBBuscarVenta});
            this.toolStrip1.Location = new System.Drawing.Point(4, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 62);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 59);
            // 
            // BBuscarVenta
            // 
            this.BBuscarVenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSPorCodigo,
            this.TSPorNombre,
            this.TSPorFecha});
            this.BBuscarVenta.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarVenta.Image")));
            this.BBuscarVenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarVenta.Name = "BBuscarVenta";
            this.BBuscarVenta.Size = new System.Drawing.Size(93, 59);
            this.BBuscarVenta.Text = "BUSCAR POR";
            // 
            // TSPorCodigo
            // 
            this.TSPorCodigo.AutoSize = false;
            this.TSPorCodigo.Checked = true;
            this.TSPorCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSPorCodigo.Name = "TSPorCodigo";
            this.TSPorCodigo.ShowShortcutKeys = false;
            this.TSPorCodigo.Size = new System.Drawing.Size(180, 22);
            this.TSPorCodigo.Text = "POR CODIGO";
            // 
            // TSPorNombre
            // 
            this.TSPorNombre.Name = "TSPorNombre";
            this.TSPorNombre.Size = new System.Drawing.Size(149, 22);
            this.TSPorNombre.Text = "POR NOMBRE";
            // 
            // TSPorFecha
            // 
            this.TSPorFecha.Name = "TSPorFecha";
            this.TSPorFecha.Size = new System.Drawing.Size(149, 22);
            this.TSPorFecha.Text = "POR FECHA";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria_producto,
            this.Marca_producto,
            this.Precio_producto,
            this.Cantidad_producto,
            this.Subtotal_producto});
            this.DGVListaProd.Location = new System.Drawing.Point(4, 149);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(553, 277);
            this.DGVListaProd.TabIndex = 47;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo_producto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_producto";
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Categoria_producto
            // 
            this.Categoria_producto.DataPropertyName = "categoria_producto";
            this.Categoria_producto.HeaderText = "Categoria";
            this.Categoria_producto.MinimumWidth = 6;
            this.Categoria_producto.Name = "Categoria_producto";
            this.Categoria_producto.Width = 125;
            // 
            // Marca_producto
            // 
            this.Marca_producto.DataPropertyName = "marca_producto";
            this.Marca_producto.HeaderText = "Marca";
            this.Marca_producto.MinimumWidth = 6;
            this.Marca_producto.Name = "Marca_producto";
            this.Marca_producto.Width = 125;
            // 
            // Precio_producto
            // 
            this.Precio_producto.DataPropertyName = "precio";
            this.Precio_producto.HeaderText = "Precio";
            this.Precio_producto.MinimumWidth = 6;
            this.Precio_producto.Name = "Precio_producto";
            this.Precio_producto.Width = 125;
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.DataPropertyName = "cantidad_producto";
            this.Cantidad_producto.HeaderText = "Cantidad";
            this.Cantidad_producto.MinimumWidth = 6;
            this.Cantidad_producto.Name = "Cantidad_producto";
            this.Cantidad_producto.Width = 125;
            // 
            // Subtotal_producto
            // 
            this.Subtotal_producto.DataPropertyName = "subtotal_producto";
            this.Subtotal_producto.HeaderText = "Subtotal";
            this.Subtotal_producto.MinimumWidth = 6;
            this.Subtotal_producto.Name = "Subtotal_producto";
            this.Subtotal_producto.Width = 125;
            // 
            // BTSBusquedaCliente
            // 
            this.BTSBusquedaCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusquedaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTSBusquedaCliente.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusquedaCliente.IconColor = System.Drawing.Color.Black;
            this.BTSBusquedaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusquedaCliente.IconSize = 36;
            this.BTSBusquedaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusquedaCliente.Location = new System.Drawing.Point(411, 52);
            this.BTSBusquedaCliente.Name = "BTSBusquedaCliente";
            this.BTSBusquedaCliente.Size = new System.Drawing.Size(125, 35);
            this.BTSBusquedaCliente.TabIndex = 49;
            this.BTSBusquedaCliente.Text = "Buscar";
            this.BTSBusquedaCliente.UseVisualStyleBackColor = false;
            // 
            // verProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 429);
            this.Controls.Add(this.pVerProd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "verProductos";
            this.Text = "verProductos";
            this.pVerProd.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pVerProd;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.Label LItems;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton BBuscarVenta;
        private System.Windows.Forms.ToolStripMenuItem TSPorCodigo;
        private System.Windows.Forms.ToolStripMenuItem TSPorNombre;
        private System.Windows.Forms.ToolStripMenuItem TSPorFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox TBBuscarVenta;
        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_producto;
        private FontAwesome.Sharp.IconButton BTSBusquedaCliente;
    }
}