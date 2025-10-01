namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class listaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaClientes));
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.BBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.BDniCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.BApellidoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBBuscarPorCliente = new System.Windows.Forms.ToolStripTextBox();
            this.DGVListaCliente = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.LDatosBajaUs = new System.Windows.Forms.Label();
            this.PGerente2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Lavender;
            this.PGerente2.Controls.Add(this.LDatosBajaUs);
            this.PGerente2.Controls.Add(this.LAgregarventas);
            this.PGerente2.Controls.Add(this.BBuscarCliente);
            this.PGerente2.Controls.Add(this.toolStrip1);
            this.PGerente2.Controls.Add(this.DGVListaCliente);
            this.PGerente2.Location = new System.Drawing.Point(0, 1);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.MinimumSize = new System.Drawing.Size(563, 352);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(595, 609);
            this.PGerente2.TabIndex = 5;
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.BBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.BBuscarCliente.IconSize = 30;
            this.BBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBuscarCliente.Location = new System.Drawing.Point(470, 114);
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(97, 38);
            this.BBuscarCliente.TabIndex = 11;
            this.BBuscarCliente.Text = "BUSCAR";
            this.BBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBuscarCliente.UseVisualStyleBackColor = false;
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPor,
            this.toolStripSeparator1,
            this.TBBuscarPorCliente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 98);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 71);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BDniCliente,
            this.BApellidoCliente});
            this.BBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(97, 68);
            this.BBuscarPor.Text = "BUSCAR POR";
            this.BBuscarPor.ToolTipText = "BUSCAR POR";
            this.BBuscarPor.ButtonClick += new System.EventHandler(this.BBuscarPor_ButtonClick);
            // 
            // BDniCliente
            // 
            this.BDniCliente.Name = "BDniCliente";
            this.BDniCliente.Size = new System.Drawing.Size(180, 22);
            this.BDniCliente.Text = "DNI";
            // 
            // BApellidoCliente
            // 
            this.BApellidoCliente.Name = "BApellidoCliente";
            this.BApellidoCliente.Size = new System.Drawing.Size(180, 22);
            this.BApellidoCliente.Text = "Apellido";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // TBBuscarPorCliente
            // 
            this.TBBuscarPorCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarPorCliente.Name = "TBBuscarPorCliente";
            this.TBBuscarPorCliente.Size = new System.Drawing.Size(367, 71);
            this.TBBuscarPorCliente.Click += new System.EventHandler(this.TBBuscarPorCliente_Click);
            // 
            // DGVListaCliente
            // 
            this.DGVListaCliente.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DGVListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Dni,
            this.Cuit,
            this.Provincia,
            this.Ciudad,
            this.Domicilio,
            this.Telefono,
            this.Correo,
            this.FechaIng});
            this.DGVListaCliente.Location = new System.Drawing.Point(2, 229);
            this.DGVListaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaCliente.Name = "DGVListaCliente";
            this.DGVListaCliente.RowHeadersWidth = 51;
            this.DGVListaCliente.RowTemplate.Height = 24;
            this.DGVListaCliente.Size = new System.Drawing.Size(575, 104);
            this.DGVListaCliente.TabIndex = 0;
            this.DGVListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaCliente_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.Width = 125;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // FechaIng
            // 
            this.FechaIng.DataPropertyName = "FechaIng";
            this.FechaIng.HeaderText = "Fecha Ingreso";
            this.FechaIng.MinimumWidth = 6;
            this.FechaIng.Name = "FechaIng";
            this.FechaIng.Width = 125;
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
            this.LAgregarventas.Size = new System.Drawing.Size(595, 98);
            this.LAgregarventas.TabIndex = 14;
            this.LAgregarventas.Text = " INFORMACIÓN CLIENTE";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LDatosBajaUs
            // 
            this.LDatosBajaUs.BackColor = System.Drawing.Color.White;
            this.LDatosBajaUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LDatosBajaUs.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosBajaUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LDatosBajaUs.Location = new System.Drawing.Point(0, 182);
            this.LDatosBajaUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDatosBajaUs.Name = "LDatosBajaUs";
            this.LDatosBajaUs.Size = new System.Drawing.Size(577, 45);
            this.LDatosBajaUs.TabIndex = 15;
            this.LDatosBajaUs.Text = "DATOS CLIENTE";
            this.LDatosBajaUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 570);
            this.Controls.Add(this.PGerente2);
            this.Name = "listaClientes";
            this.Text = "listaClientes";
            this.PGerente2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.DataGridView DGVListaCliente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem BDniCliente;
        private System.Windows.Forms.ToolStripMenuItem BApellidoCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarPorCliente;
        private FontAwesome.Sharp.IconButton BBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.Label LDatosBajaUs;
    }
}