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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LSubTitulo = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TBContrasenia = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.BIngresar = new System.Windows.Forms.Button();
            this.LContrasenia = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.PFondo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BCancelar);
            this.panel1.Controls.Add(this.TBContrasenia);
            this.panel1.Controls.Add(this.TBDni);
            this.panel1.Controls.Add(this.BIngresar);
            this.panel1.Controls.Add(this.LContrasenia);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 442);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LTitulo);
            this.panel2.Controls.Add(this.LSubTitulo);
            this.panel2.Location = new System.Drawing.Point(398, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 138);
            this.panel2.TabIndex = 18;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Black;
            this.LTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LTitulo.Font = new System.Drawing.Font("SimSun-ExtB", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Black;
            this.LTitulo.Image = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.LTitulo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LTitulo.Location = new System.Drawing.Point(99, 28);
            this.LTitulo.Margin = new System.Windows.Forms.Padding(3);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(228, 58);
            this.LTitulo.TabIndex = 7;
            this.LTitulo.Text = "SKORIAL";
            this.LTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LSubTitulo
            // 
            this.LSubTitulo.AutoSize = true;
            this.LSubTitulo.Font = new System.Drawing.Font("SimSun", 13.8F);
            this.LSubTitulo.ForeColor = System.Drawing.Color.Coral;
            this.LSubTitulo.Location = new System.Drawing.Point(105, 89);
            this.LSubTitulo.Name = "LSubTitulo";
            this.LSubTitulo.Size = new System.Drawing.Size(214, 23);
            this.LSubTitulo.TabIndex = 17;
            this.LSubTitulo.Text = "Sistema de Ventas";
            this.LSubTitulo.Click += new System.EventHandler(this.label6_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.White;
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCancelar.Font = new System.Drawing.Font("SimSun", 12F);
            this.BCancelar.Image = global::Antorena_Soto.Properties.Resources.letter_x_close_cross_remove_delete_cancel_icon_267835;
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(433, 341);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(146, 52);
            this.BCancelar.TabIndex = 15;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // TBContrasenia
            // 
            this.TBContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContrasenia.Location = new System.Drawing.Point(433, 291);
            this.TBContrasenia.MaxLength = 100;
            this.TBContrasenia.Name = "TBContrasenia";
            this.TBContrasenia.PasswordChar = '*';
            this.TBContrasenia.Size = new System.Drawing.Size(329, 30);
            this.TBContrasenia.TabIndex = 14;
            this.TBContrasenia.UseSystemPasswordChar = true;
            this.TBContrasenia.TextChanged += new System.EventHandler(this.TBContrasenia_TextChanged);
            this.TBContrasenia.Validating += new System.ComponentModel.CancelEventHandler(this.TBContrasenia_Validating);
            // 
            // TBDni
            // 
            this.TBDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDni.Location = new System.Drawing.Point(433, 221);
            this.TBDni.MaxLength = 8;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(329, 30);
            this.TBDni.TabIndex = 13;
            this.TBDni.TextChanged += new System.EventHandler(this.TBDni_TextChanged);
            this.TBDni.Validating += new System.ComponentModel.CancelEventHandler(this.TBDni_Validating);
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.White;
            this.BIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BIngresar.Font = new System.Drawing.Font("SimSun", 12F);
            this.BIngresar.Image = global::Antorena_Soto.Properties.Resources.navigation_skip_sign_direction_arrow_next_right_icon_267823;
            this.BIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIngresar.Location = new System.Drawing.Point(616, 341);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(146, 52);
            this.BIngresar.TabIndex = 12;
            this.BIngresar.Text = " Ingresar";
            this.BIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // LContrasenia
            // 
            this.LContrasenia.AutoSize = true;
            this.LContrasenia.Font = new System.Drawing.Font("SimSun", 13.8F);
            this.LContrasenia.ForeColor = System.Drawing.Color.Black;
            this.LContrasenia.Location = new System.Drawing.Point(535, 265);
            this.LContrasenia.Name = "LContrasenia";
            this.LContrasenia.Size = new System.Drawing.Size(130, 23);
            this.LContrasenia.TabIndex = 11;
            this.LContrasenia.Text = "Contraseña";
            this.LContrasenia.Click += new System.EventHandler(this.label2_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.Black;
            this.LDni.Location = new System.Drawing.Point(570, 197);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(46, 23);
            this.LDni.TabIndex = 10;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.label4_Click);
            // 
            // PFondo
            // 
            this.PFondo.BackgroundImage = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.PFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PFondo.Controls.Add(this.label3);
            this.PFondo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PFondo.Location = new System.Drawing.Point(2, 9);
            this.PFondo.Name = "PFondo";
            this.PFondo.Size = new System.Drawing.Size(401, 445);
            this.PFondo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PFondo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PFondo.ResumeLayout(false);
            this.PFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LContrasenia;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TBContrasenia;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.Panel PFondo;
        private System.Windows.Forms.Label LSubTitulo;
        private System.Windows.Forms.Panel panel2;
    }
}

