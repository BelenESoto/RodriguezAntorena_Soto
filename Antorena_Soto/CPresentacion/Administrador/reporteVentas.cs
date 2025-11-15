
using Antorena_Soto.CDatos;
using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Administrador
{
    public partial class reporteVentas : Form
    {
        private string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
        private DataTable ventasTabla;   

        private string modoBusqueda = "Fecha";
       
        private PrintDocument printDocument;
        private string textoAImprimir;
       

        public reporteVentas()
        {
            InitializeComponent();
            dtpFecha.Visible = false;
        }

        //Configuramos columnas y el DGV, cargamos las ventas al DGV
        private void reporteVentas_Load_1(object sender, EventArgs e)
        {
            DGVentas1.DefaultCellStyle.ForeColor = Color.Black;
            ConfigurarColumnas();
            DGVentas1.ColumnHeadersVisible = true;
            DGVentas1.EnableHeadersVisualStyles = false;
            DGVentas1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            DGVentas1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DGVentas1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            CargarVentasDesdeBD();
        }

        private void ConfigurarColumnas()
        {

            
            DGVentas1.AutoGenerateColumns = false;
            DGVentas1.Columns.Clear();
            DGVentas1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo", 
                HeaderText = "Código",
                DataPropertyName = "codigo_venta" 
            });
            DGVentas1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente", 
                HeaderText = "Cliente",
                DataPropertyName = "cliente_venta" 
            });
            DGVentas1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "fecha_venta"
            });

            DGVentas1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Vendedor_resp", 
                HeaderText = "Vendedor",
                DataPropertyName = "vendedor_resp" 
            });

            DGVentas1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_venta",
                HeaderText = "Total",
                DataPropertyName = "total_venta"
            });
           
            //Config boton de detalle
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.Name = "BDetalle";
            colBtn.HeaderText = "Detalle";
            colBtn.Text = "Ver"; 
            colBtn.UseColumnTextForButtonValue = true; 
            colBtn.Width = 80;
            DGVentas1.Columns.Add(colBtn);

       
        }

        private void CargarVentasDesdeBD()
        {
            string consulta = @"
        SELECT 
            F.nro_factura AS CodigoVenta,
            C.nomYApe_cliente AS Cliente,
            F.fecha_factura AS FechaVenta,
            U.nomYApe_usuario AS Vendedor,
            F.monto_total AS Total
           
        FROM Factura F
        INNER JOIN Cliente C ON F.id_cliente = C.dni_cliente
        INNER JOIN Usuario U ON F.vendedor_id = U.id_dni_usuario
        ORDER BY F.fecha_factura DESC";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlDataAdapter da = new SqlDataAdapter(consulta, con))
            {
                ventasTabla = new DataTable();
                da.Fill(ventasTabla);

                DGVentas1.Rows.Clear();

                foreach (DataRow row in ventasTabla.Rows)
                {
                    DGVentas1.Rows.Add(
                        row["CodigoVenta"],
                        row["Cliente"],
                        Convert.ToDateTime(row["FechaVenta"]).ToString("dd/MM/yyyy"),
                        row["Vendedor"],
                       Convert.ToDecimal(row["Total"]).ToString("$#,##0.00")
                       
                    );
                }
            }
        }


        private void toolFecha_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Fecha";
            tsdFiltroBusqueda.Text = "Fecha";
            TBBuscarProducto.Clear();

            dtpFecha.Visible = true;
            dtpFecha.Focus();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            TBBuscarProducto.Text = dtpFecha.Value.ToShortDateString();
            dtpFecha.Visible = false;
        }

        private void toolCliente_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Cliente";
            tsdFiltroBusqueda.Text = "Cliente";
            dtpFecha.Visible = false;
            TBBuscarProducto.Clear();

        }

        private void toolVendedor_Click(object sender, EventArgs e)
        {
            modoBusqueda = "Vendedor";
            tsdFiltroBusqueda.Text = "Vendedor";
            dtpFecha.Visible = false;
            TBBuscarProducto.Clear();
        }

        private void toolProducto_Click(object sender, EventArgs e)
        {
            modoBusqueda = "CodVenta";
            tsdFiltroBusqueda.Text = "Cod de Venta";
            dtpFecha.Visible = false;
            TBBuscarProducto.Clear();
        }

        private void BTSBusquedaProd_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterio))
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BuscarVentasDesdeBD(criterio);
        }


        //Metodo para buscar ventas segun el criterio seleccionado
        private void BuscarVentasDesdeBD(string criterio)
        {
            string where = "";
            SqlCommand cmd = new SqlCommand();

            switch (modoBusqueda)
            {
                case "Fecha":
                    if (!DateTime.TryParse(criterio, out DateTime fecha))
                    {
                        MessageBox.Show("Ingrese una fecha válida.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE CONVERT(date, F.fecha_factura) = @Fecha";
                    cmd.Parameters.AddWithValue("@Fecha", fecha.Date);
                    break;

                case "Cliente":
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("El DNI del cliente debe ser numérico.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE C.dni_cliente = @DNICliente";
                    cmd.Parameters.AddWithValue("@DNICliente", criterio);
                    break;

                case "Vendedor":
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("El DNI del vendedor debe ser numérico.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE U.id_dni_usuario = @DNIVend";
                    cmd.Parameters.AddWithValue("@DNIVend", criterio);
                    break;

                case "CodVenta":
                    if (!criterio.All(char.IsDigit))
                    {
                        MessageBox.Show("El código debe ser numérico.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    where = "WHERE F.nro_factura = @Cod";
                    cmd.Parameters.AddWithValue("@Cod", int.Parse(criterio));
                    break;
            }

            string consulta = $@"
                SELECT 
                    F.nro_factura AS CodigoVenta,
                    C.nomYApe_cliente AS Cliente,
                    F.fecha_factura AS FechaVenta,
                    U.nomYApe_usuario AS Vendedor,
                    F.monto_total AS Total
                FROM Factura F
                INNER JOIN Cliente C ON F.id_cliente = C.dni_cliente
                INNER JOIN Usuario U ON F.vendedor_id = U.id_dni_usuario
                {where}
                ORDER BY F.fecha_factura DESC";

            cmd.CommandText = consulta;
            cmd.Connection = new SqlConnection(conexionString);

            DataTable resultado = new DataTable();

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }

            DGVentas1.Rows.Clear();

            foreach (DataRow row in resultado.Rows)
            {
                DGVentas1.Rows.Add(
                    row["CodigoVenta"],
                    row["Cliente"],
                    Convert.ToDateTime(row["FechaVenta"]).ToString("dd/MM/yyyy"),
                    row["Vendedor"],
                    Convert.ToDecimal(row["Total"]).ToString("$#,##0.00")
                );
            }
        }
        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            if (DGVentas1.Rows[e.RowIndex].IsNewRow) return;

            if (DGVentas1.Columns[e.ColumnIndex].Name == "BDetalle")
            {
                long idFactura = Convert.ToInt64(
                    DGVentas1.Rows[e.RowIndex].Cells["Codigo"].Value);

                Factura facturaParaMostrar = null;
                DataRow clienteParaMostrar = null;

                try
                {
                    using (SqlConnection con = new SqlConnection(conexionString))
                    {
                        con.Open();
                        //Consulta para factura
                        string qFactura = "SELECT * FROM Factura WHERE nro_factura = @Id";
                        using (SqlCommand cmdFactura = new SqlCommand(qFactura, con))
                        {
                            cmdFactura.Parameters.AddWithValue("@Id", idFactura);
                            SqlDataAdapter daFactura = new SqlDataAdapter(cmdFactura);
                            DataTable dtFactura = new DataTable();
                            daFactura.Fill(dtFactura);

                            if (dtFactura.Rows.Count == 0)
                            {
                                MessageBox.Show("Error: No se encontró la factura.");
                                return;
                            }

                            DataRow fRow = dtFactura.Rows[0];
                            facturaParaMostrar = new Factura
                            {
                                nro_factura = Convert.ToInt64(fRow["nro_factura"]),
                                tipo_factura = Convert.ToString(fRow["tipo_factura"]),
                                id_cliente = Convert.ToInt32(fRow["id_cliente"]),
                                fecha_factura = Convert.ToDateTime(fRow["fecha_factura"]),
                                forma_pago = Convert.ToString(fRow["forma_pago"]),
                                monto_total = Convert.ToInt64(fRow["monto_total"]),
                                estado_factura = Convert.ToInt32(fRow["estado_factura"]),
                                vendedor_id = Convert.ToInt32(fRow["vendedor_id"])
                            };
                        }

                 //Consulta para cliente
                        string qCliente = "SELECT * FROM Cliente WHERE dni_cliente = @IdCliente";
                        using (SqlCommand cmdCliente = new SqlCommand(qCliente, con))
                        {
                            cmdCliente.Parameters.AddWithValue("@IdCliente", facturaParaMostrar.id_cliente);
                            SqlDataAdapter daCliente = new SqlDataAdapter(cmdCliente);
                            DataTable dtCliente = new DataTable();
                            daCliente.Fill(dtCliente);

                            if (dtCliente.Rows.Count == 0)
                            {
                                MessageBox.Show("Error: No se encontró el cliente asociado.");
                                return;
                            }
                            clienteParaMostrar = dtCliente.Rows[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al recuperar los datos de la factura: " + ex.Message);
                    return;
                }

                
                facturaVenta form = new facturaVenta();
                form.FacturaMostrada = facturaParaMostrar;
                form.ClienteMostrado = clienteParaMostrar;

                form.ShowDialog();
            }
        }
        // Botón Imprimir
        private void bImprimir_Click(object sender, EventArgs e)
        {
            if (DGVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("REPORTE DE VENTAS");
            sb.AppendLine(new string('=', 100));
            sb.AppendLine($"{"Código",-10} {"Cliente",-20} {"Fecha",-12} {"Vendedor",-20} {"Total",-10}");
            sb.AppendLine(new string('-', 100));

            foreach (DataGridViewRow row in DGVentas.Rows)
            {
                if (row.IsNewRow) continue;
                sb.AppendLine(
                    $"{row.Cells["CodigoVenta"].Value,-10} " +
                    $"{row.Cells["Cliente"].Value,-20} " +
                    $"{row.Cells["FechaVenta"].Value,-12} " +
                    $"{row.Cells["Vendedor"].Value,-20} " +
                    $"{row.Cells["Total"].Value,-10}"
                );
            }

            textoAImprimir = sb.ToString();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.Width = 800;
            preview.Height = 600;
            preview.StartPosition = FormStartPosition.CenterScreen;
            preview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Consolas", 10);
            e.Graphics.DrawString(textoAImprimir, fuente, Brushes.Black,
                new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top,
                e.MarginBounds.Width, e.MarginBounds.Height));
        }

        private void pReporteVenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsdFiltroBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void toolStripRepVenta_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TBBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void lReporteVentas_Click(object sender, EventArgs e)
        {

        }

        private void DGVentas1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVentas1.Rows[e.RowIndex].IsNewRow) return;

            if (DGVentas1.Columns[e.ColumnIndex].Name == "BDetalle")
            {
                long idFactura = Convert.ToInt64(
                    DGVentas1.Rows[e.RowIndex].Cells["Codigo"].Value);

                Factura facturaParaMostrar = null;
                DataRow clienteParaMostrar = null;

                try
                {
                    using (SqlConnection con = new SqlConnection(conexionString))
                    {
                        con.Open();

                        string qFactura = "SELECT * FROM Factura WHERE nro_factura = @Id";
                        using (SqlCommand cmdFactura = new SqlCommand(qFactura, con))
                        {
                            cmdFactura.Parameters.AddWithValue("@Id", idFactura);
                            SqlDataAdapter daFactura = new SqlDataAdapter(cmdFactura);
                            DataTable dtFactura = new DataTable();
                            daFactura.Fill(dtFactura);

                            if (dtFactura.Rows.Count == 0)
                            {
                                MessageBox.Show("Error: No se encontró la factura.");
                                return;
                            }

                            DataRow fRow = dtFactura.Rows[0];
                            facturaParaMostrar = new Factura
                            {
                                nro_factura = Convert.ToInt64(fRow["nro_factura"]),
                                tipo_factura = Convert.ToString(fRow["tipo_factura"]),
                                id_cliente = Convert.ToInt32(fRow["id_cliente"]),
                                fecha_factura = Convert.ToDateTime(fRow["fecha_factura"]),
                                forma_pago = Convert.ToString(fRow["forma_pago"]),
                                monto_total = Convert.ToInt64(fRow["monto_total"]),
                                estado_factura = Convert.ToInt32(fRow["estado_factura"]),
                                vendedor_id = Convert.ToInt32(fRow["vendedor_id"])
                            };
                        }

                        string qCliente = "SELECT * FROM Cliente WHERE dni_cliente = @IdCliente";
                        using (SqlCommand cmdCliente = new SqlCommand(qCliente, con))
                        {
                            cmdCliente.Parameters.AddWithValue("@IdCliente", facturaParaMostrar.id_cliente);
                            SqlDataAdapter daCliente = new SqlDataAdapter(cmdCliente);
                            DataTable dtCliente = new DataTable();
                            daCliente.Fill(dtCliente);

                            if (dtCliente.Rows.Count == 0)
                            {
                                MessageBox.Show("Error: No se encontró el cliente asociado.");
                                return;
                            }
                            clienteParaMostrar = dtCliente.Rows[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al recuperar los datos de la factura: " + ex.Message);
                    return;
                }

                
                facturaVenta form = new facturaVenta();
                form.FacturaMostrada = facturaParaMostrar;
                form.ClienteMostrado = clienteParaMostrar;

                form.ShowDialog();
            }
        }
    }

    public class Venta
    {
        public int CodigoVenta { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public string NombreVendedor { get; set; }
        public List<Producto> Productos { get; set; }
        public decimal Total { get; set; }
    }

    public class Producto
    {
        public string Nombre { get; set; }
    }
}