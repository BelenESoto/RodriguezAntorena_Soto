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
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.BTBajaUsuario = new System.Windows.Forms.Button();
            this.LPersonalGest = new System.Windows.Forms.Label();
            this.BTAltaUsuario = new System.Windows.Forms.Button();
            this.LMenuGerente = new System.Windows.Forms.Label();
            this.BTListaUsuario = new System.Windows.Forms.Button();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.BEditarUsuario = new System.Windows.Forms.Button();
            this.PMenuSuperAdmin.SuspendLayout();
            this.PGerente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenuSuperAdmin
            // 
            this.PMenuSuperAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PMenuSuperAdmin.Controls.Add(this.PGerente2);
            this.PMenuSuperAdmin.Controls.Add(this.PGerente1);
            this.PMenuSuperAdmin.Controls.Add(this.LMenuGerente);
            this.PMenuSuperAdmin.Location = new System.Drawing.Point(2, 2);
            this.PMenuSuperAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.PMenuSuperAdmin.Name = "PMenuSuperAdmin";
            this.PMenuSuperAdmin.Size = new System.Drawing.Size(780, 402);
            this.PMenuSuperAdmin.TabIndex = 0;
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente1.Controls.Add(this.BEditarUsuario);
            this.PGerente1.Controls.Add(this.BTBajaUsuario);
            this.PGerente1.Controls.Add(this.LPersonalGest);
            this.PGerente1.Controls.Add(this.BTListaUsuario);
            this.PGerente1.Controls.Add(this.BTAltaUsuario);
            this.PGerente1.Location = new System.Drawing.Point(0, 44);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(204, 353);
            this.PGerente1.TabIndex = 2;
            // 
            // BTBajaUsuario
            // 
            this.BTBajaUsuario.Location = new System.Drawing.Point(20, 74);
            this.BTBajaUsuario.Margin = new System.Windows.Forms.Padding(2);
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
            // BTAltaUsuario
            // 
            this.BTAltaUsuario.Location = new System.Drawing.Point(20, 43);
            this.BTAltaUsuario.Margin = new System.Windows.Forms.Padding(2);
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
            // BTListaUsuario
            // 
            this.BTListaUsuario.Location = new System.Drawing.Point(20, 105);
            this.BTListaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BTListaUsuario.Name = "BTListaUsuario";
            this.BTListaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTListaUsuario.TabIndex = 2;
            this.BTListaUsuario.Text = "Lista de Ususarios";
            this.BTListaUsuario.UseVisualStyleBackColor = true;
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.BackgroundImage = global::Antorena_Soto.Properties.Resources.config2;
            this.PGerente2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PGerente2.Location = new System.Drawing.Point(208, 0);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(572, 398);
            this.PGerente2.TabIndex = 4;
            // 
            // BEditarUsuario
            // 
            this.BEditarUsuario.Location = new System.Drawing.Point(20, 136);
            this.BEditarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BEditarUsuario.Name = "BEditarUsuario";
            this.BEditarUsuario.Size = new System.Drawing.Size(164, 27);
            this.BEditarUsuario.TabIndex = 8;
            this.BEditarUsuario.Text = "Editar Usuario";
            this.BEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // menuSuperAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 409);
            this.Controls.Add(this.PMenuSuperAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuSuperAdm";
            this.Text = "Form1";
            this.PMenuSuperAdmin.ResumeLayout(false);
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
        private System.Windows.Forms.Button BTAltaUsuario;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.Button BTListaUsuario;
        private System.Windows.Forms.Button BEditarUsuario;
    }
}