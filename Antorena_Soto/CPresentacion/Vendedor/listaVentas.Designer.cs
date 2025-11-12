namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class listaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaVentas));
            this.LItems = new System.Windows.Forms.Label();
            this.DGVListaProdVentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medio_pago_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle_prod_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.BBuscarVenta = new FontAwesome.Sharp.IconButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.BCodigoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.BApellidoClienteVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.BFechaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBBuscarPorVenta = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProdVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LItems
            // 
            this.LItems.BackColor = System.Drawing.Color.White;
            this.LItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LItems.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LItems.ForeColor = System.Drawing.Color.Black;
            this.LItems.Location = new System.Drawing.Point(0, 192);
            this.LItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LItems.Name = "LItems";
            this.LItems.Padding = new System.Windows.Forms.Padding(3);
            this.LItems.Size = new System.Drawing.Size(577, 31);
            this.LItems.TabIndex = 44;
            this.LItems.Text = "ITEMS ";
            this.LItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVListaProdVentas
            // 
            this.DGVListaProdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProdVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Vendedor_resp,
            this.Cliente,
            this.Ciudad,
            this.Medio_pago_venta,
            this.Detalle_prod_ventas,
            this.total_venta});
            this.DGVListaProdVentas.Location = new System.Drawing.Point(0, 225);
            this.DGVListaProdVentas.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaProdVentas.Name = "DGVListaProdVentas";
            this.DGVListaProdVentas.RowHeadersWidth = 51;
            this.DGVListaProdVentas.RowTemplate.Height = 24;
            this.DGVListaProdVentas.Size = new System.Drawing.Size(577, 196);
            this.DGVListaProdVentas.TabIndex = 43;
            this.DGVListaProdVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProdVentas_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.LAgregarventas);
            this.panel1.Controls.Add(this.BBuscarVenta);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.LItems);
            this.panel1.Controls.Add(this.DGVListaProdVentas);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 609);
            this.panel1.TabIndex = 45;
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
            this.LAgregarventas.Size = new System.Drawing.Size(595, 98);
            this.LAgregarventas.TabIndex = 47;
            this.LAgregarventas.Text = " INFORMACIÓN VENTAS";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BBuscarVenta
            // 
            this.BBuscarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarVenta.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BBuscarVenta.IconColor = System.Drawing.Color.Black;
            this.BBuscarVenta.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BBuscarVenta.IconSize = 30;
            this.BBuscarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscarVenta.Location = new System.Drawing.Point(470, 114);
            this.BBuscarVenta.Name = "BBuscarVenta";
            this.BBuscarVenta.Size = new System.Drawing.Size(97, 38);
            this.BBuscarVenta.TabIndex = 46;
            this.BBuscarVenta.Text = "BUSCAR";
            this.BBuscarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscarVenta.UseVisualStyleBackColor = false;
            this.BBuscarVenta.Click += new System.EventHandler(this.BBuscarVenta_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPor,
            this.toolStripSeparator1,
            this.TBBuscarPorVenta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 98);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 71);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BCodigoVenta,
            this.BApellidoClienteVenta,
            this.BFechaVenta});
            this.BBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(97, 68);
            this.BBuscarPor.Text = "BUSCAR POR";
            this.BBuscarPor.ToolTipText = "BUSCAR POR";
            // 
            // BCodigoVenta
            // 
            this.BCodigoVenta.Name = "BCodigoVenta";
            this.BCodigoVenta.Size = new System.Drawing.Size(193, 22);
            this.BCodigoVenta.Text = "CODIGO";
            this.BCodigoVenta.Click += new System.EventHandler(this.BCodigoVenta_Click);
            // 
            // BApellidoClienteVenta
            // 
            this.BApellidoClienteVenta.Name = "BApellidoClienteVenta";
            this.BApellidoClienteVenta.Size = new System.Drawing.Size(193, 22);
            this.BApellidoClienteVenta.Text = "NOMBRE Y APELLIDO";
            this.BApellidoClienteVenta.Click += new System.EventHandler(this.BApellidoClienteVenta_Click);
            // 
            // BFechaVenta
            // 
            this.BFechaVenta.Name = "BFechaVenta";
            this.BFechaVenta.Size = new System.Drawing.Size(193, 22);
            this.BFechaVenta.Text = "FECHA";
            this.BFechaVenta.Click += new System.EventHandler(this.BFechaVenta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // TBBuscarPorVenta
            // 
            this.TBBuscarPorVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarPorVenta.Name = "TBBuscarPorVenta";
            this.TBBuscarPorVenta.Size = new System.Drawing.Size(367, 71);
            // 
            // listaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 570);
            this.Controls.Add(this.panel1);
            this.Name = "listaVentas";
            this.Text = "listaVentas";
            this.Load += new System.EventHandler(this.listaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProdVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LItems;
        private System.Windows.Forms.DataGridView DGVListaProdVentas;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label LAgregarventas;
        private FontAwesome.Sharp.IconButton BBuscarVenta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem BCodigoVenta;
        private System.Windows.Forms.ToolStripMenuItem BApellidoClienteVenta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarPorVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medio_pago_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle_prod_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_venta;
        private System.Windows.Forms.ToolStripMenuItem BFechaVenta;
    }
}