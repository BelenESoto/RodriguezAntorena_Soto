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

        public facturaVenta(long idFactura)
        {
            InitializeComponent();
            CargarFactura(idFactura);
        }

        // --- MÉTODO CARGARFACTURA MODIFICADO ---
        // (Cambiado de int a long y consulta SQL actualizada)
        private void CargarFactura(long idFactura) // <-- Modificado a long
        {
            // --- CONSULTA MODIFICADA ---
            // Eliminamos el JOIN a Categoria y usamos CASE para traducir el id_categoria
            string consulta = @"
            SELECT 
                P.codigo_prod AS Codigo,
                P.nombre_prod AS Nombre,
                
                -- Traducción manual del ID de categoría
                CASE P.categoria_prod 
                    WHEN 1 THEN 'Collares'
                    WHEN 2 THEN 'Aros'
                    WHEN 3 THEN 'Otros'
                    ELSE 'N/A' -- Si hay algún otro valor
                END AS Categoria,

                DV.precio AS Precio,
                DV.cantidad AS Cantidad,
                (DV.cantidad * DV.precio) AS Subtotal
            FROM Detalle_venta DV
            INNER JOIN Producto P ON DV.id_producto = P.codigo_prod
            -- Se eliminó el INNER JOIN a Categoria
            WHERE DV.id_factura = @IdFactura";

            using (SqlConnection con = new SqlConnection(conexionString))
            using (SqlCommand cmd = new SqlCommand(consulta, con))
            {
                // El parámetro @IdFactura ahora acepta un long
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
            DGVListaProd.Columns["Categoria_producto"].HeaderText = "Categoría";
            DGVListaProd.Columns["Precio_producto"].HeaderText = "Precio";
            DGVListaProd.Columns["Cantidad_producto"].HeaderText = "Cantidad";
            DGVListaProd.Columns["Subtotal_producto"].HeaderText = "Subtotal";

            // Formato de moneda
            DGVListaProd.Columns["Precio"].DefaultCellStyle.Format = "C2";
            DGVListaProd.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            DGVListaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LProvincia_Click(object sender, EventArgs e)
        {
            // ...
        }

        // --- MÉTODO LOAD MODIFICADO ---
        private void facturaVenta_Load(object sender, EventArgs e)
        {
            // Verificamos que los datos hayan sido pasados
            if (FacturaMostrada != null && ClienteMostrado != null)
            {
                // 1. Poblar los Labels (esto ya lo tenías)
                PoblarDatos();

                // 2. --- LÍNEA AGREGADA ---
                // Cargar el DataGridView con los detalles de la factura
                CargarFactura(FacturaMostrada.nro_factura);
            }
            else
            {
                MessageBox.Show("Error: No se pudieron cargar los datos de la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Método privado para cargar los datos en los Labels
        // (Este método está bien, no se necesita cambiar)
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
                label9.Text = FacturaMostrada.fecha_factura.ToShortDateString();
                label17.Text = FacturaMostrada.forma_pago;
                label11.Text = FacturaMostrada.monto_total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al poblar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ...
        }
    }
}