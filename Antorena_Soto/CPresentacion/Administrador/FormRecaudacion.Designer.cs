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
            this.chartRecaudacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelRecaudacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(98, 157);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(253, 22);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(357, 157);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(255, 22);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(357, 185);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(255, 22);
            this.dtpHasta.TabIndex = 2;
            // 
            // btnPorFecha
            // 
            this.btnPorFecha.BackColor = System.Drawing.Color.LightGray;
            this.btnPorFecha.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPorFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPorFecha.Location = new System.Drawing.Point(142, 14);
            this.btnPorFecha.Name = "btnPorFecha";
            this.btnPorFecha.Size = new System.Drawing.Size(174, 35);
            this.btnPorFecha.TabIndex = 3;
            this.btnPorFecha.Text = "Por Fecha";
            this.btnPorFecha.UseVisualStyleBackColor = false;
            // 
            // btnPorPeriodo
            // 
            this.btnPorPeriodo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPorPeriodo.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPorPeriodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPorPeriodo.Location = new System.Drawing.Point(392, 14);
            this.btnPorPeriodo.Name = "btnPorPeriodo";
            this.btnPorPeriodo.Size = new System.Drawing.Size(168, 35);
            this.btnPorPeriodo.TabIndex = 4;
            this.btnPorPeriodo.Text = "Por Periodo";
            this.btnPorPeriodo.UseVisualStyleBackColor = false;
            this.btnPorPeriodo.Click += new System.EventHandler(this.btnPorPeriodo_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnImprimir.Location = new System.Drawing.Point(297, 650);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(165, 46);
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
            this.panelRecaudacion.Location = new System.Drawing.Point(49, 213);
            this.panelRecaudacion.Name = "panelRecaudacion";
            this.panelRecaudacion.Size = new System.Drawing.Size(659, 135);
            this.panelRecaudacion.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(298, 74);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(304, 27);
            this.lblCantidad.TabIndex = 4;
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonto.Location = new System.Drawing.Point(293, 25);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(313, 23);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos Vendidos";
            // 
            // montoRec
            // 
            this.montoRec.AutoSize = true;
            this.montoRec.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold);
            this.montoRec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.montoRec.Location = new System.Drawing.Point(21, 25);
            this.montoRec.Name = "montoRec";
            this.montoRec.Size = new System.Drawing.Size(231, 24);
            this.montoRec.TabIndex = 1;
            this.montoRec.Text = "Monto Recaudado: ";
            this.montoRec.Click += new System.EventHandler(this.montoRec_Click);
            // 
            // lRecaudacionB
            // 
            this.lRecaudacionB.BackColor = System.Drawing.Color.White;
            this.lRecaudacionB.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecaudacionB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lRecaudacionB.Location = new System.Drawing.Point(3, 14);
            this.lRecaudacionB.Name = "lRecaudacionB";
            this.lRecaudacionB.Size = new System.Drawing.Size(103, 35);
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
            this.btnBuscar.Location = new System.Drawing.Point(599, 9);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(142, 43);
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
            this.lRecaudacion.Padding = new System.Windows.Forms.Padding(11, 4, 4, 4);
            this.lRecaudacion.Size = new System.Drawing.Size(755, 81);
            this.lRecaudacion.TabIndex = 42;
            this.lRecaudacion.Text = "Reporte Recaudacion";
            this.lRecaudacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnPorPeriodo);
            this.panel1.Controls.Add(this.lRecaudacionB);
            this.panel1.Controls.Add(this.btnPorFecha);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(1, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 58);
            this.panel1.TabIndex = 43;
            // 
            // panelGrafico
            // 
            this.panelGrafico.BackColor = System.Drawing.Color.Gainsboro;
            this.panelGrafico.Controls.Add(this.chartRecaudacion);
            this.panelGrafico.Location = new System.Drawing.Point(49, 378);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(658, 266);
            this.panelGrafico.TabIndex = 44;
            // 
            // chartRecaudacion
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRecaudacion.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRecaudacion.Legends.Add(legend3);
            this.chartRecaudacion.Location = new System.Drawing.Point(3, 3);
            this.chartRecaudacion.Name = "chartRecaudacion";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRecaudacion.Series.Add(series3);
            this.chartRecaudacion.Size = new System.Drawing.Size(652, 260);
            this.chartRecaudacion.TabIndex = 0;
            this.chartRecaudacion.Text = "chart1";
            // 
            // FormRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(755, 718);
            this.Controls.Add(this.panelGrafico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lRecaudacion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelRecaudacion);
            this.Controls.Add(this.dtpDesde);
            this.Name = "FormRecaudacion";
            this.Text = "FormRecaudacion";
            this.Load += new System.EventHandler(this.FormRecaudacion_Load);
            this.panelRecaudacion.ResumeLayout(false);
            this.panelRecaudacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRecaudacion)).EndInit();
            this.ResumeLayout(false);

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
    }
}