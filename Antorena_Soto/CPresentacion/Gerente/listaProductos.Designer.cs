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
            this.DGVListaProd = new System.Windows.Forms.DataGridView();
            this.BEditarProd = new System.Windows.Forms.Button();
            this.BEliminarProd = new System.Windows.Forms.Button();
            this.TBBuscarProd = new System.Windows.Forms.TextBox();
            this.BBuscarPor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Location = new System.Drawing.Point(27, 127);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 51;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.Size = new System.Drawing.Size(761, 232);
            this.DGVListaProd.TabIndex = 1;
            // 
            // BEditarProd
            // 
            this.BEditarProd.Location = new System.Drawing.Point(577, 366);
            this.BEditarProd.Name = "BEditarProd";
            this.BEditarProd.Size = new System.Drawing.Size(75, 35);
            this.BEditarProd.TabIndex = 2;
            this.BEditarProd.Text = "EDITAR";
            this.BEditarProd.UseVisualStyleBackColor = true;
            // 
            // BEliminarProd
            // 
            this.BEliminarProd.Location = new System.Drawing.Point(658, 365);
            this.BEliminarProd.Name = "BEliminarProd";
            this.BEliminarProd.Size = new System.Drawing.Size(90, 36);
            this.BEliminarProd.TabIndex = 3;
            this.BEliminarProd.Text = "ELIMINAR";
            this.BEliminarProd.UseVisualStyleBackColor = true;
            // 
            // TBBuscarProd
            // 
            this.TBBuscarProd.Location = new System.Drawing.Point(179, 37);
            this.TBBuscarProd.Name = "TBBuscarProd";
            this.TBBuscarProd.Size = new System.Drawing.Size(395, 22);
            this.TBBuscarProd.TabIndex = 4;
            // 
            // BBuscarPor
            // 
            this.BBuscarPor.Location = new System.Drawing.Point(80, 34);
            this.BBuscarPor.Name = "BBuscarPor";
            this.BBuscarPor.Size = new System.Drawing.Size(72, 24);
            this.BBuscarPor.TabIndex = 5;
            this.BBuscarPor.Text = "button1";
            this.BBuscarPor.UseVisualStyleBackColor = true;
            // 
            // listaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BBuscarPor);
            this.Controls.Add(this.TBBuscarProd);
            this.Controls.Add(this.BEliminarProd);
            this.Controls.Add(this.BEditarProd);
            this.Controls.Add(this.DGVListaProd);
            this.Name = "listaProductos";
            this.Text = "listaProductos";
            this.Load += new System.EventHandler(this.listaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.Button BEditarProd;
        private System.Windows.Forms.Button BEliminarProd;
        private System.Windows.Forms.TextBox TBBuscarProd;
        private System.Windows.Forms.Button BBuscarPor;
    }
}