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
            this.BEditarCliente = new System.Windows.Forms.Button();
            this.BVerInfoCliente = new System.Windows.Forms.Button();
            this.BAgregarDatoCliente = new System.Windows.Forms.Button();
            this.BListarVenta = new System.Windows.Forms.Button();
            this.BVerProducto = new System.Windows.Forms.Button();
            this.BAgregarVenta = new System.Windows.Forms.Button();
            this.LVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PVendedor2 = new System.Windows.Forms.Panel();
            this.PVendedor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LMenuVentas
            // 
            this.LMenuVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuVentas.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold);
            this.LMenuVentas.Image = global::Antorena_Soto.Properties.Resources.config2;
            this.LMenuVentas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LMenuVentas.Location = new System.Drawing.Point(28, 25);
            this.LMenuVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMenuVentas.Name = "LMenuVentas";
            this.LMenuVentas.Size = new System.Drawing.Size(165, 89);
            this.LMenuVentas.TabIndex = 3;
            this.LMenuVentas.Text = "MENU VENTAS";
            this.LMenuVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LMenuVentas.UseWaitCursor = true;
            this.LMenuVentas.Click += new System.EventHandler(this.LMenuVentas_Click);
            // 
            // PVendedor1
            // 
            this.PVendedor1.BackColor = System.Drawing.Color.MidnightBlue;
            this.PVendedor1.Controls.Add(this.BEditarCliente);
            this.PVendedor1.Controls.Add(this.BVerInfoCliente);
            this.PVendedor1.Controls.Add(this.BAgregarDatoCliente);
            this.PVendedor1.Controls.Add(this.BListarVenta);
            this.PVendedor1.Controls.Add(this.BVerProducto);
            this.PVendedor1.Controls.Add(this.BAgregarVenta);
            this.PVendedor1.Controls.Add(this.LMenuVentas);
            this.PVendedor1.Controls.Add(this.LVentas);
            this.PVendedor1.Controls.Add(this.label1);
            this.PVendedor1.Controls.Add(this.label2);
            this.PVendedor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PVendedor1.Location = new System.Drawing.Point(0, 0);
            this.PVendedor1.Margin = new System.Windows.Forms.Padding(2);
            this.PVendedor1.Name = "PVendedor1";
            this.PVendedor1.Size = new System.Drawing.Size(220, 609);
            this.PVendedor1.TabIndex = 4;
            this.PVendedor1.UseWaitCursor = true;
            // 
            // BEditarCliente
            // 
            this.BEditarCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BEditarCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BEditarCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.BEditarCliente.Location = new System.Drawing.Point(29, 436);
            this.BEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BEditarCliente.Name = "BEditarCliente";
            this.BEditarCliente.Size = new System.Drawing.Size(164, 38);
            this.BEditarCliente.TabIndex = 13;
            this.BEditarCliente.Text = "Editar Datos ";
            this.BEditarCliente.UseVisualStyleBackColor = false;
            this.BEditarCliente.UseWaitCursor = true;
            this.BEditarCliente.Click += new System.EventHandler(this.BEditarCliente_Click);
            // 
            // BVerInfoCliente
            // 
            this.BVerInfoCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BVerInfoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BVerInfoCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.BVerInfoCliente.Location = new System.Drawing.Point(29, 378);
            this.BVerInfoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BVerInfoCliente.Name = "BVerInfoCliente";
            this.BVerInfoCliente.Size = new System.Drawing.Size(164, 48);
            this.BVerInfoCliente.TabIndex = 12;
            this.BVerInfoCliente.Text = "Ver Informacion";
            this.BVerInfoCliente.UseVisualStyleBackColor = false;
            this.BVerInfoCliente.UseWaitCursor = true;
            this.BVerInfoCliente.Click += new System.EventHandler(this.BVerInfoCliente_Click);
            // 
            // BAgregarDatoCliente
            // 
            this.BAgregarDatoCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.BAgregarDatoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BAgregarDatoCliente.ForeColor = System.Drawing.Color.DarkBlue;
            this.BAgregarDatoCliente.Location = new System.Drawing.Point(29, 332);
            this.BAgregarDatoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregarDatoCliente.Name = "BAgregarDatoCliente";
            this.BAgregarDatoCliente.Size = new System.Drawing.Size(164, 38);
            this.BAgregarDatoCliente.TabIndex = 9;
            this.BAgregarDatoCliente.Text = "Agregar Datos ";
            this.BAgregarDatoCliente.UseVisualStyleBackColor = false;
            this.BAgregarDatoCliente.UseWaitCursor = true;
            this.BAgregarDatoCliente.Click += new System.EventHandler(this.BAgregarDatoCliente_Click);
            // 
            // BListarVenta
            // 
            this.BListarVenta.BackColor = System.Drawing.Color.AliceBlue;
            this.BListarVenta.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BListarVenta.ForeColor = System.Drawing.Color.DarkBlue;
            this.BListarVenta.Location = new System.Drawing.Point(29, 224);
            this.BListarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BListarVenta.Name = "BListarVenta";
            this.BListarVenta.Size = new System.Drawing.Size(164, 36);
            this.BListarVenta.TabIndex = 7;
            this.BListarVenta.Text = "Listado Ventas";
            this.BListarVenta.UseVisualStyleBackColor = false;
            this.BListarVenta.UseWaitCursor = true;
            this.BListarVenta.Click += new System.EventHandler(this.BListarVenta_Click);
            // 
            // BVerProducto
            // 
            this.BVerProducto.BackColor = System.Drawing.Color.AliceBlue;
            this.BVerProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BVerProducto.ForeColor = System.Drawing.Color.DarkBlue;
            this.BVerProducto.Location = new System.Drawing.Point(28, 547);
            this.BVerProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BVerProducto.Name = "BVerProducto";
            this.BVerProducto.Size = new System.Drawing.Size(164, 38);
            this.BVerProducto.TabIndex = 3;
            this.BVerProducto.Text = "Ver Productos";
            this.BVerProducto.UseVisualStyleBackColor = false;
            this.BVerProducto.UseWaitCursor = true;
            this.BVerProducto.Click += new System.EventHandler(this.BVerProducto_Click);
            // 
            // BAgregarVenta
            // 
            this.BAgregarVenta.BackColor = System.Drawing.Color.AliceBlue;
            this.BAgregarVenta.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BAgregarVenta.ForeColor = System.Drawing.Color.DarkBlue;
            this.BAgregarVenta.Location = new System.Drawing.Point(28, 178);
            this.BAgregarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregarVenta.Name = "BAgregarVenta";
            this.BAgregarVenta.Size = new System.Drawing.Size(164, 36);
            this.BAgregarVenta.TabIndex = 1;
            this.BAgregarVenta.Text = "Agregar Venta";
            this.BAgregarVenta.UseVisualStyleBackColor = false;
            this.BAgregarVenta.UseWaitCursor = true;
            this.BAgregarVenta.Click += new System.EventHandler(this.BAgregarVenta_Click);
            // 
            // LVentas
            // 
            this.LVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LVentas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVentas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LVentas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LVentas.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LVentas.Location = new System.Drawing.Point(21, 141);
            this.LVentas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LVentas.Name = "LVentas";
            this.LVentas.Padding = new System.Windows.Forms.Padding(3);
            this.LVentas.Size = new System.Drawing.Size(181, 128);
            this.LVentas.TabIndex = 8;
            this.LVentas.Text = "VENTAS";
            this.LVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LVentas.UseWaitCursor = true;
            this.LVentas.Click += new System.EventHandler(this.LVentas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(181, 194);
            this.label1.TabIndex = 14;
            this.label1.Text = "CLIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(21, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(181, 88);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRODUCTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // PVendedor2
            // 
            this.PVendedor2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PVendedor2.BackgroundImage = global::Antorena_Soto.Properties.Resources.cart_icon_147474;
            this.PVendedor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PVendedor2.Dock = System.Windows.Forms.DockStyle.Right;
            this.PVendedor2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PVendedor2.Location = new System.Drawing.Point(218, 0);
            this.PVendedor2.Margin = new System.Windows.Forms.Padding(2);
            this.PVendedor2.Name = "PVendedor2";
            this.PVendedor2.Size = new System.Drawing.Size(595, 609);
            this.PVendedor2.TabIndex = 5;
            this.PVendedor2.UseWaitCursor = true;
            this.PVendedor2.Paint += new System.Windows.Forms.PaintEventHandler(this.PVendedor2_Paint);
            // 
            // menuVendedor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 609);
            this.Controls.Add(this.PVendedor2);
            this.Controls.Add(this.PVendedor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "menuVendedor";
            this.Text = "menuVendedor";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.menuVendedor_Load);
            this.PVendedor1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label LMenuVentas;
        private Panel PVendedor2;
        private Panel PVendedor1;
        private Button BListarVenta;
        private Label LVentas;
        private Button BVerProducto;
        private Button BAgregarVenta;
        private Button BVerInfoCliente;
        private Button BAgregarDatoCliente;
        private Button BEditarCliente;
        private Label label1;
        private Label label2;
    }
}