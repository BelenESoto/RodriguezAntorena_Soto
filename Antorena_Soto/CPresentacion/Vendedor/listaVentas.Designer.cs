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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BBuscarVenta = new System.Windows.Forms.ToolStripSplitButton();
            this.TSPorCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSPorFecha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TBBuscarVenta = new System.Windows.Forms.ToolStripTextBox();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.LItems = new System.Windows.Forms.Label();
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTSBusquedaVenta = new FontAwesome.Sharp.IconButton();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor_resp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medio_pago_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle_prod_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSPorVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.TSPorCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(6, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 62);
            this.toolStrip1.TabIndex = 42;
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
            this.TSPorFecha,
            this.TSPorVendedor,
            this.TSPorCliente});
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
            // TSPorFecha
            // 
            this.TSPorFecha.Name = "TSPorFecha";
            this.TSPorFecha.Size = new System.Drawing.Size(180, 22);
            this.TSPorFecha.Text = "POR FECHA";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // TBBuscarVenta
            // 
            this.TBBuscarVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarVenta.Name = "TBBuscarVenta";
            this.TBBuscarVenta.Size = new System.Drawing.Size(276, 62);
            this.TBBuscarVenta.Click += new System.EventHandler(this.TBBuscarVenta_Click);
            // 
            // LAgregarventas
            // 
            this.LAgregarventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarventas.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarventas.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarventas.Location = new System.Drawing.Point(6, 16);
            this.LAgregarventas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAgregarventas.Name = "LAgregarventas";
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.LAgregarventas.Size = new System.Drawing.Size(553, 36);
            this.LAgregarventas.TabIndex = 41;
            this.LAgregarventas.Text = "LISTADO VENTAS";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LItems
            // 
            this.LItems.BackColor = System.Drawing.Color.White;
            this.LItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LItems.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LItems.ForeColor = System.Drawing.Color.Black;
            this.LItems.Location = new System.Drawing.Point(6, 146);
            this.LItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LItems.Name = "LItems";
            this.LItems.Padding = new System.Windows.Forms.Padding(3);
            this.LItems.Size = new System.Drawing.Size(553, 31);
            this.LItems.TabIndex = 44;
            this.LItems.Text = "ITEMS ";
            this.LItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Vendedor_resp,
            this.Cliente,
            this.Medio_pago_venta,
            this.Detalle_prod_ventas,
            this.total_venta});
            this.DGVListaProd.Location = new System.Drawing.Point(7, 179);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(553, 196);
            this.DGVListaProd.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTSBusquedaVenta);
            this.panel1.Controls.Add(this.LItems);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.LAgregarventas);
            this.panel1.Controls.Add(this.DGVListaProd);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 454);
            this.panel1.TabIndex = 45;
            // 
            // BTSBusquedaVenta
            // 
            this.BTSBusquedaVenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusquedaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusquedaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusquedaVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTSBusquedaVenta.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusquedaVenta.IconColor = System.Drawing.Color.Black;
            this.BTSBusquedaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusquedaVenta.IconSize = 36;
            this.BTSBusquedaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusquedaVenta.Location = new System.Drawing.Point(415, 64);
            this.BTSBusquedaVenta.Name = "BTSBusquedaVenta";
            this.BTSBusquedaVenta.Size = new System.Drawing.Size(125, 35);
            this.BTSBusquedaVenta.TabIndex = 45;
            this.BTSBusquedaVenta.Text = "BUSCAR";
            this.BTSBusquedaVenta.UseVisualStyleBackColor = false;
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
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
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
            this.Detalle_prod_ventas.DataPropertyName = "detalle_prod_ventas";
            this.Detalle_prod_ventas.HeaderText = "Detalle Productos";
            this.Detalle_prod_ventas.MinimumWidth = 6;
            this.Detalle_prod_ventas.Name = "Detalle_prod_ventas";
            this.Detalle_prod_ventas.Width = 125;
            // 
            // total_venta
            // 
            this.total_venta.DataPropertyName = "total";
            this.total_venta.HeaderText = "TOTAL";
            this.total_venta.MinimumWidth = 6;
            this.total_venta.Name = "total_venta";
            this.total_venta.Width = 125;
            // 
            // TSPorVendedor
            // 
            this.TSPorVendedor.Name = "TSPorVendedor";
            this.TSPorVendedor.Size = new System.Drawing.Size(180, 22);
            this.TSPorVendedor.Text = "POR VENDEDOR";
            // 
            // TSPorCliente
            // 
            this.TSPorCliente.Name = "TSPorCliente";
            this.TSPorCliente.Size = new System.Drawing.Size(180, 22);
            this.TSPorCliente.Text = "POR CLIENTE";
            // 
            // listaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 440);
            this.Controls.Add(this.panel1);
            this.Name = "listaVentas";
            this.Text = "listaVentas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarVenta;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.Label LItems;
        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BTSBusquedaVenta;
        private System.Windows.Forms.ToolStripSplitButton BBuscarVenta;
        private System.Windows.Forms.ToolStripMenuItem TSPorCodigo;
        private System.Windows.Forms.ToolStripMenuItem TSPorFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor_resp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medio_pago_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle_prod_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_venta;
        private System.Windows.Forms.ToolStripMenuItem TSPorVendedor;
        private System.Windows.Forms.ToolStripMenuItem TSPorCliente;
    }
}