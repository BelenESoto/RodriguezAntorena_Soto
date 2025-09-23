namespace Antorena_Soto.CPresentacion.SuperAdministrador
{
    partial class listaUsuarios
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
            this.DGVListaVendedor = new System.Windows.Forms.DataGridView();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.LListaUsuario = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).BeginInit();
            this.PGerente2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVListaVendedor
            // 
            this.DGVListaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGVListaVendedor.Location = new System.Drawing.Point(12, 64);
            this.DGVListaVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaVendedor.Name = "DGVListaVendedor";
            this.DGVListaVendedor.RowHeadersWidth = 51;
            this.DGVListaVendedor.RowTemplate.Height = 24;
            this.DGVListaVendedor.Size = new System.Drawing.Size(552, 257);
            this.DGVListaVendedor.TabIndex = 0;
            this.DGVListaVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaVendedor_CellContentClick);
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.Controls.Add(this.LListaUsuario);
            this.PGerente2.Controls.Add(this.DGVListaVendedor);
            this.PGerente2.Location = new System.Drawing.Point(0, 0);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(573, 391);
            this.PGerente2.TabIndex = 5;
            // 
            // LListaUsuario
            // 
            this.LListaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LListaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.LListaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LListaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LListaUsuario.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LListaUsuario.Location = new System.Drawing.Point(12, 10);
            this.LListaUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LListaUsuario.Name = "LListaUsuario";
            this.LListaUsuario.Size = new System.Drawing.Size(552, 39);
            this.LListaUsuario.TabIndex = 5;
            this.LListaUsuario.Text = "LISTA DE USUARIOS";
            this.LListaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // listaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.PGerente2);
            this.Name = "listaUsuarios";
            this.Text = "listaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).EndInit();
            this.PGerente2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListaVendedor;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.Label LListaUsuario;
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
    }
}