namespace Antorena_Soto.CPresentacion.Gerente
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnPorFecha = new System.Windows.Forms.Button();
            this.btnPorPeriodo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelRecaudacion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.montoRec = new System.Windows.Forms.Label();
            this.lRecaudacion = new System.Windows.Forms.Label();
            this.lRecaudacionB = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.panelRecaudacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(229, 134);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(205, 22);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(489, 134);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(202, 22);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(489, 162);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(202, 22);
            this.dtpHasta.TabIndex = 2;
            // 
            // btnPorFecha
            // 
            this.btnPorFecha.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPorFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPorFecha.Location = new System.Drawing.Point(229, 84);
            this.btnPorFecha.Name = "btnPorFecha";
            this.btnPorFecha.Size = new System.Drawing.Size(196, 44);
            this.btnPorFecha.TabIndex = 3;
            this.btnPorFecha.Text = "Por Fecha";
            this.btnPorFecha.UseVisualStyleBackColor = true;
            // 
            // btnPorPeriodo
            // 
            this.btnPorPeriodo.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPorPeriodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPorPeriodo.Location = new System.Drawing.Point(502, 84);
            this.btnPorPeriodo.Name = "btnPorPeriodo";
            this.btnPorPeriodo.Size = new System.Drawing.Size(189, 44);
            this.btnPorPeriodo.TabIndex = 4;
            this.btnPorPeriodo.Text = "Por Periodo";
            this.btnPorPeriodo.UseVisualStyleBackColor = true;
            this.btnPorPeriodo.Click += new System.EventHandler(this.btnPorPeriodo_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnImprimir.Location = new System.Drawing.Point(309, 483);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(165, 60);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panelRecaudacion
            // 
            this.panelRecaudacion.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRecaudacion.Controls.Add(this.lblCantidad);
            this.panelRecaudacion.Controls.Add(this.lblMonto);
            this.panelRecaudacion.Controls.Add(this.label1);
            this.panelRecaudacion.Controls.Add(this.montoRec);
            this.panelRecaudacion.Location = new System.Drawing.Point(32, 258);
            this.panelRecaudacion.Name = "panelRecaudacion";
            this.panelRecaudacion.Size = new System.Drawing.Size(659, 188);
            this.panelRecaudacion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(21, 118);
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
            this.montoRec.Location = new System.Drawing.Point(21, 64);
            this.montoRec.Name = "montoRec";
            this.montoRec.Size = new System.Drawing.Size(231, 24);
            this.montoRec.TabIndex = 1;
            this.montoRec.Text = "Monto Recaudado: ";
            // 
            // lRecaudacion
            // 
            this.lRecaudacion.AutoSize = true;
            this.lRecaudacion.BackColor = System.Drawing.Color.Gainsboro;
            this.lRecaudacion.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecaudacion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lRecaudacion.Location = new System.Drawing.Point(224, 9);
            this.lRecaudacion.Name = "lRecaudacion";
            this.lRecaudacion.Size = new System.Drawing.Size(327, 28);
            this.lRecaudacion.TabIndex = 39;
            this.lRecaudacion.Text = "Recadacion  de ventas";
            // 
            // lRecaudacionB
            // 
            this.lRecaudacionB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lRecaudacionB.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecaudacionB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lRecaudacionB.Location = new System.Drawing.Point(3, 92);
            this.lRecaudacionB.Name = "lRecaudacionB";
            this.lRecaudacionB.Size = new System.Drawing.Size(193, 29);
            this.lRecaudacionB.TabIndex = 40;
            this.lRecaudacionB.Text = "Buscar por: ";
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
            this.btnBuscar.Location = new System.Drawing.Point(330, 208);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(167, 43);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.CursorChanged += new System.EventHandler(this.btnBuscar_CursorChanged);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMonto.Location = new System.Drawing.Point(274, 64);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(332, 23);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(274, 118);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(328, 27);
            this.lblCantidad.TabIndex = 4;
            // 
            // FormRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(755, 718);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lRecaudacionB);
            this.Controls.Add(this.lRecaudacion);
            this.Controls.Add(this.panelRecaudacion);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPorPeriodo);
            this.Controls.Add(this.btnPorFecha);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FormRecaudacion";
            this.Text = "FormRecaudacion";
            this.Load += new System.EventHandler(this.FormRecaudacion_Load);
            this.panelRecaudacion.ResumeLayout(false);
            this.panelRecaudacion.PerformLayout();
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
        private System.Windows.Forms.Label lRecaudacion;
        private System.Windows.Forms.Label lRecaudacionB;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label montoRec;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCantidad;
    }
}