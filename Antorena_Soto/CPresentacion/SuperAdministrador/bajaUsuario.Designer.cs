namespace Antorena_Soto.CPresentacion.SuperAdministrador
{
    partial class bajaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bajaUsuario));
            this.TBuscador = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.BTSDni = new System.Windows.Forms.ToolStripMenuItem();
            this.BTSNomYApe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.BTSBusqueda = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LDatosBajaUs = new System.Windows.Forms.Label();
            this.DGVListaUsuario = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BBorrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.TBuscador.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaUsuario)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBuscador
            // 
            this.TBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBuscador.AutoSize = false;
            this.TBuscador.Dock = System.Windows.Forms.DockStyle.None;
            this.TBuscador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPor,
            this.toolStripSeparator1,
            this.LBuscarPor,
            this.TBBuscador,
            this.BTSBusqueda});
            this.TBuscador.Location = new System.Drawing.Point(0, 100);
            this.TBuscador.Name = "TBuscador";
            this.TBuscador.Size = new System.Drawing.Size(773, 103);
            this.TBuscador.TabIndex = 5;
            this.TBuscador.Text = "toolStrip1";
            this.TBuscador.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTSDni,
            this.BTSNomYApe});
            this.BBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(135, 100);
            this.BBuscarPor.Text = "BUSCAR POR";
            this.BBuscarPor.ButtonClick += new System.EventHandler(this.BBuscarPor_ButtonClick);
            // 
            // BTSDni
            // 
            this.BTSDni.Name = "BTSDni";
            this.BTSDni.Size = new System.Drawing.Size(247, 28);
            this.BTSDni.Text = "DNI";
            this.BTSDni.Click += new System.EventHandler(this.BTSDni_Click);
            // 
            // BTSNomYApe
            // 
            this.BTSNomYApe.Name = "BTSNomYApe";
            this.BTSNomYApe.Size = new System.Drawing.Size(247, 28);
            this.BTSNomYApe.Text = "Apellido y Nombre";
            this.BTSNomYApe.Click += new System.EventHandler(this.BTSNomyApe_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 103);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(0, 100);
            // 
            // TBBuscador
            // 
            this.TBBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(367, 103);
            this.TBBuscador.Click += new System.EventHandler(this.TBuscadorAdmin_Click);
            // 
            // BTSBusqueda
            // 
            this.BTSBusqueda.AutoSize = false;
            this.BTSBusqueda.BackColor = System.Drawing.Color.White;
            this.BTSBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("BTSBusqueda.Image")));
            this.BTSBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTSBusqueda.Name = "BTSBusqueda";
            this.BTSBusqueda.Size = new System.Drawing.Size(70, 50);
            this.BTSBusqueda.Text = "Buscar";
            this.BTSBusqueda.Click += new System.EventHandler(this.BTSBusqueda_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.LDatosBajaUs);
            this.panel1.Controls.Add(this.DGVListaUsuario);
            this.panel1.Controls.Add(this.BBorrar);
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 502);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LDatosBajaUs
            // 
            this.LDatosBajaUs.BackColor = System.Drawing.Color.White;
            this.LDatosBajaUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LDatosBajaUs.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosBajaUs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LDatosBajaUs.Location = new System.Drawing.Point(3, 58);
            this.LDatosBajaUs.Name = "LDatosBajaUs";
            this.LDatosBajaUs.Size = new System.Drawing.Size(762, 78);
            this.LDatosBajaUs.TabIndex = 10;
            this.LDatosBajaUs.Text = "DATOS USUARIO";
            this.LDatosBajaUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVListaUsuario
            // 
            this.DGVListaUsuario.BackgroundColor = System.Drawing.Color.Lavender;
            this.DGVListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Provincia,
            this.Ciudad,
            this.Domicilio,
            this.Tel,
            this.Correo,
            this.FechaNac,
            this.Cuit,
            this.FechaIng,
            this.TipoUsuario,
            this.Estado});
            this.DGVListaUsuario.Location = new System.Drawing.Point(0, 140);
            this.DGVListaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListaUsuario.Name = "DGVListaUsuario";
            this.DGVListaUsuario.RowHeadersWidth = 51;
            this.DGVListaUsuario.RowTemplate.Height = 24;
            this.DGVListaUsuario.Size = new System.Drawing.Size(765, 107);
            this.DGVListaUsuario.TabIndex = 9;
            this.DGVListaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaUsuario_CellContentClick);
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "id_dni_usuario";
            this.Dni.HeaderText = "Dni";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nomYApe_usuario";
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 6;
            this.Provincia.Name = "Provincia";
            this.Provincia.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 125;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 125;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "telefono";
            this.Tel.HeaderText = "Telefono";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.Width = 125;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "fecha_nacimiento";
            this.FechaNac.HeaderText = "Edad";
            this.FechaNac.MinimumWidth = 6;
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Width = 125;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.MinimumWidth = 6;
            this.Cuit.Name = "Cuit";
            this.Cuit.Width = 125;
            // 
            // FechaIng
            // 
            this.FechaIng.DataPropertyName = "fecha_ingreso";
            this.FechaIng.HeaderText = "Fecha Ingreso";
            this.FechaIng.MinimumWidth = 6;
            this.FechaIng.Name = "FechaIng";
            this.FechaIng.Width = 125;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.DataPropertyName = "tipo_Usuario";
            this.TipoUsuario.HeaderText = "Tipo Usuario";
            this.TipoUsuario.MinimumWidth = 6;
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // BBorrar
            // 
            this.BBorrar.BackColor = System.Drawing.Color.White;
            this.BBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBorrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BBorrar.Location = new System.Drawing.Point(279, 310);
            this.BBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(220, 84);
            this.BBorrar.TabIndex = 8;
            this.BBorrar.Text = "ELIMINAR";
            this.BBorrar.UseVisualStyleBackColor = false;
            this.BBorrar.Click += new System.EventHandler(this.BBorrar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.LAgregarventas);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.TBuscador);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 750);
            this.panel2.TabIndex = 7;
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
            this.LAgregarventas.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.LAgregarventas.Size = new System.Drawing.Size(793, 97);
            this.LAgregarventas.TabIndex = 13;
            this.LAgregarventas.Text = "BAJA USUARIO";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(772, 702);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bajaUsuario";
            this.Text = "bajaUsuario";
            this.Load += new System.EventHandler(this.bajaUsuario_Load_1);
            this.Click += new System.EventHandler(this.bajaUsuario_Load);
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TBuscador;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TBBuscador;
        private System.Windows.Forms.ToolStripButton BTSBusqueda;
        private System.Windows.Forms.ToolStripMenuItem BTSDni;
        private System.Windows.Forms.ToolStripMenuItem BTSNomYApe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVListaUsuario;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.Label LDatosBajaUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}