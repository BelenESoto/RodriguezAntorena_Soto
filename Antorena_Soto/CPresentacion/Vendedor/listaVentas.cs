
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


        // --- NUEVO ---
        private readonly string conexionString; // = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
        private readonly FacturaBLL cn_factura;

        private string criterioBusqueda = "";

        public listaVentas()
        {
            InitializeComponent();
            conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            cn_factura = new FacturaBLL(conexionString);
            ConfigurarDataGrid();
           
        }

        // --- MÉTODO MODIFICADO ---
        private void ConfigurarDataGrid()
        {
            DGVListaProdVentas.DefaultCellStyle.ForeColor = Color.Black;
            DGVListaProdVentas.AutoGenerateColumns = false;
            DGVListaProdVentas.Columns.Clear();

            // Se agrega la propiedad 'Name' a cada columna.
            // El 'Name' es el identificador para el código.
            // El 'DataPropertyName' es el nombre de la columna de la consulta SQL.

            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo", // <-- Nombre para el código
                HeaderText = "Código",
                DataPropertyName = "codigo_venta" // <-- Nombre de la consulta SQL
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha", // <-- Nombre para el código
                HeaderText = "Fecha",
                DataPropertyName = "fecha_venta" // <-- Nombre de la consulta SQL
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Vendedor_resp", // <-- Nombre para el código
                HeaderText = "Vendedor",
                DataPropertyName = "vendedor_resp" // <-- Nombre de la consulta SQL
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente", // <-- Nombre para el código
                HeaderText = "Cliente",
                DataPropertyName = "cliente_venta" // <-- Nombre de la consulta SQL
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ciudad", // <-- Nombre para el código
                HeaderText = "Ciudad",
                DataPropertyName = "ciudad_venta" // <-- Nombre de la consulta SQL
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Medio_pago_venta", // <-- Nombre para el código
                HeaderText = "Medio Pago",
                DataPropertyName = "medio_pago_venta" // <-- Nombre de la consulta SQL
            });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_venta", // <-- Nombre para el código
                HeaderText = "Total",
                DataPropertyName = "total_venta" // <-- Nombre de la consulta SQL
            });

            // Ahora se accede a las columnas por su 'Name'
            DGVListaProdVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            DGVListaProdVentas.Columns["total_venta"].DefaultCellStyle.Format = "$#,##0.00";
        }

        // --- Estos 3 métodos están bien, no cambian ---
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

        // --- MÉTODO PRINCIPAL MODIFICADO ---
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

            // 1. Consulta SQL Base
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

            // 2. Construir el WHERE según el criterio
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

            // 3. Ejecutar la consulta
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

            // 4. Mostrar resultados
            if (dtResultados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.");
            }

            DGVListaProdVentas.DataSource = dtResultados;
        }

        private void TBBuscarPorVenta_Click(object sender, EventArgs e)
        {
            // Helper para limpiar el placeholder
            if (TBBuscarPorVenta.Text.StartsWith("Ingrese"))
            {
                TBBuscarPorVenta.Text = "";
            }
        }

        private void listaVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void DGVListaProdVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*public void CargarVentasBD()
        {

            try
            {
                DGVListaProdVentas.DefaultCellStyle.ForeColor = Color.Black;
                // Traer datos desde la BLL
                DataTable ventas = cn_factura.ListarFacturasBLL();

                // Cargar en el DataGridView
                DGVListaProdVentas.DataSource = ventas;

                // Mostrar cantidad de filas cargadas
                MessageBox.Show($"Se cargaron {ventas.Rows.Count} Ventas.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }*/

        public void CargarVentasBD()
        {
            try
            {
                DGVListaProdVentas.DefaultCellStyle.ForeColor = Color.Black;

                // --- CORRECCIÓN AQUÍ ---
                // 1. Usamos la misma consulta SQL compleja (con JOINs y Alias) 
                //    que usa tu 'ConfigurarDataGrid'.
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
            ORDER BY F.fecha_factura DESC"; // Ordenar por fecha

                DataTable ventas = new DataTable();

                // 2. Ejecutar esta consulta directamente
                using (SqlConnection con = new SqlConnection(conexionString))
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ventas);
                }
                // --- FIN DE LA CORRECCIÓN ---

                // Cargar en el DataGridView
                // Ahora las columnas del DataTable SÍ coinciden con los DataPropertyName
                DGVListaProdVentas.DataSource = ventas;

                // Mostrar cantidad de filas cargadas
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