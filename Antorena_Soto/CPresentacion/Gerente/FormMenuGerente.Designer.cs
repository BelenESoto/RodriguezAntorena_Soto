namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class FormMenuGerente
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
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.bListarVentas = new System.Windows.Forms.Button();
            this.Linformes = new System.Windows.Forms.Label();
            this.BListarProductos = new System.Windows.Forms.Button();
            this.LProductosGest = new System.Windows.Forms.Label();
            this.BEditarProducto = new System.Windows.Forms.Button();
            this.BAltaProductos = new System.Windows.Forms.Button();
            this.LMenuGerente = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.PGerente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente1.Controls.Add(this.bListarVentas);
            this.PGerente1.Controls.Add(this.Linformes);
            this.PGerente1.Controls.Add(this.BListarProductos);
            this.PGerente1.Controls.Add(this.LProductosGest);
            this.PGerente1.Controls.Add(this.BEditarProducto);
            this.PGerente1.Controls.Add(this.BAltaProductos);
            this.PGerente1.Location = new System.Drawing.Point(5, 71);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(272, 435);
            this.PGerente1.TabIndex = 0;
            // 
            // bListarVentas
            // 
            this.bListarVentas.Location = new System.Drawing.Point(27, 281);
            this.bListarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bListarVentas.Name = "bListarVentas";
            this.bListarVentas.Size = new System.Drawing.Size(219, 33);
            this.bListarVentas.TabIndex = 10;
            this.bListarVentas.Text = "Listar ventas";
            this.bListarVentas.UseVisualStyleBackColor = true;
            this.bListarVentas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Linformes
            // 
            this.Linformes.AutoSize = true;
            this.Linformes.BackColor = System.Drawing.Color.LightGray;
            this.Linformes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linformes.Location = new System.Drawing.Point(87, 250);
            this.Linformes.Name = "Linformes";
            this.Linformes.Size = new System.Drawing.Size(87, 20);
            this.Linformes.TabIndex = 9;
            this.Linformes.Text = "Informes";
            // 
            // BListarProductos
            // 
            this.BListarProductos.Location = new System.Drawing.Point(27, 133);
            this.BListarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BListarProductos.Name = "BListarProductos";
            this.BListarProductos.Size = new System.Drawing.Size(219, 33);
            this.BListarProductos.TabIndex = 8;
            this.BListarProductos.Text = "Listar Productos";
            this.BListarProductos.UseVisualStyleBackColor = true;
            this.BListarProductos.Click += new System.EventHandler(this.BListarProductos_Click);
            // 
            // LProductosGest
            // 
            this.LProductosGest.AutoSize = true;
            this.LProductosGest.BackColor = System.Drawing.Color.LightGray;
            this.LProductosGest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductosGest.Location = new System.Drawing.Point(87, 39);
            this.LProductosGest.Name = "LProductosGest";
            this.LProductosGest.Size = new System.Drawing.Size(93, 20);
            this.LProductosGest.TabIndex = 6;
            this.LProductosGest.Text = "Productos";
            // 
            // BEditarProducto
            // 
            this.BEditarProducto.Location = new System.Drawing.Point(27, 185);
            this.BEditarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEditarProducto.Name = "BEditarProducto";
            this.BEditarProducto.Size = new System.Drawing.Size(219, 33);
            this.BEditarProducto.TabIndex = 4;
            this.BEditarProducto.Text = "Editar Productos";
            this.BEditarProducto.UseVisualStyleBackColor = true;
            this.BEditarProducto.Click += new System.EventHandler(this.BEditarProducto_Click);
            // 
            // BAltaProductos
            // 
            this.BAltaProductos.Location = new System.Drawing.Point(27, 82);
            this.BAltaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAltaProductos.Name = "BAltaProductos";
            this.BAltaProductos.Size = new System.Drawing.Size(219, 33);
            this.BAltaProductos.TabIndex = 3;
            this.BAltaProductos.Text = "Alta Productos";
            this.BAltaProductos.UseVisualStyleBackColor = true;
            this.BAltaProductos.Click += new System.EventHandler(this.BAltaProductos_Click);
            // 
            // LMenuGerente
            // 
            this.LMenuGerente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LMenuGerente.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuGerente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LMenuGerente.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMenuGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LMenuGerente.Location = new System.Drawing.Point(5, 6);
            this.LMenuGerente.Name = "LMenuGerente";
            this.LMenuGerente.Size = new System.Drawing.Size(272, 62);
            this.LMenuGerente.TabIndex = 0;
            this.LMenuGerente.Text = "MENU GERENTE";
            this.LMenuGerente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LMenuGerente.Click += new System.EventHandler(this.LMenuGerente_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.BackgroundImage = global::Antorena_Soto.Properties.Resources.config2;
            this.PGerente2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PGerente2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PGerente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PGerente2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PGerente2.Location = new System.Drawing.Point(278, 6);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(790, 500);
            this.PGerente2.TabIndex = 1;
            this.PGerente2.Paint += new System.Windows.Forms.PaintEventHandler(this.PGerente2_Paint);
            // 
            // FormMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1068, 516);
            this.Controls.Add(this.LMenuGerente);
            this.Controls.Add(this.PGerente2);
            this.Controls.Add(this.PGerente1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenuGerente";
            this.Text = "FormMenuGerente";
            this.Load += new System.EventHandler(this.FormMenuGerente_Load);
            this.PGerente1.ResumeLayout(false);
            this.PGerente1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PGerente1;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.Label LMenuGerente;
        private System.Windows.Forms.Button BEditarProducto;
        private System.Windows.Forms.Button BAltaProductos;
        private System.Windows.Forms.Label LProductosGest;
        private System.Windows.Forms.Button BListarProductos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label Linformes;
        private System.Windows.Forms.Button bListarVentas;
    }
}