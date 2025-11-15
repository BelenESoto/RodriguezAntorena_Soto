namespace Antorena_Soto.CPresentacion.Administrador
{
    partial class reporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteVentas));
            this.pReporteVenta = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lReporteVentas = new System.Windows.Forms.Label();
            this.BTSBusquedaProd = new FontAwesome.Sharp.IconButton();
            this.toolStripRepVenta = new System.Windows.Forms.ToolStrip();
            this.tsdFiltroBusqueda = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolCodigoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNombreProd = new System.Windows.Forms.ToolStripMenuItem();
            this.pORFECHAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORVENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarProducto = new System.Windows.Forms.ToolStripTextBox();
            this.bImprimir = new System.Windows.Forms.Button();
            this.DGVentas = new System.Windows.Forms.DataGridView();
            this.DGVentas1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medio_pago_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle_prod_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pReporteVenta.SuspendLayout();
            this.toolStripRepVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas1)).BeginInit();
            this.SuspendLayout();
            // 
            // pReporteVenta
            // 
            this.pReporteVenta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pReporteVenta.Controls.Add(this.DGVentas1);
            this.pReporteVenta.Controls.Add(this.dtpFecha);
            this.pReporteVenta.Controls.Add(this.lReporteVentas);
            this.pReporteVenta.Controls.Add(this.BTSBusquedaProd);
            this.pReporteVenta.Controls.Add(this.toolStripRepVenta);
            this.pReporteVenta.Controls.Add(this.bImprimir);
            this.pReporteVenta.Controls.Add(this.DGVentas);
            this.pReporteVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReporteVenta.Location = new System.Drawing.Point(0, 0);
            this.pReporteVenta.Margin = new System.Windows.Forms.Padding(2);
            this.pReporteVenta.Name = "pReporteVenta";
            this.pReporteVenta.Size = new System.Drawing.Size(566, 583);
            this.pReporteVenta.TabIndex = 0;
            this.pReporteVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.pReporteVenta_Paint);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(136, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 44;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lReporteVentas
            // 
            this.lReporteVentas.BackColor = System.Drawing.Color.MidnightBlue;
            this.lReporteVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lReporteVentas.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReporteVentas.ForeColor = System.Drawing.Color.AliceBlue;
            this.lReporteVentas.Location = new System.Drawing.Point(0, 0);
            this.lReporteVentas.Margin = new System.Windows.Forms.Padding(0);
            this.lReporteVentas.Name = "lReporteVentas";
            this.lReporteVentas.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.lReporteVentas.Size = new System.Drawing.Size(566, 61);
            this.lReporteVentas.TabIndex = 43;
            this.lReporteVentas.Text = "Reporte de Ventas ";
            this.lReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lReporteVentas.Click += new System.EventHandler(this.lReporteVentas_Click);
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
            this.BTSBusquedaProd.Location = new System.Drawing.Point(418, 84);
            this.BTSBusquedaProd.Name = "BTSBusquedaProd";
            this.BTSBusquedaProd.Size = new System.Drawing.Size(125, 35);
            this.BTSBusquedaProd.TabIndex = 10;
            this.BTSBusquedaProd.Text = "Buscar";
            this.BTSBusquedaProd.UseVisualStyleBackColor = false;
            this.BTSBusquedaProd.Click += new System.EventHandler(this.BTSBusquedaProd_Click);
            // 
            // toolStripRepVenta
            // 
            this.toolStripRepVenta.AutoSize = false;
            this.toolStripRepVenta.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripRepVenta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripRepVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdFiltroBusqueda,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TBBuscarProducto});
            this.toolStripRepVenta.Location = new System.Drawing.Point(0, 80);
            this.toolStripRepVenta.Name = "toolStripRepVenta";
            this.toolStripRepVenta.Size = new System.Drawing.Size(566, 39);
            this.toolStripRepVenta.TabIndex = 8;
            this.toolStripRepVenta.Text = "toolStrip1";
            this.toolStripRepVenta.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripRepVenta_ItemClicked);
            // 
            // tsdFiltroBusqueda
            // 
            this.tsdFiltroBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdFiltroBusqueda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCodigoVenta,
            this.toolNombreProd,
            this.pORFECHAToolStripMenuItem,
            this.pORVENDEDORToolStripMenuItem});
            this.tsdFiltroBusqueda.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
            this.tsdFiltroBusqueda.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsdFiltroBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tsdFiltroBusqueda.Image")));
            this.tsdFiltroBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdFiltroBusqueda.Name = "tsdFiltroBusqueda";
            this.tsdFiltroBusqueda.Size = new System.Drawing.Size(119, 36);
            this.tsdFiltroBusqueda.Text = "BUSCAR POR:";
            this.tsdFiltroBusqueda.Click += new System.EventHandler(this.tsdFiltroBusqueda_Click);
            // 
            // toolCodigoVenta
            // 
            this.toolCodigoVenta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolCodigoVenta.Name = "toolCodigoVenta";
            this.toolCodigoVenta.Size = new System.Drawing.Size(209, 22);
            this.toolCodigoVenta.Text = "Codigo de Venta";
            this.toolCodigoVenta.Click += new System.EventHandler(this.toolProducto_Click);
            // 
            // toolNombreProd
            // 
            this.toolNombreProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolNombreProd.Name = "toolNombreProd";
            this.toolNombreProd.Size = new System.Drawing.Size(209, 22);
            this.toolNombreProd.Text = "DNI Cliente";
            this.toolNombreProd.Click += new System.EventHandler(this.toolCliente_Click);
            // 
            // pORFECHAToolStripMenuItem
            // 
            this.pORFECHAToolStripMenuItem.Name = "pORFECHAToolStripMenuItem";
            this.pORFECHAToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pORFECHAToolStripMenuItem.Text = "DNI Vendedor";
            this.pORFECHAToolStripMenuItem.Click += new System.EventHandler(this.toolVendedor_Click);
            // 
            // pORVENDEDORToolStripMenuItem
            // 
            this.pORVENDEDORToolStripMenuItem.Name = "pORVENDEDORToolStripMenuItem";
            this.pORVENDEDORToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pORVENDEDORToolStripMenuItem.Text = "Fecha venta";
            this.pORVENDEDORToolStripMenuItem.Click += new System.EventHandler(this.toolFecha_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 36);
            // 
            // TBBuscarProducto
            // 
            this.TBBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarProducto.Name = "TBBuscarProducto";
            this.TBBuscarProducto.Size = new System.Drawing.Size(276, 39);
            this.TBBuscarProducto.Click += new System.EventHandler(this.TBBuscarProducto_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.Location = new System.Drawing.Point(225, 474);
            this.bImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(96, 30);
            this.bImprimir.TabIndex = 5;
            this.bImprimir.Text = "IMPRIMIR";
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // DGVentas
            // 
            this.DGVentas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentas.Location = new System.Drawing.Point(28, 137);
            this.DGVentas.Margin = new System.Windows.Forms.Padding(2);
            this.DGVentas.Name = "DGVentas";
            this.DGVentas.RowHeadersWidth = 51;
            this.DGVentas.RowTemplate.Height = 24;
            this.DGVentas.Size = new System.Drawing.Size(508, 318);
            this.DGVentas.TabIndex = 4;
            this.DGVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas_CellContentClick);
            this.DGVentas.Click += new System.EventHandler(this.reporteVentas_Load_1);
            // 
            // DGVentas1
            // 
            this.DGVentas1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentas1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Vendedor_resp,
            this.Cliente,
            this.Ciudad,
            this.Medio_pago_venta,
            this.Detalle_prod_ventas,
            this.total_venta});
            this.DGVentas1.Location = new System.Drawing.Point(-11, 137);
            this.DGVentas1.Margin = new System.Windows.Forms.Padding(2);
            this.DGVentas1.Name = "DGVentas1";
            this.DGVentas1.RowHeadersWidth = 51;
            this.DGVentas1.RowTemplate.Height = 24;
            this.DGVentas1.Size = new System.Drawing.Size(577, 318);
            this.DGVentas1.TabIndex = 45;
            this.DGVentas1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo_venta";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha_venta";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Vendedor_resp
            // 
            this.Vendedor_resp.DataPropertyName = "vendedor_resp";
            this.Vendedor_resp.HeaderText = "Vendedor Responsable";
            this.Vendedor_resp.MinimumWidth = 6;
            this.Vendedor_resp.Name = "Vendedor_resp";
            this.Vendedor_resp.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "cliente_venta";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "ciudad_venta";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Medio_pago_venta
            // 
            this.Medio_pago_venta.DataPropertyName = "medio_pago_venta";
            this.Medio_pago_venta.HeaderText = "Medio de Pago";
            this.Medio_pago_venta.MinimumWidth = 6;
            this.Medio_pago_venta.Name = "Medio_pago_venta";
            this.Medio_pago_venta.Width = 125;
            // 
            // Detalle_prod_ventas
            // 
            this.Detalle_prod_ventas.DataPropertyName = "detalle_prod_venta";
            this.Detalle_prod_ventas.HeaderText = "Detalle Productos";
            this.Detalle_prod_ventas.MinimumWidth = 6;
            this.Detalle_prod_ventas.Name = "Detalle_prod_ventas";
            this.Detalle_prod_ventas.Width = 125;
            // 
            // total_venta
            // 
            this.total_venta.DataPropertyName = "total_venta";
            this.total_venta.HeaderText = "TOTAL";
            this.total_venta.MinimumWidth = 6;
            this.total_venta.Name = "total_venta";
            this.total_venta.Width = 125;
            // 
            // reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 583);
            this.Controls.Add(this.pReporteVenta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "reporteVentas";
            this.Text = "reporteVentas";
            this.Load += new System.EventHandler(this.reporteVentas_Load_1);
            this.pReporteVenta.ResumeLayout(false);
            this.toolStripRepVenta.ResumeLayout(false);
            this.toolStripRepVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pReporteVenta;
        private System.Windows.Forms.DataGridView DGVentas;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.ToolStrip toolStripRepVenta;
        private System.Windows.Forms.ToolStripDropDownButton tsdFiltroBusqueda;
        private System.Windows.Forms.ToolStripMenuItem toolCodigoVenta;
        private System.Windows.Forms.ToolStripMenuItem toolNombreProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarProducto;
        private FontAwesome.Sharp.IconButton BTSBusquedaProd;
        private System.Windows.Forms.ToolStripMenuItem pORFECHAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORVENDEDORToolStripMenuItem;
        public System.Windows.Forms.Label lReporteVentas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView DGVentas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medio_pago_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle_prod_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_venta;
    }
}