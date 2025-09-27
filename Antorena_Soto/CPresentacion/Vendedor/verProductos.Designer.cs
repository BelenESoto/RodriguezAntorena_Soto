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
            this.DGVVerProd = new System.Windows.Forms.DataGridView();
            this.pVerProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVerProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pVerProd
            // 
            this.pVerProd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pVerProd.Controls.Add(this.DGVVerProd);
            this.pVerProd.Location = new System.Drawing.Point(1, 0);
            this.pVerProd.Name = "pVerProd";
            this.pVerProd.Size = new System.Drawing.Size(748, 450);
            this.pVerProd.TabIndex = 0;
            // 
            // DGVVerProd
            // 
            this.DGVVerProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVerProd.Location = new System.Drawing.Point(3, 65);
            this.DGVVerProd.Name = "DGVVerProd";
            this.DGVVerProd.RowHeadersWidth = 51;
            this.DGVVerProd.RowTemplate.Height = 24;
            this.DGVVerProd.Size = new System.Drawing.Size(734, 326);
            this.DGVVerProd.TabIndex = 0;
            // 
            // verProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.pVerProd);
            this.Name = "verProductos";
            this.Text = "verProductos";
            this.pVerProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVerProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pVerProd;
        private System.Windows.Forms.DataGridView DGVVerProd;
    }
}