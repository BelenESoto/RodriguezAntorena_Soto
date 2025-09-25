namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class verProductos
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
            this.pVerProd = new System.Windows.Forms.Panel();
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.LverProd = new System.Windows.Forms.Label();
            this.TBuscadorProd = new System.Windows.Forms.ToolStrip();
            this.BBuscarPor = new System.Windows.Forms.ToolStripSplitButton();
            this.nombreProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarProd = new System.Windows.Forms.ToolStripTextBox();
            this.pVerProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.TBuscadorProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pVerProd
            // 
            this.pVerProd.BackColor = System.Drawing.Color.Black;
            this.pVerProd.Controls.Add(this.TBuscadorProd);
            this.pVerProd.Controls.Add(this.DGVListaProd);
            this.pVerProd.Controls.Add(this.LverProd);
            this.pVerProd.Location = new System.Drawing.Point(-51, -27);
            this.pVerProd.Name = "pVerProd";
            this.pVerProd.Size = new System.Drawing.Size(832, 491);
            this.pVerProd.TabIndex = 0;
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Location = new System.Drawing.Point(87, 313);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(241, 74);
            this.DGVListaProd.TabIndex = 8;
            this.DGVListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProd_CellContentClick);
            // 
            // LverProd
            // 
            this.LverProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LverProd.BackColor = System.Drawing.Color.Gainsboro;
            this.LverProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LverProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LverProd.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LverProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LverProd.Location = new System.Drawing.Point(63, 23);
            this.LverProd.Name = "LverProd";
            this.LverProd.Size = new System.Drawing.Size(749, 44);
            this.LverProd.TabIndex = 6;
            this.LverProd.Text = "PRODUCTOS";
            this.LverProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TBuscadorProd.Location = new System.Drawing.Point(63, 76);
            this.TBuscadorProd.Name = "TBuscadorProd";
            this.TBuscadorProd.Size = new System.Drawing.Size(749, 48);
            this.TBuscadorProd.TabIndex = 9;
            this.TBuscadorProd.Text = "toolStrip1";
            this.TBuscadorProd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TBuscadorProd_ItemClicked_1);
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
            this.BBuscarPor.ButtonClick += new System.EventHandler(this.BBuscarPor_ButtonClick_1);
            // 
            // nombreProdToolStripMenuItem
            // 
            this.nombreProdToolStripMenuItem.Name = "nombreProdToolStripMenuItem";
            this.nombreProdToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nombreProdToolStripMenuItem.Text = "Nombre";
            this.nombreProdToolStripMenuItem.Click += new System.EventHandler(this.nombreProdToolStripMenuItem_Click);
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.TBBuscarProd.Click += new System.EventHandler(this.TBBuscarProd_Click_1);
            // 
            // verProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.pVerProd);
            this.Name = "verProductos";
            this.Text = "verProductos";
            this.pVerProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.TBuscadorProd.ResumeLayout(false);
            this.TBuscadorProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pVerProd;
        private System.Windows.Forms.Label LverProd;
        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.ToolStrip TBuscadorProd;
        private System.Windows.Forms.ToolStripSplitButton BBuscarPor;
        private System.Windows.Forms.ToolStripMenuItem nombreProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.ToolStripTextBox TBBuscarProd;
    }
}