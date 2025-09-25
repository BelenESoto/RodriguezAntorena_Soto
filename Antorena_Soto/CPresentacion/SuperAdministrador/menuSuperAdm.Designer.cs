namespace Antorena_Soto.CPresentacion.Administrador
{
    partial class menuSuperAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuSuperAdm));
            this.PMenuSuperAdmin = new System.Windows.Forms.Panel();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.DGVListaVendedor = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.BTBajaUsuario = new System.Windows.Forms.Button();
            this.LPersonalGest = new System.Windows.Forms.Label();
            this.BTListaUsuario = new System.Windows.Forms.Button();
            this.BTAltaUsuario = new System.Windows.Forms.Button();
            this.LMenuGerente = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.bUSCARPORToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PMenuSuperAdmin.SuspendLayout();
            this.PGerente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.PGerente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenuSuperAdmin
            // 
            this.PMenuSuperAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PMenuSuperAdmin.Controls.Add(this.PGerente2);
            this.PMenuSuperAdmin.Controls.Add(this.toolStrip1);
            this.PMenuSuperAdmin.Controls.Add(this.PGerente1);
            this.PMenuSuperAdmin.Controls.Add(this.LMenuGerente);
            this.PMenuSuperAdmin.Location = new System.Drawing.Point(2, 2);
            this.PMenuSuperAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PMenuSuperAdmin.Name = "PMenuSuperAdmin";
            this.PMenuSuperAdmin.Size = new System.Drawing.Size(780, 402);
            this.PMenuSuperAdmin.TabIndex = 0;
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.Controls.Add(this.LListaUsuarios);
            this.PGerente2.Controls.Add(this.DGVListaVendedor);
            this.PGerente2.Location = new System.Drawing.Point(209, 46);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(563, 352);
            this.PGerente2.TabIndex = 4;
            // 
            // DGVListaVendedor
            // 
            this.DGVListaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cuit,
            this.Correo,
            this.TipoUsuario,
            this.Dni,
            this.FechaIng});
            this.DGVListaVendedor.Location = new System.Drawing.Point(15, 60);
            this.DGVListaVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVListaVendedor.Name = "DGVListaVendedor";
            this.DGVListaVendedor.RowHeadersWidth = 51;
            this.DGVListaVendedor.RowTemplate.Height = 24;
            this.DGVListaVendedor.Size = new System.Drawing.Size(530, 279);
            this.DGVListaVendedor.TabIndex = 0;
            this.DGVListaVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaVendedor_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPor,
            this.toolStripSeparator1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(208, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(367, 39);
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente1.Controls.Add(this.BTBajaUsuario);
            this.PGerente1.Controls.Add(this.LPersonalGest);
            this.PGerente1.Controls.Add(this.BTListaUsuario);
            this.PGerente1.Controls.Add(this.BTAltaUsuario);
            this.PGerente1.Location = new System.Drawing.Point(0, 44);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(204, 353);
            this.PGerente1.TabIndex = 2;
            // 
            // BTBajaUsuario
            // 
            this.BTBajaUsuario.Location = new System.Drawing.Point(20, 74);
            this.BTBajaUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTBajaUsuario.Name = "BTBajaUsuario";
            this.BTBajaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTBajaUsuario.TabIndex = 7;
            this.BTBajaUsuario.Text = "Baja Usuario";
            this.BTBajaUsuario.UseVisualStyleBackColor = true;
            this.BTBajaUsuario.Click += new System.EventHandler(this.BTBajaUsuario_Click_1);
            // 
            // LPersonalGest
            // 
            this.LPersonalGest.AutoSize = true;
            this.LPersonalGest.BackColor = System.Drawing.Color.LightGray;
            this.LPersonalGest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPersonalGest.Location = new System.Drawing.Point(74, 14);
            this.LPersonalGest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPersonalGest.Name = "LPersonalGest";
            this.LPersonalGest.Size = new System.Drawing.Size(67, 17);
            this.LPersonalGest.TabIndex = 5;
            this.LPersonalGest.Text = "Personal";
            // 
            // BTListaUsuario
            // 
            this.BTListaUsuario.Location = new System.Drawing.Point(20, 105);
            this.BTListaUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTListaUsuario.Name = "BTListaUsuario";
            this.BTListaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTListaUsuario.TabIndex = 2;
            this.BTListaUsuario.Text = "Lista de Ususarios";
            this.BTListaUsuario.UseVisualStyleBackColor = true;
            // 
            // BTAltaUsuario
            // 
            this.BTAltaUsuario.Location = new System.Drawing.Point(20, 43);
            this.BTAltaUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAltaUsuario.Name = "BTAltaUsuario";
            this.BTAltaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTAltaUsuario.TabIndex = 1;
            this.BTAltaUsuario.Text = "Alta Usuario";
            this.BTAltaUsuario.UseVisualStyleBackColor = true;
            this.BTAltaUsuario.Click += new System.EventHandler(this.BTAltaUsuario_Click);
            // 
            // LMenuGerente
            // 
            this.LMenuGerente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LMenuGerente.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuGerente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMenuGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LMenuGerente.Location = new System.Drawing.Point(0, 3);
            this.LMenuGerente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMenuGerente.Name = "LMenuGerente";
            this.LMenuGerente.Size = new System.Drawing.Size(204, 39);
            this.LMenuGerente.TabIndex = 1;
            this.LMenuGerente.Text = "MENU SUPER-ADMIN";
            this.LMenuGerente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo Usuario";
            this.TipoUsuario.Name = "TipoUsuario";
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
            // LListaUsuarios
            // 
            this.LListaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LListaUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.LListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LListaUsuarios.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LListaUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LListaUsuarios.Location = new System.Drawing.Point(13, 8);
            this.LListaUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Size = new System.Drawing.Size(530, 45);
            this.LListaUsuarios.TabIndex = 9;
            this.LListaUsuarios.Text = "LISTA DE USUARIOS";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARPORToolStripMenuItem1,
            this.apellidoToolStripMenuItem1,
            this.tipoUsuarioToolStripMenuItem});
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(113, 36);
            this.BBuscarPor.Text = "BUSCAR POR";
            this.BBuscarPor.ToolTipText = "BUSCAR POR";
            // 
            // bUSCARPORToolStripMenuItem1
            // 
            this.bUSCARPORToolStripMenuItem1.Name = "bUSCARPORToolStripMenuItem1";
            this.bUSCARPORToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bUSCARPORToolStripMenuItem1.Text = "DNI";
            // 
            // apellidoToolStripMenuItem1
            // 
            this.apellidoToolStripMenuItem1.Name = "apellidoToolStripMenuItem1";
            this.apellidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.apellidoToolStripMenuItem1.Text = "Apellido";
            this.apellidoToolStripMenuItem1.Click += new System.EventHandler(this.apellidoToolStripMenuItem1_Click);
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            // 
            // menuSuperAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 409);
            this.Controls.Add(this.PMenuSuperAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menuSuperAdm";
            this.Text = "Form1";
            this.PMenuSuperAdmin.ResumeLayout(false);
            this.PGerente2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PGerente1.ResumeLayout(false);
            this.PGerente1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenuSuperAdmin;
        private System.Windows.Forms.Label LMenuGerente;
        private System.Windows.Forms.Panel PGerente1;
        private System.Windows.Forms.Button BTBajaUsuario;
        private System.Windows.Forms.Label LPersonalGest;
        private System.Windows.Forms.Button BTListaUsuario;
        private System.Windows.Forms.Button BTAltaUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.DataGridView DGVListaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
        private System.Windows.Forms.Label LListaUsuarios;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem bUSCARPORToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
    }
}