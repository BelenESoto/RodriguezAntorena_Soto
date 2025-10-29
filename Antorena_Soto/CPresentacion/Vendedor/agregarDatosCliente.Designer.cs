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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarDatosCliente));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.PAgregarProducto = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LCuitVendedor = new System.Windows.Forms.Label();
            this.TBCuitCliente = new System.Windows.Forms.TextBox();
            this.LCorreoCliente = new System.Windows.Forms.Label();
            this.LNumCliente = new System.Windows.Forms.Label();
            this.TBCorreoCliente = new System.Windows.Forms.TextBox();
            this.TBNumCliente = new System.Windows.Forms.TextBox();
            this.LDomicilioCliente = new System.Windows.Forms.Label();
            this.TBDomicilioCliente = new System.Windows.Forms.TextBox();
            this.DTFechaModifCliente = new System.Windows.Forms.DateTimePicker();
            this.LFechaModificacionCliente = new System.Windows.Forms.Label();
            this.BAgregarCliente = new System.Windows.Forms.Button();
            this.TBCiudadCliente = new System.Windows.Forms.TextBox();
            this.TBProvinciaCliente = new System.Windows.Forms.TextBox();
            this.LCiudadCliente = new System.Windows.Forms.Label();
            this.LProvinviaCliente = new System.Windows.Forms.Label();
            this.TBDniCliente = new System.Windows.Forms.TextBox();
            this.LDescripcionProducto = new System.Windows.Forms.Label();
            this.TBNombreCliente = new System.Windows.Forms.TextBox();
            this.LNombreCliente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LAgregarventas);
            this.panel1.Controls.Add(this.PAgregarProducto);
            this.panel1.Location = new System.Drawing.Point(-9, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 585);
            this.panel1.TabIndex = 0;
            // 
            // LAgregarventas
            // 
            this.LAgregarventas.BackColor = System.Drawing.Color.MidnightBlue;
            this.LAgregarventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.LAgregarventas.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarventas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LAgregarventas.Image = ((System.Drawing.Image)(resources.GetObject("LAgregarventas.Image")));
            this.LAgregarventas.Location = new System.Drawing.Point(0, 0);
            this.LAgregarventas.Margin = new System.Windows.Forms.Padding(0);
            this.LAgregarventas.Name = "LAgregarventas";
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.LAgregarventas.Size = new System.Drawing.Size(605, 79);
            this.LAgregarventas.TabIndex = 13;
            this.LAgregarventas.Text = "AGREGAR CLIENTE";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LAgregarventas.Click += new System.EventHandler(this.LAgregarventas_Click);
            // 
            // PAgregarProducto
            // 
            this.PAgregarProducto.BackColor = System.Drawing.Color.Lavender;
            this.PAgregarProducto.Controls.Add(this.pictureBox1);
            this.PAgregarProducto.Controls.Add(this.LCuitVendedor);
            this.PAgregarProducto.Controls.Add(this.TBCuitCliente);
            this.PAgregarProducto.Controls.Add(this.LCorreoCliente);
            this.PAgregarProducto.Controls.Add(this.LNumCliente);
            this.PAgregarProducto.Controls.Add(this.TBCorreoCliente);
            this.PAgregarProducto.Controls.Add(this.TBNumCliente);
            this.PAgregarProducto.Controls.Add(this.LDomicilioCliente);
            this.PAgregarProducto.Controls.Add(this.TBDomicilioCliente);
            this.PAgregarProducto.Controls.Add(this.DTFechaModifCliente);
            this.PAgregarProducto.Controls.Add(this.LFechaModificacionCliente);
            this.PAgregarProducto.Controls.Add(this.BAgregarCliente);
            this.PAgregarProducto.Controls.Add(this.TBCiudadCliente);
            this.PAgregarProducto.Controls.Add(this.TBProvinciaCliente);
            this.PAgregarProducto.Controls.Add(this.LCiudadCliente);
            this.PAgregarProducto.Controls.Add(this.LProvinviaCliente);
            this.PAgregarProducto.Controls.Add(this.TBDniCliente);
            this.PAgregarProducto.Controls.Add(this.LDescripcionProducto);
            this.PAgregarProducto.Controls.Add(this.TBNombreCliente);
            this.PAgregarProducto.Controls.Add(this.LNombreCliente);
            this.PAgregarProducto.Location = new System.Drawing.Point(2, 75);
            this.PAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.PAgregarProducto.Name = "PAgregarProducto";
            this.PAgregarProducto.Size = new System.Drawing.Size(595, 609);
            this.PAgregarProducto.TabIndex = 2;
            this.PAgregarProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarProducto_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(395, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 41);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // LCuitVendedor
            // 
            this.LCuitVendedor.AutoSize = true;
            this.LCuitVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCuitVendedor.ForeColor = System.Drawing.Color.Black;
            this.LCuitVendedor.Location = new System.Drawing.Point(304, 190);
            this.LCuitVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCuitVendedor.Name = "LCuitVendedor";
            this.LCuitVendedor.Size = new System.Drawing.Size(49, 19);
            this.LCuitVendedor.TabIndex = 50;
            this.LCuitVendedor.Text = "CUIT";
            // 
            // TBCuitCliente
            // 
            this.TBCuitCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCuitCliente.Location = new System.Drawing.Point(302, 213);
            this.TBCuitCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBCuitCliente.MaxLength = 11;
            this.TBCuitCliente.Name = "TBCuitCliente";
            this.TBCuitCliente.Size = new System.Drawing.Size(202, 26);
            this.TBCuitCliente.TabIndex = 51;
            this.TBCuitCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCuitCliente_Validating);
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCliente.ForeColor = System.Drawing.Color.Black;
            this.LCorreoCliente.Location = new System.Drawing.Point(303, 271);
            this.LCorreoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(69, 19);
            this.LCorreoCliente.TabIndex = 41;
            this.LCorreoCliente.Text = "Correo";
            // 
            // LNumCliente
            // 
            this.LNumCliente.AutoSize = true;
            this.LNumCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNumCliente.ForeColor = System.Drawing.Color.Black;
            this.LNumCliente.Location = new System.Drawing.Point(23, 272);
            this.LNumCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNumCliente.Name = "LNumCliente";
            this.LNumCliente.Size = new System.Drawing.Size(69, 19);
            this.LNumCliente.TabIndex = 40;
            this.LNumCliente.Text = "Numero";
            // 
            // TBCorreoCliente
            // 
            this.TBCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreoCliente.Location = new System.Drawing.Point(302, 294);
            this.TBCorreoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBCorreoCliente.MaxLength = 100;
            this.TBCorreoCliente.Name = "TBCorreoCliente";
            this.TBCorreoCliente.Size = new System.Drawing.Size(266, 26);
            this.TBCorreoCliente.TabIndex = 39;
            this.TBCorreoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCorreoCliente_Validating);
            // 
            // TBNumCliente
            // 
            this.TBNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumCliente.Location = new System.Drawing.Point(23, 294);
            this.TBNumCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBNumCliente.MaxLength = 100;
            this.TBNumCliente.Name = "TBNumCliente";
            this.TBNumCliente.Size = new System.Drawing.Size(258, 26);
            this.TBNumCliente.TabIndex = 38;
            this.TBNumCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBNumCliente_Validating);
            // 
            // LDomicilioCliente
            // 
            this.LDomicilioCliente.AutoSize = true;
            this.LDomicilioCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilioCliente.ForeColor = System.Drawing.Color.Black;
            this.LDomicilioCliente.Location = new System.Drawing.Point(23, 191);
            this.LDomicilioCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDomicilioCliente.Name = "LDomicilioCliente";
            this.LDomicilioCliente.Size = new System.Drawing.Size(99, 19);
            this.LDomicilioCliente.TabIndex = 37;
            this.LDomicilioCliente.Text = "Domicilio";
            // 
            // TBDomicilioCliente
            // 
            this.TBDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDomicilioCliente.Location = new System.Drawing.Point(23, 213);
            this.TBDomicilioCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBDomicilioCliente.MaxLength = 100;
            this.TBDomicilioCliente.Name = "TBDomicilioCliente";
            this.TBDomicilioCliente.Size = new System.Drawing.Size(258, 26);
            this.TBDomicilioCliente.TabIndex = 36;
            // 
            // DTFechaModifCliente
            // 
            this.DTFechaModifCliente.Location = new System.Drawing.Point(23, 390);
            this.DTFechaModifCliente.Margin = new System.Windows.Forms.Padding(2);
            this.DTFechaModifCliente.Name = "DTFechaModifCliente";
            this.DTFechaModifCliente.Size = new System.Drawing.Size(339, 20);
            this.DTFechaModifCliente.TabIndex = 35;
            // 
            // LFechaModificacionCliente
            // 
            this.LFechaModificacionCliente.AutoSize = true;
            this.LFechaModificacionCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaModificacionCliente.ForeColor = System.Drawing.Color.Black;
            this.LFechaModificacionCliente.Location = new System.Drawing.Point(23, 352);
            this.LFechaModificacionCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFechaModificacionCliente.Name = "LFechaModificacionCliente";
            this.LFechaModificacionCliente.Size = new System.Drawing.Size(189, 19);
            this.LFechaModificacionCliente.TabIndex = 30;
            this.LFechaModificacionCliente.Text = "Fecha Modificacion";
            // 
            // BAgregarCliente
            // 
            this.BAgregarCliente.BackColor = System.Drawing.Color.White;
            this.BAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BAgregarCliente.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BAgregarCliente.Location = new System.Drawing.Point(389, 371);
            this.BAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.BAgregarCliente.Name = "BAgregarCliente";
            this.BAgregarCliente.Size = new System.Drawing.Size(169, 58);
            this.BAgregarCliente.TabIndex = 25;
            this.BAgregarCliente.Text = "Agregar Cliente";
            this.BAgregarCliente.UseVisualStyleBackColor = false;
            this.BAgregarCliente.Click += new System.EventHandler(this.BAgregarCliente_Click_1);
            // 
            // TBCiudadCliente
            // 
            this.TBCiudadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudadCliente.Location = new System.Drawing.Point(302, 137);
            this.TBCiudadCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBCiudadCliente.MaxLength = 10;
            this.TBCiudadCliente.Name = "TBCiudadCliente";
            this.TBCiudadCliente.Size = new System.Drawing.Size(233, 26);
            this.TBCiudadCliente.TabIndex = 24;
            this.TBCiudadCliente.TextChanged += new System.EventHandler(this.TBCiudadCliente_TextChanged);
            this.TBCiudadCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCiudadCliente_Validating);
            // 
            // TBProvinciaCliente
            // 
            this.TBProvinciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProvinciaCliente.Location = new System.Drawing.Point(23, 137);
            this.TBProvinciaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBProvinciaCliente.MaxLength = 8;
            this.TBProvinciaCliente.Name = "TBProvinciaCliente";
            this.TBProvinciaCliente.Size = new System.Drawing.Size(248, 26);
            this.TBProvinciaCliente.TabIndex = 20;
            this.TBProvinciaCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBProvinciaCliente_Validating);
            // 
            // LCiudadCliente
            // 
            this.LCiudadCliente.AutoSize = true;
            this.LCiudadCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudadCliente.ForeColor = System.Drawing.Color.Black;
            this.LCiudadCliente.Location = new System.Drawing.Point(303, 114);
            this.LCiudadCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCiudadCliente.Name = "LCiudadCliente";
            this.LCiudadCliente.Size = new System.Drawing.Size(79, 19);
            this.LCiudadCliente.TabIndex = 18;
            this.LCiudadCliente.Text = "Ciudad ";
            // 
            // LProvinviaCliente
            // 
            this.LProvinviaCliente.AutoSize = true;
            this.LProvinviaCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvinviaCliente.ForeColor = System.Drawing.Color.Black;
            this.LProvinviaCliente.Location = new System.Drawing.Point(24, 114);
            this.LProvinviaCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LProvinviaCliente.Name = "LProvinviaCliente";
            this.LProvinviaCliente.Size = new System.Drawing.Size(99, 19);
            this.LProvinviaCliente.TabIndex = 17;
            this.LProvinviaCliente.Text = "Provincia";
            // 
            // TBDniCliente
            // 
            this.TBDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniCliente.Location = new System.Drawing.Point(302, 60);
            this.TBDniCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBDniCliente.MaxLength = 200;
            this.TBDniCliente.Name = "TBDniCliente";
            this.TBDniCliente.Size = new System.Drawing.Size(247, 26);
            this.TBDniCliente.TabIndex = 16;
            this.TBDniCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDniCliente_Validating);
            // 
            // LDescripcionProducto
            // 
            this.LDescripcionProducto.AutoSize = true;
            this.LDescripcionProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProducto.Location = new System.Drawing.Point(306, 34);
            this.LDescripcionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDescripcionProducto.Name = "LDescripcionProducto";
            this.LDescripcionProducto.Size = new System.Drawing.Size(39, 19);
            this.LDescripcionProducto.TabIndex = 15;
            this.LDescripcionProducto.Text = "DNI";
            this.LDescripcionProducto.Click += new System.EventHandler(this.LDescripcionProducto_Click);
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.Location = new System.Drawing.Point(23, 60);
            this.TBNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TBNombreCliente.MaxLength = 100;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(261, 26);
            this.TBNombreCliente.TabIndex = 14;
            this.TBNombreCliente.TextChanged += new System.EventHandler(this.TBNombreCliente_TextChanged_1);
            this.TBNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombreCliente_Validating);
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.LNombreCliente.Location = new System.Drawing.Point(23, 36);
            this.LNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(149, 19);
            this.LNombreCliente.TabIndex = 11;
            this.LNombreCliente.Text = "Nombre Cliente";
            // 
            // agregarDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(579, 570);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "agregarDatosCliente";
            this.Text = "agregarDatosCliente";
            this.Load += new System.EventHandler(this.agregarDatosCliente_Load);
            this.panel1.ResumeLayout(false);
            this.PAgregarProducto.ResumeLayout(false);
            this.PAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PAgregarProducto;
        private System.Windows.Forms.DateTimePicker DTFechaModifCliente;
        private System.Windows.Forms.Label LFechaModificacionCliente;
        private System.Windows.Forms.Button BAgregarCliente;
        private System.Windows.Forms.TextBox TBCiudadCliente;
        private System.Windows.Forms.TextBox TBProvinciaCliente;
        private System.Windows.Forms.Label LCiudadCliente;
        private System.Windows.Forms.Label LProvinviaCliente;
        private System.Windows.Forms.TextBox TBDniCliente;
        private System.Windows.Forms.Label LDescripcionProducto;
        private System.Windows.Forms.TextBox TBNombreCliente;
        private System.Windows.Forms.Label LNombreCliente;
        private System.Windows.Forms.Label LDomicilioCliente;
        private System.Windows.Forms.TextBox TBDomicilioCliente;
        private System.Windows.Forms.TextBox TBCorreoCliente;
        private System.Windows.Forms.TextBox TBNumCliente;
        private System.Windows.Forms.Label LCorreoCliente;
        private System.Windows.Forms.Label LNumCliente;
        private System.Windows.Forms.Label LCuitVendedor;
        private System.Windows.Forms.TextBox TBCuitCliente;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}