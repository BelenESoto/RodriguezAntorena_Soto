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
            this.LMenuVentas = new System.Windows.Forms.Label();
            this.PVendedor1 = new System.Windows.Forms.Panel();
            this.BVerInfoCliente = new System.Windows.Forms.Button();
            this.LCliente = new System.Windows.Forms.Label();
            this.BAgregarDatoCliente = new System.Windows.Forms.Button();
            this.BListarVenta = new System.Windows.Forms.Button();
            this.LVentas = new System.Windows.Forms.Label();
            this.LProductos = new System.Windows.Forms.Label();
            this.BListarProducto = new System.Windows.Forms.Button();
            this.BVerProducto = new System.Windows.Forms.Button();
            this.BAgregarVenta = new System.Windows.Forms.Button();
            this.PVendedor2 = new System.Windows.Forms.Panel();
            this.PVendedor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LMenuVentas
            // 
            this.LMenuVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LMenuVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuVentas.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMenuVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LMenuVentas.Location = new System.Drawing.Point(11, 4);
            this.LMenuVentas.Name = "LMenuVentas";
            this.LMenuVentas.Size = new System.Drawing.Size(272, 55);
            this.LMenuVentas.TabIndex = 3;
            this.LMenuVentas.Text = "MENU VENTAS";
            this.LMenuVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LMenuVentas.UseWaitCursor = true;
            this.LMenuVentas.Click += new System.EventHandler(this.LMenuVentas_Click);
            // 
            // PVendedor1
            // 
            this.PVendedor1.BackColor = System.Drawing.Color.Gainsboro;
            this.PVendedor1.Controls.Add(this.BVerInfoCliente);
            this.PVendedor1.Controls.Add(this.LCliente);
            this.PVendedor1.Controls.Add(this.BAgregarDatoCliente);
            this.PVendedor1.Controls.Add(this.BListarVenta);
            this.PVendedor1.Controls.Add(this.LVentas);
            this.PVendedor1.Controls.Add(this.LProductos);
            this.PVendedor1.Controls.Add(this.BListarProducto);
            this.PVendedor1.Controls.Add(this.BVerProducto);
            this.PVendedor1.Controls.Add(this.BAgregarVenta);
            this.PVendedor1.Location = new System.Drawing.Point(11, 62);
            this.PVendedor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PVendedor1.Name = "PVendedor1";
            this.PVendedor1.Size = new System.Drawing.Size(272, 427);
            this.PVendedor1.TabIndex = 4;
            this.PVendedor1.UseWaitCursor = true;
            // 
            // BVerInfoCliente
            // 
            this.BVerInfoCliente.Location = new System.Drawing.Point(27, 220);
            this.BVerInfoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVerInfoCliente.Name = "BVerInfoCliente";
            this.BVerInfoCliente.Size = new System.Drawing.Size(219, 33);
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
            this.LCliente.Location = new System.Drawing.Point(99, 153);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(69, 20);
            this.LCliente.TabIndex = 11;
            this.LCliente.Text = "Cliente";
            this.LCliente.UseWaitCursor = true;
            // 
            // BAgregarDatoCliente
            // 
            this.BAgregarDatoCliente.Location = new System.Drawing.Point(27, 183);
            this.BAgregarDatoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAgregarDatoCliente.Name = "BAgregarDatoCliente";
            this.BAgregarDatoCliente.Size = new System.Drawing.Size(219, 33);
            this.BAgregarDatoCliente.TabIndex = 9;
            this.BAgregarDatoCliente.Text = "Agregar Datos ";
            this.BAgregarDatoCliente.UseVisualStyleBackColor = true;
            this.BAgregarDatoCliente.UseWaitCursor = true;
            this.BAgregarDatoCliente.Click += new System.EventHandler(this.BAgregarDatoCliente_Click);
            // 
            // BListarVenta
            // 
            this.BListarVenta.Location = new System.Drawing.Point(27, 91);
            this.BListarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BListarVenta.Name = "BListarVenta";
            this.BListarVenta.Size = new System.Drawing.Size(219, 31);
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
            this.LVentas.Location = new System.Drawing.Point(99, 23);
            this.LVentas.Name = "LVentas";
            this.LVentas.Size = new System.Drawing.Size(67, 20);
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
            this.LProductos.Location = new System.Drawing.Point(81, 283);
            this.LProductos.Name = "LProductos";
            this.LProductos.Size = new System.Drawing.Size(93, 20);
            this.LProductos.TabIndex = 5;
            this.LProductos.Text = "Productos";
            this.LProductos.UseWaitCursor = true;
            // 
            // BListarProducto
            // 
            this.BListarProducto.Location = new System.Drawing.Point(27, 353);
            this.BListarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BListarProducto.Name = "BListarProducto";
            this.BListarProducto.Size = new System.Drawing.Size(219, 33);
            this.BListarProducto.TabIndex = 4;
            this.BListarProducto.Text = "Listar Productos";
            this.BListarProducto.UseVisualStyleBackColor = true;
            this.BListarProducto.UseWaitCursor = true;
            this.BListarProducto.Click += new System.EventHandler(this.BListarProducto_Click);
            // 
            // BVerProducto
            // 
            this.BVerProducto.Location = new System.Drawing.Point(27, 315);
            this.BVerProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVerProducto.Name = "BVerProducto";
            this.BVerProducto.Size = new System.Drawing.Size(219, 33);
            this.BVerProducto.TabIndex = 3;
            this.BVerProducto.Text = "Ver Producto";
            this.BVerProducto.UseVisualStyleBackColor = true;
            this.BVerProducto.UseWaitCursor = true;
            this.BVerProducto.Click += new System.EventHandler(this.BVerProducto_Click);
            // 
            // BAgregarVenta
            // 
            this.BAgregarVenta.Location = new System.Drawing.Point(27, 53);
            this.BAgregarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAgregarVenta.Name = "BAgregarVenta";
            this.BAgregarVenta.Size = new System.Drawing.Size(219, 31);
            this.BAgregarVenta.TabIndex = 1;
            this.BAgregarVenta.Text = "Agregar Venta";
            this.BAgregarVenta.UseVisualStyleBackColor = true;
            this.BAgregarVenta.UseWaitCursor = true;
            this.BAgregarVenta.Click += new System.EventHandler(this.BAgregarVenta_Click);
            // 
            // PVendedor2
            // 
            this.PVendedor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PVendedor2.BackColor = System.Drawing.Color.Gainsboro;
            this.PVendedor2.BackgroundImage = global::Antorena_Soto.Properties.Resources.cart_icon_147474;
            this.PVendedor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PVendedor2.Location = new System.Drawing.Point(288, 4);
            this.PVendedor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PVendedor2.Name = "PVendedor2";
            this.PVendedor2.Size = new System.Drawing.Size(744, 485);
            this.PVendedor2.TabIndex = 5;
            this.PVendedor2.UseWaitCursor = true;
            this.PVendedor2.Paint += new System.Windows.Forms.PaintEventHandler(this.PGerente2_Paint);
            // 
            // menuVendedor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 494);
            this.Controls.Add(this.LMenuVentas);
            this.Controls.Add(this.PVendedor2);
            this.Controls.Add(this.PVendedor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuVendedor";
            this.Text = "menuVendedor";
            this.UseWaitCursor = true;
            this.PVendedor1.ResumeLayout(false);
            this.PVendedor1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label LMenuVentas;
        private Panel PVendedor2;
        private Panel PVendedor1;
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