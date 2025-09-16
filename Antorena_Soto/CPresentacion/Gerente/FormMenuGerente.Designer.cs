namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class FormMenuGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuGerente));
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.BListarProductos = new System.Windows.Forms.Button();
            this.BTBajaVendedor = new System.Windows.Forms.Button();
            this.LProductosGest = new System.Windows.Forms.Label();
            this.LPersonalGest = new System.Windows.Forms.Label();
            this.BEditarProducto = new System.Windows.Forms.Button();
            this.BAltaProducto = new System.Windows.Forms.Button();
            this.BTListaVendedores = new System.Windows.Forms.Button();
            this.BTAltaVendedor = new System.Windows.Forms.Button();
            this.LMenuGerente = new System.Windows.Forms.Label();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.DGVListaVendedor = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.PGerente1.SuspendLayout();
            this.PGerente2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente1.Controls.Add(this.BListarProductos);
            this.PGerente1.Controls.Add(this.BTBajaVendedor);
            this.PGerente1.Controls.Add(this.LProductosGest);
            this.PGerente1.Controls.Add(this.LPersonalGest);
            this.PGerente1.Controls.Add(this.BEditarProducto);
            this.PGerente1.Controls.Add(this.BAltaProducto);
            this.PGerente1.Controls.Add(this.BTListaVendedores);
            this.PGerente1.Controls.Add(this.BTAltaVendedor);
            this.PGerente1.Location = new System.Drawing.Point(4, 46);
            this.PGerente1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(204, 362);
            this.PGerente1.TabIndex = 0;
            // 
            // BListarProductos
            // 
            this.BListarProductos.Location = new System.Drawing.Point(20, 282);
            this.BListarProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BListarProductos.Name = "BListarProductos";
            this.BListarProductos.Size = new System.Drawing.Size(164, 27);
            this.BListarProductos.TabIndex = 8;
            this.BListarProductos.Text = "Listar Productos";
            this.BListarProductos.UseVisualStyleBackColor = true;
            // 
            // BTBajaVendedor
            // 
            this.BTBajaVendedor.Location = new System.Drawing.Point(20, 74);
            this.BTBajaVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTBajaVendedor.Name = "BTBajaVendedor";
            this.BTBajaVendedor.Size = new System.Drawing.Size(164, 27);
            this.BTBajaVendedor.TabIndex = 7;
            this.BTBajaVendedor.Text = "Baja Usuario Vendedor";
            this.BTBajaVendedor.UseVisualStyleBackColor = true;
            this.BTBajaVendedor.Click += new System.EventHandler(this.BTBajaVendedor_Click);
            // 
            // LProductosGest
            // 
            this.LProductosGest.AutoSize = true;
            this.LProductosGest.BackColor = System.Drawing.Color.LightGray;
            this.LProductosGest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductosGest.Location = new System.Drawing.Point(74, 190);
            this.LProductosGest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LProductosGest.Name = "LProductosGest";
            this.LProductosGest.Size = new System.Drawing.Size(79, 17);
            this.LProductosGest.TabIndex = 6;
            this.LProductosGest.Text = "Productos";
            // 
            // LPersonalGest
            // 
            this.LPersonalGest.AutoSize = true;
            this.LPersonalGest.BackColor = System.Drawing.Color.LightGray;
            this.LPersonalGest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPersonalGest.Location = new System.Drawing.Point(74, 14);
            this.LPersonalGest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPersonalGest.Name = "LPersonalGest";
            this.LPersonalGest.Size = new System.Drawing.Size(67, 17);
            this.LPersonalGest.TabIndex = 5;
            this.LPersonalGest.Text = "Personal";
            this.LPersonalGest.Click += new System.EventHandler(this.label1_Click);
            // 
            // BEditarProducto
            // 
            this.BEditarProducto.Location = new System.Drawing.Point(20, 250);
            this.BEditarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BEditarProducto.Name = "BEditarProducto";
            this.BEditarProducto.Size = new System.Drawing.Size(164, 27);
            this.BEditarProducto.TabIndex = 4;
            this.BEditarProducto.Text = "Editar Productos";
            this.BEditarProducto.UseVisualStyleBackColor = true;
            // 
            // BAltaProducto
            // 
            this.BAltaProducto.Location = new System.Drawing.Point(20, 219);
            this.BAltaProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BAltaProducto.Name = "BAltaProducto";
            this.BAltaProducto.Size = new System.Drawing.Size(164, 27);
            this.BAltaProducto.TabIndex = 3;
            this.BAltaProducto.Text = "Alta Producto";
            this.BAltaProducto.UseVisualStyleBackColor = true;
            this.BAltaProducto.Click += new System.EventHandler(this.BAltaProducto_Click);
            // 
            // BTListaVendedores
            // 
            this.BTListaVendedores.Location = new System.Drawing.Point(20, 105);
            this.BTListaVendedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTListaVendedores.Name = "BTListaVendedores";
            this.BTListaVendedores.Size = new System.Drawing.Size(164, 27);
            this.BTListaVendedores.TabIndex = 2;
            this.BTListaVendedores.Text = "Lista Vendedores";
            this.BTListaVendedores.UseVisualStyleBackColor = true;
            this.BTListaVendedores.Click += new System.EventHandler(this.BTListaVendedores_Click);
            // 
            // BTAltaVendedor
            // 
            this.BTAltaVendedor.Location = new System.Drawing.Point(20, 43);
            this.BTAltaVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAltaVendedor.Name = "BTAltaVendedor";
            this.BTAltaVendedor.Size = new System.Drawing.Size(164, 27);
            this.BTAltaVendedor.TabIndex = 1;
            this.BTAltaVendedor.Text = "Alta Usuario Vendedor";
            this.BTAltaVendedor.UseVisualStyleBackColor = true;
            this.BTAltaVendedor.Click += new System.EventHandler(this.BTAltaVendedor_Click);
            // 
            // LMenuGerente
            // 
            this.LMenuGerente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LMenuGerente.BackColor = System.Drawing.Color.Gainsboro;
            this.LMenuGerente.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMenuGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LMenuGerente.Location = new System.Drawing.Point(4, 5);
            this.LMenuGerente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LMenuGerente.Name = "LMenuGerente";
            this.LMenuGerente.Size = new System.Drawing.Size(204, 39);
            this.LMenuGerente.TabIndex = 0;
            this.LMenuGerente.Text = "MENU ADMIN USUARIOS";
            this.LMenuGerente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LMenuGerente.Click += new System.EventHandler(this.LMenuGerente_Click);
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.Controls.Add(this.DGVListaVendedor);
            this.PGerente2.Location = new System.Drawing.Point(212, 46);
            this.PGerente2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(563, 362);
            this.PGerente2.TabIndex = 1;
            // 
            // DGVListaVendedor
            // 
            this.DGVListaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Dni,
            this.FechaIng});
            this.DGVListaVendedor.Location = new System.Drawing.Point(20, 23);
            this.DGVListaVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVListaVendedor.Name = "DGVListaVendedor";
            this.DGVListaVendedor.RowHeadersWidth = 51;
            this.DGVListaVendedor.RowTemplate.Height = 24;
            this.DGVListaVendedor.Size = new System.Drawing.Size(530, 331);
            this.DGVListaVendedor.TabIndex = 0;
            this.DGVListaVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
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
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(212, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 36);
            this.toolStripLabel1.Text = "Buscar";
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
            // FormMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 409);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LMenuGerente);
            this.Controls.Add(this.PGerente2);
            this.Controls.Add(this.PGerente1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenuGerente";
            this.Text = "FormMenuGerente";
            this.Load += new System.EventHandler(this.FormMenuGerente_Load);
            this.PGerente1.ResumeLayout(false);
            this.PGerente1.PerformLayout();
            this.PGerente2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaVendedor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PGerente1;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.Label LMenuGerente;
        private System.Windows.Forms.Button BTAltaVendedor;
        private System.Windows.Forms.Label LPersonalGest;
        private System.Windows.Forms.Button BEditarProducto;
        private System.Windows.Forms.Button BAltaProducto;
        private System.Windows.Forms.Button BTListaVendedores;
        private System.Windows.Forms.Label LProductosGest;
        private System.Windows.Forms.Button BTBajaVendedor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView DGVListaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIng;
        private System.Windows.Forms.Button BListarProductos;
    }
}