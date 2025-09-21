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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.LBajaUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BBorrar = new System.Windows.Forms.Button();
            this.DGVListaVendedor = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDatosBajaUs = new System.Windows.Forms.Label();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.dNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoYNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TBuscador.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).BeginInit();
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
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.TBuscador.Location = new System.Drawing.Point(3, 62);
            this.TBuscador.Name = "TBuscador";
            this.TBuscador.Size = new System.Drawing.Size(674, 48);
            this.TBuscador.TabIndex = 5;
            this.TBuscador.Text = "toolStrip1";
            this.TBuscador.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(0, 45);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(367, 48);
            // 
            // LBajaUsuario
            // 
            this.LBajaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBajaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.LBajaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBajaUsuario.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBajaUsuario.Location = new System.Drawing.Point(3, 11);
            this.LBajaUsuario.Name = "LBajaUsuario";
            this.LBajaUsuario.Size = new System.Drawing.Size(674, 48);
            this.LBajaUsuario.TabIndex = 4;
            this.LBajaUsuario.Text = "BAJA DE USUARIO";
            this.LBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.BBorrar);
            this.panel1.Controls.Add(this.DGVListaVendedor);
            this.panel1.Controls.Add(this.LDatosBajaUs);
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 356);
            this.panel1.TabIndex = 6;
            // 
            // BBorrar
            // 
            this.BBorrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BBorrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBorrar.Location = new System.Drawing.Point(211, 149);
            this.BBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(212, 53);
            this.BBorrar.TabIndex = 8;
            this.BBorrar.Text = "ELIMINAR";
            this.BBorrar.UseVisualStyleBackColor = false;
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
            this.DGVListaVendedor.Location = new System.Drawing.Point(7, 42);
            this.DGVListaVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListaVendedor.Name = "DGVListaVendedor";
            this.DGVListaVendedor.RowHeadersWidth = 51;
            this.DGVListaVendedor.RowTemplate.Height = 24;
            this.DGVListaVendedor.Size = new System.Drawing.Size(651, 76);
            this.DGVListaVendedor.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.MinimumWidth = 6;
            this.Cuit.Name = "Cuit";
            this.Cuit.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo Usuario";
            this.TipoUsuario.MinimumWidth = 6;
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Width = 125;
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
            // LDatosBajaUs
            // 
            this.LDatosBajaUs.AutoSize = true;
            this.LDatosBajaUs.BackColor = System.Drawing.Color.LightGray;
            this.LDatosBajaUs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosBajaUs.Location = new System.Drawing.Point(12, 12);
            this.LDatosBajaUs.Name = "LDatosBajaUs";
            this.LDatosBajaUs.Size = new System.Drawing.Size(231, 25);
            this.LDatosBajaUs.TabIndex = 6;
            this.LDatosBajaUs.Text = "DATOS DEL USUARIO";
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dNIToolStripMenuItem,
            this.apellidoYNombreToolStripMenuItem});
            this.BBuscarPor.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarPor.Image")));
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(135, 45);
            this.BBuscarPor.Text = "BUSCAR POR";
            // 
            // dNIToolStripMenuItem
            // 
            this.dNIToolStripMenuItem.Name = "dNIToolStripMenuItem";
            this.dNIToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.dNIToolStripMenuItem.Text = "DNI";
            // 
            // apellidoYNombreToolStripMenuItem
            // 
            this.apellidoYNombreToolStripMenuItem.Name = "apellidoYNombreToolStripMenuItem";
            this.apellidoYNombreToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.apellidoYNombreToolStripMenuItem.Text = "Apellido y Nombre";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // bajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(680, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBuscador);
            this.Controls.Add(this.LBajaUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bajaUsuario";
            this.Text = "bajaUsuario";
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TBuscador;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label LBajaUsuario;
        private System.Windows.Forms.ToolStripMenuItem dNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoYNombreToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.Label LDatosBajaUs;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.DataGridView DGVListaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
    }
}