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
            this.LBajaUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.BBorrar = new System.Windows.Forms.Button();
            this.LDatosBajaUs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTSBusqueda = new FontAwesome.Sharp.IconButton();
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
            this.TBBuscador});
            this.TBuscador.Location = new System.Drawing.Point(0, 50);
            this.TBuscador.Name = "TBuscador";
            this.TBuscador.Size = new System.Drawing.Size(572, 39);
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
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(93, 36);
            this.BBuscarPor.Text = "BUSCAR POR";
            // 
            // BTSDni
            // 
            this.BTSDni.Name = "BTSDni";
            this.BTSDni.Size = new System.Drawing.Size(174, 22);
            this.BTSDni.Text = "DNI";
            this.BTSDni.Click += new System.EventHandler(this.BTSDni_Click_1);
            // 
            // BTSNomYApe
            // 
            this.BTSNomYApe.Name = "BTSNomYApe";
            this.BTSNomYApe.Size = new System.Drawing.Size(174, 22);
            this.BTSNomYApe.Text = "Apellido y Nombre";
            this.BTSNomYApe.Click += new System.EventHandler(this.BTSNomYApe_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(0, 36);
            // 
            // TBBuscador
            // 
            this.TBBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(276, 39);
            this.TBBuscador.Click += new System.EventHandler(this.TBBuscador_Click);
            // 
            // LBajaUsuario
            // 
            this.LBajaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBajaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.LBajaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBajaUsuario.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBajaUsuario.Location = new System.Drawing.Point(0, 0);
            this.LBajaUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBajaUsuario.Name = "LBajaUsuario";
            this.LBajaUsuario.Size = new System.Drawing.Size(573, 48);
            this.LBajaUsuario.TabIndex = 4;
            this.LBajaUsuario.Text = "BAJA DE USUARIO";
            this.LBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.DGVListaUsuario);
            this.panel1.Controls.Add(this.BBorrar);
            this.panel1.Controls.Add(this.LDatosBajaUs);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 290);
            this.panel1.TabIndex = 6;
            // 
            // DGVListaUsuario
            // 
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
            this.TipoUsuario});
            this.DGVListaUsuario.Location = new System.Drawing.Point(9, 30);
            this.DGVListaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaUsuario.Name = "DGVListaUsuario";
            this.DGVListaUsuario.RowHeadersWidth = 51;
            this.DGVListaUsuario.RowTemplate.Height = 24;
            this.DGVListaUsuario.Size = new System.Drawing.Size(552, 73);
            this.DGVListaUsuario.TabIndex = 9;
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
            this.Provincia.Name = "Provincia";
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "telefono";
            this.Tel.HeaderText = "Telefono";
            this.Tel.Name = "Tel";
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
            this.FechaNac.Name = "FechaNac";
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
            // BBorrar
            // 
            this.BBorrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BBorrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrar.Location = new System.Drawing.Point(194, 135);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(159, 43);
            this.BBorrar.TabIndex = 8;
            this.BBorrar.Text = "ELIMINAR";
            this.BBorrar.UseVisualStyleBackColor = false;
            this.BBorrar.Click += new System.EventHandler(this.BBorrar_Click_1);
            // 
            // LDatosBajaUs
            // 
            this.LDatosBajaUs.AutoSize = true;
            this.LDatosBajaUs.BackColor = System.Drawing.Color.LightGray;
            this.LDatosBajaUs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosBajaUs.Location = new System.Drawing.Point(9, 10);
            this.LDatosBajaUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDatosBajaUs.Name = "LDatosBajaUs";
            this.LDatosBajaUs.Size = new System.Drawing.Size(182, 18);
            this.LDatosBajaUs.TabIndex = 6;
            this.LDatosBajaUs.Text = "DATOS DEL USUARIO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTSBusqueda);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.TBuscador);
            this.panel2.Controls.Add(this.LBajaUsuario);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 389);
            this.panel2.TabIndex = 7;
            // 
            // BTSBusqueda
            // 
            this.BTSBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusqueda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTSBusqueda.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusqueda.IconColor = System.Drawing.Color.Black;
            this.BTSBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusqueda.IconSize = 36;
            this.BTSBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusqueda.Location = new System.Drawing.Point(388, 51);
            this.BTSBusqueda.Name = "BTSBusqueda";
            this.BTSBusqueda.Size = new System.Drawing.Size(125, 35);
            this.BTSBusqueda.TabIndex = 7;
            this.BTSBusqueda.Text = "Buscar";
            this.BTSBusqueda.UseVisualStyleBackColor = false;
            this.BTSBusqueda.Click += new System.EventHandler(this.BTSBusqueda_Click);
            // 
            // bajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(583, 384);
            this.Controls.Add(this.panel2);
            this.Name = "bajaUsuario";
            this.Text = "bajaUsuario";
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TBuscador;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TBBuscador;
        private System.Windows.Forms.Label LBajaUsuario;
        private System.Windows.Forms.ToolStripMenuItem BTSDni;
        private System.Windows.Forms.ToolStripMenuItem BTSNomYApe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.Label LDatosBajaUs;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVListaUsuario;
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
        private FontAwesome.Sharp.IconButton BTSBusqueda;
    }
}