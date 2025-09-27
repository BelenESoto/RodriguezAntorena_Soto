namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class ventaAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventaAgregar));
            this.LAgregarVenta = new System.Windows.Forms.Label();
            this.PAgregarVendedor = new System.Windows.Forms.Panel();
            this.LItems = new System.Windows.Forms.Label();
            this.BEditarProd = new System.Windows.Forms.Button();
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAgregarProd = new System.Windows.Forms.Button();
            this.LTipoUsuario = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.BContinuar = new System.Windows.Forms.Button();
            this.TBTotalVenta = new System.Windows.Forms.TextBox();
            this.LTotal = new System.Windows.Forms.Label();
            this.TBNombreVendedor = new System.Windows.Forms.TextBox();
            this.LNombreProd = new System.Windows.Forms.Label();
            this.TBuscador = new System.Windows.Forms.ToolStrip();
            this.BBuscarProd = new System.Windows.Forms.ToolStripSplitButton();
            this.BTSCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.BTSNombreProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscadorProd = new System.Windows.Forms.ToolStripTextBox();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarCliente = new System.Windows.Forms.ToolStripDropDownButton();
            this.dNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORNOMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.BTSBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.PAgregarVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.TBuscador.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAgregarVenta
            // 
            this.LAgregarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarVenta.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarVenta.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarVenta.Location = new System.Drawing.Point(-8, 18);
            this.LAgregarVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAgregarVenta.Name = "LAgregarVenta";
            this.LAgregarVenta.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.LAgregarVenta.Size = new System.Drawing.Size(583, 28);
            this.LAgregarVenta.TabIndex = 4;
            this.LAgregarVenta.Text = "AGREGAR  VENTA";
            this.LAgregarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAgregarVendedor
            // 
            this.PAgregarVendedor.BackColor = System.Drawing.Color.Gainsboro;
            this.PAgregarVendedor.Controls.Add(this.LItems);
            this.PAgregarVendedor.Controls.Add(this.BEditarProd);
            this.PAgregarVendedor.Controls.Add(this.DGVListaProd);
            this.PAgregarVendedor.Controls.Add(this.BAgregarProd);
            this.PAgregarVendedor.Controls.Add(this.LTipoUsuario);
            this.PAgregarVendedor.Controls.Add(this.TBCantidad);
            this.PAgregarVendedor.Controls.Add(this.BContinuar);
            this.PAgregarVendedor.Controls.Add(this.TBTotalVenta);
            this.PAgregarVendedor.Controls.Add(this.LTotal);
            this.PAgregarVendedor.Controls.Add(this.TBNombreVendedor);
            this.PAgregarVendedor.Controls.Add(this.LNombreProd);
            this.PAgregarVendedor.Location = new System.Drawing.Point(5, 135);
            this.PAgregarVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PAgregarVendedor.Name = "PAgregarVendedor";
            this.PAgregarVendedor.Size = new System.Drawing.Size(769, 419);
            this.PAgregarVendedor.TabIndex = 3;
            this.PAgregarVendedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarVendedor_Paint);
            // 
            // LItems
            // 
            this.LItems.BackColor = System.Drawing.Color.White;
            this.LItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LItems.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LItems.ForeColor = System.Drawing.Color.Black;
            this.LItems.Location = new System.Drawing.Point(9, 87);
            this.LItems.Name = "LItems";
            this.LItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LItems.Size = new System.Drawing.Size(737, 38);
            this.LItems.TabIndex = 40;
            this.LItems.Text = "ITEMS ";
            this.LItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BEditarProd
            // 
            this.BEditarProd.BackColor = System.Drawing.Color.DarkGray;
            this.BEditarProd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarProd.ForeColor = System.Drawing.Color.Black;
            this.BEditarProd.Location = new System.Drawing.Point(603, 36);
            this.BEditarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(151, 36);
            this.BEditarProd.TabIndex = 39;
            this.BEditarProd.Text = "Editar ";
            this.BEditarProd.UseVisualStyleBackColor = false;
            this.BEditarProd.Click += new System.EventHandler(this.BEditarProd_Click);
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
            this.DGVListaProd.Location = new System.Drawing.Point(9, 128);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(737, 146);
            this.DGVListaProd.TabIndex = 38;
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
            // BAgregarProd
            // 
            this.BAgregarProd.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarProd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarProd.ForeColor = System.Drawing.Color.Black;
            this.BAgregarProd.Location = new System.Drawing.Point(444, 36);
            this.BAgregarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAgregarProd.Name = "BAgregarProd";
            this.BAgregarProd.Size = new System.Drawing.Size(153, 36);
            this.BAgregarProd.TabIndex = 37;
            this.BAgregarProd.Text = "Agregar Producto";
            this.BAgregarProd.UseVisualStyleBackColor = false;
            this.BAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // LTipoUsuario
            // 
            this.LTipoUsuario.AutoSize = true;
            this.LTipoUsuario.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.LTipoUsuario.Location = new System.Drawing.Point(292, 10);
            this.LTipoUsuario.Name = "LTipoUsuario";
            this.LTipoUsuario.Size = new System.Drawing.Size(106, 23);
            this.LTipoUsuario.TabIndex = 36;
            this.LTipoUsuario.Text = "CANTIDAD";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCantidad.Location = new System.Drawing.Point(285, 39);
            this.TBCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCantidad.MaxLength = 11;
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(139, 30);
            this.TBCantidad.TabIndex = 29;
            this.TBCantidad.TextChanged += new System.EventHandler(this.TBCantidad_TextChanged);
            // 
            // BContinuar
            // 
            this.BContinuar.BackColor = System.Drawing.Color.DarkGray;
            this.BContinuar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BContinuar.ForeColor = System.Drawing.Color.Black;
            this.BContinuar.Location = new System.Drawing.Point(472, 299);
            this.BContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BContinuar.Name = "BContinuar";
            this.BContinuar.Size = new System.Drawing.Size(245, 68);
            this.BContinuar.TabIndex = 25;
            this.BContinuar.Text = "CONTINUAR";
            this.BContinuar.UseVisualStyleBackColor = false;
            this.BContinuar.Click += new System.EventHandler(this.BContinuar_Click);
            // 
            // TBTotalVenta
            // 
            this.TBTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalVenta.Location = new System.Drawing.Point(244, 314);
            this.TBTotalVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBTotalVenta.MaxLength = 200;
            this.TBTotalVenta.Name = "TBTotalVenta";
            this.TBTotalVenta.Size = new System.Drawing.Size(165, 30);
            this.TBTotalVenta.TabIndex = 22;
            this.TBTotalVenta.TextChanged += new System.EventHandler(this.TBTotalVenta_TextChanged);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LTotal.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.Black;
            this.LTotal.Location = new System.Drawing.Point(65, 319);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(142, 23);
            this.LTotal.TabIndex = 18;
            this.LTotal.Text = "TOTAL VENTA";
            // 
            // TBNombreVendedor
            // 
            this.TBNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreVendedor.Location = new System.Drawing.Point(11, 39);
            this.TBNombreVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombreVendedor.MaxLength = 100;
            this.TBNombreVendedor.Name = "TBNombreVendedor";
            this.TBNombreVendedor.Size = new System.Drawing.Size(245, 30);
            this.TBNombreVendedor.TabIndex = 14;
            this.TBNombreVendedor.TextChanged += new System.EventHandler(this.TBNombreVendedor_TextChanged);
            // 
            // LNombreProd
            // 
            this.LNombreProd.AutoSize = true;
            this.LNombreProd.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProd.ForeColor = System.Drawing.Color.Black;
            this.LNombreProd.Location = new System.Drawing.Point(16, 10);
            this.LNombreProd.Name = "LNombreProd";
            this.LNombreProd.Size = new System.Drawing.Size(106, 23);
            this.LNombreProd.TabIndex = 11;
            this.LNombreProd.Text = "PRODUCTO";
            // 
            // TBuscador
            // 
            this.TBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBuscador.AutoSize = false;
            this.TBuscador.Dock = System.Windows.Forms.DockStyle.None;
            this.TBuscador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarProd,
            this.toolStripSeparator1,
            this.LBuscarPor,
            this.TBBuscadorProd});
            this.TBuscador.Location = new System.Drawing.Point(0, 50);
            this.TBuscador.Name = "TBuscador";
            this.TBuscador.Size = new System.Drawing.Size(572, 39);
            this.TBuscador.TabIndex = 5;
            this.TBuscador.Text = "toolStrip1";
            // 
            // BBuscarProd
            // 
            this.BBuscarProd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTSCodigo,
            this.BTSNombreProd});
            this.BBuscarProd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarProd.Name = "BBuscarProd";
            this.BBuscarProd.Size = new System.Drawing.Size(163, 36);
            this.BBuscarProd.Text = "BUSCAR PRODUCTO";
            this.BBuscarProd.ButtonClick += new System.EventHandler(this.BBuscarProd_ButtonClick);
            // 
            // BTSCodigo
            // 
            this.BTSCodigo.Name = "BTSCodigo";
            this.BTSCodigo.Size = new System.Drawing.Size(185, 26);
            this.BTSCodigo.Text = "POR CÓDIGO";
            this.BTSCodigo.Click += new System.EventHandler(this.BTSCodigo_Click);
            // 
            // BTSNombreProd
            // 
            this.BTSNombreProd.Name = "BTSNombreProd";
            this.BTSNombreProd.Size = new System.Drawing.Size(185, 26);
            this.BTSNombreProd.Text = "POR NOMBRE";
            this.BTSNombreProd.Click += new System.EventHandler(this.BTSNombreProd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(0, 36);
            // 
            // TBBuscadorProd
            // 
            this.TBBuscadorProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscadorProd.Name = "TBBuscadorProd";
            this.TBBuscadorProd.Size = new System.Drawing.Size(276, 39);
            this.TBBuscadorProd.Click += new System.EventHandler(this.TBBuscadorProd_Click);
            // 
            // LAgregarventas
            // 
            this.LAgregarventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarventas.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarventas.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarventas.Location = new System.Drawing.Point(9, 9);
            this.LAgregarventas.Name = "LAgregarventas";
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.LAgregarventas.Size = new System.Drawing.Size(765, 44);
            this.LAgregarventas.TabIndex = 4;
            this.LAgregarventas.Text = "AGREGAR VENTA";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarCliente,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TBBuscarCliente});
            this.toolStrip1.Location = new System.Drawing.Point(9, 72);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 48);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dNIToolStripMenuItem,
            this.pORNOMBREToolStripMenuItem});
            this.BBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarCliente.Image")));
            this.BBuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(158, 45);
            this.BBuscarCliente.Text = "BUSCAR PRODUCTO";
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // dNIToolStripMenuItem
            // 
            this.dNIToolStripMenuItem.Name = "dNIToolStripMenuItem";
            this.dNIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dNIToolStripMenuItem.Text = "POR CODIGO";
            // 
            // pORNOMBREToolStripMenuItem
            // 
            this.pORNOMBREToolStripMenuItem.Name = "pORNOMBREToolStripMenuItem";
            this.pORNOMBREToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pORNOMBREToolStripMenuItem.Text = "POR NOMBRE";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 45);
            // 
            // TBBuscarCliente
            // 
            this.TBBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarCliente.Name = "TBBuscarCliente";
            this.TBBuscarCliente.Size = new System.Drawing.Size(367, 48);
            this.TBBuscarCliente.Click += new System.EventHandler(this.TBBuscarCliente_Click);
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
            this.BTSBusquedaCliente.Location = new System.Drawing.Point(542, 72);
            this.BTSBusquedaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BTSBusquedaCliente.Name = "BTSBusquedaCliente";
            this.BTSBusquedaCliente.Size = new System.Drawing.Size(167, 43);
            this.BTSBusquedaCliente.TabIndex = 8;
            this.BTSBusquedaCliente.Text = "Buscar";
            this.BTSBusquedaCliente.UseVisualStyleBackColor = false;
            this.BTSBusquedaCliente.Click += new System.EventHandler(this.BTSBusquedaCliente_Click);
            // 
            // ventaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(783, 553);
            this.Controls.Add(this.BTSBusquedaCliente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LAgregarventas);
            this.Controls.Add(this.PAgregarVendedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ventaAgregar";
            this.Text = "ventaAgregar";
            this.Load += new System.EventHandler(this.ventaAgregar_Load);
            this.PAgregarVendedor.ResumeLayout(false);
            this.PAgregarVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LAgregarVenta;
        private System.Windows.Forms.Panel PAgregarVendedor;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.Button BContinuar;
        private System.Windows.Forms.TextBox TBTotalVenta;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBNombreVendedor;
        private System.Windows.Forms.Label LNombreProd;
 //       private FontAwesome.Sharp.IconButton BTSBuscarProd;
        private System.Windows.Forms.ToolStrip TBuscador;
        private System.Windows.Forms.ToolStripSplitButton BBuscarProd;
        private System.Windows.Forms.ToolStripMenuItem BTSCodigo;
        private System.Windows.Forms.ToolStripMenuItem BTSNombreProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.ToolStripTextBox TBBuscadorProd;
        private System.Windows.Forms.Label LTipoUsuario;
        private System.Windows.Forms.Button BAgregarProd;
        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.Button BEditarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_producto;
        private System.Windows.Forms.Label LItems;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton BBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem dNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORNOMBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarCliente;
        private FontAwesome.Sharp.IconButton BTSBusquedaCliente;
    }
}