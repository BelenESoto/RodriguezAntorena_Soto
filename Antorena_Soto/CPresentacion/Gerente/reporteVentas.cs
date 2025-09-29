using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class reporteVentas : Form
    {
        private List<Venta> _ventas;
        public reporteVentas(List<Venta> ventas)
        {
            InitializeComponent();
            _ventas = ventas;
        }

        public reporteVentas() 
        {
            InitializeComponent();
        }

      

        private void reporteVentas_Load_1(object sender, EventArgs e)
             {
            ConfigurarDataGridView();
            CBFiltroBusqueda.Items.AddRange(new string[]
            {
                "Código de venta",
                "Fecha de venta",
                "Nombre del cliente",
                "Nombre del vendedor"
            });
            CBFiltroBusqueda.SelectedIndex = 0;

            CargarVentasEnGrid(_ventas);
        }

        private void ConfigurarDataGridView()
        {
            DGVentas.AllowUserToAddRows = false;
            DGVentas.ReadOnly = true;
            DGVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVentas.MultiSelect = false;

            DGVentas.Columns.Clear();

            // Agregar columnas con encabezado
            DGVentas.Columns.Add("CodigoVenta", "Código de Venta");
            DGVentas.Columns.Add("NombreCliente", "Cliente");
            DGVentas.Columns.Add("Productos", "Productos");
            DGVentas.Columns.Add("Total", "Total");
            DGVentas.Columns.Add("Fecha", "Fecha de Venta");
            DGVentas.Columns.Add("Vendedor", "Vendedor");
        }
        private void pReporteVenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void CargarVentasEnGrid(IEnumerable<Venta> ventas)
            {
                DGVentas.Rows.Clear();

                foreach (var v in ventas)
                {
                    string productosConcatenados = string.Join(", ", v.Productos.Select(p => p.Nombre));

                    DGVentas.Rows.Add(
                        v.CodigoVenta,
                        v.NombreCliente,
                        productosConcatenados,
                        v.Total.ToString("C"),
                        v.FechaVenta.ToString("dd/MM/yyyy"),
                        v.NombreVendedor
                    );
                }
            }
        private void BBuscar_Click_1(object sender, EventArgs e)
            {
                string filtro = CBFiltroBusqueda.SelectedItem.ToString();
                string criterio = TBCriterio.Text.Trim().ToLower();

                IEnumerable<Venta> filtradas = _ventas;

                if (!string.IsNullOrEmpty(criterio))
                {
                    switch (filtro)
                    {
                        case "Código de venta":
                            filtradas = filtradas.Where(v => v.CodigoVenta.ToLower().Contains(criterio));
                            break;
                        case "Fecha de venta":
                            if (DateTime.TryParse(criterio, out DateTime fechaBuscada))
                            {
                                filtradas = filtradas.Where(v => v.FechaVenta.Date == fechaBuscada.Date);
                            }
                            break;
                        case "Nombre del cliente":
                            filtradas = filtradas.Where(v => v.NombreCliente.ToLower().Contains(criterio));
                            break;
                        case "Nombre del vendedor":
                            filtradas = filtradas.Where(v => v.NombreVendedor.ToLower().Contains(criterio));
                            break;
                    }
                }

                CargarVentasEnGrid(filtradas);
            }

        private void BLimpiar_Click_1(object sender, EventArgs e)
        {
                TBCriterio.Clear();
                CBFiltroBusqueda.SelectedIndex = 0;
                CargarVentasEnGrid(_ventas);
            }

       
    }
    }

    // 🔸 Clases de ejemplo
    public class Venta
        {
            public string CodigoVenta { get; set; }
            public string NombreCliente { get; set; }
            public string NombreVendedor { get; set; }
            public DateTime FechaVenta { get; set; }
            public decimal Total { get; set; }
            public List<Producto> Productos { get; set; } = new List<Producto>();
        }

        public class Producto
        {
            public string Nombre { get; set; }
        }
    


