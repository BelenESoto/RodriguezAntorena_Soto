namespace Antorena_Soto.CPresentacion.SuperAdministrador
{
    partial class listaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LAgregarventas = new System.Windows.Forms.Label();
            this.BTListaUsuario = new System.Windows.Forms.Button();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.DGVListaUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTSBusquedaUs = new FontAwesome.Sharp.IconButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.BBuscarDni = new System.Windows.Forms.ToolStripMenuItem();
            this.BBuscarApe = new System.Windows.Forms.ToolStripMenuItem();
            this.BBuscarEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBBuscarr = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            this.PGerente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LAgregarventas);
            this.panel1.Controls.Add(this.BTListaUsuario);
            this.panel1.Controls.Add(this.PGerente2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 609);
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
            this.LAgregarventas.Size = new System.Drawing.Size(595, 79);
            this.LAgregarventas.TabIndex = 13;
            this.LAgregarventas.Text = "LISTA USUARIOS";
            this.LAgregarventas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTListaUsuario
            // 
            this.BTListaUsuario.Location = new System.Drawing.Point(-177, 110);
            this.BTListaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.BTListaUsuario.Name = "BTListaUsuario";
            this.BTListaUsuario.Size = new System.Drawing.Size(164, 27);
            this.BTListaUsuario.TabIndex = 5;
            this.BTListaUsuario.Text = "Lista de Ususarios";
            this.BTListaUsuario.UseVisualStyleBackColor = true;
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Lavender;
            this.PGerente2.Controls.Add(this.DGVListaUsuarios);
            this.PGerente2.Controls.Add(this.BTSBusquedaUs);
            this.PGerente2.Controls.Add(this.toolStrip1);
            this.PGerente2.Location = new System.Drawing.Point(2, 81);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(586, 500);
            this.PGerente2.TabIndex = 7;
            // 
            // DGVListaUsuarios
            // 
            this.DGVListaUsuarios.BackgroundColor = System.Drawing.Color.Lavender;
            this.DGVListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Provincia,
            this.Ciudad,
            this.Domicilio,
            this.Tel,
            this.dataGridViewTextBoxColumn3,
            this.FechaNac,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Estado});
            this.DGVListaUsuarios.Location = new System.Drawing.Point(3, 95);
            this.DGVListaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaUsuarios.Name = "DGVListaUsuarios";
            this.DGVListaUsuarios.RowHeadersWidth = 51;
            this.DGVListaUsuarios.RowTemplate.Height = 24;
            this.DGVListaUsuarios.Size = new System.Drawing.Size(574, 218);
            this.DGVListaUsuarios.TabIndex = 10;
            this.DGVListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaUsuarios_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_dni_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomYApe_usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre y Apellido";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "fecha_nacimiento";
            this.FechaNac.HeaderText = "Edad";
            this.FechaNac.MinimumWidth = 6;
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cuit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cuit";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_ingreso";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Ingreso";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tipo_Usuario";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tipo Usuario";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // BTSBusquedaUs
            // 
            this.BTSBusquedaUs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusquedaUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusquedaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusquedaUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTSBusquedaUs.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusquedaUs.IconColor = System.Drawing.Color.Black;
            this.BTSBusquedaUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusquedaUs.IconSize = 36;
            this.BTSBusquedaUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusquedaUs.Location = new System.Drawing.Point(451, 27);
            this.BTSBusquedaUs.Name = "BTSBusquedaUs";
            this.BTSBusquedaUs.Size = new System.Drawing.Size(116, 35);
            this.BTSBusquedaUs.TabIndex = 8;
            this.BTSBusquedaUs.Text = "Buscar";
            this.BTSBusquedaUs.UseVisualStyleBackColor = false;
            this.BTSBusquedaUs.Click += new System.EventHandler(this.BTSBusquedaUs_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPor,
            this.toolStripSeparator1,
            this.TBBuscarr});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 78);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarDni,
            this.BBuscarApe,
            this.BBuscarEstado});
            this.BBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(103, 75);
            this.BBuscarPor.Text = "BUSCAR POR";
            this.BBuscarPor.ToolTipText = "BUSCAR POR";
            // 
            // BBuscarDni
            // 
            this.BBuscarDni.Name = "BBuscarDni";
            this.BBuscarDni.Size = new System.Drawing.Size(180, 22);
            this.BBuscarDni.Text = "DNI";
            this.BBuscarDni.Click += new System.EventHandler(this.BBuscarDni_Click);
            // 
            // BBuscarApe
            // 
            this.BBuscarApe.Name = "BBuscarApe";
            this.BBuscarApe.Size = new System.Drawing.Size(180, 22);
            this.BBuscarApe.Text = "Apellido";
            this.BBuscarApe.Click += new System.EventHandler(this.BBuscarApe_Click);
            // 
            // BBuscarEstado
            // 
            this.BBuscarEstado.Name = "BBuscarEstado";
            this.BBuscarEstado.Size = new System.Drawing.Size(180, 22);
            this.BBuscarEstado.Text = "Estado";
            this.BBuscarEstado.Click += new System.EventHandler(this.BBuscarEstado_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 78);
            // 
            // TBBuscarr
            // 
            this.TBBuscarr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarr.Name = "TBBuscarr";
            this.TBBuscarr.Size = new System.Drawing.Size(367, 78);
            // 
            // listaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 570);
            this.Controls.Add(this.panel1);
            this.Name = "listaUsuario";
            this.Text = "listaUsuario";
            this.Load += new System.EventHandler(this.listaUsuario_Load_1);
            this.Click += new System.EventHandler(this.listaUsuario_Load_1);
            this.panel1.ResumeLayout(false);
            this.PGerente2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTListaUsuario;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem BBuscarDni;
        private System.Windows.Forms.ToolStripMenuItem BBuscarApe;
        private System.Windows.Forms.ToolStripMenuItem BBuscarEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TBBuscarr;
        private FontAwesome.Sharp.IconButton BTSBusquedaUs;
        public System.Windows.Forms.Label LAgregarventas;
        private System.Windows.Forms.DataGridView DGVListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}