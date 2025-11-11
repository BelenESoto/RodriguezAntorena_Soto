using Antorena_Soto.CDatos; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class facturaVenta : Form
    {
        private string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
        public Factura FacturaMostrada { get; set; }
        public DataRow ClienteMostrado { get; set; }
        public facturaVenta()
        {
            InitializeComponent();
        }
        public facturaVenta(int idFactura)
        {
            InitializeComponent();
            CargarFactura(idFactura);
        }
        private void CargarFactura(int idFactura)
        {
            string consulta = @"
        SELECT 
            P.codigo_prod AS Codigo,
            P.nombre_prod AS Nombre,
            CAT.nombre_categoria AS Categoria,
            DV.precio AS Precio,
            DV.cantidad AS Cantidad,
            (DV.cantidad * DV.precio) AS Subtotal
        FROM Detalle_venta DV
        INNER JOIN Producto P ON DV.id_producto = P.id_producto
        INNER JOIN Categoria CAT ON P.id_categoria = CAT.id_categoria
        WHERE DV.id_factura = @IdFactura";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlCommand cmd = new SqlCommand(consulta, con))
            {
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tablaDetalle = new DataTable();
                da.Fill(tablaDetalle);

                DGVListaProd.DataSource = tablaDetalle;
            }

            // Ajuste de nombres visuales
            DGVListaProd.Columns["Codigo"].HeaderText = "Código";
            DGVListaProd.Columns["Nombre"].HeaderText = "Nombre";
            DGVListaProd.Columns["Categoria"].HeaderText = "Categoría";
            DGVListaProd.Columns["Precio"].HeaderText = "Precio";
            DGVListaProd.Columns["Cantidad"].HeaderText = "Cantidad";
            DGVListaProd.Columns["Subtotal"].HeaderText = "Subtotal";

            DGVListaProd.Columns["Precio"].DefaultCellStyle.Format = "C2";
            DGVListaProd.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            DGVListaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
