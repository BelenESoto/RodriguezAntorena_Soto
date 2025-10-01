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
    public partial class listaVentas : Form
    {
        public static BindingList<Venta> ListaVentas { get; } = new BindingList<Venta>();
        // Lista filtrada
        private BindingList<Venta> ListaFiltrada = new BindingList<Venta>();

        // Variable para guardar el criterio actual
        private string criterioBusqueda = "";
        public listaVentas()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            DGVListaProdVentas.DataSource = ListaVentas;
        }

        private void ConfigurarDataGrid()
        {
            DGVListaProdVentas.AutoGenerateColumns = false;
            DGVListaProdVentas.Columns.Clear();

            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "Codigo_Venta" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha", DataPropertyName = "Fecha_Venta" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vendedor", DataPropertyName = "Vendedor_Resp" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", DataPropertyName = "Cliente_Venta" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ciudad", DataPropertyName = "Ciudad_Venta" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Medio Pago", DataPropertyName = "Medio_Pago_Venta" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Detalle Productos", DataPropertyName = "Detalle_Prod_Venta" });
            DGVListaProdVentas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "Total_Venta" });
        }

        private void BCodigoVenta_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "codigo";
            MessageBox.Show("Buscar por Código de Venta");
        }

        private void BApellidoClienteVenta_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "apellido";
            MessageBox.Show("Buscar por Apellido del Cliente");
        }

        private void BFechaVenta_Click(object sender, EventArgs e)
        {
            criterioBusqueda = "fecha";
            MessageBox.Show("Buscar por Fecha de Venta (dd/MM/yyyy)");
        }


        private void BBuscarVenta_Click(object sender, EventArgs e)
        {
            string valorBusqueda = TBBuscarPorVenta.Text.Trim();

            if (string.IsNullOrEmpty(criterioBusqueda))
            {
                MessageBox.Show("Debe seleccionar un criterio de búsqueda (Código, Apellido o Fecha).");
                return;
            }

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Debe ingresar un valor para buscar.");
                return;
            }

            IEnumerable<Venta> resultados = new List<Venta>();

            switch (criterioBusqueda)
            {
                case "codigo":
                    resultados = ListaVentas.Where(v =>
                        v.Codigo_Venta != null &&
                        v.Codigo_Venta.ToString().Contains(valorBusqueda));
                    break;

                case "apellido":
                    resultados = ListaVentas.Where(v =>
                        !string.IsNullOrEmpty(v.Cliente_Venta) &&
                        v.Cliente_Venta.IndexOf(valorBusqueda, StringComparison.OrdinalIgnoreCase) >= 0);
                    break;

                case "fecha":
                    if (DateTime.TryParse(valorBusqueda, out DateTime fecha))
                    {
                        resultados = ListaVentas.Where(v => v.Fecha_Venta.Date == fecha.Date);
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha inválido. Use dd/MM/yyyy.");
                        return;
                    }
                    break;
                }

            // Actualizar la lista filtrada
            ListaFiltrada = new BindingList<Venta>(resultados.ToList());

            if (ListaFiltrada.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.");
            }

            DGVListaProdVentas.DataSource = ListaFiltrada;
        }
    }
}
