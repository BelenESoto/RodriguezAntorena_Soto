namespace Antorena_Soto.CPresentacion.Gerente
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
            this.BTSBusquedaProd = new FontAwesome.Sharp.IconButton();
            this.toolStripRepVenta = new System.Windows.Forms.ToolStrip();
            this.tsdFiltroBusqueda = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolCodigoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNombreProd = new System.Windows.Forms.ToolStripMenuItem();
            this.pORFECHAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORVENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarProducto = new System.Windows.Forms.ToolStripTextBox();
            this.bExportar = new System.Windows.Forms.Button();
            this.DGVentas = new System.Windows.Forms.DataGridView();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.pReporteVenta.SuspendLayout();
            this.toolStripRepVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pReporteVenta
            // 
            this.pReporteVenta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pReporteVenta.Controls.Add(this.BTSBusquedaProd);
            this.pReporteVenta.Controls.Add(this.toolStripRepVenta);
            this.pReporteVenta.Controls.Add(this.bExportar);
            this.pReporteVenta.Controls.Add(this.DGVentas);
            this.pReporteVenta.Controls.Add(this.BLimpiar);
            this.pReporteVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReporteVenta.Location = new System.Drawing.Point(0, 0);
            this.pReporteVenta.Name = "pReporteVenta";
            this.pReporteVenta.Size = new System.Drawing.Size(755, 718);
            this.pReporteVenta.TabIndex = 0;
            this.pReporteVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.pReporteVenta_Paint);
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
            this.BTSBusquedaProd.Location = new System.Drawing.Point(547, 5);
            this.BTSBusquedaProd.Margin = new System.Windows.Forms.Padding(4);
            this.BTSBusquedaProd.Name = "BTSBusquedaProd";
            this.BTSBusquedaProd.Size = new System.Drawing.Size(167, 43);
            this.BTSBusquedaProd.TabIndex = 10;
            this.BTSBusquedaProd.Text = "Buscar";
            this.BTSBusquedaProd.UseVisualStyleBackColor = false;
            this.BTSBusquedaProd.Click += new System.EventHandler(this.BTSBusquedaProd_Click);
            // 
            // toolStripRepVenta
            // 
            this.toolStripRepVenta.AutoSize = false;
            this.toolStripRepVenta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripRepVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdFiltroBusqueda,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TBBuscarProducto});
            this.toolStripRepVenta.Location = new System.Drawing.Point(0, 0);
            this.toolStripRepVenta.Name = "toolStripRepVenta";
            this.toolStripRepVenta.Size = new System.Drawing.Size(755, 48);
            this.toolStripRepVenta.TabIndex = 8;
            this.toolStripRepVenta.Text = "toolStrip1";
            this.toolStripRepVenta.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsdFiltroBusqueda
            // 
            this.tsdFiltroBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdFiltroBusqueda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCodigoProd,
            this.toolNombreProd,
            this.pORFECHAToolStripMenuItem,
            this.pORVENDEDORToolStripMenuItem});
            this.tsdFiltroBusqueda.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
            this.tsdFiltroBusqueda.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsdFiltroBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("tsdFiltroBusqueda.Image")));
            this.tsdFiltroBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdFiltroBusqueda.Name = "tsdFiltroBusqueda";
            this.tsdFiltroBusqueda.Size = new System.Drawing.Size(188, 45);
            this.tsdFiltroBusqueda.Text = "BUSCAR PRODUCTO";
            this.tsdFiltroBusqueda.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // toolCodigoProd
            // 
            this.toolCodigoProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolCodigoProd.Name = "toolCodigoProd";
            this.toolCodigoProd.Size = new System.Drawing.Size(224, 26);
            this.toolCodigoProd.Text = "POR CODIGO";
            // 
            // toolNombreProd
            // 
            this.toolNombreProd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolNombreProd.Name = "toolNombreProd";
            this.toolNombreProd.Size = new System.Drawing.Size(224, 26);
            this.toolNombreProd.Text = "POR NOMBRE";
            // 
            // pORFECHAToolStripMenuItem
            // 
            this.pORFECHAToolStripMenuItem.Name = "pORFECHAToolStripMenuItem";
            this.pORFECHAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pORFECHAToolStripMenuItem.Text = "POR FECHA";
            // 
            // pORVENDEDORToolStripMenuItem
            // 
            this.pORVENDEDORToolStripMenuItem.Name = "pORVENDEDORToolStripMenuItem";
            this.pORVENDEDORToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pORVENDEDORToolStripMenuItem.Text = "POR VENDEDOR";
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
            // TBBuscarProducto
            // 
            this.TBBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarProducto.Name = "TBBuscarProducto";
            this.TBBuscarProducto.Size = new System.Drawing.Size(367, 48);
            // 
            // bExportar
            // 
            this.bExportar.Location = new System.Drawing.Point(428, 575);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(128, 37);
            this.bExportar.TabIndex = 5;
            this.bExportar.Text = "button1";
            this.bExportar.UseVisualStyleBackColor = true;
            // 
            // DGVentas
            // 
            this.DGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentas.Location = new System.Drawing.Point(37, 127);
            this.DGVentas.Name = "DGVentas";
            this.DGVentas.RowHeadersWidth = 51;
            this.DGVentas.RowTemplate.Height = 24;
            this.DGVentas.Size = new System.Drawing.Size(677, 433);
            this.DGVentas.TabIndex = 4;
            this.DGVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas_CellContentClick);
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(201, 575);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(128, 37);
            this.BLimpiar.TabIndex = 3;
            this.BLimpiar.Text = "BLimpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click_1);
            // 
            // reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 718);
            this.Controls.Add(this.pReporteVenta);
            this.Name = "reporteVentas";
            this.Text = "reporteVentas";
            this.Load += new System.EventHandler(this.reporteVentas_Load_1);
            this.pReporteVenta.ResumeLayout(false);
            this.toolStripRepVenta.ResumeLayout(false);
            this.toolStripRepVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pReporteVenta;
        private System.Windows.Forms.DataGridView DGVentas;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button bExportar;
        private System.Windows.Forms.ToolStrip toolStripRepVenta;
        private System.Windows.Forms.ToolStripDropDownButton tsdFiltroBusqueda;
        private System.Windows.Forms.ToolStripMenuItem toolCodigoProd;
        private System.Windows.Forms.ToolStripMenuItem toolNombreProd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarProducto;
        private FontAwesome.Sharp.IconButton BTSBusquedaProd;
        private System.Windows.Forms.ToolStripMenuItem pORFECHAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORVENDEDORToolStripMenuItem;
    }
}