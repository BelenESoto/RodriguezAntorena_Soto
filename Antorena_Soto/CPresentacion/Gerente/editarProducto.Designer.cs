namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class editarProducto
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
            this.pEditarProd = new System.Windows.Forms.Panel();
            this.BEliminarProd = new System.Windows.Forms.Button();
            this.BEditarProd = new System.Windows.Forms.Button();
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDatosBajaProd = new System.Windows.Forms.Label();
            this.LBajaProducto = new System.Windows.Forms.Label();
            this.TBuscador = new System.Windows.Forms.ToolStrip();
            this.BBuscarPorEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.codToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBEditarProd = new System.Windows.Forms.ToolStripTextBox();
            this.pcontenedorEditarProd = new System.Windows.Forms.Panel();
            this.pEditarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.TBuscador.SuspendLayout();
            this.pcontenedorEditarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pEditarProd
            // 
            this.pEditarProd.BackColor = System.Drawing.Color.Gainsboro;
            this.pEditarProd.Controls.Add(this.BEliminarProd);
            this.pEditarProd.Controls.Add(this.BEditarProd);
            this.pEditarProd.Controls.Add(this.DGVListaProd);
            this.pEditarProd.Controls.Add(this.LDatosBajaProd);
            this.pEditarProd.Location = new System.Drawing.Point(7, 121);
            this.pEditarProd.Margin = new System.Windows.Forms.Padding(4);
            this.pEditarProd.Name = "pEditarProd";
            this.pEditarProd.Size = new System.Drawing.Size(745, 375);
            this.pEditarProd.TabIndex = 7;
            // 
            // BEliminarProd
            // 
            this.BEliminarProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BEliminarProd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminarProd.Location = new System.Drawing.Point(373, 247);
            this.BEliminarProd.Margin = new System.Windows.Forms.Padding(4);
            this.BEliminarProd.Name = "BEliminarProd";
            this.BEliminarProd.Size = new System.Drawing.Size(158, 53);
            this.BEliminarProd.TabIndex = 9;
            this.BEliminarProd.Text = "ELIMINAR";
            this.BEliminarProd.UseVisualStyleBackColor = false;
            this.BEliminarProd.Click += new System.EventHandler(this.BEliminarProd_Click_1);
            // 
            // BEditarProd
            // 
            this.BEditarProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BEditarProd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarProd.Location = new System.Drawing.Point(191, 247);
            this.BEditarProd.Margin = new System.Windows.Forms.Padding(4);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(162, 53);
            this.BEditarProd.TabIndex = 8;
            this.BEditarProd.Text = "EDITAR";
            this.BEditarProd.UseVisualStyleBackColor = false;
            this.BEditarProd.Click += new System.EventHandler(this.BEditarProd_Click_1);
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cuit,
            this.TipoUsuario,
            this.Dni,
            this.FechaIng});
            this.DGVListaProd.Location = new System.Drawing.Point(12, 44);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(711, 76);
            this.DGVListaProd.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Precio";
            this.Cuit.MinimumWidth = 6;
            this.Cuit.Name = "Cuit";
            this.Cuit.Width = 125;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Categoria";
            this.TipoUsuario.MinimumWidth = 6;
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Width = 125;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Stock";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.Width = 125;
            // 
            // FechaIng
            // 
            this.FechaIng.HeaderText = "Fecha Modif";
            this.FechaIng.MinimumWidth = 6;
            this.FechaIng.Name = "FechaIng";
            this.FechaIng.Width = 125;
            // 
            // LDatosBajaProd
            // 
            this.LDatosBajaProd.AutoSize = true;
            this.LDatosBajaProd.BackColor = System.Drawing.Color.LightGray;
            this.LDatosBajaProd.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold);
            this.LDatosBajaProd.Location = new System.Drawing.Point(220, 9);
            this.LDatosBajaProd.Name = "LDatosBajaProd";
            this.LDatosBajaProd.Size = new System.Drawing.Size(244, 24);
            this.LDatosBajaProd.TabIndex = 6;
            this.LDatosBajaProd.Text = "DATOS DEL PRODUCTO";
            this.LDatosBajaProd.Click += new System.EventHandler(this.LDatosBajaProd_Click);
            // 
            // LBajaProducto
            // 
            this.LBajaProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBajaProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.LBajaProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBajaProducto.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBajaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBajaProducto.Location = new System.Drawing.Point(7, 13);
            this.LBajaProducto.Name = "LBajaProducto";
            this.LBajaProducto.Size = new System.Drawing.Size(745, 47);
            this.LBajaProducto.TabIndex = 8;
            this.LBajaProducto.Text = "EDITAR PRODUCTO";
            this.LBajaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBajaProducto.Click += new System.EventHandler(this.LBajaProducto_Click);
            // 
            // TBuscador
            // 
            this.TBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBuscador.AutoSize = false;
            this.TBuscador.Dock = System.Windows.Forms.DockStyle.None;
            this.TBuscador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPorEditar,
            this.toolStripSeparator1,
            this.LBuscarPor,
            this.TBEditarProd});
            this.TBuscador.Location = new System.Drawing.Point(8, 60);
            this.TBuscador.Name = "TBuscador";
            this.TBuscador.Size = new System.Drawing.Size(745, 57);
            this.TBuscador.TabIndex = 9;
            this.TBuscador.Text = "toolStrip1";
            this.TBuscador.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TBuscador_ItemClicked);
            // 
            // BBuscarPorEditar
            // 
            this.BBuscarPorEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codToolStripMenuItem,
            this.nombreToolStripMenuItem});
            this.BBuscarPorEditar.Image = global::Antorena_Soto.Properties.Resources.lupa;
            this.BBuscarPorEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPorEditar.Name = "BBuscarPorEditar";
            this.BBuscarPorEditar.Size = new System.Drawing.Size(103, 54);
            this.BBuscarPorEditar.Text = "BUSCAR";
            this.BBuscarPorEditar.ButtonClick += new System.EventHandler(this.BBuscarPorEditar_ButtonClick_1);
            // 
            // codToolStripMenuItem
            // 
            this.codToolStripMenuItem.Name = "codToolStripMenuItem";
            this.codToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.codToolStripMenuItem.Text = "Codigo";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.nombreToolStripMenuItem.Text = " Nombre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(0, 54);
            // 
            // TBEditarProd
            // 
            this.TBEditarProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBEditarProd.Name = "TBEditarProd";
            this.TBEditarProd.Size = new System.Drawing.Size(367, 57);
            // 
            // pcontenedorEditarProd
            // 
            this.pcontenedorEditarProd.BackColor = System.Drawing.Color.Black;
            this.pcontenedorEditarProd.Controls.Add(this.LBajaProducto);
            this.pcontenedorEditarProd.Controls.Add(this.pEditarProd);
            this.pcontenedorEditarProd.Controls.Add(this.TBuscador);
            this.pcontenedorEditarProd.Location = new System.Drawing.Point(-7, -4);
            this.pcontenedorEditarProd.Name = "pcontenedorEditarProd";
            this.pcontenedorEditarProd.Size = new System.Drawing.Size(762, 500);
            this.pcontenedorEditarProd.TabIndex = 10;
            // 
            // editarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 463);
            this.Controls.Add(this.pcontenedorEditarProd);
            this.Name = "editarProducto";
            this.Text = "Editar Priducto";
            this.Load += new System.EventHandler(this.editarProducto_Load_1);
            this.pEditarProd.ResumeLayout(false);
            this.pEditarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.pcontenedorEditarProd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pEditarProd;
        private System.Windows.Forms.Button BEditarProd;
        private System.Windows.Forms.Label LDatosBajaProd;
        private System.Windows.Forms.Label LBajaProducto;
        private System.Windows.Forms.ToolStrip TBuscador;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPorEditar;
        private System.Windows.Forms.ToolStripMenuItem codToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.ToolStripTextBox TBEditarProd;
        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.Panel pcontenedorEditarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
        private System.Windows.Forms.Button BEliminarProd;
    }
}