namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class agregarCliente
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
            this.PAgregarClienteFondo = new System.Windows.Forms.Panel();
            this.LAgregarCliente = new System.Windows.Forms.Label();
            this.PAgregarCliente = new System.Windows.Forms.Panel();
            this.TBCorreoCliente = new System.Windows.Forms.TextBox();
            this.LCorreoCliente = new System.Windows.Forms.Label();
            this.BAgregarCliente = new System.Windows.Forms.Button();
            this.TBNumCliente = new System.Windows.Forms.TextBox();
            this.LTelefonoCliente = new System.Windows.Forms.Label();
            this.TBDomicilioCliente = new System.Windows.Forms.TextBox();
            this.LDomicilioCliente = new System.Windows.Forms.Label();
            this.TBCiudadCliente = new System.Windows.Forms.TextBox();
            this.TBProvinciaCliente = new System.Windows.Forms.TextBox();
            this.LCiudadCliente = new System.Windows.Forms.Label();
            this.LProvinviaCliente = new System.Windows.Forms.Label();
            this.TBDniCliente = new System.Windows.Forms.TextBox();
            this.LDniCliente = new System.Windows.Forms.Label();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.PAgregarClienteFondo.SuspendLayout();
            this.PAgregarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAgregarClienteFondo
            // 
            this.PAgregarClienteFondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PAgregarClienteFondo.Controls.Add(this.LAgregarCliente);
            this.PAgregarClienteFondo.Controls.Add(this.PAgregarCliente);
            this.PAgregarClienteFondo.Location = new System.Drawing.Point(2, 1);
            this.PAgregarClienteFondo.Name = "PAgregarClienteFondo";
            this.PAgregarClienteFondo.Size = new System.Drawing.Size(801, 451);
            this.PAgregarClienteFondo.TabIndex = 0;
            this.PAgregarClienteFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarClienteFondo_Paint);
            // 
            // LAgregarCliente
            // 
            this.LAgregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarCliente.BackColor = System.Drawing.Color.Coral;
            this.LAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarCliente.Location = new System.Drawing.Point(10, 0);
            this.LAgregarCliente.Name = "LAgregarCliente";
            this.LAgregarCliente.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.LAgregarCliente.Size = new System.Drawing.Size(771, 44);
            this.LAgregarCliente.TabIndex = 2;
            this.LAgregarCliente.Text = "AGREGAR CLIENTE ";
            this.LAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAgregarCliente
            // 
            this.PAgregarCliente.BackColor = System.Drawing.Color.PeachPuff;
            this.PAgregarCliente.Controls.Add(this.TBCorreoCliente);
            this.PAgregarCliente.Controls.Add(this.LCorreoCliente);
            this.PAgregarCliente.Controls.Add(this.BAgregarCliente);
            this.PAgregarCliente.Controls.Add(this.TBNumCliente);
            this.PAgregarCliente.Controls.Add(this.LTelefonoCliente);
            this.PAgregarCliente.Controls.Add(this.TBDomicilioCliente);
            this.PAgregarCliente.Controls.Add(this.LDomicilioCliente);
            this.PAgregarCliente.Controls.Add(this.TBCiudadCliente);
            this.PAgregarCliente.Controls.Add(this.TBProvinciaCliente);
            this.PAgregarCliente.Controls.Add(this.LCiudadCliente);
            this.PAgregarCliente.Controls.Add(this.LProvinviaCliente);
            this.PAgregarCliente.Controls.Add(this.TBDniCliente);
            this.PAgregarCliente.Controls.Add(this.LDniCliente);
            this.PAgregarCliente.Controls.Add(this.TBNombreCliente);
            this.PAgregarCliente.Controls.Add(this.LNombreCliente);
            this.PAgregarCliente.Location = new System.Drawing.Point(10, 47);
            this.PAgregarCliente.Name = "PAgregarCliente";
            this.PAgregarCliente.Size = new System.Drawing.Size(771, 404);
            this.PAgregarCliente.TabIndex = 1;
            this.PAgregarCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarCliente_Paint);
            // 
            // TBCorreoCliente
            // 
            this.TBCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreoCliente.Location = new System.Drawing.Point(21, 331);
            this.TBCorreoCliente.MaxLength = 100;
            this.TBCorreoCliente.Name = "TBCorreoCliente";
            this.TBCorreoCliente.Size = new System.Drawing.Size(729, 30);
            this.TBCorreoCliente.TabIndex = 27;
            this.TBCorreoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCorreoCliente_Validating);
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCliente.ForeColor = System.Drawing.Color.Black;
            this.LCorreoCliente.Location = new System.Drawing.Point(17, 305);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(94, 23);
            this.LCorreoCliente.TabIndex = 26;
            this.LCorreoCliente.Text = "Correo ";
            // 
            // BAgregarCliente
            // 
            this.BAgregarCliente.BackColor = System.Drawing.Color.Black;
            this.BAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCliente.ForeColor = System.Drawing.Color.Coral;
            this.BAgregarCliente.Location = new System.Drawing.Point(559, 361);
            this.BAgregarCliente.Name = "BAgregarCliente";
            this.BAgregarCliente.Size = new System.Drawing.Size(191, 40);
            this.BAgregarCliente.TabIndex = 25;
            this.BAgregarCliente.Text = "Agregar Cliente";
            this.BAgregarCliente.UseVisualStyleBackColor = false;
            this.BAgregarCliente.Click += new System.EventHandler(this.BAgregarCliente_Click);
            // 
            // TBNumCliente
            // 
            this.TBNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumCliente.Location = new System.Drawing.Point(21, 272);
            this.TBNumCliente.MaxLength = 12;
            this.TBNumCliente.Name = "TBNumCliente";
            this.TBNumCliente.Size = new System.Drawing.Size(729, 30);
            this.TBNumCliente.TabIndex = 24;
            this.TBNumCliente.TextChanged += new System.EventHandler(this.TBNumCliente_TextChanged);
            this.TBNumCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBNumCliente_Validating);
            // 
            // LTelefonoCliente
            // 
            this.LTelefonoCliente.AutoSize = true;
            this.LTelefonoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoCliente.Location = new System.Drawing.Point(17, 246);
            this.LTelefonoCliente.Name = "LTelefonoCliente";
            this.LTelefonoCliente.Size = new System.Drawing.Size(214, 23);
            this.LTelefonoCliente.TabIndex = 23;
            this.LTelefonoCliente.Text = "Numero Telefonico";
            // 
            // TBDomicilioCliente
            // 
            this.TBDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDomicilioCliente.Location = new System.Drawing.Point(21, 213);
            this.TBDomicilioCliente.MaxLength = 200;
            this.TBDomicilioCliente.Name = "TBDomicilioCliente";
            this.TBDomicilioCliente.Size = new System.Drawing.Size(729, 30);
            this.TBDomicilioCliente.TabIndex = 22;
            this.TBDomicilioCliente.TextChanged += new System.EventHandler(this.TBDomicilioCliente_TextChanged);
            this.TBDomicilioCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDomicilioCliente_Validating);
            // 
            // LDomicilioCliente
            // 
            this.LDomicilioCliente.AutoSize = true;
            this.LDomicilioCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilioCliente.ForeColor = System.Drawing.Color.Black;
            this.LDomicilioCliente.Location = new System.Drawing.Point(17, 187);
            this.LDomicilioCliente.Name = "LDomicilioCliente";
            this.LDomicilioCliente.Size = new System.Drawing.Size(118, 23);
            this.LDomicilioCliente.TabIndex = 21;
            this.LDomicilioCliente.Text = "Domicilio";
            // 
            // TBCiudadCliente
            // 
            this.TBCiudadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudadCliente.Location = new System.Drawing.Point(410, 154);
            this.TBCiudadCliente.MaxLength = 50;
            this.TBCiudadCliente.Name = "TBCiudadCliente";
            this.TBCiudadCliente.Size = new System.Drawing.Size(340, 30);
            this.TBCiudadCliente.TabIndex = 20;
            this.TBCiudadCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCiudadCliente_Validating);
            // 
            // TBProvinciaCliente
            // 
            this.TBProvinciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProvinciaCliente.Location = new System.Drawing.Point(21, 154);
            this.TBProvinciaCliente.MaxLength = 50;
            this.TBProvinciaCliente.Name = "TBProvinciaCliente";
            this.TBProvinciaCliente.Size = new System.Drawing.Size(383, 30);
            this.TBProvinciaCliente.TabIndex = 19;
            this.TBProvinciaCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBProvinciaCliente_Validating);
            // 
            // LCiudadCliente
            // 
            this.LCiudadCliente.AutoSize = true;
            this.LCiudadCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudadCliente.ForeColor = System.Drawing.Color.Black;
            this.LCiudadCliente.Location = new System.Drawing.Point(410, 128);
            this.LCiudadCliente.Name = "LCiudadCliente";
            this.LCiudadCliente.Size = new System.Drawing.Size(82, 23);
            this.LCiudadCliente.TabIndex = 18;
            this.LCiudadCliente.Text = "Ciudad";
            // 
            // LProvinviaCliente
            // 
            this.LProvinviaCliente.AutoSize = true;
            this.LProvinviaCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvinviaCliente.ForeColor = System.Drawing.Color.Black;
            this.LProvinviaCliente.Location = new System.Drawing.Point(17, 128);
            this.LProvinviaCliente.Name = "LProvinviaCliente";
            this.LProvinviaCliente.Size = new System.Drawing.Size(118, 23);
            this.LProvinviaCliente.TabIndex = 17;
            this.LProvinviaCliente.Text = "Provincia";
            // 
            // TBDniCliente
            // 
            this.TBDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniCliente.Location = new System.Drawing.Point(21, 95);
            this.TBDniCliente.MaxLength = 8;
            this.TBDniCliente.Name = "TBDniCliente";
            this.TBDniCliente.Size = new System.Drawing.Size(729, 30);
            this.TBDniCliente.TabIndex = 16;
            this.TBDniCliente.TextChanged += new System.EventHandler(this.TBDniCliente_TextChanged);
            this.TBDniCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDniCliente_Validating);
            this.TBDniCliente.Validated += new System.EventHandler(this.TBDniCliente_TextChanged);
            // 
            // LDniCliente
            // 
            this.LDniCliente.AutoSize = true;
            this.LDniCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDniCliente.ForeColor = System.Drawing.Color.Black;
            this.LDniCliente.Location = new System.Drawing.Point(17, 69);
            this.LDniCliente.Name = "LDniCliente";
            this.LDniCliente.Size = new System.Drawing.Size(46, 23);
            this.LDniCliente.TabIndex = 15;
            this.LDniCliente.Text = "DNI";
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.Location = new System.Drawing.Point(21, 36);
            this.TBNombreCliente.MaxLength = 200;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(729, 30);
            this.TBNombreCliente.TabIndex = 14;
            this.TBNombreCliente.TextChanged += new System.EventHandler(this.TBNombreCliente_TextChanged);
            this.TBNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombreCliente_Validating);
            this.TBNombreCliente.Validated += new System.EventHandler(this.TBNombreCliente_TextChanged);
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.LNombreCliente.Location = new System.Drawing.Point(17, 10);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(202, 23);
            this.LNombreCliente.TabIndex = 11;
            this.LNombreCliente.Text = "Nombre completo ";
            // 
            // agregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PAgregarClienteFondo);
            this.Name = "agregarCliente";
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.agregarCliente_Load);
            this.PAgregarClienteFondo.ResumeLayout(false);
            this.PAgregarCliente.ResumeLayout(false);
            this.PAgregarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAgregarClienteFondo;
        private System.Windows.Forms.Panel PAgregarCliente;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.TextBox TBNombreCliente;
        private System.Windows.Forms.TextBox TBProvinciaCliente;
        private System.Windows.Forms.Label LCiudadCliente;
        private System.Windows.Forms.Label LProvinviaCliente;
        private System.Windows.Forms.TextBox TBDniCliente;
        private System.Windows.Forms.Label LDniCliente;
        private System.Windows.Forms.TextBox TBCiudadCliente;
        private System.Windows.Forms.TextBox TBNumCliente;
        private System.Windows.Forms.Label LTelefonoCliente;
        private System.Windows.Forms.TextBox TBDomicilioCliente;
        private System.Windows.Forms.Label LDomicilioCliente;
        private System.Windows.Forms.Button BAgregarCliente;
        public System.Windows.Forms.Label LAgregarCliente;
        private System.Windows.Forms.Label LCorreoCliente;
        private System.Windows.Forms.TextBox TBCorreoCliente;
    }
}