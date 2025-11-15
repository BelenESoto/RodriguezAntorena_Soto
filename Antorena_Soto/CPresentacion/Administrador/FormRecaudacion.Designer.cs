namespace Antorena_Soto.CPresentacion.Administrador
{
    partial class FormRecaudacion

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecaudacion));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnPorFecha = new System.Windows.Forms.Button();
            this.btnPorPeriodo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelRecaudacion = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.montoRec = new System.Windows.Forms.Label();
            this.lRecaudacionB = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lRecaudacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGrafico = new System.Windows.Forms.Panel();
            this.chartCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRecaudacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRecaudacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(74, 128);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(191, 20);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(268, 128);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(192, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(268, 150);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(192, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // btnPorFecha
            // 
            this.btnPorFecha.BackColor = System.Drawing.Color.LightGray;
            this.btnPorFecha.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPorFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPorFecha.Location = new System.Drawing.Point(106, 11);
            this.btnPorFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorFecha.Name = "btnPorFecha";
            this.btnPorFecha.Size = new System.Drawing.Size(130, 28);
            this.btnPorFecha.TabIndex = 3;
            this.btnPorFecha.Text = "Por Fecha";
            this.btnPorFecha.UseVisualStyleBackColor = false;
            // 
            // btnPorPeriodo
            // 
            this.btnPorPeriodo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPorPeriodo.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPorPeriodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPorPeriodo.Location = new System.Drawing.Point(294, 11);
            this.btnPorPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorPeriodo.Name = "btnPorPeriodo";
            this.btnPorPeriodo.Size = new System.Drawing.Size(126, 28);
            this.btnPorPeriodo.TabIndex = 4;
            this.btnPorPeriodo.Text = "Por Periodo";
            this.btnPorPeriodo.UseVisualStyleBackColor = false;
            this.btnPorPeriodo.Click += new System.EventHandler(this.btnPorPeriodo_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnImprimir.Location = new System.Drawing.Point(383, 284);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 37);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // panelRecaudacion
            // 
            this.panelRecaudacion.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRecaudacion.Controls.Add(this.lblCantidad);
            this.panelRecaudacion.Controls.Add(this.lblMonto);
            this.panelRecaudacion.Controls.Add(this.label1);
            this.panelRecaudacion.Controls.Add(this.montoRec);
            this.panelRecaudacion.Location = new System.Drawing.Point(37, 173);
            this.panelRecaudacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelRecaudacion.Name = "panelRecaudacion";
            this.panelRecaudacion.Size = new System.Drawing.Size(482, 100);
            this.panelRecaudacion.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(224, 60);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(228, 22);
            this.lblCantidad.TabIndex = 4;
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonto.Location = new System.Drawing.Point(220, 20);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(235, 19);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos Vendidos";
            // 
            // montoRec
            // 
            this.montoRec.AutoSize = true;
            this.montoRec.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold);
            this.montoRec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.montoRec.Location = new System.Drawing.Point(16, 20);
            this.montoRec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.montoRec.Name = "montoRec";
            this.montoRec.Size = new System.Drawing.Size(196, 19);
            this.montoRec.TabIndex = 1;
            this.montoRec.Text = "Monto Recaudado: ";
            this.montoRec.Click += new System.EventHandler(this.montoRec_Click);
            // 
            // lRecaudacionB
            // 
            this.lRecaudacionB.BackColor = System.Drawing.Color.White;
            this.lRecaudacionB.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecaudacionB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lRecaudacionB.Location = new System.Drawing.Point(2, 11);
            this.lRecaudacionB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRecaudacionB.Name = "lRecaudacionB";
            this.lRecaudacionB.Size = new System.Drawing.Size(77, 28);
            this.lRecaudacionB.TabIndex = 40;
            this.lRecaudacionB.Text = "Buscar:";
            this.lRecaudacionB.Click += new System.EventHandler(this.lRecaudacionB_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 36;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(449, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 35);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.CursorChanged += new System.EventHandler(this.btnBuscar_CursorChanged);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lRecaudacion
            // 
            this.lRecaudacion.BackColor = System.Drawing.Color.MidnightBlue;
            this.lRecaudacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lRecaudacion.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecaudacion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lRecaudacion.Image = ((System.Drawing.Image)(resources.GetObject("lRecaudacion.Image")));
            this.lRecaudacion.Location = new System.Drawing.Point(0, 0);
            this.lRecaudacion.Margin = new System.Windows.Forms.Padding(0);
            this.lRecaudacion.Name = "lRecaudacion";
            this.lRecaudacion.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.lRecaudacion.Size = new System.Drawing.Size(567, 66);
            this.lRecaudacion.TabIndex = 42;
            this.lRecaudacion.Text = "Reporte Recaudacion";
            this.lRecaudacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRecaudacion.Click += new System.EventHandler(this.lRecaudacion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnPorPeriodo);
            this.panel1.Controls.Add(this.lRecaudacionB);
            this.panel1.Controls.Add(this.btnPorFecha);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(1, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 47);
            this.panel1.TabIndex = 43;
            // 
            // panelGrafico
            // 
            this.panelGrafico.AutoScroll = true;
            this.panelGrafico.BackColor = System.Drawing.Color.Gainsboro;
            this.panelGrafico.Controls.Add(this.chartCategorias);
            this.panelGrafico.Controls.Add(this.chartProductos);
            this.panelGrafico.Controls.Add(this.chartRecaudacion);
            this.panelGrafico.Location = new System.Drawing.Point(11, 328);
            this.panelGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(529, 451);
            this.panelGrafico.TabIndex = 44;
            // 
            // chartCategorias
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCategorias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCategorias.Legends.Add(legend1);
            this.chartCategorias.Location = new System.Drawing.Point(267, 192);
            this.chartCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.chartCategorias.Name = "chartCategorias";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategorias.Series.Add(series1);
            this.chartCategorias.Size = new System.Drawing.Size(241, 238);
            this.chartCategorias.TabIndex = 2;
            this.chartCategorias.Text = "chart2";
            // 
            // chartProductos
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProductos.Legends.Add(legend2);
            this.chartProductos.Location = new System.Drawing.Point(2, 192);
            this.chartProductos.Margin = new System.Windows.Forms.Padding(2);
            this.chartProductos.Name = "chartProductos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProductos.Series.Add(series2);
            this.chartProductos.Size = new System.Drawing.Size(261, 238);
            this.chartProductos.TabIndex = 1;
            this.chartProductos.Text = "chart1";
            // 
            // chartRecaudacion
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRecaudacion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRecaudacion.Legends.Add(legend3);
            this.chartRecaudacion.Location = new System.Drawing.Point(2, 8);
            this.chartRecaudacion.Margin = new System.Windows.Forms.Padding(2);
            this.chartRecaudacion.Name = "chartRecaudacion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRecaudacion.Series.Add(series3);
            this.chartRecaudacion.Size = new System.Drawing.Size(506, 177);
            this.chartRecaudacion.TabIndex = 0;
            this.chartRecaudacion.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "GRÁFICO DE VENTAS SKORIAL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(552, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelGrafico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lRecaudacion);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.panelRecaudacion);
            this.Controls.Add(this.dtpDesde);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRecaudacion";
            this.Text = "FormRecaudacion";
            this.Load += new System.EventHandler(this.FormRecaudacion_Load);
            this.panelRecaudacion.ResumeLayout(false);
            this.panelRecaudacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnPorFecha;
        private System.Windows.Forms.Button btnPorPeriodo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelRecaudacion;
        private System.Windows.Forms.Label lRecaudacionB;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label montoRec;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCantidad;
        public System.Windows.Forms.Label lRecaudacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecaudacion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorias;
        private System.Windows.Forms.Label label2;
    }
}