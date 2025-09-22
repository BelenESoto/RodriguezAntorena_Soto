namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class listaProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.LListaUsuario = new System.Windows.Forms.Label();
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.TBuscadorProd = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.nombreProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarProd = new System.Windows.Forms.ToolStripTextBox();
            this.pContenedorListaProd = new System.Windows.Forms.Panel();
            this.BEliminarProd = new System.Windows.Forms.Button();
            this.BEditarProd = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.TBuscadorProd.SuspendLayout();
            this.pContenedorListaProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // LListaUsuario
            // 
            this.LListaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LListaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.LListaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LListaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LListaUsuario.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LListaUsuario.Location = new System.Drawing.Point(11, 22);
            this.LListaUsuario.Name = "LListaUsuario";
            this.LListaUsuario.Size = new System.Drawing.Size(749, 44);
            this.LListaUsuario.TabIndex = 5;
            this.LListaUsuario.Text = "LISTA DE PRODUCTOS";
            this.LListaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVListaProd.ColumnHeadersHeight = 29;
            this.DGVListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.TipoUsuario,
            this.Dni,
            this.FechaIng});
            this.DGVListaProd.Location = new System.Drawing.Point(12, 116);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(748, 392);
            this.DGVListaProd.TabIndex = 0;
            this.DGVListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProd_CellContentClick);
            // 
            // TBuscadorProd
            // 
            this.TBuscadorProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBuscadorProd.AutoSize = false;
            this.TBuscadorProd.Dock = System.Windows.Forms.DockStyle.None;
            this.TBuscadorProd.GripMargin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.TBuscadorProd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TBuscadorProd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarPor,
            this.toolStripSeparator1,
            this.LBuscarPor,
            this.TBBuscarProd});
            this.TBuscadorProd.Location = new System.Drawing.Point(11, 66);
            this.TBuscadorProd.Name = "TBuscadorProd";
            this.TBuscadorProd.Size = new System.Drawing.Size(749, 48);
            this.TBuscadorProd.TabIndex = 6;
            this.TBuscadorProd.Text = "toolStrip1";
            this.TBuscadorProd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TBuscadorProd_ItemClicked);
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreProdToolStripMenuItem,
            this.codigoToolStripMenuItem});
            this.BBuscarPor.Image = global::Antorena_Soto.Properties.Resources.lupa;
            this.BBuscarPor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarPor.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.BBuscarPor.MergeIndex = 0;
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BBuscarPor.Size = new System.Drawing.Size(108, 45);
            this.BBuscarPor.Text = "BUSCAR";
            this.BBuscarPor.ButtonClick += new System.EventHandler(this.BBuscarPor_ButtonClick);
            // 
            // nombreProdToolStripMenuItem
            // 
            this.nombreProdToolStripMenuItem.Name = "nombreProdToolStripMenuItem";
            this.nombreProdToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.nombreProdToolStripMenuItem.Text = "Nombre";
            this.nombreProdToolStripMenuItem.Click += new System.EventHandler(this.nombreProdToolStripMenuItem_Click);
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.codigoToolStripMenuItem.Text = "Codigo";
            this.codigoToolStripMenuItem.Click += new System.EventHandler(this.codigoToolStripMenuItem_Click);
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
            // TBBuscarProd
            // 
            this.TBBuscarProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarProd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TBBuscarProd.Name = "TBBuscarProd";
            this.TBBuscarProd.Size = new System.Drawing.Size(367, 48);
            this.TBBuscarProd.Text = "Seleccione una categoria de busqueda ";
            this.TBBuscarProd.Click += new System.EventHandler(this.TBBuscarProd_Click);
            // 
            // pContenedorListaProd
            // 
            this.pContenedorListaProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pContenedorListaProd.BackColor = System.Drawing.Color.Black;
            this.pContenedorListaProd.Controls.Add(this.BEliminarProd);
            this.pContenedorListaProd.Controls.Add(this.BEditarProd);
            this.pContenedorListaProd.Controls.Add(this.DGVListaProd);
            this.pContenedorListaProd.Controls.Add(this.TBuscadorProd);
            this.pContenedorListaProd.Controls.Add(this.LListaUsuario);
            this.pContenedorListaProd.Location = new System.Drawing.Point(-1, -24);
            this.pContenedorListaProd.Name = "pContenedorListaProd";
            this.pContenedorListaProd.Size = new System.Drawing.Size(760, 500);
            this.pContenedorListaProd.TabIndex = 7;
            // 
            // BEliminarProd
            // 
            this.BEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminarProd.Location = new System.Drawing.Point(388, 396);
            this.BEliminarProd.Name = "BEliminarProd";
            this.BEliminarProd.Size = new System.Drawing.Size(149, 49);
            this.BEliminarProd.TabIndex = 8;
            this.BEliminarProd.Text = "Eliminar";
            this.BEliminarProd.UseVisualStyleBackColor = true;
            this.BEliminarProd.Click += new System.EventHandler(this.BEliminarProd_Click_1);
            // 
            // BEditarProd
            // 
            this.BEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarProd.Location = new System.Drawing.Point(218, 396);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(149, 49);
            this.BEditarProd.TabIndex = 7;
            this.BEditarProd.Text = "Editar";
            this.BEditarProd.UseVisualStyleBackColor = true;
            this.BEditarProd.Click += new System.EventHandler(this.BEditarProd_Click_1);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 3;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 3;
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 3;
            this.Precio.Name = "Precio";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoUsuario.HeaderText = "Categoria";
            this.TipoUsuario.MinimumWidth = 3;
            this.TipoUsuario.Name = "TipoUsuario";
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Dni.HeaderText = "Stock";
            this.Dni.MinimumWidth = 3;
            this.Dni.Name = "Dni";
            // 
            // FechaIng
            // 
            this.FechaIng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaIng.HeaderText = "Fecha Modif";
            this.FechaIng.MinimumWidth = 3;
            this.FechaIng.Name = "FechaIng";
            // 
            // listaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 463);
            this.Controls.Add(this.pContenedorListaProd);
            this.Controls.Add(this.label1);
            this.Name = "listaProductos";
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.listaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.TBuscadorProd.ResumeLayout(false);
            this.TBuscadorProd.PerformLayout();
            this.pContenedorListaProd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LListaUsuario;
        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.ToolStrip TBuscadorProd;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem nombreProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.ToolStripTextBox TBBuscarProd;
        private System.Windows.Forms.Panel pContenedorListaProd;
        private System.Windows.Forms.Button BEliminarProd;
        private System.Windows.Forms.Button BEditarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
    }
}