namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class menuAdmin
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
            this.lAdministrador = new System.Windows.Forms.Label();
            this.BListarProductos = new System.Windows.Forms.Button();
            this.BEditarProducto = new System.Windows.Forms.Button();
            this.BAltaProductos = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pAdmin1 = new System.Windows.Forms.Panel();
            this.PAdmin = new System.Windows.Forms.Panel();
            this.pAdmin2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PGerente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.MidnightBlue;
            this.PGerente1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PGerente1.Controls.Add(this.pAdmin2);
            this.PGerente1.Controls.Add(this.pAdmin1);
            this.PGerente1.Controls.Add(this.lAdministrador);
            this.PGerente1.Controls.Add(this.BListarProductos);
            this.PGerente1.Controls.Add(this.BEditarProducto);
            this.PGerente1.Controls.Add(this.BAltaProductos);
            this.PGerente1.Location = new System.Drawing.Point(-7, -3);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(285, 957);
            this.PGerente1.TabIndex = 0;
            this.PGerente1.Paint += new System.Windows.Forms.PaintEventHandler(this.PGerente1_Paint);
            // 
            // lAdministrador
            // 
            this.lAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lAdministrador.BackColor = System.Drawing.Color.Gainsboro;
            this.lAdministrador.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdministrador.ForeColor = System.Drawing.Color.Black;
            this.lAdministrador.Location = new System.Drawing.Point(-1, 45);
            this.lAdministrador.Name = "lAdministrador";
            this.lAdministrador.Size = new System.Drawing.Size(289, 76);
            this.lAdministrador.TabIndex = 0;
            this.lAdministrador.Text = "Menu Administrador";
            this.lAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lAdministrador.Click += new System.EventHandler(this.lAdministrador_Click);
            // 
            // BListarProductos
            // 
            this.BListarProductos.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BListarProductos.Location = new System.Drawing.Point(27, 360);
            this.BListarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BListarProductos.Name = "BListarProductos";
            this.BListarProductos.Size = new System.Drawing.Size(240, 61);
            this.BListarProductos.TabIndex = 8;
            this.BListarProductos.Text = "Listar Productos";
            this.BListarProductos.UseVisualStyleBackColor = true;
            this.BListarProductos.Click += new System.EventHandler(this.BListarProductos_Click);
            // 
            // BEditarProducto
            // 
            this.BEditarProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarProducto.Location = new System.Drawing.Point(27, 460);
            this.BEditarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BEditarProducto.Name = "BEditarProducto";
            this.BEditarProducto.Size = new System.Drawing.Size(240, 65);
            this.BEditarProducto.TabIndex = 4;
            this.BEditarProducto.Text = "Editar Productos";
            this.BEditarProducto.UseVisualStyleBackColor = true;
            this.BEditarProducto.Click += new System.EventHandler(this.BEditarProducto_Click);
            // 
            // BAltaProductos
            // 
            this.BAltaProductos.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BAltaProductos.Location = new System.Drawing.Point(27, 253);
            this.BAltaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAltaProductos.Name = "BAltaProductos";
            this.BAltaProductos.Size = new System.Drawing.Size(240, 62);
            this.BAltaProductos.TabIndex = 3;
            this.BAltaProductos.Text = "Alta  Productos";
            this.BAltaProductos.UseVisualStyleBackColor = true;
            this.BAltaProductos.Click += new System.EventHandler(this.BAltaProductos_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pAdmin1
            // 
            this.pAdmin1.Location = new System.Drawing.Point(307, 3);
            this.pAdmin1.Name = "pAdmin1";
            this.pAdmin1.Size = new System.Drawing.Size(793, 765);
            this.pAdmin1.TabIndex = 2;
            // 
            // PAdmin
            // 
            this.PAdmin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PAdmin.BackgroundImage = global::Antorena_Soto.Properties.Resources.config2;
            this.PAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PAdmin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PAdmin.Location = new System.Drawing.Point(0, 0);
            this.PAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PAdmin.Name = "PAdmin";
            this.PAdmin.Size = new System.Drawing.Size(810, 765);
            this.PAdmin.TabIndex = 1;
            this.PAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.PGerente2_Paint);
            // 
            // pAdmin2
            // 
            this.pAdmin2.Location = new System.Drawing.Point(304, 3);
            this.pAdmin2.Name = "pAdmin2";
            this.pAdmin2.Size = new System.Drawing.Size(793, 765);
            this.pAdmin2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.PAdmin);
            this.panel1.Location = new System.Drawing.Point(284, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 765);
            this.panel1.TabIndex = 0;
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PGerente1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "menuAdmin";
            this.Text = "menuAdmin";
            this.Load += new System.EventHandler(this.FormMenuGerente_Load);
            this.PGerente1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PGerente1;
        private System.Windows.Forms.Panel PAdmin;
        private System.Windows.Forms.Button BEditarProducto;
        private System.Windows.Forms.Button BAltaProductos;
        private System.Windows.Forms.Button BListarProductos;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pAdmin1;
        private System.Windows.Forms.Label lAdministrador;
        private System.Windows.Forms.Panel pAdmin2;
        private System.Windows.Forms.Panel panel1;
    }
}