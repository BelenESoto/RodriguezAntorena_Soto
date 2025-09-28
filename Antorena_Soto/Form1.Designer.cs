namespace Antorena_Soto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LDni = new System.Windows.Forms.Label();
            this.LContrasenia = new System.Windows.Forms.Label();
            this.BIngresar = new System.Windows.Forms.Button();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBContrasenia = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PFondoLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubTitulo = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PFondoLogin)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LDni.Location = new System.Drawing.Point(183, 283);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(57, 28);
            this.LDni.TabIndex = 10;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.label4_Click);
            // 
            // LContrasenia
            // 
            this.LContrasenia.AutoSize = true;
            this.LContrasenia.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContrasenia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LContrasenia.Location = new System.Drawing.Point(127, 360);
            this.LContrasenia.Name = "LContrasenia";
            this.LContrasenia.Size = new System.Drawing.Size(162, 28);
            this.LContrasenia.TabIndex = 11;
            this.LContrasenia.Text = "Contraseña";
            this.LContrasenia.Click += new System.EventHandler(this.label2_Click);
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BIngresar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BIngresar.Location = new System.Drawing.Point(225, 452);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(120, 52);
            this.BIngresar.TabIndex = 12;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDni.Location = new System.Drawing.Point(26, 314);
            this.TBDni.MaxLength = 8;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(365, 30);
            this.TBDni.TabIndex = 13;
            this.TBDni.TextChanged += new System.EventHandler(this.TBDni_TextChanged);
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // TBContrasenia
            // 
            this.TBContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContrasenia.Location = new System.Drawing.Point(26, 391);
            this.TBContrasenia.MaxLength = 100;
            this.TBContrasenia.Name = "TBContrasenia";
            this.TBContrasenia.PasswordChar = '*';
            this.TBContrasenia.Size = new System.Drawing.Size(365, 30);
            this.TBContrasenia.TabIndex = 14;
            this.TBContrasenia.UseSystemPasswordChar = true;
            this.TBContrasenia.TextChanged += new System.EventHandler(this.TBContrasenia_TextChanged);
            this.TBContrasenia.Validating += new System.ComponentModel.CancelEventHandler(this.TBContrasenia_Validating);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCancelar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(78, 452);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(120, 52);
            this.BCancelar.TabIndex = 15;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PFondoLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TBDni);
            this.panel2.Controls.Add(this.LDni);
            this.panel2.Controls.Add(this.LContrasenia);
            this.panel2.Controls.Add(this.TBContrasenia);
            this.panel2.Controls.Add(this.BIngresar);
            this.panel2.Controls.Add(this.BCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(617, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 576);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PFondoLogin
            // 
            this.PFondoLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PFondoLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PFondoLogin.Image = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.PFondoLogin.Location = new System.Drawing.Point(118, 103);
            this.PFondoLogin.Name = "PFondoLogin";
            this.PFondoLogin.Size = new System.Drawing.Size(193, 159);
            this.PFondoLogin.TabIndex = 20;
            this.PFondoLogin.TabStop = false;
            this.PFondoLogin.Click += new System.EventHandler(this.PFondoLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("SimSun", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bienvenido";
            // 
            // LTitulo
            // 
            this.LTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LTitulo.Font = new System.Drawing.Font("SimSun-ExtB", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Image = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LTitulo.Location = new System.Drawing.Point(126, 237);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(3);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(359, 112);
            this.LTitulo.TabIndex = 7;
            this.LTitulo.Text = "SKORIAL";
            this.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LSubTitulo
            // 
            this.LSubTitulo.AutoSize = true;
            this.LSubTitulo.Font = new System.Drawing.Font("SimSun", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LSubTitulo.Location = new System.Drawing.Point(128, 197);
            this.LSubTitulo.Name = "LSubTitulo";
            this.LSubTitulo.Size = new System.Drawing.Size(357, 37);
            this.LSubTitulo.TabIndex = 17;
            this.LSubTitulo.Text = "Sistema de Ventas";
            this.LSubTitulo.Click += new System.EventHandler(this.label6_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogin.Controls.Add(this.LSubTitulo);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.LTitulo);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1034, 576);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 576);
            this.Controls.Add(this.panelLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PFondoLogin)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LContrasenia;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBContrasenia;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LSubTitulo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PFondoLogin;
    }
}

