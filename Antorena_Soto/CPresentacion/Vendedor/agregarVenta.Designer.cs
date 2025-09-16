namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class agregarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarVenta));
            this.PAgregarClienteFondo = new System.Windows.Forms.Panel();
            this.LAgregarVenta = new System.Windows.Forms.Label();
            this.PAgregarVendedor = new System.Windows.Forms.Panel();
            this.BAgregarVendedor = new System.Windows.Forms.Button();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.TBNombreProd = new System.Windows.Forms.TextBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTotalVenta = new System.Windows.Forms.Label();
            this.BAgregarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PAgregarClienteFondo.SuspendLayout();
            this.PAgregarVendedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PAgregarClienteFondo
            // 
            resources.ApplyResources(this.PAgregarClienteFondo, "PAgregarClienteFondo");
            this.PAgregarClienteFondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PAgregarClienteFondo.Controls.Add(this.LAgregarVenta);
            this.PAgregarClienteFondo.Controls.Add(this.PAgregarVendedor);
            this.PAgregarClienteFondo.Name = "PAgregarClienteFondo";
            // 
            // LAgregarVenta
            // 
            resources.ApplyResources(this.LAgregarVenta, "LAgregarVenta");
            this.LAgregarVenta.BackColor = System.Drawing.Color.Gainsboro;
            this.LAgregarVenta.Name = "LAgregarVenta";
            // 
            // PAgregarVendedor
            // 
            resources.ApplyResources(this.PAgregarVendedor, "PAgregarVendedor");
            this.PAgregarVendedor.BackColor = System.Drawing.Color.Gainsboro;
            this.PAgregarVendedor.Controls.Add(this.BAgregarVendedor);
            this.PAgregarVendedor.Controls.Add(this.TBCantidad);
            this.PAgregarVendedor.Controls.Add(this.LCantidad);
            this.PAgregarVendedor.Controls.Add(this.TBNombreProd);
            this.PAgregarVendedor.Controls.Add(this.LNombreProducto);
            this.PAgregarVendedor.Controls.Add(this.panel1);
            this.PAgregarVendedor.Name = "PAgregarVendedor";
            // 
            // BAgregarVendedor
            // 
            resources.ApplyResources(this.BAgregarVendedor, "BAgregarVendedor");
            this.BAgregarVendedor.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarVendedor.ForeColor = System.Drawing.Color.Black;
            this.BAgregarVendedor.Name = "BAgregarVendedor";
            this.BAgregarVendedor.UseVisualStyleBackColor = false;
            this.BAgregarVendedor.Click += new System.EventHandler(this.BAgregarVendedor_Click);
            // 
            // TBCantidad
            // 
            resources.ApplyResources(this.TBCantidad, "TBCantidad");
            this.TBCantidad.Name = "TBCantidad";
            // 
            // LCantidad
            // 
            resources.ApplyResources(this.LCantidad, "LCantidad");
            this.LCantidad.ForeColor = System.Drawing.Color.Black;
            this.LCantidad.Name = "LCantidad";
            // 
            // TBNombreProd
            // 
            resources.ApplyResources(this.TBNombreProd, "TBNombreProd");
            this.TBNombreProd.Name = "TBNombreProd";
            // 
            // LNombreProducto
            // 
            resources.ApplyResources(this.LNombreProducto, "LNombreProducto");
            this.LNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.LNombreProducto.Name = "LNombreProducto";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.LTotalVenta);
            this.panel1.Controls.Add(this.BAgregarVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.cantidad,
            this.categoria,
            this.Subtotal});
            this.dataGridView1.Name = "dataGridView1";
            // 
            // Codigo
            // 
            resources.ApplyResources(this.Codigo, "Codigo");
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            // 
            // cantidad
            // 
            resources.ApplyResources(this.cantidad, "cantidad");
            this.cantidad.Name = "cantidad";
            // 
            // categoria
            // 
            resources.ApplyResources(this.categoria, "categoria");
            this.categoria.Name = "categoria";
            // 
            // Subtotal
            // 
            resources.ApplyResources(this.Subtotal, "Subtotal");
            this.Subtotal.Name = "Subtotal";
            // 
            // LTotalVenta
            // 
            resources.ApplyResources(this.LTotalVenta, "LTotalVenta");
            this.LTotalVenta.BackColor = System.Drawing.Color.Gainsboro;
            this.LTotalVenta.ForeColor = System.Drawing.Color.Black;
            this.LTotalVenta.Name = "LTotalVenta";
            // 
            // BAgregarVenta
            // 
            resources.ApplyResources(this.BAgregarVenta, "BAgregarVenta");
            this.BAgregarVenta.BackColor = System.Drawing.Color.DarkGray;
            this.BAgregarVenta.ForeColor = System.Drawing.Color.Black;
            this.BAgregarVenta.Name = "BAgregarVenta";
            this.BAgregarVenta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // agregarVenta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.PAgregarClienteFondo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "agregarVenta";
            this.PAgregarClienteFondo.ResumeLayout(false);
            this.PAgregarVendedor.ResumeLayout(false);
            this.PAgregarVendedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PAgregarClienteFondo;
        public System.Windows.Forms.Label LAgregarVenta;
        private System.Windows.Forms.Panel PAgregarVendedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BAgregarVendedor;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TBNombreProd;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTotalVenta;
        private System.Windows.Forms.Button BAgregarVenta;
        private System.Windows.Forms.Label label1;
    }
}