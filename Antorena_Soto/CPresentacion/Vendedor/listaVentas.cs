
using Antorena_Soto.CDatos;
using Antorena_Soto.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.Vendedor;




namespace Antorena_Soto.CPresentacion.Vendedor
{
    public partial class listaVentas : Form
    {

        private readonly string conexionString; 
        private readonly FacturaBLL cn_factura;

        private string criterioBusqueda = "";

        public listaVentas()
        {
            InitializeComponent();
            conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            cn_factura = new FacturaBLL(conexionString);
            ConfigurarDataGrid();
           
        }

        //Configura las columnas del DataGridView
        private void ConfigurarDataGrid()
        {
            DGVListaProdVentas.DefaultCellStyle.ForeColor = Color.Black;
            DGVListaProdVentas.AutoGenerateColumns = false;
            DGVListaProdVentas.Columns.Clear();
            

            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo", 
                HeaderText = "Código",
                DataPropertyName = "codigo_venta" 
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha", 
                HeaderText = "Fecha",
                DataPropertyName = "fecha_venta" 
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Vendedor_resp", 
                HeaderText = "Vendedor",
                DataPropertyName = "vendedor_resp" 
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente", 
                HeaderText = "Cliente",
                DataPropertyName = "cliente_venta" 
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ciudad", 
                HeaderText = "Ciudad",
                DataPropertyName = "ciudad_venta" 
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Medio_pago_venta",
                HeaderText = "Medio Pago",
                DataPropertyName = "medio_pago_venta" 
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_venta", 
                HeaderText = "Total",
                DataPropertyName = "total_venta" 
            });

            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_venta",
                HeaderText = "Total",
                DataPropertyName = "total_venta"
            });

            //Acá creamos una columna de botones para "Detalle" que trae la factura con los datos
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn();
            colBtn.Name = "BDetalle"; 
            colBtn.HeaderText = "Detalle";
            colBtn.Text = "Ver"; 
            colBtn.UseColumnTextForButtonValue = true; 
            colBtn.Width = 80;
            DGVListaProdVentas.Columns.Add(colBtn);

            DGVListaProdVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DGVListaProdVentas.Columns["total_venta"].DefaultCellStyle.Format = "$#,##0.00";
        }

      
        private void BCodigoVenta_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "codigo";
            MessageBox.Show("Buscar por Código de Venta");
            TBBuscarPorVenta.Text = "Ingrese Código";
        }

        private void BApellidoClienteVenta_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "apellido";
            MessageBox.Show("Buscar por Apellido del Cliente");
            TBBuscarPorVenta.Text = "Ingrese Apellido o Nombre";
        }

        private void BFechaVenta_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "fecha";
            MessageBox.Show("Buscar por Fecha de Venta (dd/MM/yyyy)");
            TBBuscarPorVenta.Text = "Ingrese Fecha";
        }


        //Boton para buscar ventas segun el criterio seleccionado
        private void BBuscarVenta_Click(object sender, EventArgs e)
        {
            string valorBusqueda = TBBuscarPorVenta.Text.Trim();

            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda (Código, Apellido o Fecha).");
                return;
            }

            if (string.IsNullOrEmpty(valorBusqueda) || valorBusqueda.StartsWith("Ingrese"))
            {
                MessageBox.Show("Debe ingresar un valor para buscar.");
                return;
            }

        
            string consultaBase = @"
                SELECT 
                    F.nro_factura AS codigo_venta,
                    F.fecha_factura AS fecha_venta,
                    U.nomYApe_usuario AS vendedor_resp,
                    C.nomYApe_cliente AS cliente_venta,
                    C.ciudad AS ciudad_venta,
                    F.forma_pago AS medio_pago_venta,
                    F.monto_total AS total_venta
                FROM Factura F
                INNER JOIN Cliente C ON F.id_cliente = C.dni_cliente
                INNER JOIN Usuario U ON F.vendedor_id = U.id_dni_usuario";

            string whereClause = "";
            SqlCommand cmd = new SqlCommand();

           
            try
            {
                switch (criterioBusqueda)
                {
                    case "codigo":
                        whereClause = " WHERE F.nro_factura = @valor";
                        cmd.Parameters.AddWithValue("@valor", long.Parse(valorBusqueda));
                        break;

                    case "apellido":
                        whereClause = " WHERE C.nomYApe_cliente LIKE @valor";
                        cmd.Parameters.AddWithValue("@valor", "%" + valorBusqueda + "%");
                        break;

                    case "fecha":
                        if (DateTime.TryParse(valorBusqueda, out DateTime fecha))
                        {
                            whereClause = " WHERE CONVERT(date, F.fecha_factura) = @valor";
                            cmd.Parameters.AddWithValue("@valor", fecha.Date);
                        }
                        else
                        {
                            MessageBox.Show("Formato de fecha inválido. Use dd/MM/yyyy.");
                            return;
                        }
                        break;
                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el valor de búsqueda: " + ex.Message);
                return;
            }

            cmd.CommandText = consultaBase + whereClause + " ORDER BY F.fecha_factura DESC";
            cmd.Connection = new SqlConnection(conexionString);

            DataTable dtResultados = new DataTable();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtResultados);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                return;
            }

            if (dtResultados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.");
            }

            DGVListaProdVentas.DataSource = dtResultados;
        }

        private void TBBuscarPorVenta_Click(object sender, EventArgs e)
        {
            
            if (TBBuscarPorVenta.Text.StartsWith("Ingrese"))
            {
                TBBuscarPorVenta.Text = "";
            }
        }

        private void listaVentas_Load(object sender, EventArgs e)
        {
            
        }

        //Configuraciones para el DGV al cargar el formulario y que funcione el boton detalle
        private void DGVListaProdVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (DGVListaProdVentas.Rows[e.RowIndex].IsNewRow) return;

            if (DGVListaProdVentas.Columns[e.ColumnIndex].Name == "BDetalle")
            {
                long idFactura = Convert.ToInt64(
                    DGVListaProdVentas.Rows[e.RowIndex].Cells["Codigo"].Value); 

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

        

        public void CargarVentasBD()
        {
            try
            {
                DGVListaProdVentas.DefaultCellStyle.ForeColor = Color.Black;

                string consulta = @"
            SELECT 
                F.nro_factura AS codigo_venta,
                F.fecha_factura AS fecha_venta,
                U.nomYApe_usuario AS vendedor_resp,
                C.nomYApe_cliente AS cliente_venta,
                C.ciudad AS ciudad_venta,
                F.forma_pago AS medio_pago_venta,
                F.monto_total AS total_venta
            FROM Factura F
            INNER JOIN Cliente C ON F.id_cliente = C.dni_cliente
            INNER JOIN Usuario U ON F.vendedor_id = U.id_dni_usuario
            ORDER BY F.fecha_factura DESC"; 

                DataTable ventas = new DataTable();

               
                using (SqlConnection con = new SqlConnection(conexionString))
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ventas);
                }
                
                DGVListaProdVentas.DataSource = ventas;

               
                MessageBox.Show($"Se cargaron {ventas.Rows.Count} Ventas.",
                                 "Información",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}