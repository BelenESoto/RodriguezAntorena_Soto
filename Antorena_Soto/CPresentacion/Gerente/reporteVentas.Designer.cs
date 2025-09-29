namespace Antorena_Soto.CPresentacion.Gerente
{
    partial class reporteVentas
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
            this.pReporteVenta = new System.Windows.Forms.Panel();
            this.bExportar = new System.Windows.Forms.Button();
            this.DGVentas = new System.Windows.Forms.DataGridView();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TBCriterio = new System.Windows.Forms.TextBox();
            this.CBFiltroBusqueda = new System.Windows.Forms.ComboBox();
            this.pReporteVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pReporteVenta
            // 
            this.pReporteVenta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pReporteVenta.Controls.Add(this.bExportar);
            this.pReporteVenta.Controls.Add(this.DGVentas);
            this.pReporteVenta.Controls.Add(this.BLimpiar);
            this.pReporteVenta.Controls.Add(this.BBuscar);
            this.pReporteVenta.Controls.Add(this.TBCriterio);
            this.pReporteVenta.Controls.Add(this.CBFiltroBusqueda);
            this.pReporteVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReporteVenta.Location = new System.Drawing.Point(0, 0);
            this.pReporteVenta.Name = "pReporteVenta";
            this.pReporteVenta.Size = new System.Drawing.Size(755, 718);
            this.pReporteVenta.TabIndex = 0;
            this.pReporteVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.pReporteVenta_Paint);
            // 
            // bExportar
            // 
            this.bExportar.Location = new System.Drawing.Point(428, 575);
            this.bExportar.Name = "bExportar";
            this.bExportar.Size = new System.Drawing.Size(128, 37);
            this.bExportar.TabIndex = 5;
            this.bExportar.Text = "button1";
            this.bExportar.UseVisualStyleBackColor = true;
            // 
            // DGVentas
            // 
            this.DGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentas.Location = new System.Drawing.Point(37, 127);
            this.DGVentas.Name = "DGVentas";
            this.DGVentas.RowHeadersWidth = 51;
            this.DGVentas.RowTemplate.Height = 24;
            this.DGVentas.Size = new System.Drawing.Size(677, 433);
            this.DGVentas.TabIndex = 4;
            this.DGVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVentas_CellContentClick);
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(201, 575);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(128, 37);
            this.BLimpiar.TabIndex = 3;
            this.BLimpiar.Text = "BLimpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click_1);
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(646, 58);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(68, 27);
            this.BBuscar.TabIndex = 2;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click_1);
            // 
            // TBCriterio
            // 
            this.TBCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TBCriterio.Location = new System.Drawing.Point(176, 61);
            this.TBCriterio.Name = "TBCriterio";
            this.TBCriterio.Size = new System.Drawing.Size(538, 22);
            this.TBCriterio.TabIndex = 1;
            // 
            // CBFiltroBusqueda
            // 
            this.CBFiltroBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBFiltroBusqueda.FormattingEnabled = true;
            this.CBFiltroBusqueda.Location = new System.Drawing.Point(37, 61);
            this.CBFiltroBusqueda.Name = "CBFiltroBusqueda";
            this.CBFiltroBusqueda.Size = new System.Drawing.Size(148, 24);
            this.CBFiltroBusqueda.TabIndex = 0;
            // 
            // reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 718);
            this.Controls.Add(this.pReporteVenta);
            this.Name = "reporteVentas";
            this.Text = "reporteVentas";
            this.Load += new System.EventHandler(this.reporteVentas_Load_1);
            this.pReporteVenta.ResumeLayout(false);
            this.pReporteVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pReporteVenta;
        private System.Windows.Forms.ComboBox CBFiltroBusqueda;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TBCriterio;
        private System.Windows.Forms.DataGridView DGVentas;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button bExportar;
    }
}