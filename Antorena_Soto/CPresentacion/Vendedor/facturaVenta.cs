using Antorena_Soto.CDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Solo necesitas uno de estos
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class facturaVenta : Form
    {
        private string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
        public Factura FacturaMostrada { get; set; }
        public DataRow ClienteMostrado { get; set; }

        private PrintDocument printDocument1 = new PrintDocument();
        private int currentRow = 0;
        public facturaVenta()
        {
            InitializeComponent();
            DGVListaProd.AutoGenerateColumns = false;
            printDocument1.PrintPage += PrintDocument1_PrintPage;
        }

        public facturaVenta(long idFactura)
        {
            InitializeComponent();
            CargarFactura(idFactura);
        }


        //Metodo para cargar los datos del detalle de la factura en el DataGridView
        private void CargarFactura(long idFactura)
        {
            string consulta = @"
    SELECT 
        P.codigo_prod AS codigo_producto,
        P.nombre_prod AS nombre_producto,
        P.descripcion_prod AS descripcion_prod,
        
        CASE P.categoria_prod 
            WHEN 1 THEN 'Collares'
            WHEN 2 THEN 'Aros'
            WHEN 3 THEN 'Otros'
            ELSE 'N/A'
        END AS categoria_producto,

        DV.precio AS precio_producto,
        DV.cantidad AS cantidad_producto,
        (DV.cantidad * DV.precio) AS subtotal_producto
    FROM Detalle_venta DV
    INNER JOIN Producto P ON DV.id_producto = P.codigo_prod
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

            DGVListaProd.Columns["precio_producto"].DefaultCellStyle.Format = "$#,##0.00";
            DGVListaProd.Columns["subtotal_producto"].DefaultCellStyle.Format = "$#,##0.00";

            DGVListaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVListaProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void LProvincia_Click(object sender, EventArgs e)
        {
        }

        //Acá verificamos que los datos estén cargados antes de poblar los Labels, cargar el detalle y datos de factura
        private void facturaVenta_Load(object sender, EventArgs e)
        {
            if (FacturaMostrada != null && ClienteMostrado != null)
            {
                PoblarDatos();
                CargarFactura(FacturaMostrada.nro_factura);
            }
            else
            {
                MessageBox.Show("Error: No se pudieron cargar los datos de la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Metodo para traer todos los datos en los labels
        private void PoblarDatos()
        {
            try
            {
                // Datos del Cliente 
                label1Cuit.Text = Convert.ToString(ClienteMostrado["cuit"]);
                LNomCliente.Text = Convert.ToString(ClienteMostrado["nomYApe_cliente"]);
                label3.Text = Convert.ToString(ClienteMostrado["domicilio"]);
                label2.Text = Convert.ToString(ClienteMostrado["correo"]);

                // Datos de la Factura 
                label7.Text = FacturaMostrada.nro_factura.ToString();
                label8.Text = FacturaMostrada.tipo_factura;
                label9.Text = FacturaMostrada.fecha_factura.ToShortDateString();
                label17.Text = FacturaMostrada.forma_pago;
                label11.Text = FacturaMostrada.monto_total.ToString("$#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poblar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Metodos para imprimir la factura
        private void btnImprimirFac_Click(object sender, EventArgs e)
        {
            currentRow = 0; 

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument1;
            preview.Width = 1200;
            preview.Height = 800;

            preview.ShowDialog(); 
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           

            int y = 20;
            int leftMargin = 40;
            Font font = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);

            
            e.Graphics.DrawString("FACTURA", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, leftMargin, y);
            y += 40;

            e.Graphics.DrawString("Cliente: " + LNomCliente.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("CUIT: " + label1Cuit.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("Domicilio: " + label3.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("Correo: " + label2.Text, font, Brushes.Black, leftMargin, y); y += 30;

            e.Graphics.DrawString("N° Factura: " + label7.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("Tipo: " + label8.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("Fecha: " + label9.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("Forma de Pago: " + label17.Text, font, Brushes.Black, leftMargin, y); y += 20;
            e.Graphics.DrawString("Total: " + label11.Text, fontBold, Brushes.Black, leftMargin, y); y += 30;

            
            e.Graphics.DrawString("Detalle de Productos", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, leftMargin, y);
            y += 30;

            
            e.Graphics.DrawString("Producto", fontBold, Brushes.Black, leftMargin, y);
            e.Graphics.DrawString("Cant.", fontBold, Brushes.Black, leftMargin + 250, y);
            e.Graphics.DrawString("Precio", fontBold, Brushes.Black, leftMargin + 330, y);
            e.Graphics.DrawString("Subtotal", fontBold, Brushes.Black, leftMargin + 420, y);
            y += 20;

            while (currentRow < DGVListaProd.Rows.Count)
            {
                DataGridViewRow row = DGVListaProd.Rows[currentRow];

                if (row.IsNewRow)
                {
                    currentRow++;
                    continue;
                }

                if (y > e.MarginBounds.Bottom - 80)
                {
                    e.HasMorePages = true;
                    return;
                }

                string nombre = row.Cells["Nombre"].Value.ToString();
                string cantidad = row.Cells["Cantidad_producto"].Value.ToString();

                decimal precio = Convert.ToDecimal(row.Cells["Precio_producto"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal_producto"].Value);

               
                e.Graphics.DrawString(nombre, font, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(cantidad, font, Brushes.Black, leftMargin + 250, y);
                e.Graphics.DrawString(precio.ToString("$#,##0.00"), font, Brushes.Black, leftMargin + 330, y);
                e.Graphics.DrawString(subtotal.ToString("$#,##0.00"), font, Brushes.Black, leftMargin + 420, y);


                y += 25;
                currentRow++;
            }

            e.HasMorePages = false;
        }
    }
}