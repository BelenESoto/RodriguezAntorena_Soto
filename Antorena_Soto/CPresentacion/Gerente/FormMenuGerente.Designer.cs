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
            this.PGerente1 = new System.Windows.Forms.Panel();
            this.PGerente2 = new System.Windows.Forms.Panel();
            this.LMenuGerente = new System.Windows.Forms.Label();
            this.BTAltaVendedor = new System.Windows.Forms.Button();
            this.BTListaVendedores = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LPersonalGest = new System.Windows.Forms.Label();
            this.LProductosGest = new System.Windows.Forms.Label();
            this.BTBajaVendedor = new System.Windows.Forms.Button();
            this.PGerente1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGerente1
            // 
            this.PGerente1.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente1.Controls.Add(this.BTBajaVendedor);
            this.PGerente1.Controls.Add(this.LProductosGest);
            this.PGerente1.Controls.Add(this.LPersonalGest);
            this.PGerente1.Controls.Add(this.button4);
            this.PGerente1.Controls.Add(this.button3);
            this.PGerente1.Controls.Add(this.BTListaVendedores);
            this.PGerente1.Controls.Add(this.BTAltaVendedor);
            this.PGerente1.Controls.Add(this.LMenuGerente);
            this.PGerente1.Location = new System.Drawing.Point(0, -2);
            this.PGerente1.Name = "PGerente1";
            this.PGerente1.Size = new System.Drawing.Size(272, 504);
            this.PGerente1.TabIndex = 0;
            // 
            // PGerente2
            // 
            this.PGerente2.BackColor = System.Drawing.Color.Gainsboro;
            this.PGerente2.Location = new System.Drawing.Point(278, -2);
            this.PGerente2.Name = "PGerente2";
            this.PGerente2.Size = new System.Drawing.Size(795, 504);
            this.PGerente2.TabIndex = 1;
            // 
            // LMenuGerente
            // 
            this.LMenuGerente.AutoSize = true;
            this.LMenuGerente.BackColor = System.Drawing.Color.LightGray;
            this.LMenuGerente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMenuGerente.Location = new System.Drawing.Point(53, 11);
            this.LMenuGerente.Name = "LMenuGerente";
            this.LMenuGerente.Size = new System.Drawing.Size(182, 25);
            this.LMenuGerente.TabIndex = 0;
            this.LMenuGerente.Text = "MENU GERENTE ";
            // 
            // BTAltaVendedor
            // 
            this.BTAltaVendedor.Location = new System.Drawing.Point(27, 131);
            this.BTAltaVendedor.Name = "BTAltaVendedor";
            this.BTAltaVendedor.Size = new System.Drawing.Size(218, 33);
            this.BTAltaVendedor.TabIndex = 1;
            this.BTAltaVendedor.Text = "Alta Vendedor";
            this.BTAltaVendedor.UseVisualStyleBackColor = true;
            this.BTAltaVendedor.Click += new System.EventHandler(this.BTAltaVendedor_Click);
            // 
            // BTListaVendedores
            // 
            this.BTListaVendedores.Location = new System.Drawing.Point(27, 208);
            this.BTListaVendedores.Name = "BTListaVendedores";
            this.BTListaVendedores.Size = new System.Drawing.Size(218, 33);
            this.BTListaVendedores.TabIndex = 2;
            this.BTListaVendedores.Text = "Lista Vendedores";
            this.BTListaVendedores.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // LPersonalGest
            // 
            this.LPersonalGest.AutoSize = true;
            this.LPersonalGest.BackColor = System.Drawing.Color.LightGray;
            this.LPersonalGest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPersonalGest.Location = new System.Drawing.Point(99, 94);
            this.LPersonalGest.Name = "LPersonalGest";
            this.LPersonalGest.Size = new System.Drawing.Size(81, 20);
            this.LPersonalGest.TabIndex = 5;
            this.LPersonalGest.Text = "Personal";
            this.LPersonalGest.Click += new System.EventHandler(this.label1_Click);
            // 
            // LProductosGest
            // 
            this.LProductosGest.AutoSize = true;
            this.LProductosGest.BackColor = System.Drawing.Color.LightGray;
            this.LProductosGest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductosGest.Location = new System.Drawing.Point(99, 261);
            this.LProductosGest.Name = "LProductosGest";
            this.LProductosGest.Size = new System.Drawing.Size(93, 20);
            this.LProductosGest.TabIndex = 6;
            this.LProductosGest.Text = "Productos";
            // 
            // BTBajaVendedor
            // 
            this.BTBajaVendedor.Location = new System.Drawing.Point(27, 170);
            this.BTBajaVendedor.Name = "BTBajaVendedor";
            this.BTBajaVendedor.Size = new System.Drawing.Size(218, 33);
            this.BTBajaVendedor.TabIndex = 7;
            this.BTBajaVendedor.Text = "Baja Vendedor";
            this.BTBajaVendedor.UseVisualStyleBackColor = true;
            // 
            // FormMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.PGerente2);
            this.Controls.Add(this.PGerente1);
            this.Name = "FormMenuGerente";
            this.Text = "FormMenuGerente";
            this.PGerente1.ResumeLayout(false);
            this.PGerente1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PGerente1;
        private System.Windows.Forms.Panel PGerente2;
        private System.Windows.Forms.Label LMenuGerente;
        private System.Windows.Forms.Button BTAltaVendedor;
        private System.Windows.Forms.Label LPersonalGest;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTListaVendedores;
        private System.Windows.Forms.Label LProductosGest;
        private System.Windows.Forms.Button BTBajaVendedor;
    }
}