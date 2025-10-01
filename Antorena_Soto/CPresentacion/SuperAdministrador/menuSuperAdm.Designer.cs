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
            this.PMenuSuperAdmin = new System.Windows.Forms.Panel();
            this.PGerente22 = new System.Windows.Forms.Panel();
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.BTBajaUsuario = new System.Windows.Forms.Button();
            this.BTListaUsuario = new System.Windows.Forms.Button();
            this.BTAltaUsuario = new System.Windows.Forms.Button();
            this.LMenuVentas = new System.Windows.Forms.Label();
            this.LVentas = new System.Windows.Forms.Label();
            this.BEditarUsuario = new System.Windows.Forms.Button();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.PMenuSuperAdmin.SuspendLayout();
            this.PGerente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenuSuperAdmin
            // 
            this.PMenuSuperAdmin.BackColor = System.Drawing.Color.Lavender;
            this.PMenuSuperAdmin.Controls.Add(this.PGerente1);
            this.PMenuSuperAdmin.Controls.Add(this.PGerente22);
            this.PMenuSuperAdmin.Location = new System.Drawing.Point(2, 2);
            this.PMenuSuperAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PMenuSuperAdmin.Name = "PMenuSuperAdmin";
            this.PMenuSuperAdmin.Size = new System.Drawing.Size(829, 648);
            this.PMenuSuperAdmin.TabIndex = 0;
            // 
            // PGerente22
            // 
            this.PGerente22.BackColor = System.Drawing.Color.Lavender;
            this.PGerente22.BackgroundImage = global::Antorena_Soto.Properties.Resources.config2;
            this.PGerente22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PGerente22.Dock = System.Windows.Forms.DockStyle.Right;
            this.PGerente22.Location = new System.Drawing.Point(234, 0);
            this.PGerente22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PGerente22.Name = "PGerente22";
            this.PGerente22.Size = new System.Drawing.Size(595, 648);
            this.PGerente22.TabIndex = 4;
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.MidnightBlue;
            this.PGerente1.Controls.Add(this.BEditarUsuario);
            this.PGerente1.Controls.Add(this.LMenuVentas);
            this.PGerente1.Controls.Add(this.BTBajaUsuario);
            this.PGerente1.Controls.Add(this.BTListaUsuario);
            this.PGerente1.Controls.Add(this.BTAltaUsuario);
            this.PGerente1.Controls.Add(this.LVentas);
            this.PGerente1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PGerente1.Location = new System.Drawing.Point(0, 0);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(220, 648);
            this.PGerente1.TabIndex = 2;
            // 
            // BTBajaUsuario
            // 
            this.BTBajaUsuario.BackColor = System.Drawing.Color.White;
            this.BTBajaUsuario.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTBajaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BTBajaUsuario.Location = new System.Drawing.Point(26, 267);
            this.BTBajaUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTBajaUsuario.Name = "BTBajaUsuario";
            this.BTBajaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTBajaUsuario.TabIndex = 7;
            this.BTBajaUsuario.Text = "Baja Usuario";
            this.BTBajaUsuario.UseVisualStyleBackColor = false;
            this.BTBajaUsuario.Click += new System.EventHandler(this.BTBajaUsuario_Click_1);
            // 
            // BTListaUsuario
            // 
            this.BTListaUsuario.BackColor = System.Drawing.Color.White;
            this.BTListaUsuario.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTListaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BTListaUsuario.Location = new System.Drawing.Point(26, 355);
            this.BTListaUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTListaUsuario.Name = "BTListaUsuario";
            this.BTListaUsuario.Size = new System.Drawing.Size(164, 55);
            this.BTListaUsuario.TabIndex = 2;
            this.BTListaUsuario.Text = "Lista de Usuarios";
            this.BTListaUsuario.UseVisualStyleBackColor = false;
            this.BTListaUsuario.Click += new System.EventHandler(this.BTListaUsuario_Click_1);
            // 
            // BTAltaUsuario
            // 
            this.BTAltaUsuario.BackColor = System.Drawing.Color.White;
            this.BTAltaUsuario.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTAltaUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BTAltaUsuario.Location = new System.Drawing.Point(26, 226);
            this.BTAltaUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAltaUsuario.Name = "BTAltaUsuario";
            this.BTAltaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTAltaUsuario.TabIndex = 1;
            this.BTAltaUsuario.Text = "Alta Usuario";
            this.BTAltaUsuario.UseVisualStyleBackColor = false;
            this.BTAltaUsuario.Click += new System.EventHandler(this.BTAltaUsuario_Click);
            // 
            // LMenuVentas
            // 
            this.LMenuVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuVentas.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold);
            this.LMenuVentas.Image = global::Antorena_Soto.Properties.Resources.config2;
            this.LMenuVentas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LMenuVentas.Location = new System.Drawing.Point(7, 36);
            this.LMenuVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMenuVentas.Name = "LMenuVentas";
            this.LMenuVentas.Size = new System.Drawing.Size(209, 90);
            this.LMenuVentas.TabIndex = 8;
            this.LMenuVentas.Text = "MENU SUPER ADMINISTRADOR";
            this.LMenuVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LMenuVentas.UseWaitCursor = true;
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
            this.LVentas.Location = new System.Drawing.Point(12, 179);
            this.LVentas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LVentas.Name = "LVentas";
            this.LVentas.Padding = new System.Windows.Forms.Padding(3);
            this.LVentas.Size = new System.Drawing.Size(195, 243);
            this.LVentas.TabIndex = 9;
            this.LVentas.Text = "PERSONAL";
            this.LVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LVentas.UseWaitCursor = true;
            // 
            // BEditarUsuario
            // 
            this.BEditarUsuario.BackColor = System.Drawing.Color.White;
            this.BEditarUsuario.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.BEditarUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BEditarUsuario.Location = new System.Drawing.Point(28, 311);
            this.BEditarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BEditarUsuario.Name = "BEditarUsuario";
            this.BEditarUsuario.Size = new System.Drawing.Size(164, 27);
            this.BEditarUsuario.TabIndex = 10;
            this.BEditarUsuario.Text = "Editar Usuario";
            this.BEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PGerente2.BackgroundImage = global::Antorena_Soto.Properties.Resources.config2;
            this.PGerente2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PGerente2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PGerente2.Location = new System.Drawing.Point(222, 2);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(595, 609);
            this.PGerente2.TabIndex = 6;
            this.PGerente2.UseWaitCursor = true;
            this.PGerente2.Paint += new System.Windows.Forms.PaintEventHandler(this.PGerente2_Paint);
            // 
            // menuSuperAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 609);
            this.Controls.Add(this.PGerente2);
            this.Controls.Add(this.PMenuSuperAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menuSuperAdm";
            this.Text = "Form1";
            this.PMenuSuperAdmin.ResumeLayout(false);
            this.PGerente1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenuSuperAdmin;
        private System.Windows.Forms.Panel PGerente1;
        private System.Windows.Forms.Button BTBajaUsuario;
        private System.Windows.Forms.Button BTListaUsuario;
        private System.Windows.Forms.Button BTAltaUsuario;
        private System.Windows.Forms.Panel PGerente22;
        private System.Windows.Forms.Label LMenuVentas;
        private System.Windows.Forms.Label LVentas;
        private System.Windows.Forms.Button BEditarUsuario;
        private System.Windows.Forms.Panel PGerente2;
    }
}