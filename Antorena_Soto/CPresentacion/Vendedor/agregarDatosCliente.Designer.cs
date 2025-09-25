namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class agregarDatosCliente
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
            this.PAgregarVendedor = new System.Windows.Forms.Panel();
            this.DTFechaIngCliente = new System.Windows.Forms.DateTimePicker();
            this.DTFechaNacCliente = new System.Windows.Forms.DateTimePicker();
            this.LFechaNacCliente = new System.Windows.Forms.Label();
            this.LFechaIngresoCliente = new System.Windows.Forms.Label();
            this.TBCorreoCliente = new System.Windows.Forms.TextBox();
            this.LCorreoVendedor = new System.Windows.Forms.Label();
            this.BAgregarCliente = new System.Windows.Forms.Button();
            this.TBNumCliente = new System.Windows.Forms.TextBox();
            this.LTelefonoCliente = new System.Windows.Forms.Label();
            this.TBDomicilioCliente = new System.Windows.Forms.TextBox();
            this.LDomicilioCliente = new System.Windows.Forms.Label();
            this.TBCiudadCliente = new System.Windows.Forms.TextBox();
            this.TBProvinciaCliente = new System.Windows.Forms.TextBox();
            this.LCiudadVendedor = new System.Windows.Forms.Label();
            this.LProvinviaVendedor = new System.Windows.Forms.Label();
            this.TBDniCliente = new System.Windows.Forms.TextBox();
            this.LDniCliente = new System.Windows.Forms.Label();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.PAgregarClienteFondo.SuspendLayout();
            this.PAgregarVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PAgregarClienteFondo
            // 
            this.PAgregarClienteFondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PAgregarClienteFondo.Controls.Add(this.LAgregarCliente);
            this.PAgregarClienteFondo.Controls.Add(this.PAgregarVendedor);
            this.PAgregarClienteFondo.Location = new System.Drawing.Point(-13, 0);
            this.PAgregarClienteFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PAgregarClienteFondo.Name = "PAgregarClienteFondo";
            this.PAgregarClienteFondo.Size = new System.Drawing.Size(801, 450);
            this.PAgregarClienteFondo.TabIndex = 2;
            // 
            // LAgregarCliente
            // 
            this.LAgregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarCliente.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarCliente.Location = new System.Drawing.Point(5, 9);
            this.LAgregarCliente.Name = "LAgregarCliente";
            this.LAgregarCliente.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.LAgregarCliente.Size = new System.Drawing.Size(767, 34);
            this.LAgregarCliente.TabIndex = 2;
            this.LAgregarCliente.Text = "AGREGAR CLIENTE";
            this.LAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAgregarVendedor
            // 
            this.PAgregarVendedor.BackColor = System.Drawing.Color.Gainsboro;
            this.PAgregarVendedor.Controls.Add(this.DTFechaIngCliente);
            this.PAgregarVendedor.Controls.Add(this.DTFechaNacCliente);
            this.PAgregarVendedor.Controls.Add(this.LFechaNacCliente);
            this.PAgregarVendedor.Controls.Add(this.LFechaIngresoCliente);
            this.PAgregarVendedor.Controls.Add(this.TBCorreoCliente);
            this.PAgregarVendedor.Controls.Add(this.LCorreoVendedor);
            this.PAgregarVendedor.Controls.Add(this.BAgregarCliente);
            this.PAgregarVendedor.Controls.Add(this.TBNumCliente);
            this.PAgregarVendedor.Controls.Add(this.LTelefonoCliente);
            this.PAgregarVendedor.Controls.Add(this.TBDomicilioCliente);
            this.PAgregarVendedor.Controls.Add(this.LDomicilioCliente);
            this.PAgregarVendedor.Controls.Add(this.TBCiudadCliente);
            this.PAgregarVendedor.Controls.Add(this.TBProvinciaCliente);
            this.PAgregarVendedor.Controls.Add(this.LCiudadVendedor);
            this.PAgregarVendedor.Controls.Add(this.LProvinviaVendedor);
            this.PAgregarVendedor.Controls.Add(this.TBDniCliente);
            this.PAgregarVendedor.Controls.Add(this.LDniCliente);
            this.PAgregarVendedor.Controls.Add(this.TBNombreCliente);
            this.PAgregarVendedor.Controls.Add(this.LNombreCliente);
            this.PAgregarVendedor.Location = new System.Drawing.Point(3, 47);
            this.PAgregarVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PAgregarVendedor.Name = "PAgregarVendedor";
            this.PAgregarVendedor.Size = new System.Drawing.Size(769, 423);
            this.PAgregarVendedor.TabIndex = 1;
            // 
            // DTFechaIngCliente
            // 
            this.DTFechaIngCliente.Location = new System.Drawing.Point(22, 348);
            this.DTFechaIngCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTFechaIngCliente.Name = "DTFechaIngCliente";
            this.DTFechaIngCliente.Size = new System.Drawing.Size(363, 22);
            this.DTFechaIngCliente.TabIndex = 35;
            this.DTFechaIngCliente.ValueChanged += new System.EventHandler(this.DTFechaIngCliente_ValueChanged);
            this.DTFechaIngCliente.Validating += new System.ComponentModel.CancelEventHandler(this.DTFechaIngCliente_Validating);
            // 
            // DTFechaNacCliente
            // 
            this.DTFechaNacCliente.Location = new System.Drawing.Point(388, 93);
            this.DTFechaNacCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTFechaNacCliente.Name = "DTFechaNacCliente";
            this.DTFechaNacCliente.Size = new System.Drawing.Size(360, 22);
            this.DTFechaNacCliente.TabIndex = 34;
            this.DTFechaNacCliente.Validating += new System.ComponentModel.CancelEventHandler(this.DTFechaNacCliente_Validating);
            // 
            // LFechaNacCliente
            // 
            this.LFechaNacCliente.AutoSize = true;
            this.LFechaNacCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNacCliente.ForeColor = System.Drawing.Color.Black;
            this.LFechaNacCliente.Location = new System.Drawing.Point(401, 68);
            this.LFechaNacCliente.Name = "LFechaNacCliente";
            this.LFechaNacCliente.Size = new System.Drawing.Size(202, 23);
            this.LFechaNacCliente.TabIndex = 32;
            this.LFechaNacCliente.Text = "Fecha Nacimiento";
            // 
            // LFechaIngresoCliente
            // 
            this.LFechaIngresoCliente.AutoSize = true;
            this.LFechaIngresoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaIngresoCliente.ForeColor = System.Drawing.Color.Black;
            this.LFechaIngresoCliente.Location = new System.Drawing.Point(22, 323);
            this.LFechaIngresoCliente.Name = "LFechaIngresoCliente";
            this.LFechaIngresoCliente.Size = new System.Drawing.Size(130, 23);
            this.LFechaIngresoCliente.TabIndex = 30;
            this.LFechaIngresoCliente.Text = "Fecha Alta";
            // 
            // TBCorreoCliente
            // 
            this.TBCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreoCliente.Location = new System.Drawing.Point(392, 276);
            this.TBCorreoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCorreoCliente.MaxLength = 100;
            this.TBCorreoCliente.Name = "TBCorreoCliente";
            this.TBCorreoCliente.Size = new System.Drawing.Size(362, 30);
            this.TBCorreoCliente.TabIndex = 27;
            this.TBCorreoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDomicilioCliente_Validating);
            // 
            // LCorreoVendedor
            // 
            this.LCorreoVendedor.AutoSize = true;
            this.LCorreoVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoVendedor.ForeColor = System.Drawing.Color.Black;
            this.LCorreoVendedor.Location = new System.Drawing.Point(401, 247);
            this.LCorreoVendedor.Name = "LCorreoVendedor";
            this.LCorreoVendedor.Size = new System.Drawing.Size(94, 23);
            this.LCorreoVendedor.TabIndex = 26;
            this.LCorreoVendedor.Text = "Correo ";
            // 
            // BAgregarCliente
            // 
            this.BAgregarCliente.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarCliente.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.BAgregarCliente.Location = new System.Drawing.Point(514, 340);
            this.BAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAgregarCliente.Name = "BAgregarCliente";
            this.BAgregarCliente.Size = new System.Drawing.Size(191, 39);
            this.BAgregarCliente.TabIndex = 25;
            this.BAgregarCliente.Text = "Agregar Cliente";
            this.BAgregarCliente.UseVisualStyleBackColor = false;
            this.BAgregarCliente.Click += new System.EventHandler(this.BAgregarCliente_Click);
            // 
            // TBNumCliente
            // 
            this.TBNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumCliente.Location = new System.Drawing.Point(20, 276);
            this.TBNumCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNumCliente.MaxLength = 10;
            this.TBNumCliente.Name = "TBNumCliente";
            this.TBNumCliente.Size = new System.Drawing.Size(362, 30);
            this.TBNumCliente.TabIndex = 24;
            this.TBNumCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDomicilioCliente_Validating);
            // 
            // LTelefonoCliente
            // 
            this.LTelefonoCliente.AutoSize = true;
            this.LTelefonoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoCliente.Location = new System.Drawing.Point(22, 251);
            this.LTelefonoCliente.Name = "LTelefonoCliente";
            this.LTelefonoCliente.Size = new System.Drawing.Size(214, 23);
            this.LTelefonoCliente.TabIndex = 23;
            this.LTelefonoCliente.Text = "Numero Telefonico";
            // 
            // TBDomicilioCliente
            // 
            this.TBDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDomicilioCliente.Location = new System.Drawing.Point(22, 219);
            this.TBDomicilioCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDomicilioCliente.MaxLength = 200;
            this.TBDomicilioCliente.Name = "TBDomicilioCliente";
            this.TBDomicilioCliente.Size = new System.Drawing.Size(732, 30);
            this.TBDomicilioCliente.TabIndex = 22;
            this.TBDomicilioCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDomicilioCliente_Validating);
            // 
            // LDomicilioCliente
            // 
            this.LDomicilioCliente.AutoSize = true;
            this.LDomicilioCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilioCliente.ForeColor = System.Drawing.Color.Black;
            this.LDomicilioCliente.Location = new System.Drawing.Point(22, 194);
            this.LDomicilioCliente.Name = "LDomicilioCliente";
            this.LDomicilioCliente.Size = new System.Drawing.Size(118, 23);
            this.LDomicilioCliente.TabIndex = 21;
            this.LDomicilioCliente.Text = "Domicilio";
            // 
            // TBCiudadCliente
            // 
            this.TBCiudadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudadCliente.Location = new System.Drawing.Point(391, 162);
            this.TBCiudadCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCiudadCliente.MaxLength = 100;
            this.TBCiudadCliente.Name = "TBCiudadCliente";
            this.TBCiudadCliente.Size = new System.Drawing.Size(363, 30);
            this.TBCiudadCliente.TabIndex = 20;
            this.TBCiudadCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCiudadCliente_Validating);
            // 
            // TBProvinciaCliente
            // 
            this.TBProvinciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProvinciaCliente.Location = new System.Drawing.Point(26, 162);
            this.TBProvinciaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBProvinciaCliente.MaxLength = 100;
            this.TBProvinciaCliente.Name = "TBProvinciaCliente";
            this.TBProvinciaCliente.Size = new System.Drawing.Size(360, 30);
            this.TBProvinciaCliente.TabIndex = 19;
            this.TBProvinciaCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBProvinciaCliente_Validating);
            // 
            // LCiudadVendedor
            // 
            this.LCiudadVendedor.AutoSize = true;
            this.LCiudadVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudadVendedor.ForeColor = System.Drawing.Color.Black;
            this.LCiudadVendedor.Location = new System.Drawing.Point(387, 137);
            this.LCiudadVendedor.Name = "LCiudadVendedor";
            this.LCiudadVendedor.Size = new System.Drawing.Size(82, 23);
            this.LCiudadVendedor.TabIndex = 18;
            this.LCiudadVendedor.Text = "Ciudad";
            // 
            // LProvinviaVendedor
            // 
            this.LProvinviaVendedor.AutoSize = true;
            this.LProvinviaVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvinviaVendedor.ForeColor = System.Drawing.Color.Black;
            this.LProvinviaVendedor.Location = new System.Drawing.Point(22, 137);
            this.LProvinviaVendedor.Name = "LProvinviaVendedor";
            this.LProvinviaVendedor.Size = new System.Drawing.Size(118, 23);
            this.LProvinviaVendedor.TabIndex = 17;
            this.LProvinviaVendedor.Text = "Provincia";
            // 
            // TBDniCliente
            // 
            this.TBDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniCliente.Location = new System.Drawing.Point(22, 93);
            this.TBDniCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDniCliente.MaxLength = 8;
            this.TBDniCliente.Name = "TBDniCliente";
            this.TBDniCliente.Size = new System.Drawing.Size(360, 30);
            this.TBDniCliente.TabIndex = 16;
            this.TBDniCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDniCliente_Validating);
            // 
            // LDniCliente
            // 
            this.LDniCliente.AutoSize = true;
            this.LDniCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDniCliente.ForeColor = System.Drawing.Color.Black;
            this.LDniCliente.Location = new System.Drawing.Point(22, 68);
            this.LDniCliente.Name = "LDniCliente";
            this.LDniCliente.Size = new System.Drawing.Size(46, 23);
            this.LDniCliente.TabIndex = 15;
            this.LDniCliente.Text = "DNI";
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.Location = new System.Drawing.Point(21, 36);
            this.TBNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombreCliente.MaxLength = 100;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(726, 30);
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
            this.LNombreCliente.Size = new System.Drawing.Size(226, 23);
            this.LNombreCliente.TabIndex = 11;
            this.LNombreCliente.Text = "Nombre del Cliente";
            // 
            // agregarDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.PAgregarClienteFondo);
            this.Name = "agregarDatosCliente";
            this.Text = "agregarDatosCliente";
            this.PAgregarClienteFondo.ResumeLayout(false);
            this.PAgregarVendedor.ResumeLayout(false);
            this.PAgregarVendedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAgregarClienteFondo;
        public System.Windows.Forms.Label LAgregarCliente;
        private System.Windows.Forms.Panel PAgregarVendedor;
        private System.Windows.Forms.DateTimePicker DTFechaIngCliente;
        private System.Windows.Forms.DateTimePicker DTFechaNacCliente;
        private System.Windows.Forms.Label LFechaNacCliente;
        private System.Windows.Forms.Label LFechaIngresoCliente;
        private System.Windows.Forms.TextBox TBCorreoCliente;
        private System.Windows.Forms.Label LCorreoVendedor;
        private System.Windows.Forms.Button BAgregarCliente;
        private System.Windows.Forms.TextBox TBNumCliente;
        private System.Windows.Forms.Label LTelefonoCliente;
        private System.Windows.Forms.TextBox TBDomicilioCliente;
        private System.Windows.Forms.Label LDomicilioCliente;
        private System.Windows.Forms.TextBox TBCiudadCliente;
        private System.Windows.Forms.TextBox TBProvinciaCliente;
        private System.Windows.Forms.Label LCiudadVendedor;
        private System.Windows.Forms.Label LProvinviaVendedor;
        private System.Windows.Forms.TextBox TBDniCliente;
        private System.Windows.Forms.Label LDniCliente;
        private System.Windows.Forms.TextBox TBNombreCliente;
        private System.Windows.Forms.Label LNombreCliente;
    }
}