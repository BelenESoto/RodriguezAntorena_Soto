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
            this.BTListaUsuario = new System.Windows.Forms.Button();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.DGVListaVendedor = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.bUSCARPORToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BTSBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.PGerente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LListaUsuarios);
            this.panel1.Controls.Add(this.BTListaUsuario);
            this.panel1.Controls.Add(this.PGerente2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 455);
            this.panel1.TabIndex = 0;
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
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.Controls.Add(this.BTSBusquedaCliente);
            this.PGerente2.Controls.Add(this.DGVListaVendedor);
            this.PGerente2.Controls.Add(this.toolStrip1);
            this.PGerente2.Location = new System.Drawing.Point(12, 51);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(586, 352);
            this.PGerente2.TabIndex = 7;
            // 
            // LListaUsuarios
            // 
            this.LListaUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LListaUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.LListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LListaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LListaUsuarios.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LListaUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LListaUsuarios.Location = new System.Drawing.Point(12, 4);
            this.LListaUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Size = new System.Drawing.Size(586, 45);
            this.LListaUsuarios.TabIndex = 9;
            this.LListaUsuarios.Text = "LISTA DE USUARIOS";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVListaVendedor
            // 
            this.DGVListaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cuit,
            this.Correo,
            this.TipoUsuario,
            this.Dni,
            this.FechaIng});
            this.DGVListaVendedor.Location = new System.Drawing.Point(15, 60);
            this.DGVListaVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaVendedor.Name = "DGVListaVendedor";
            this.DGVListaVendedor.RowHeadersWidth = 51;
            this.DGVListaVendedor.RowTemplate.Height = 24;
            this.DGVListaVendedor.Size = new System.Drawing.Size(564, 279);
            this.DGVListaVendedor.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo Usuario";
            this.TipoUsuario.Name = "TipoUsuario";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.Width = 125;
            // 
            // FechaIng
            // 
            this.FechaIng.HeaderText = "Fecha Ingreso";
            this.FechaIng.MinimumWidth = 6;
            this.FechaIng.Name = "FechaIng";
            this.FechaIng.Width = 125;
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
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(13, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARPORToolStripMenuItem1,
            this.apellidoToolStripMenuItem1,
            this.tipoUsuarioToolStripMenuItem});
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(93, 36);
            this.BBuscarPor.Text = "BUSCAR POR";
            this.BBuscarPor.ToolTipText = "BUSCAR POR";
            // 
            // bUSCARPORToolStripMenuItem1
            // 
            this.bUSCARPORToolStripMenuItem1.Name = "bUSCARPORToolStripMenuItem1";
            this.bUSCARPORToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bUSCARPORToolStripMenuItem1.Text = "DNI";
            // 
            // apellidoToolStripMenuItem1
            // 
            this.apellidoToolStripMenuItem1.Name = "apellidoToolStripMenuItem1";
            this.apellidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.apellidoToolStripMenuItem1.Text = "Apellido";
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(367, 39);
            // 
            // BTSBusquedaCliente
            // 
            this.BTSBusquedaCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusquedaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTSBusquedaCliente.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusquedaCliente.IconColor = System.Drawing.Color.Black;
            this.BTSBusquedaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusquedaCliente.IconSize = 36;
            this.BTSBusquedaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusquedaCliente.Location = new System.Drawing.Point(462, 12);
            this.BTSBusquedaCliente.Name = "BTSBusquedaCliente";
            this.BTSBusquedaCliente.Size = new System.Drawing.Size(116, 35);
            this.BTSBusquedaCliente.TabIndex = 8;
            this.BTSBusquedaCliente.Text = "Buscar";
            this.BTSBusquedaCliente.UseVisualStyleBackColor = false;
            // 
            // listaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel1);
            this.Name = "listaUsuario";
            this.Text = "listaUsuario";
            this.panel1.ResumeLayout(false);
            this.PGerente2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LListaUsuarios;
        private System.Windows.Forms.Button BTListaUsuario;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.DataGridView DGVListaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem bUSCARPORToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconButton BTSBusquedaCliente;
    }
}