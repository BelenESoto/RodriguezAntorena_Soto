namespace Antorena_Soto.CPresentacion.Vendedor
{
    partial class ventaConfirmar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTSBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBTipoFact = new System.Windows.Forms.TextBox();
            this.DTFechaAct = new System.Windows.Forms.DateTimePicker();
            this.BFinalizarPago = new System.Windows.Forms.Button();
            this.LDatosBajaUs = new System.Windows.Forms.Label();
            this.LFechaNacVendedor = new System.Windows.Forms.Label();
            this.LCuitVendedor = new System.Windows.Forms.Label();
            this.TBCiudadFact = new System.Windows.Forms.TextBox();
            this.TBCuitFact = new System.Windows.Forms.TextBox();
            this.TBNombreFact = new System.Windows.Forms.TextBox();
            this.TBMontoFact = new System.Windows.Forms.TextBox();
            this.LCiudadVendedor = new System.Windows.Forms.Label();
            this.LTelefonoVendedor = new System.Windows.Forms.Label();
            this.LCorreoVendedor = new System.Windows.Forms.Label();
            this.LProvinviaVendedor = new System.Windows.Forms.Label();
            this.LDniVendedor = new System.Windows.Forms.Label();
            this.TBMedioPagoFact = new System.Windows.Forms.TextBox();
            this.TBDniFact = new System.Windows.Forms.TextBox();
            this.TBuscador = new System.Windows.Forms.ToolStrip();
            this.BBuscarCliente = new System.Windows.Forms.ToolStripDropDownButton();
            this.dNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORNOMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBuscarPor = new System.Windows.Forms.ToolStripLabel();
            this.TBBuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.LBajaUsuario = new System.Windows.Forms.Label();
            this.PFacturaOpciones = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTSBusquedaCliente);
            this.panel2.Controls.Add(this.LBajaUsuario);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.TBuscador);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 466);
            this.panel2.TabIndex = 8;
            // 
            // BTSBusquedaCliente
            // 
            this.BTSBusquedaCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTSBusquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSBusquedaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTSBusquedaCliente.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BTSBusquedaCliente.IconColor = System.Drawing.Color.Black;
            this.BTSBusquedaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTSBusquedaCliente.IconSize = 36;
            this.BTSBusquedaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSBusquedaCliente.Location = new System.Drawing.Point(442, 55);
            this.BTSBusquedaCliente.Name = "BTSBusquedaCliente";
            this.BTSBusquedaCliente.Size = new System.Drawing.Size(125, 35);
            this.BTSBusquedaCliente.TabIndex = 7;
            this.BTSBusquedaCliente.Text = "Buscar";
            this.BTSBusquedaCliente.UseVisualStyleBackColor = false;
            this.BTSBusquedaCliente.Click += new System.EventHandler(this.BTSBusquedaCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.PFacturaOpciones);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBTipoFact);
            this.panel1.Controls.Add(this.DTFechaAct);
            this.panel1.Controls.Add(this.BFinalizarPago);
            this.panel1.Controls.Add(this.LDatosBajaUs);
            this.panel1.Controls.Add(this.LFechaNacVendedor);
            this.panel1.Controls.Add(this.LCuitVendedor);
            this.panel1.Controls.Add(this.TBCiudadFact);
            this.panel1.Controls.Add(this.TBCuitFact);
            this.panel1.Controls.Add(this.TBNombreFact);
            this.panel1.Controls.Add(this.TBMontoFact);
            this.panel1.Controls.Add(this.LCiudadVendedor);
            this.panel1.Controls.Add(this.LTelefonoVendedor);
            this.panel1.Controls.Add(this.LCorreoVendedor);
            this.panel1.Controls.Add(this.LProvinviaVendedor);
            this.panel1.Controls.Add(this.LDniVendedor);
            this.panel1.Controls.Add(this.TBMedioPagoFact);
            this.panel1.Controls.Add(this.TBDniFact);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 371);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(206, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tipo Factura";
            // 
            // TBTipoFact
            // 
            this.TBTipoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTipoFact.Location = new System.Drawing.Point(210, 202);
            this.TBTipoFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBTipoFact.MaxLength = 11;
            this.TBTipoFact.Name = "TBTipoFact";
            this.TBTipoFact.Size = new System.Drawing.Size(134, 26);
            this.TBTipoFact.TabIndex = 52;
            this.TBTipoFact.TextChanged += new System.EventHandler(this.TBTipoFact_TextChanged);
            // 
            // DTFechaAct
            // 
            this.DTFechaAct.Location = new System.Drawing.Point(18, 266);
            this.DTFechaAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTFechaAct.Name = "DTFechaAct";
            this.DTFechaAct.Size = new System.Drawing.Size(271, 20);
            this.DTFechaAct.TabIndex = 51;
            this.DTFechaAct.ValueChanged += new System.EventHandler(this.DTFechaNacVendedor_ValueChanged);
            // 
            // BFinalizarPago
            // 
            this.BFinalizarPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BFinalizarPago.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFinalizarPago.Location = new System.Drawing.Point(364, 254);
            this.BFinalizarPago.Name = "BFinalizarPago";
            this.BFinalizarPago.Size = new System.Drawing.Size(159, 43);
            this.BFinalizarPago.TabIndex = 8;
            this.BFinalizarPago.Text = "FINALIZAR PAGO";
            this.BFinalizarPago.UseVisualStyleBackColor = false;
            this.BFinalizarPago.Click += new System.EventHandler(this.BBorrar_Click);
            // 
            // LDatosBajaUs
            // 
            this.LDatosBajaUs.AutoSize = true;
            this.LDatosBajaUs.BackColor = System.Drawing.Color.LightGray;
            this.LDatosBajaUs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDatosBajaUs.Location = new System.Drawing.Point(19, 9);
            this.LDatosBajaUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDatosBajaUs.Name = "LDatosBajaUs";
            this.LDatosBajaUs.Size = new System.Drawing.Size(186, 18);
            this.LDatosBajaUs.TabIndex = 6;
            this.LDatosBajaUs.Text = "DATOS FACTURACION";
            this.LDatosBajaUs.Click += new System.EventHandler(this.LDatosBajaUs_Click);
            // 
            // LFechaNacVendedor
            // 
            this.LFechaNacVendedor.AutoSize = true;
            this.LFechaNacVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNacVendedor.ForeColor = System.Drawing.Color.Black;
            this.LFechaNacVendedor.Location = new System.Drawing.Point(18, 243);
            this.LFechaNacVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LFechaNacVendedor.Name = "LFechaNacVendedor";
            this.LFechaNacVendedor.Size = new System.Drawing.Size(129, 19);
            this.LFechaNacVendedor.TabIndex = 50;
            this.LFechaNacVendedor.Text = "Fecha Actual";
            // 
            // LCuitVendedor
            // 
            this.LCuitVendedor.AutoSize = true;
            this.LCuitVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCuitVendedor.ForeColor = System.Drawing.Color.Black;
            this.LCuitVendedor.Location = new System.Drawing.Point(311, 37);
            this.LCuitVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCuitVendedor.Name = "LCuitVendedor";
            this.LCuitVendedor.Size = new System.Drawing.Size(49, 19);
            this.LCuitVendedor.TabIndex = 48;
            this.LCuitVendedor.Text = "CUIT";
            // 
            // TBCiudadFact
            // 
            this.TBCiudadFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCiudadFact.Location = new System.Drawing.Point(311, 106);
            this.TBCiudadFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBCiudadFact.MaxLength = 100;
            this.TBCiudadFact.Name = "TBCiudadFact";
            this.TBCiudadFact.Size = new System.Drawing.Size(202, 26);
            this.TBCiudadFact.TabIndex = 40;
            this.TBCiudadFact.TextChanged += new System.EventHandler(this.TBCiudadFact_TextChanged);
            // 
            // TBCuitFact
            // 
            this.TBCuitFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCuitFact.Location = new System.Drawing.Point(311, 58);
            this.TBCuitFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBCuitFact.MaxLength = 11;
            this.TBCuitFact.Name = "TBCuitFact";
            this.TBCuitFact.Size = new System.Drawing.Size(202, 26);
            this.TBCuitFact.TabIndex = 49;
            this.TBCuitFact.TextChanged += new System.EventHandler(this.TBCuitFact_TextChanged);
            // 
            // TBNombreFact
            // 
            this.TBNombreFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreFact.Location = new System.Drawing.Point(19, 106);
            this.TBNombreFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNombreFact.MaxLength = 100;
            this.TBNombreFact.Name = "TBNombreFact";
            this.TBNombreFact.Size = new System.Drawing.Size(248, 26);
            this.TBNombreFact.TabIndex = 39;
            this.TBNombreFact.TextChanged += new System.EventHandler(this.TBNombreFact_TextChanged);
            // 
            // TBMontoFact
            // 
            this.TBMontoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMontoFact.Location = new System.Drawing.Point(360, 202);
            this.TBMontoFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBMontoFact.MaxLength = 100;
            this.TBMontoFact.Name = "TBMontoFact";
            this.TBMontoFact.Size = new System.Drawing.Size(177, 26);
            this.TBMontoFact.TabIndex = 47;
            this.TBMontoFact.TextChanged += new System.EventHandler(this.TBMontoFact_TextChanged);
            // 
            // LCiudadVendedor
            // 
            this.LCiudadVendedor.AutoSize = true;
            this.LCiudadVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudadVendedor.ForeColor = System.Drawing.Color.Black;
            this.LCiudadVendedor.Location = new System.Drawing.Point(311, 85);
            this.LCiudadVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCiudadVendedor.Name = "LCiudadVendedor";
            this.LCiudadVendedor.Size = new System.Drawing.Size(69, 19);
            this.LCiudadVendedor.TabIndex = 38;
            this.LCiudadVendedor.Text = "Ciudad";
            // 
            // LTelefonoVendedor
            // 
            this.LTelefonoVendedor.AutoSize = true;
            this.LTelefonoVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefonoVendedor.ForeColor = System.Drawing.Color.Black;
            this.LTelefonoVendedor.Location = new System.Drawing.Point(13, 181);
            this.LTelefonoVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTelefonoVendedor.Name = "LTelefonoVendedor";
            this.LTelefonoVendedor.Size = new System.Drawing.Size(139, 19);
            this.LTelefonoVendedor.TabIndex = 43;
            this.LTelefonoVendedor.Text = "Medio de Pago";
            // 
            // LCorreoVendedor
            // 
            this.LCorreoVendedor.AutoSize = true;
            this.LCorreoVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCorreoVendedor.ForeColor = System.Drawing.Color.Black;
            this.LCorreoVendedor.Location = new System.Drawing.Point(360, 179);
            this.LCorreoVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCorreoVendedor.Name = "LCorreoVendedor";
            this.LCorreoVendedor.Size = new System.Drawing.Size(119, 19);
            this.LCorreoVendedor.TabIndex = 46;
            this.LCorreoVendedor.Text = "Monto Final";
            // 
            // LProvinviaVendedor
            // 
            this.LProvinviaVendedor.AutoSize = true;
            this.LProvinviaVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvinviaVendedor.ForeColor = System.Drawing.Color.Black;
            this.LProvinviaVendedor.Location = new System.Drawing.Point(16, 85);
            this.LProvinviaVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LProvinviaVendedor.Name = "LProvinviaVendedor";
            this.LProvinviaVendedor.Size = new System.Drawing.Size(179, 19);
            this.LProvinviaVendedor.TabIndex = 37;
            this.LProvinviaVendedor.Text = "Nombre y Apellido";
            // 
            // LDniVendedor
            // 
            this.LDniVendedor.AutoSize = true;
            this.LDniVendedor.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDniVendedor.ForeColor = System.Drawing.Color.Black;
            this.LDniVendedor.Location = new System.Drawing.Point(16, 37);
            this.LDniVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LDniVendedor.Name = "LDniVendedor";
            this.LDniVendedor.Size = new System.Drawing.Size(39, 19);
            this.LDniVendedor.TabIndex = 35;
            this.LDniVendedor.Text = "DNI";
            // 
            // TBMedioPagoFact
            // 
            this.TBMedioPagoFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMedioPagoFact.Location = new System.Drawing.Point(11, 202);
            this.TBMedioPagoFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBMedioPagoFact.MaxLength = 10;
            this.TBMedioPagoFact.Name = "TBMedioPagoFact";
            this.TBMedioPagoFact.Size = new System.Drawing.Size(184, 26);
            this.TBMedioPagoFact.TabIndex = 44;
            this.TBMedioPagoFact.TextChanged += new System.EventHandler(this.TBMedioPagoFact_TextChanged);
            // 
            // TBDniFact
            // 
            this.TBDniFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDniFact.Location = new System.Drawing.Point(19, 58);
            this.TBDniFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBDniFact.MaxLength = 8;
            this.TBDniFact.Name = "TBDniFact";
            this.TBDniFact.Size = new System.Drawing.Size(248, 26);
            this.TBDniFact.TabIndex = 36;
            this.TBDniFact.TextChanged += new System.EventHandler(this.TBDniFact_TextChanged);
            // 
            // TBuscador
            // 
            this.TBuscador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBuscador.AutoSize = false;
            this.TBuscador.Dock = System.Windows.Forms.DockStyle.None;
            this.TBuscador.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TBuscador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BBuscarCliente,
            this.toolStripSeparator1,
            this.LBuscarPor,
            this.TBBuscarCliente});
            this.TBuscador.Location = new System.Drawing.Point(1, 53);
            this.TBuscador.Name = "TBuscador";
            this.TBuscador.Size = new System.Drawing.Size(572, 39);
            this.TBuscador.TabIndex = 5;
            this.TBuscador.Text = "toolStrip1";
            // 
            // BBuscarCliente
            // 
            this.BBuscarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BBuscarCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dNIToolStripMenuItem,
            this.pORNOMBREToolStripMenuItem});
            this.BBuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BBuscarCliente.Name = "BBuscarCliente";
            this.BBuscarCliente.Size = new System.Drawing.Size(111, 36);
            this.BBuscarCliente.Text = "BUSCAR CLIENTE";
            this.BBuscarCliente.Click += new System.EventHandler(this.BBuscarCliente_Click);
            // 
            // dNIToolStripMenuItem
            // 
            this.dNIToolStripMenuItem.Name = "dNIToolStripMenuItem";
            this.dNIToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dNIToolStripMenuItem.Text = "POR DNI";
            this.dNIToolStripMenuItem.Click += new System.EventHandler(this.dNIToolStripMenuItem_Click);
            // 
            // pORNOMBREToolStripMenuItem
            // 
            this.pORNOMBREToolStripMenuItem.Name = "pORNOMBREToolStripMenuItem";
            this.pORNOMBREToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pORNOMBREToolStripMenuItem.Text = "POR NOMBRE";
            this.pORNOMBREToolStripMenuItem.Click += new System.EventHandler(this.pORNOMBREToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // LBuscarPor
            // 
            this.LBuscarPor.Name = "LBuscarPor";
            this.LBuscarPor.Size = new System.Drawing.Size(0, 36);
            // 
            // TBBuscarCliente
            // 
            this.TBBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBBuscarCliente.Name = "TBBuscarCliente";
            this.TBBuscarCliente.Size = new System.Drawing.Size(276, 39);
            this.TBBuscarCliente.Click += new System.EventHandler(this.TBBuscarCliente_Click);
            // 
            // LBajaUsuario
            // 
            this.LBajaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBajaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.LBajaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBajaUsuario.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBajaUsuario.Location = new System.Drawing.Point(0, 5);
            this.LBajaUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBajaUsuario.Name = "LBajaUsuario";
            this.LBajaUsuario.Size = new System.Drawing.Size(573, 48);
            this.LBajaUsuario.TabIndex = 4;
            this.LBajaUsuario.Text = "CONFIRMAR VENTA";
            this.LBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PFacturaOpciones
            // 
            this.PFacturaOpciones.BackColor = System.Drawing.Color.White;
            this.PFacturaOpciones.Location = new System.Drawing.Point(0, 316);
            this.PFacturaOpciones.Name = "PFacturaOpciones";
            this.PFacturaOpciones.Padding = new System.Windows.Forms.Padding(3);
            this.PFacturaOpciones.Size = new System.Drawing.Size(575, 55);
            this.PFacturaOpciones.TabIndex = 9;
            // 
            // ventaConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 467);
            this.Controls.Add(this.panel2);
            this.Name = "ventaConfirmar";
            this.Text = "ventaConfirmar";
            this.Load += new System.EventHandler(this.ventaConfirmar_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TBuscador.ResumeLayout(false);
            this.TBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BTSBusquedaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BFinalizarPago;
        private System.Windows.Forms.Label LDatosBajaUs;
        private System.Windows.Forms.ToolStrip TBuscador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LBuscarPor;
        private System.Windows.Forms.ToolStripTextBox TBBuscarCliente;
        private System.Windows.Forms.Label LBajaUsuario;
        private System.Windows.Forms.ToolStripDropDownButton BBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem dNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORNOMBREToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker DTFechaAct;
        private System.Windows.Forms.Label LFechaNacVendedor;
        private System.Windows.Forms.Label LCuitVendedor;
        private System.Windows.Forms.TextBox TBCiudadFact;
        private System.Windows.Forms.TextBox TBCuitFact;
        private System.Windows.Forms.TextBox TBNombreFact;
        private System.Windows.Forms.TextBox TBMontoFact;
        private System.Windows.Forms.Label LCiudadVendedor;
        private System.Windows.Forms.Label LTelefonoVendedor;
        private System.Windows.Forms.Label LCorreoVendedor;
        private System.Windows.Forms.Label LProvinviaVendedor;
        private System.Windows.Forms.Label LDniVendedor;
        private System.Windows.Forms.TextBox TBMedioPagoFact;
        private System.Windows.Forms.TextBox TBDniFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTipoFact;
        private System.Windows.Forms.Panel PFacturaOpciones;
    }
}