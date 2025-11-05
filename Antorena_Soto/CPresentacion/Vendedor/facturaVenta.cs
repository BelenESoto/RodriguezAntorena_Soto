using Antorena_Soto.CDatos; 
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class facturaVenta : Form
    {
        public Factura FacturaMostrada { get; set; }
        public DataRow ClienteMostrado { get; set; }
        public facturaVenta()
        {
            InitializeComponent();
        }

        private void LProvincia_Click(object sender, EventArgs e)
        {

        }

        // --- MÉTODO LOAD MODIFICADO ---
        private void facturaVenta_Load(object sender, EventArgs e)
        {
            // Verificamos que los datos hayan sido pasados
            if (FacturaMostrada != null && ClienteMostrado != null)
            {
                PoblarDatos();
            }
            else
            {
                MessageBox.Show("Error: No se pudieron cargar los datos de la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // --- NUEVO ---
        // Método privado para cargar los datos en los Labels
        private void PoblarDatos()
        {
            try
            {
                // Datos del Cliente (desde la DataRow)
                label1Cuit.Text = Convert.ToString(ClienteMostrado["cuit"]);
                LNomCliente.Text = Convert.ToString(ClienteMostrado["nomYApe_cliente"]);
                label3.Text = Convert.ToString(ClienteMostrado["domicilio"]);
                label2.Text = Convert.ToString(ClienteMostrado["correo"]);

                // Datos de la Factura (desde el objeto Factura)
                label7.Text = FacturaMostrada.nro_factura.ToString();
                label8.Text = FacturaMostrada.tipo_factura;
                label9.Text = FacturaMostrada.fecha_factura.ToShortDateString(); // Formato corto de fecha
                label17.Text = FacturaMostrada.forma_pago;
                label11.Text = FacturaMostrada.monto_total.ToString("C"); // "C" formatea como Moneda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poblar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
