using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class menuVendedor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MAgregarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListadoComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelIngresoDatos = new System.Windows.Forms.FlowLayoutPanel();
            this.LDatosVenta = new System.Windows.Forms.Label();
            this.LIngresoProd = new System.Windows.Forms.Label();
            this.TProducto = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TCantidad = new System.Windows.Forms.TextBox();
            this.BAgregarProd = new System.Windows.Forms.Button();
            this.PanelDerecho = new System.Windows.Forms.FlowLayoutPanel();
            this.LDetalleVenta = new System.Windows.Forms.Label();
            this.DGDetalle_Venta = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.BFinCompra = new System.Windows.Forms.Button();
            this.PanelBuscar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.PanelIngresoDatos.SuspendLayout();
            this.PanelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle_Venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.productosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(63, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAgregarVenta,
            this.verListadoVentasToolStripMenuItem,
            this.verInformacionToolStripMenuItem1});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("SimSun-ExtG", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(195, 40);
            this.productosToolStripMenuItem.Text = "       Vendedor       ";
            // 
            // MAgregarVenta
            // 
            this.MAgregarVenta.Name = "MAgregarVenta";
            this.MAgregarVenta.Size = new System.Drawing.Size(266, 22);
            this.MAgregarVenta.Text = "Agregar venta";
            // 
            // verListadoVentasToolStripMenuItem
            // 
            this.verListadoVentasToolStripMenuItem.Name = "verListadoVentasToolStripMenuItem";
            this.verListadoVentasToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.verListadoVentasToolStripMenuItem.Text = "Ver listado ventas";
            // 
            // verInformacionToolStripMenuItem1
            // 
            this.verInformacionToolStripMenuItem1.Name = "verInformacionToolStripMenuItem1";
            this.verInformacionToolStripMenuItem1.Size = new System.Drawing.Size(266, 22);
            this.verInformacionToolStripMenuItem1.Text = "Ver informacion Vendedor";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.verListadoComprasToolStripMenuItem,
            this.verInformacionToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("SimSun-ExtG", 12F);
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(75, 40);
            this.usuarioToolStripMenuItem.Text = "Cliente";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar cliente";
            // 
            // verListadoComprasToolStripMenuItem
            // 
            this.verListadoComprasToolStripMenuItem.Name = "verListadoComprasToolStripMenuItem";
            this.verListadoComprasToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.verListadoComprasToolStripMenuItem.Text = "Ver listado compras";
            // 
            // verInformacionToolStripMenuItem
            // 
            this.verInformacionToolStripMenuItem.Name = "verInformacionToolStripMenuItem";
            this.verInformacionToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.verInformacionToolStripMenuItem.Text = "Ver informacion cliente";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductoToolStripMenuItem,
            this.listadoProductosToolStripMenuItem});
            this.productosToolStripMenuItem1.Font = new System.Drawing.Font("SimSun-ExtG", 12F);
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(195, 40);
            this.productosToolStripMenuItem1.Text = "       Productos      ";
            // 
            // verProductoToolStripMenuItem
            // 
            this.verProductoToolStripMenuItem.Name = "verProductoToolStripMenuItem";
            this.verProductoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.verProductoToolStripMenuItem.Text = "Ver producto";
            // 
            // listadoProductosToolStripMenuItem
            // 
            this.listadoProductosToolStripMenuItem.Name = "listadoProductosToolStripMenuItem";
            this.listadoProductosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.listadoProductosToolStripMenuItem.Text = "Listado productos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("SimSun-ExtG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // PanelIngresoDatos
            // 
            this.PanelIngresoDatos.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelIngresoDatos.Controls.Add(this.LDatosVenta);
            this.PanelIngresoDatos.Controls.Add(this.LIngresoProd);
            this.PanelIngresoDatos.Controls.Add(this.TProducto);
            this.PanelIngresoDatos.Controls.Add(this.LCantidad);
            this.PanelIngresoDatos.Controls.Add(this.TCantidad);
            this.PanelIngresoDatos.Controls.Add(this.BAgregarProd);
            this.PanelIngresoDatos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelIngresoDatos.Location = new System.Drawing.Point(10, 86);
            this.PanelIngresoDatos.Name = "PanelIngresoDatos";
            this.PanelIngresoDatos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PanelIngresoDatos.Size = new System.Drawing.Size(169, 173);
            this.PanelIngresoDatos.TabIndex = 2;
            this.PanelIngresoDatos.UseWaitCursor = true;
            this.PanelIngresoDatos.WrapContents = false;
            // 
            // LDatosVenta
            // 
            this.LDatosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LDatosVenta.AutoSize = true;
            this.LDatosVenta.Font = new System.Drawing.Font("SimSun-ExtG", 11F, System.Drawing.FontStyle.Bold);
            this.LDatosVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LDatosVenta.Location = new System.Drawing.Point(12, 0);
            this.LDatosVenta.Name = "LDatosVenta";
            this.LDatosVenta.Padding = new System.Windows.Forms.Padding(3);
            this.LDatosVenta.Size = new System.Drawing.Size(149, 36);
            this.LDatosVenta.TabIndex = 11;
            this.LDatosVenta.Text = "DATOS DE LA VENTA";
            this.LDatosVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LDatosVenta.UseWaitCursor = true;
            // 
            // LIngresoProd
            // 
            this.LIngresoProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LIngresoProd.Location = new System.Drawing.Point(12, 36);
            this.LIngresoProd.Name = "LIngresoProd";
            this.LIngresoProd.Padding = new System.Windows.Forms.Padding(3);
            this.LIngresoProd.Size = new System.Drawing.Size(149, 20);
            this.LIngresoProd.TabIndex = 1;
            this.LIngresoProd.Text = "Ingrese Producto";
            this.LIngresoProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LIngresoProd.UseWaitCursor = true;
            // 
            // TProducto
            // 
            this.TProducto.BackColor = System.Drawing.Color.MistyRose;
            this.TProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TProducto.Location = new System.Drawing.Point(12, 59);
            this.TProducto.Name = "TProducto";
            this.TProducto.Size = new System.Drawing.Size(149, 20);
            this.TProducto.TabIndex = 0;
            this.TProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TProducto.UseWaitCursor = true;
            // 
            // LCantidad
            // 
            this.LCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LCantidad.Location = new System.Drawing.Point(12, 82);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Padding = new System.Windows.Forms.Padding(3);
            this.LCantidad.Size = new System.Drawing.Size(149, 20);
            this.LCantidad.TabIndex = 3;
            this.LCantidad.Text = "Cantidad";
            this.LCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LCantidad.UseWaitCursor = true;
            // 
            // TCantidad
            // 
            this.TCantidad.BackColor = System.Drawing.Color.MistyRose;
            this.TCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCantidad.Location = new System.Drawing.Point(12, 105);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(149, 20);
            this.TCantidad.TabIndex = 2;
            this.TCantidad.UseWaitCursor = true;
            // 
            // BAgregarProd
            // 
            this.BAgregarProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAgregarProd.AutoSize = true;
            this.BAgregarProd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BAgregarProd.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PanelIngresoDatos.SetFlowBreak(this.BAgregarProd, true);
            this.BAgregarProd.ForeColor = System.Drawing.Color.Tomato;
            this.BAgregarProd.Location = new System.Drawing.Point(12, 131);
            this.BAgregarProd.Name = "BAgregarProd";
            this.BAgregarProd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BAgregarProd.Size = new System.Drawing.Size(149, 23);
            this.BAgregarProd.TabIndex = 10;
            this.BAgregarProd.TabStop = false;
            this.BAgregarProd.Text = "Agregar";
            this.BAgregarProd.UseMnemonic = false;
            this.BAgregarProd.UseVisualStyleBackColor = false;
            this.BAgregarProd.UseWaitCursor = true;
            // 
            // PanelDerecho
            // 
            this.PanelDerecho.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelDerecho.Controls.Add(this.LDetalleVenta);
            this.PanelDerecho.Controls.Add(this.DGDetalle_Venta);
            this.PanelDerecho.Controls.Add(this.label4);
            this.PanelDerecho.Controls.Add(this.LTotal);
            this.PanelDerecho.Controls.Add(this.BFinCompra);
            this.PanelDerecho.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelDerecho.Location = new System.Drawing.Point(184, 86);
            this.PanelDerecho.Name = "PanelDerecho";
            this.PanelDerecho.Padding = new System.Windows.Forms.Padding(9);
            this.PanelDerecho.Size = new System.Drawing.Size(489, 294);
            this.PanelDerecho.TabIndex = 3;
            this.PanelDerecho.UseWaitCursor = true;
            // 
            // LDetalleVenta
            // 
            this.LDetalleVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDetalleVenta.BackColor = System.Drawing.Color.Coral;
            this.LDetalleVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalleVenta.ForeColor = System.Drawing.Color.Black;
            this.LDetalleVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LDetalleVenta.Location = new System.Drawing.Point(12, 9);
            this.LDetalleVenta.Name = "LDetalleVenta";
            this.LDetalleVenta.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.LDetalleVenta.Size = new System.Drawing.Size(465, 40);
            this.LDetalleVenta.TabIndex = 12;
            this.LDetalleVenta.Text = "DETALLE VENTA";
            this.LDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LDetalleVenta.UseWaitCursor = true;
            // 
            // DGDetalle_Venta
            // 
            this.DGDetalle_Venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGDetalle_Venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalle_Venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDetalle_Venta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGDetalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDetalle_Venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CCantidad,
            this.CSubtotal});
            this.DGDetalle_Venta.Location = new System.Drawing.Point(12, 52);
            this.DGDetalle_Venta.Name = "DGDetalle_Venta";
            this.DGDetalle_Venta.Size = new System.Drawing.Size(465, 70);
            this.DGDetalle_Venta.TabIndex = 18;
            this.DGDetalle_Venta.UseWaitCursor = true;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "CÓDIGO";
            this.CCodigo.Name = "CCodigo";
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "NOMBRE";
            this.CNombre.Name = "CNombre";
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "CANTIDAD";
            this.CCantidad.Name = "CCantidad";
            // 
            // CSubtotal
            // 
            this.CSubtotal.HeaderText = "SUBTOTAL";
            this.CSubtotal.Name = "CSubtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            this.label4.UseWaitCursor = true;
            // 
            // LTotal
            // 
            this.LTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(218, 138);
            this.LTotal.Name = "LTotal";
            this.LTotal.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.LTotal.Size = new System.Drawing.Size(52, 35);
            this.LTotal.TabIndex = 17;
            this.LTotal.Text = "TOTAL:";
            this.LTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTotal.UseWaitCursor = true;
            // 
            // BFinCompra
            // 
            this.BFinCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BFinCompra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BFinCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BFinCompra.ForeColor = System.Drawing.Color.Tomato;
            this.BFinCompra.Location = new System.Drawing.Point(181, 176);
            this.BFinCompra.Name = "BFinCompra";
            this.BFinCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BFinCompra.Size = new System.Drawing.Size(127, 31);
            this.BFinCompra.TabIndex = 16;
            this.BFinCompra.TabStop = false;
            this.BFinCompra.Text = "FINALIZAR COMPRA";
            this.BFinCompra.UseMnemonic = false;
            this.BFinCompra.UseVisualStyleBackColor = false;
            this.BFinCompra.UseWaitCursor = true;
            // 
            // PanelBuscar
            // 
            this.PanelBuscar.BackColor = System.Drawing.Color.PeachPuff;
            this.PanelBuscar.Location = new System.Drawing.Point(10, 57);
            this.PanelBuscar.Name = "PanelBuscar";
            this.PanelBuscar.Size = new System.Drawing.Size(663, 25);
            this.PanelBuscar.TabIndex = 5;
            this.PanelBuscar.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.pictureBox1.InitialImage = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // menuVendedor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelBuscar);
            this.Controls.Add(this.PanelDerecho);
            this.Controls.Add(this.PanelIngresoDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuVendedor";
            this.Text = "menuVendedor";
            this.UseWaitCursor = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelIngresoDatos.ResumeLayout(false);
            this.PanelIngresoDatos.PerformLayout();
            this.PanelDerecho.ResumeLayout(false);
            this.PanelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalle_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem verListadoComprasToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private ToolStripMenuItem MAgregarVenta;
        private ToolStripMenuItem verInformacionToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem verListadoVentasToolStripMenuItem;
        private ToolStripMenuItem verInformacionToolStripMenuItem1;
        private ToolStripMenuItem verProductoToolStripMenuItem;
        private ToolStripMenuItem listadoProductosToolStripMenuItem;
        private Button button1;
        private FlowLayoutPanel PanelIngresoDatos;
        private FlowLayoutPanel PanelDerecho;
        private PictureBox pictureBox1;
        private FlowLayoutPanel PanelBuscar;
        private Label LIngresoProd;
        private TextBox TProducto;
        private Label LCantidad;
        private TextBox TCantidad;
        public Button BAgregarProd;
        private Label LDatosVenta;
        private Label LDetalleVenta;
        private Label label4;
        private Label LTotal;
        public Button BFinCompra;
        private DataGridView DGDetalle_Venta;
        private DataGridViewTextBoxColumn CCodigo;
        private DataGridViewTextBoxColumn CNombre;
        private DataGridViewTextBoxColumn CCantidad;
        private DataGridViewTextBoxColumn CSubtotal;
    }
}