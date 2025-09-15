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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuVendedor));
            this.BarraBusqueda = new System.Windows.Forms.ToolStrip();
            this.BBuscar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.TBotonFoto = new System.Windows.Forms.ToolStripButton();
            this.LMenuVentas = new System.Windows.Forms.Label();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.DGVListaVentas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.BVerInfoCliente = new System.Windows.Forms.Button();
            this.LCliente = new System.Windows.Forms.Label();
            this.BAgregarDatoCliente = new System.Windows.Forms.Button();
            this.BListarVenta = new System.Windows.Forms.Button();
            this.LVentas = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.BListarProducto = new System.Windows.Forms.Button();
            this.BVerProducto = new System.Windows.Forms.Button();
            this.BAgregarVenta = new System.Windows.Forms.Button();
            this.BarraBusqueda.SuspendLayout();
            this.PGerente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVentas)).BeginInit();
            this.PGerente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraBusqueda
            // 
            this.BarraBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarraBusqueda.AutoSize = false;
            this.BarraBusqueda.Dock = System.Windows.Forms.DockStyle.None;
            this.BarraBusqueda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscar,
            this.toolStripSeparator1,
            this.TBusqueda,
            this.TBotonFoto});
            this.BarraBusqueda.Location = new System.Drawing.Point(216, 3);
            this.BarraBusqueda.Name = "BarraBusqueda";
            this.BarraBusqueda.Size = new System.Drawing.Size(558, 45);
            this.BarraBusqueda.TabIndex = 6;
            this.BarraBusqueda.Text = "toolStrip1";
            this.BarraBusqueda.UseWaitCursor = true;
            // 
            // BBuscar
            // 
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(42, 42);
            this.BBuscar.Text = "Buscar";
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // TBusqueda
            // 
            this.TBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBusqueda.Name = "TBusqueda";
            this.TBusqueda.Size = new System.Drawing.Size(367, 45);
            this.TBusqueda.Click += new System.EventHandler(this.TBusqueda_Click);
            // 
            // TBotonFoto
            // 
            this.TBotonFoto.AutoSize = false;
            this.TBotonFoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBotonFoto.Image = ((System.Drawing.Image)(resources.GetObject("TBotonFoto.Image")));
            this.TBotonFoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TBotonFoto.Name = "TBotonFoto";
            this.TBotonFoto.Size = new System.Drawing.Size(29, 24);
            this.TBotonFoto.Text = "toolStripButton1";
            // 
            // LMenuVentas
            // 
            this.LMenuVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LMenuVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuVentas.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMenuVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LMenuVentas.Location = new System.Drawing.Point(8, 3);
            this.LMenuVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMenuVentas.Name = "LMenuVentas";
            this.LMenuVentas.Size = new System.Drawing.Size(204, 45);
            this.LMenuVentas.TabIndex = 3;
            this.LMenuVentas.Text = "MENU VENTAS";
            this.LMenuVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LMenuVentas.UseWaitCursor = true;
            this.LMenuVentas.Click += new System.EventHandler(this.LMenuVentas_Click);
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.Controls.Add(this.DGVListaVentas);
            this.PGerente2.Location = new System.Drawing.Point(216, 50);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(558, 347);
            this.PGerente2.TabIndex = 5;
            this.PGerente2.UseWaitCursor = true;
            // 
            // DGVListaVentas
            // 
            this.DGVListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Dni,
            this.FechaIng});
            this.DGVListaVentas.Location = new System.Drawing.Point(20, 23);
            this.DGVListaVentas.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaVentas.Name = "DGVListaVentas";
            this.DGVListaVentas.RowHeadersWidth = 51;
            this.DGVListaVentas.RowTemplate.Height = 24;
            this.DGVListaVentas.Size = new System.Drawing.Size(530, 331);
            this.DGVListaVentas.TabIndex = 0;
            this.DGVListaVentas.UseWaitCursor = true;
            this.DGVListaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaVentas_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.Width = 125;
            // 
            // FechaIng
            // 
            this.FechaIng.HeaderText = "Fecha Ingreso";
            this.FechaIng.MinimumWidth = 6;
            this.FechaIng.Name = "FechaIng";
            this.FechaIng.Width = 125;
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente1.Controls.Add(this.BVerInfoCliente);
            this.PGerente1.Controls.Add(this.LCliente);
            this.PGerente1.Controls.Add(this.BAgregarDatoCliente);
            this.PGerente1.Controls.Add(this.BListarVenta);
            this.PGerente1.Controls.Add(this.LVentas);
            this.PGerente1.Controls.Add(this.LProductos);
            this.PGerente1.Controls.Add(this.BListarProducto);
            this.PGerente1.Controls.Add(this.BVerProducto);
            this.PGerente1.Controls.Add(this.BAgregarVenta);
            this.PGerente1.Location = new System.Drawing.Point(8, 50);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(204, 347);
            this.PGerente1.TabIndex = 4;
            this.PGerente1.UseWaitCursor = true;
            // 
            // BVerInfoCliente
            // 
            this.BVerInfoCliente.Location = new System.Drawing.Point(20, 179);
            this.BVerInfoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BVerInfoCliente.Name = "BVerInfoCliente";
            this.BVerInfoCliente.Size = new System.Drawing.Size(164, 27);
            this.BVerInfoCliente.TabIndex = 12;
            this.BVerInfoCliente.Text = "Ver Informacion";
            this.BVerInfoCliente.UseVisualStyleBackColor = true;
            this.BVerInfoCliente.UseWaitCursor = true;
            this.BVerInfoCliente.Click += new System.EventHandler(this.BVerInfoCliente_Click);
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.BackColor = System.Drawing.Color.LightGray;
            this.LCliente.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.Location = new System.Drawing.Point(74, 124);
            this.LCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(55, 17);
            this.LCliente.TabIndex = 11;
            this.LCliente.Text = "Cliente";
            this.LCliente.UseWaitCursor = true;
            // 
            // BAgregarDatoCliente
            // 
            this.BAgregarDatoCliente.Location = new System.Drawing.Point(20, 149);
            this.BAgregarDatoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregarDatoCliente.Name = "BAgregarDatoCliente";
            this.BAgregarDatoCliente.Size = new System.Drawing.Size(164, 27);
            this.BAgregarDatoCliente.TabIndex = 9;
            this.BAgregarDatoCliente.Text = "Agregar Datos ";
            this.BAgregarDatoCliente.UseVisualStyleBackColor = true;
            this.BAgregarDatoCliente.UseWaitCursor = true;
            this.BAgregarDatoCliente.Click += new System.EventHandler(this.BAgregarDatoCliente_Click);
            // 
            // BListarVenta
            // 
            this.BListarVenta.Location = new System.Drawing.Point(20, 74);
            this.BListarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BListarVenta.Name = "BListarVenta";
            this.BListarVenta.Size = new System.Drawing.Size(164, 25);
            this.BListarVenta.TabIndex = 7;
            this.BListarVenta.Text = "Listado Ventas";
            this.BListarVenta.UseVisualStyleBackColor = true;
            this.BListarVenta.UseWaitCursor = true;
            this.BListarVenta.Click += new System.EventHandler(this.BListarVenta_Click);
            // 
            // LVentas
            // 
            this.LVentas.AutoSize = true;
            this.LVentas.BackColor = System.Drawing.Color.LightGray;
            this.LVentas.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentas.Location = new System.Drawing.Point(74, 19);
            this.LVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(56, 17);
            this.LVentas.TabIndex = 6;
            this.LVentas.Text = "Ventas";
            this.LVentas.UseWaitCursor = true;
            this.LVentas.Click += new System.EventHandler(this.LVentas_Click);
            // 
            // LProductos
            // 
            this.LProductos.AutoSize = true;
            this.LProductos.BackColor = System.Drawing.Color.LightGray;
            this.LProductos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductos.Location = new System.Drawing.Point(61, 230);
            this.LProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(79, 17);
            this.LProductos.TabIndex = 5;
            this.LProductos.Text = "Productos";
            this.LProductos.UseWaitCursor = true;
            // 
            // BListarProducto
            // 
            this.BListarProducto.Location = new System.Drawing.Point(20, 287);
            this.BListarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BListarProducto.Name = "BListarProducto";
            this.BListarProducto.Size = new System.Drawing.Size(164, 27);
            this.BListarProducto.TabIndex = 4;
            this.BListarProducto.Text = "Listar Productos";
            this.BListarProducto.UseVisualStyleBackColor = true;
            this.BListarProducto.UseWaitCursor = true;
            this.BListarProducto.Click += new System.EventHandler(this.BListarProducto_Click);
            // 
            // BVerProducto
            // 
            this.BVerProducto.Location = new System.Drawing.Point(20, 256);
            this.BVerProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BVerProducto.Name = "BVerProducto";
            this.BVerProducto.Size = new System.Drawing.Size(164, 27);
            this.BVerProducto.TabIndex = 3;
            this.BVerProducto.Text = "Ver Producto";
            this.BVerProducto.UseVisualStyleBackColor = true;
            this.BVerProducto.UseWaitCursor = true;
            this.BVerProducto.Click += new System.EventHandler(this.BVerProducto_Click);
            // 
            // BAgregarVenta
            // 
            this.BAgregarVenta.Location = new System.Drawing.Point(20, 43);
            this.BAgregarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregarVenta.Name = "BAgregarVenta";
            this.BAgregarVenta.Size = new System.Drawing.Size(164, 25);
            this.BAgregarVenta.TabIndex = 1;
            this.BAgregarVenta.Text = "Agregar Venta";
            this.BAgregarVenta.UseVisualStyleBackColor = true;
            this.BAgregarVenta.UseWaitCursor = true;
            this.BAgregarVenta.Click += new System.EventHandler(this.BAgregarVenta_Click);
            // 
            // menuVendedor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 401);
            this.Controls.Add(this.BarraBusqueda);
            this.Controls.Add(this.LMenuVentas);
            this.Controls.Add(this.PGerente2);
            this.Controls.Add(this.PGerente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "menuVendedor";
            this.Text = "menuVendedor";
            this.UseWaitCursor = true;
            this.BarraBusqueda.ResumeLayout(false);
            this.BarraBusqueda.PerformLayout();
            this.PGerente2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVentas)).EndInit();
            this.PGerente1.ResumeLayout(false);
            this.PGerente1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip BarraBusqueda;
        private ToolStripLabel BBuscar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox TBusqueda;
        private ToolStripButton TBotonFoto;
        private Label LMenuVentas;
        private Panel PGerente2;
        private DataGridView DGVListaVentas;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn FechaIng;
        private Panel PGerente1;
        private Button BListarVenta;
        private Label LVentas;
        private Label LProductos;
        private Button BListarProducto;
        private Button BVerProducto;
        private Button BAgregarVenta;
        private Button BVerInfoCliente;
        private Label LCliente;
        private Button BAgregarDatoCliente;
    }
}