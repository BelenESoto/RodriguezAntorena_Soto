namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class facturaVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LFechaFact = new System.Windows.Forms.Label();
            this.LFactN = new System.Windows.Forms.Label();
            this.label1Cuit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LFacturaA = new System.Windows.Forms.Label();
            this.LNomCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LCuit = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LProvincia = new System.Windows.Forms.Label();
            this.PLogo = new System.Windows.Forms.PictureBox();
            this.LNombreSkorial = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirFac = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVListaProd
            // 
            this.DGVListaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListaProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVListaProd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVListaProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListaProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DGVListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Categoria_producto,
            this.Precio_producto,
            this.Cantidad_producto,
            this.Subtotal_producto});
            this.DGVListaProd.Location = new System.Drawing.Point(10, 287);
            this.DGVListaProd.Margin = new System.Windows.Forms.Padding(2);
            this.DGVListaProd.Name = "DGVListaProd";
            this.DGVListaProd.RowHeadersWidth = 15;
            this.DGVListaProd.RowTemplate.Height = 24;
            this.DGVListaProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVListaProd.Size = new System.Drawing.Size(663, 280);
            this.DGVListaProd.TabIndex = 39;
            this.DGVListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListaProd_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.DGVListaProd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 705);
            this.panel1.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnImprimirFac);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(11, 572);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 119);
            this.panel4.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(552, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Monto ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(373, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "TOTAL FACTURA:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(37, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "FORMA DE PAGO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Nombre forma de pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "ITEMS ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.LFechaFact);
            this.panel3.Controls.Add(this.LFactN);
            this.panel3.Controls.Add(this.label1Cuit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.LFacturaA);
            this.panel3.Controls.Add(this.LNomCliente);
            this.panel3.Location = new System.Drawing.Point(10, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 119);
            this.panel3.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(554, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(602, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "nro factura ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "TIPO";
            // 
            // LFechaFact
            // 
            this.LFechaFact.AutoSize = true;
            this.LFechaFact.BackColor = System.Drawing.Color.White;
            this.LFechaFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaFact.Location = new System.Drawing.Point(483, 71);
            this.LFechaFact.Name = "LFechaFact";
            this.LFechaFact.Size = new System.Drawing.Size(58, 16);
            this.LFechaFact.TabIndex = 47;
            this.LFechaFact.Text = "Fecha: ";
            // 
            // LFactN
            // 
            this.LFactN.AutoSize = true;
            this.LFactN.BackColor = System.Drawing.Color.White;
            this.LFactN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFactN.Location = new System.Drawing.Point(348, 11);
            this.LFactN.Name = "LFactN";
            this.LFactN.Size = new System.Drawing.Size(98, 16);
            this.LFactN.TabIndex = 46;
            this.LFactN.Text = "FACTURA N°";
            // 
            // label1Cuit
            // 
            this.label1Cuit.AutoSize = true;
            this.label1Cuit.BackColor = System.Drawing.Color.White;
            this.label1Cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Cuit.Location = new System.Drawing.Point(105, 37);
            this.label1Cuit.Name = "label1Cuit";
            this.label1Cuit.Size = new System.Drawing.Size(38, 16);
            this.label1Cuit.TabIndex = 43;
            this.label1Cuit.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Direccion";
            // 
            // LFacturaA
            // 
            this.LFacturaA.AutoSize = true;
            this.LFacturaA.BackColor = System.Drawing.Color.White;
            this.LFacturaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFacturaA.Location = new System.Drawing.Point(3, 11);
            this.LFacturaA.Name = "LFacturaA";
            this.LFacturaA.Size = new System.Drawing.Size(96, 16);
            this.LFacturaA.TabIndex = 41;
            this.LFacturaA.Text = "FACTURA A:";
            // 
            // LNomCliente
            // 
            this.LNomCliente.AutoSize = true;
            this.LNomCliente.BackColor = System.Drawing.Color.White;
            this.LNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNomCliente.Location = new System.Drawing.Point(105, 11);
            this.LNomCliente.Name = "LNomCliente";
            this.LNomCliente.Size = new System.Drawing.Size(100, 16);
            this.LNomCliente.TabIndex = 40;
            this.LNomCliente.Text = "Nombre Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LCuit);
            this.panel2.Controls.Add(this.LEmail);
            this.panel2.Controls.Add(this.LDireccion);
            this.panel2.Controls.Add(this.LProvincia);
            this.panel2.Controls.Add(this.PLogo);
            this.panel2.Controls.Add(this.LNombreSkorial);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 119);
            this.panel2.TabIndex = 44;
            // 
            // LCuit
            // 
            this.LCuit.AutoSize = true;
            this.LCuit.BackColor = System.Drawing.Color.White;
            this.LCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCuit.Location = new System.Drawing.Point(465, 64);
            this.LCuit.Name = "LCuit";
            this.LCuit.Size = new System.Drawing.Size(92, 16);
            this.LCuit.TabIndex = 43;
            this.LCuit.Text = "77-32432432-2";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(507, 89);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(146, 16);
            this.LEmail.TabIndex = 45;
            this.LEmail.Text = "skorial.mw@gmail.com";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.BackColor = System.Drawing.Color.White;
            this.LDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(589, 37);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(64, 16);
            this.LDireccion.TabIndex = 42;
            this.LDireccion.Text = "Direccion";
            // 
            // LProvincia
            // 
            this.LProvincia.AutoSize = true;
            this.LProvincia.BackColor = System.Drawing.Color.White;
            this.LProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvincia.Location = new System.Drawing.Point(474, 12);
            this.LProvincia.Name = "LProvincia";
            this.LProvincia.Size = new System.Drawing.Size(179, 16);
            this.LProvincia.TabIndex = 41;
            this.LProvincia.Text = "Corrientes, Capital. Argentina";
            this.LProvincia.Click += new System.EventHandler(this.LProvincia_Click);
            // 
            // PLogo
            // 
            this.PLogo.BackColor = System.Drawing.Color.Transparent;
            this.PLogo.BackgroundImage = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.PLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLogo.InitialImage = global::Antorena_Soto.Properties.Resources.DSC08269__1___1_;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(127, 117);
            this.PLogo.TabIndex = 0;
            this.PLogo.TabStop = false;
            // 
            // LNombreSkorial
            // 
            this.LNombreSkorial.AutoSize = true;
            this.LNombreSkorial.BackColor = System.Drawing.Color.White;
            this.LNombreSkorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreSkorial.Location = new System.Drawing.Point(563, 64);
            this.LNombreSkorial.Name = "LNombreSkorial";
            this.LNombreSkorial.Size = new System.Drawing.Size(90, 16);
            this.LNombreSkorial.TabIndex = 40;
            this.LNombreSkorial.Text = "SKORIAL S.A.";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo_producto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_producto";
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion_prod";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Categoria_producto
            // 
            this.Categoria_producto.DataPropertyName = "categoria_producto";
            this.Categoria_producto.HeaderText = "Categoria";
            this.Categoria_producto.MinimumWidth = 6;
            this.Categoria_producto.Name = "Categoria_producto";
            // 
            // Precio_producto
            // 
            this.Precio_producto.DataPropertyName = "precio_producto";
            this.Precio_producto.HeaderText = "Precio";
            this.Precio_producto.MinimumWidth = 6;
            this.Precio_producto.Name = "Precio_producto";
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.DataPropertyName = "cantidad_producto";
            this.Cantidad_producto.HeaderText = "Cantidad";
            this.Cantidad_producto.MinimumWidth = 6;
            this.Cantidad_producto.Name = "Cantidad_producto";
            // 
            // Subtotal_producto
            // 
            this.Subtotal_producto.DataPropertyName = "subtotal_producto";
            this.Subtotal_producto.HeaderText = "Subtotal";
            this.Subtotal_producto.MinimumWidth = 6;
            this.Subtotal_producto.Name = "Subtotal_producto";
            // 
            // btnImprimirFac
            // 
            this.btnImprimirFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFac.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimirFac.IconColor = System.Drawing.Color.Black;
            this.btnImprimirFac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirFac.Location = new System.Drawing.Point(429, 69);
            this.btnImprimirFac.Name = "btnImprimirFac";
            this.btnImprimirFac.Size = new System.Drawing.Size(164, 35);
            this.btnImprimirFac.TabIndex = 48;
            this.btnImprimirFac.Text = "IMPRIMIR";
            this.btnImprimirFac.UseVisualStyleBackColor = true;
            this.btnImprimirFac.Click += new System.EventHandler(this.btnImprimirFac_Click);
            // 
            // facturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 704);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "facturaVenta";
            this.Text = "facturaVenta";
            this.Load += new System.EventHandler(this.facturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListaProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LProvincia;
        private System.Windows.Forms.Label LNombreSkorial;
        private System.Windows.Forms.Label LCuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PLogo;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1Cuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LFacturaA;
        private System.Windows.Forms.Label LNomCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LFechaFact;
        private System.Windows.Forms.Label LFactN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal_producto;
        private FontAwesome.Sharp.IconButton btnImprimirFac;
    }
}