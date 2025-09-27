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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PAgregarProducto = new System.Windows.Forms.Panel();
            this.LCorreoCliente = new System.Windows.Forms.Label();
            this.LNumCliente = new System.Windows.Forms.Label();
            this.TBCorreoCliente = new System.Windows.Forms.TextBox();
            this.TBNumCliente = new System.Windows.Forms.TextBox();
            this.LDomicilioCliente = new System.Windows.Forms.Label();
            this.TBDomicilioCliente = new System.Windows.Forms.TextBox();
            this.DTFechaModifProd = new System.Windows.Forms.DateTimePicker();
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
            this.LAgregarCliente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PAgregarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LAgregarCliente);
            this.panel1.Controls.Add(this.PAgregarProducto);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 451);
            this.panel1.TabIndex = 0;
            // 
            // PAgregarProducto
            // 
            this.PAgregarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.PAgregarProducto.Controls.Add(this.LCorreoCliente);
            this.PAgregarProducto.Controls.Add(this.LNumCliente);
            this.PAgregarProducto.Controls.Add(this.TBCorreoCliente);
            this.PAgregarProducto.Controls.Add(this.TBNumCliente);
            this.PAgregarProducto.Controls.Add(this.LDomicilioCliente);
            this.PAgregarProducto.Controls.Add(this.TBDomicilioCliente);
            this.PAgregarProducto.Controls.Add(this.DTFechaModifProd);
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
            this.PAgregarProducto.Location = new System.Drawing.Point(10, 56);
            this.PAgregarProducto.Name = "PAgregarProducto";
            this.PAgregarProducto.Size = new System.Drawing.Size(773, 377);
            this.PAgregarProducto.TabIndex = 2;
            this.PAgregarProducto.Paint += new System.Windows.Forms.PaintEventHandler(this.PAgregarProducto_Paint);
            // 
            // LCorreoCliente
            // 
            this.LCorreoCliente.AutoSize = true;
            this.LCorreoCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoCliente.ForeColor = System.Drawing.Color.Black;
            this.LCorreoCliente.Location = new System.Drawing.Point(379, 199);
            this.LCorreoCliente.Name = "LCorreoCliente";
            this.LCorreoCliente.Size = new System.Drawing.Size(82, 23);
            this.LCorreoCliente.TabIndex = 41;
            this.LCorreoCliente.Text = "Correo";
            // 
            // LNumCliente
            // 
            this.LNumCliente.AutoSize = true;
            this.LNumCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNumCliente.ForeColor = System.Drawing.Color.Black;
            this.LNumCliente.Location = new System.Drawing.Point(17, 199);
            this.LNumCliente.Name = "LNumCliente";
            this.LNumCliente.Size = new System.Drawing.Size(82, 23);
            this.LNumCliente.TabIndex = 40;
            this.LNumCliente.Text = "Numero";
            // 
            // TBCorreoCliente
            // 
            this.TBCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreoCliente.Location = new System.Drawing.Point(383, 225);
            this.TBCorreoCliente.MaxLength = 100;
            this.TBCorreoCliente.Name = "TBCorreoCliente";
            this.TBCorreoCliente.Size = new System.Drawing.Size(353, 30);
            this.TBCorreoCliente.TabIndex = 39;
            this.TBCorreoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCorreoCliente_Validating);
            // 
            // TBNumCliente
            // 
            this.TBNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumCliente.Location = new System.Drawing.Point(10, 225);
            this.TBNumCliente.MaxLength = 100;
            this.TBNumCliente.Name = "TBNumCliente";
            this.TBNumCliente.Size = new System.Drawing.Size(342, 30);
            this.TBNumCliente.TabIndex = 38;
            this.TBNumCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBNumCliente_Validating);
            // 
            // LDomicilioCliente
            // 
            this.LDomicilioCliente.AutoSize = true;
            this.LDomicilioCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDomicilioCliente.ForeColor = System.Drawing.Color.Black;
            this.LDomicilioCliente.Location = new System.Drawing.Point(3, 129);
            this.LDomicilioCliente.Name = "LDomicilioCliente";
            this.LDomicilioCliente.Size = new System.Drawing.Size(118, 23);
            this.LDomicilioCliente.TabIndex = 37;
            this.LDomicilioCliente.Text = "Domicilio";
            // 
            // TBDomicilioCliente
            // 
            this.TBDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDomicilioCliente.Location = new System.Drawing.Point(10, 155);
            this.TBDomicilioCliente.MaxLength = 100;
            this.TBDomicilioCliente.Name = "TBDomicilioCliente";
            this.TBDomicilioCliente.Size = new System.Drawing.Size(715, 30);
            this.TBDomicilioCliente.TabIndex = 36;
            // 
            // DTFechaModifProd
            // 
            this.DTFechaModifProd.Location = new System.Drawing.Point(10, 284);
            this.DTFechaModifProd.Name = "DTFechaModifProd";
            this.DTFechaModifProd.Size = new System.Drawing.Size(451, 22);
            this.DTFechaModifProd.TabIndex = 35;
            // 
            // LFechaModificacionCliente
            // 
            this.LFechaModificacionCliente.AutoSize = true;
            this.LFechaModificacionCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaModificacionCliente.ForeColor = System.Drawing.Color.Black;
            this.LFechaModificacionCliente.Location = new System.Drawing.Point(17, 258);
            this.LFechaModificacionCliente.Name = "LFechaModificacionCliente";
            this.LFechaModificacionCliente.Size = new System.Drawing.Size(226, 23);
            this.LFechaModificacionCliente.TabIndex = 30;
            this.LFechaModificacionCliente.Text = "Fecha Modificacion";
            // 
            // BAgregarCliente
            // 
            this.BAgregarCliente.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarCliente.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.BAgregarCliente.Location = new System.Drawing.Point(545, 275);
            this.BAgregarCliente.Name = "BAgregarCliente";
            this.BAgregarCliente.Size = new System.Drawing.Size(191, 40);
            this.BAgregarCliente.TabIndex = 25;
            this.BAgregarCliente.Text = "Agregar Cliente";
            this.BAgregarCliente.UseVisualStyleBackColor = false;
            this.BAgregarCliente.Click += new System.EventHandler(this.BAgregarCliente_Click_1);
            // 
            // TBCiudadCliente
            // 
            this.TBCiudadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudadCliente.Location = new System.Drawing.Point(370, 96);
            this.TBCiudadCliente.MaxLength = 10;
            this.TBCiudadCliente.Name = "TBCiudadCliente";
            this.TBCiudadCliente.Size = new System.Drawing.Size(353, 30);
            this.TBCiudadCliente.TabIndex = 24;
            this.TBCiudadCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBCiudadCliente_Validating);
            // 
            // TBProvinciaCliente
            // 
            this.TBProvinciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBProvinciaCliente.Location = new System.Drawing.Point(10, 96);
            this.TBProvinciaCliente.MaxLength = 8;
            this.TBProvinciaCliente.Name = "TBProvinciaCliente";
            this.TBProvinciaCliente.Size = new System.Drawing.Size(330, 30);
            this.TBProvinciaCliente.TabIndex = 20;
            this.TBProvinciaCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBProvinciaCliente_Validating);
            // 
            // LCiudadCliente
            // 
            this.LCiudadCliente.AutoSize = true;
            this.LCiudadCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudadCliente.ForeColor = System.Drawing.Color.Black;
            this.LCiudadCliente.Location = new System.Drawing.Point(397, 70);
            this.LCiudadCliente.Name = "LCiudadCliente";
            this.LCiudadCliente.Size = new System.Drawing.Size(94, 23);
            this.LCiudadCliente.TabIndex = 18;
            this.LCiudadCliente.Text = "Ciudad ";
            // 
            // LProvinviaCliente
            // 
            this.LProvinviaCliente.AutoSize = true;
            this.LProvinviaCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvinviaCliente.ForeColor = System.Drawing.Color.Black;
            this.LProvinviaCliente.Location = new System.Drawing.Point(3, 70);
            this.LProvinviaCliente.Name = "LProvinviaCliente";
            this.LProvinviaCliente.Size = new System.Drawing.Size(118, 23);
            this.LProvinviaCliente.TabIndex = 17;
            this.LProvinviaCliente.Text = "Provincia";
            // 
            // TBDniCliente
            // 
            this.TBDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniCliente.Location = new System.Drawing.Point(442, 37);
            this.TBDniCliente.MaxLength = 200;
            this.TBDniCliente.Name = "TBDniCliente";
            this.TBDniCliente.Size = new System.Drawing.Size(328, 30);
            this.TBDniCliente.TabIndex = 16;
            this.TBDniCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBDniCliente_Validating);
            // 
            // LDescripcionProducto
            // 
            this.LDescripcionProducto.AutoSize = true;
            this.LDescripcionProducto.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.LDescripcionProducto.Location = new System.Drawing.Point(459, 11);
            this.LDescripcionProducto.Name = "LDescripcionProducto";
            this.LDescripcionProducto.Size = new System.Drawing.Size(46, 23);
            this.LDescripcionProducto.TabIndex = 15;
            this.LDescripcionProducto.Text = "DNI";
            // 
            // TBNombreCliente
            // 
            this.TBNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreCliente.Location = new System.Drawing.Point(7, 37);
            this.TBNombreCliente.MaxLength = 100;
            this.TBNombreCliente.Name = "TBNombreCliente";
            this.TBNombreCliente.Size = new System.Drawing.Size(429, 30);
            this.TBNombreCliente.TabIndex = 14;
            this.TBNombreCliente.TextChanged += new System.EventHandler(this.TBNombreCliente_TextChanged_1);
            this.TBNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TBNombreCliente_Validating);
            // 
            // LNombreCliente
            // 
            this.LNombreCliente.AutoSize = true;
            this.LNombreCliente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.LNombreCliente.Location = new System.Drawing.Point(3, 11);
            this.LNombreCliente.Name = "LNombreCliente";
            this.LNombreCliente.Size = new System.Drawing.Size(178, 23);
            this.LNombreCliente.TabIndex = 11;
            this.LNombreCliente.Text = "Nombre Cliente";
            // 
            // LAgregarCliente
            // 
            this.LAgregarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LAgregarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarCliente.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAgregarCliente.Location = new System.Drawing.Point(12, 9);
            this.LAgregarCliente.Name = "LAgregarCliente";
            this.LAgregarCliente.Padding = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.LAgregarCliente.Size = new System.Drawing.Size(771, 44);
            this.LAgregarCliente.TabIndex = 42;
            this.LAgregarCliente.Text = "AGREGAR CLIENTE";
            this.LAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agregarDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "agregarDatosCliente";
            this.Text = "agregarDatosCliente";
            this.Load += new System.EventHandler(this.agregarDatosCliente_Load);
            this.panel1.ResumeLayout(false);
            this.PAgregarProducto.ResumeLayout(false);
            this.PAgregarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PAgregarProducto;
        private System.Windows.Forms.DateTimePicker DTFechaModifProd;
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
        public System.Windows.Forms.Label LAgregarCliente;
    }
}