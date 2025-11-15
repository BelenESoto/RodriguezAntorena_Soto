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
            this.label1 = new System.Windows.Forms.Label();
            this.TBStockProd = new System.Windows.Forms.TextBox();
            this.DGVListaProdVentas = new System.Windows.Forms.DataGridView();
            this.BTSBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarCliente = new System.Windows.Forms.ToolStripDropDownButton();
            this.BTSCodigoV = new System.Windows.Forms.ToolStripMenuItem();
            this.BTSPorNombreV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.LItems = new System.Windows.Forms.Label();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.BEditarProd = new System.Windows.Forms.Button();
            this.BAgregarProd = new System.Windows.Forms.Button();
            this.LTipoUsuario = new System.Windows.Forms.Label();
            this.TBCantidadProd = new System.Windows.Forms.TextBox();
            this.BContinuar = new System.Windows.Forms.Button();
            this.TBTotalVenta = new System.Windows.Forms.TextBox();
            this.LTotal = new System.Windows.Forms.Label();
            this.TBNombreProd = new System.Windows.Forms.TextBox();
            this.LNombreProd = new System.Windows.Forms.Label();
            this.TBuscador = new System.Windows.Forms.ToolStrip();
            this.BBuscarProd = new System.Windows.Forms.ToolStripSplitButton();
            this.BTSCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.BTSNombreProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscadorProd = new System.Windows.Forms.ToolStripTextBox();
            this.PConfirmar = new System.Windows.Forms.Panel();
            this.PAgregarVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProdVentas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.TBuscador.SuspendLayout();
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
            this.PAgregarVendedor.BackColor = System.Drawing.Color.White;
            this.PAgregarVendedor.Controls.Add(this.PConfirmar);
            this.PAgregarVendedor.Controls.Add(this.label1);
            this.PAgregarVendedor.Controls.Add(this.TBStockProd);
            this.PAgregarVendedor.Controls.Add(this.DGVListaProdVentas);
            this.PAgregarVendedor.Controls.Add(this.BTSBusquedaCliente);
            this.PAgregarVendedor.Controls.Add(this.toolStrip1);
            this.PAgregarVendedor.Controls.Add(this.LItems);
            this.PAgregarVendedor.Controls.Add(this.LAgregarventas);
            this.PAgregarVendedor.Controls.Add(this.BEditarProd);
            this.PAgregarVendedor.Controls.Add(this.BAgregarProd);
            this.PAgregarVendedor.Controls.Add(this.LTipoUsuario);
            this.PAgregarVendedor.Controls.Add(this.TBCantidadProd);
            this.PAgregarVendedor.Controls.Add(this.BContinuar);
            this.PAgregarVendedor.Controls.Add(this.TBTotalVenta);
            this.PAgregarVendedor.Controls.Add(this.LTotal);
            this.PAgregarVendedor.Controls.Add(this.TBNombreProd);
            this.PAgregarVendedor.Controls.Add(this.LNombreProd);
            this.PAgregarVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAgregarVendedor.Location = new System.Drawing.Point(0, 0);
            this.PAgregarVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.PAgregarVendedor.Name = "PAgregarVendedor";
            this.PAgregarVendedor.Size = new System.Drawing.Size(579, 570);
            this.PAgregarVendedor.TabIndex = 3;
            this.PAgregarVendedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarVendedor_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(174, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 43;
            this.label1.Text = "  Stock Disponible";
            // 
            // TBStockProd
            // 
            this.TBStockProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStockProd.Location = new System.Drawing.Point(171, 211);
            this.TBStockProd.Margin = new System.Windows.Forms.Padding(2);
            this.TBStockProd.MaxLength = 11;
            this.TBStockProd.Name = "TBStockProd";
            this.TBStockProd.Size = new System.Drawing.Size(106, 26);
            this.TBStockProd.TabIndex = 42;
            this.TBStockProd.Click += new System.EventHandler(this.BTSBusquedaCliente_Click);
            // 
            // DGVListaProdVentas
            // 
            this.DGVListaProdVentas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVListaProdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProdVentas.Location = new System.Drawing.Point(0, 285);
            this.DGVListaProdVentas.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaProdVentas.Name = "DGVListaProdVentas";
            this.DGVListaProdVentas.RowHeadersWidth = 51;
            this.DGVListaProdVentas.RowTemplate.Height = 24;
            this.DGVListaProdVentas.Size = new System.Drawing.Size(577, 178);
            this.DGVListaProdVentas.TabIndex = 41;
            this.DGVListaProdVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProdVentas_CellContentClick);
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
            this.BTSBusquedaCliente.Location = new System.Drawing.Point(442, 103);
            this.BTSBusquedaCliente.Name = "BTSBusquedaCliente";
            this.BTSBusquedaCliente.Size = new System.Drawing.Size(125, 35);
            this.BTSBusquedaCliente.TabIndex = 8;
            this.BTSBusquedaCliente.Text = "Buscar";
            this.BTSBusquedaCliente.UseVisualStyleBackColor = false;
            this.BTSBusquedaCliente.Click += new System.EventHandler(this.BTSBusquedaCliente_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarCliente,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TBBuscarCliente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 79);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 81);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTSCodigoV,
            this.BTSPorNombreV});
            this.BBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarCliente.Image")));
            this.BBuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(135, 78);
            this.BBuscarCliente.Text = "BUSCAR PRODUCTO";
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // BTSCodigoV
            // 
            this.BTSCodigoV.Name = "BTSCodigoV";
            this.BTSCodigoV.Size = new System.Drawing.Size(152, 22);
            this.BTSCodigoV.Text = "POR CODIGO";
            this.BTSCodigoV.Click += new System.EventHandler(this.BTSCodigoV_Click);
            // 
            // BTSPorNombreV
            // 
            this.BTSPorNombreV.Name = "BTSPorNombreV";
            this.BTSPorNombreV.Size = new System.Drawing.Size(152, 22);
            this.BTSPorNombreV.Text = "POR NOMBRE";
            this.BTSPorNombreV.Click += new System.EventHandler(this.BTSPorNombreV_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 78);
            // 
            // TBBuscarCliente
            // 
            this.TBBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarCliente.Name = "TBBuscarCliente";
            this.TBBuscarCliente.Size = new System.Drawing.Size(276, 81);
            this.TBBuscarCliente.Click += new System.EventHandler(this.TBBuscarCliente_Click);
            // 
            // LItems
            // 
            this.LItems.BackColor = System.Drawing.Color.Lavender;
            this.LItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LItems.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LItems.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LItems.Location = new System.Drawing.Point(0, 249);
            this.LItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LItems.Name = "LItems";
            this.LItems.Padding = new System.Windows.Forms.Padding(3);
            this.LItems.Size = new System.Drawing.Size(577, 37);
            this.LItems.TabIndex = 40;
            this.LItems.Text = "ITEMS ";
            this.LItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LAgregarventas.Size = new System.Drawing.Size(579, 79);
            this.LAgregarventas.TabIndex = 4;
            this.LAgregarventas.Text = "AGREGAR VENTA";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BEditarProd
            // 
            this.BEditarProd.BackColor = System.Drawing.Color.Lavender;
            this.BEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEditarProd.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold);
            this.BEditarProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BEditarProd.Location = new System.Drawing.Point(477, 212);
            this.BEditarProd.Margin = new System.Windows.Forms.Padding(2);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(90, 29);
            this.BEditarProd.TabIndex = 39;
            this.BEditarProd.Text = "Editar ";
            this.BEditarProd.UseVisualStyleBackColor = false;
            this.BEditarProd.Click += new System.EventHandler(this.BEditarProd_Click);
            // 
            // BAgregarProd
            // 
            this.BAgregarProd.BackColor = System.Drawing.Color.Lavender;
            this.BAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarProd.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold);
            this.BAgregarProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BAgregarProd.Location = new System.Drawing.Point(477, 170);
            this.BAgregarProd.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregarProd.Name = "BAgregarProd";
            this.BAgregarProd.Size = new System.Drawing.Size(90, 29);
            this.BAgregarProd.TabIndex = 37;
            this.BAgregarProd.Text = "Agregar Producto";
            this.BAgregarProd.UseVisualStyleBackColor = false;
            this.BAgregarProd.Click += new System.EventHandler(this.BAgregarProd_Click);
            // 
            // LTipoUsuario
            // 
            this.LTipoUsuario.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold);
            this.LTipoUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LTipoUsuario.Location = new System.Drawing.Point(322, 170);
            this.LTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTipoUsuario.Name = "LTipoUsuario";
            this.LTipoUsuario.Size = new System.Drawing.Size(112, 39);
            this.LTipoUsuario.TabIndex = 36;
            this.LTipoUsuario.Text = "Seleccione  Cantidad";
            // 
            // TBCantidadProd
            // 
            this.TBCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCantidadProd.Location = new System.Drawing.Point(325, 212);
            this.TBCantidadProd.Margin = new System.Windows.Forms.Padding(2);
            this.TBCantidadProd.MaxLength = 11;
            this.TBCantidadProd.Name = "TBCantidadProd";
            this.TBCantidadProd.Size = new System.Drawing.Size(106, 26);
            this.TBCantidadProd.TabIndex = 29;
            this.TBCantidadProd.TextChanged += new System.EventHandler(this.TBCantidadProd_TextChanged);
            // 
            // BContinuar
            // 
            this.BContinuar.BackColor = System.Drawing.Color.Lavender;
            this.BContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BContinuar.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BContinuar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BContinuar.Location = new System.Drawing.Point(355, 483);
            this.BContinuar.Margin = new System.Windows.Forms.Padding(2);
            this.BContinuar.Name = "BContinuar";
            this.BContinuar.Size = new System.Drawing.Size(184, 55);
            this.BContinuar.TabIndex = 25;
            this.BContinuar.Text = "CONTINUAR";
            this.BContinuar.UseVisualStyleBackColor = false;
            this.BContinuar.Click += new System.EventHandler(this.BContinuar_Click);
            // 
            // TBTotalVenta
            // 
            this.TBTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalVenta.Location = new System.Drawing.Point(177, 497);
            this.TBTotalVenta.Margin = new System.Windows.Forms.Padding(2);
            this.TBTotalVenta.MaxLength = 200;
            this.TBTotalVenta.Name = "TBTotalVenta";
            this.TBTotalVenta.Size = new System.Drawing.Size(125, 26);
            this.TBTotalVenta.TabIndex = 22;
            this.TBTotalVenta.TextChanged += new System.EventHandler(this.TBTotalVenta_TextChanged);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LTotal.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LTotal.Location = new System.Drawing.Point(43, 501);
            this.LTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(130, 19);
            this.LTotal.TabIndex = 18;
            this.LTotal.Text = "TOTAL VENTA";
            // 
            // TBNombreProd
            // 
            this.TBNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreProd.Location = new System.Drawing.Point(11, 211);
            this.TBNombreProd.Margin = new System.Windows.Forms.Padding(2);
            this.TBNombreProd.MaxLength = 100;
            this.TBNombreProd.Name = "TBNombreProd";
            this.TBNombreProd.Size = new System.Drawing.Size(119, 26);
            this.TBNombreProd.TabIndex = 14;
            this.TBNombreProd.TextChanged += new System.EventHandler(this.TBNombreProd_TextChanged);
            // 
            // LNombreProd
            // 
            this.LNombreProd.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold);
            this.LNombreProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LNombreProd.Location = new System.Drawing.Point(29, 170);
            this.LNombreProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombreProd.Name = "LNombreProd";
            this.LNombreProd.Size = new System.Drawing.Size(110, 45);
            this.LNombreProd.TabIndex = 11;
            this.LNombreProd.Text = " Código  Producto";
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
            this.BBuscarProd.Size = new System.Drawing.Size(131, 36);
            this.BBuscarProd.Text = "BUSCAR PRODUCTO";
            this.BBuscarProd.ButtonClick += new System.EventHandler(this.BBuscarProd_ButtonClick);
            // 
            // BTSCodigo
            // 
            this.BTSCodigo.Name = "BTSCodigo";
            this.BTSCodigo.Size = new System.Drawing.Size(149, 22);
            this.BTSCodigo.Text = "POR CÓDIGO";
            this.BTSCodigo.Click += new System.EventHandler(this.BTSCodigo_Click);
            // 
            // BTSNombreProd
            // 
            this.BTSNombreProd.Name = "BTSNombreProd";
            this.BTSNombreProd.Size = new System.Drawing.Size(149, 22);
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
            // PConfirmar
            // 
            this.PConfirmar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PConfirmar.BackgroundImage = global::Antorena_Soto.Properties.Resources.cart_icon_147474;
            this.PConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PConfirmar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PConfirmar.Location = new System.Drawing.Point(0, 0);
            this.PConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.PConfirmar.Name = "PConfirmar";
            this.PConfirmar.Size = new System.Drawing.Size(579, 609);
            this.PConfirmar.TabIndex = 44;
            this.PConfirmar.UseWaitCursor = true;
            this.PConfirmar.Visible = false;
            // 
            // ventaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(579, 570);
            this.Controls.Add(this.PAgregarVendedor);
            this.Name = "ventaAgregar";
            this.Text = "ventaAgregar";
            this.Load += new System.EventHandler(this.ventaAgregar_Load);
            this.PAgregarVendedor.ResumeLayout(false);
            this.PAgregarVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProdVentas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LAgregarVenta;
        private System.Windows.Forms.Panel PAgregarVendedor;
        private System.Windows.Forms.TextBox TBCantidadProd;
        private System.Windows.Forms.Button BContinuar;
        private System.Windows.Forms.TextBox TBTotalVenta;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TBNombreProd;
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
        private System.Windows.Forms.Button BEditarProd;
        private System.Windows.Forms.Label LItems;
        private FontAwesome.Sharp.IconButton BTSBusquedaCliente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton BBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem BTSCodigoV;
        private System.Windows.Forms.ToolStripMenuItem BTSPorNombreV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarCliente;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.DataGridView DGVListaProdVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBStockProd;
        private System.Windows.Forms.Panel PConfirmar;
    }
}