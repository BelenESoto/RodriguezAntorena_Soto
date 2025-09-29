/* using System;
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
        private string modoBusqueda = "Codigo";
        private bool textoLimpiado = false;

        public List<Producto> Productos { get; private set; }

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

                // Limpiamos ítems existentes
                tsdFiltroBusqueda.DropDownItems.Clear();

                // Agregamos opciones de búsqueda
                string[] filtros = { "Código de venta", "Fecha de venta", "Nombre del cliente", "Nombre del vendedor" };
                foreach (string f in filtros)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(f);
                    item.Click += FiltroBusqueda_Click; // Evento al hacer clic en el filtro
                    tsdFiltroBusqueda.DropDownItems.Add(item);
                }

                // Guardamos un valor inicial
                modoBusqueda = filtros[0]; // Por defecto "Código de venta"

                CargarVentasEnGrid(_ventas);
            }

        private void FiltroBusqueda_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                modoBusqueda = item.Text; // Guardamos el filtro seleccionado
                tsdFiltroBusqueda.Text = "Buscar por: " + item.Text; // Actualizamos el texto del botón
            }
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
        }

            private void BLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpiamos el texto del TextBox
            TBBuscarProducto.Text = "";

            // Restaurar filtro por defecto
            modoBusqueda = "Código"; // filtro inicial
            tsdFiltroBusqueda.Text = "Buscar por: " + modoBusqueda; // botón ToolStripDropDownButton

            // Recargar todas las ventas/productos
            CargarVentasEnGrid(_ventas); // o CargarProductos() si es la lista de productos
        }


        private void TBCriterio_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTSBusquedaProd_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarProducto.Text.Trim().ToLower();

            IEnumerable<Venta> filtradas = _ventas;

            if (!string.IsNullOrEmpty(criterio))
            {
                switch (modoBusqueda)
                {
                    case "Código de venta":
                        filtradas = filtradas.Where(v => v.CodigoVenta.ToLower().Contains(criterio));
                        break;
                    case "Fecha de venta":
                        if (DateTime.TryParse(criterio, out DateTime fechaBuscada))
                            filtradas = filtradas.Where(v => v.FechaVenta.Date == fechaBuscada.Date);
                        break;
                    case "Nombre del cliente":
                        filtradas = filtradas.Where(v => v.NombreCliente.ToLower().Contains(criterio));
                        break;
                    case "Nombre del vendedor":
                        filtradas = filtradas.Where(v => v.NombreVendedor.ToLower().Contains(criterio));
                        break;
                }
            }

            DGVentas.Rows.Clear();
            foreach (var v in filtradas)
             DGVentas.Rows.Add(v.CodigoVenta, v.FechaVenta.ToString("dd/MM/yyyy"), v.NombreCliente, v.NombreVendedor, v.Total);
        }


        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            //aca
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Cambiamos el texto del botón o del ComboBox para mostrar el filtro seleccionado
            string filtroSeleccionado = e.ClickedItem.Text;

            // Guardamos en una variable global cuál será el filtro para la búsqueda
            modoBusqueda = filtroSeleccionado; // Por ejemplo: "Código de venta", "Fecha de venta", etc.

            // Opcional: actualizar visualmente el botón
            tsdFiltroBusqueda.Text = "Buscar por: " + filtroSeleccionado;
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
    
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProductoGerente = Antorena_Soto.CPresentacion.Gerente.Producto;


namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class reporteVentas : Form
    {
        private string modoBusqueda = "Código de venta"; // filtro por defecto
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

        private void reporteVentas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();

            // Configurar filtros en ToolStripDropDownButton
            tsdFiltroBusqueda.DropDownItems.Clear();
            string[] filtros = { "Código de venta", "Fecha de venta", "Nombre del cliente", "Nombre del vendedor" };
            foreach (string f in filtros)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(f);
                item.Click += FiltroBusqueda_Click;
                tsdFiltroBusqueda.DropDownItems.Add(item);
            }

            tsdFiltroBusqueda.Text = "Buscar por: " + modoBusqueda;

            CargarVentasEnGrid(_ventas);
        }

        private void FiltroBusqueda_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                modoBusqueda = item.Text;
                tsdFiltroBusqueda.Text = "Buscar por: " + item.Text;
            }
        }

        private void ConfigurarDataGridView()
        {
            DGVentas.AllowUserToAddRows = false;
            DGVentas.ReadOnly = true;
            DGVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVentas.MultiSelect = false;

            DGVentas.Columns.Clear();

            DGVentas.Columns.Add("CodigoVenta", "Código de Venta");
            DGVentas.Columns.Add("NombreCliente", "Cliente");
            DGVentas.Columns.Add("Productos", "Productos");
            DGVentas.Columns.Add("Total", "Total");
            DGVentas.Columns.Add("Fecha", "Fecha de Venta");
            DGVentas.Columns.Add("Vendedor", "Vendedor");
        }

        private void CargarVentasEnGrid(IEnumerable<Venta> ventas)
        {
            DGVentas.Rows.Clear();
            foreach (var v in ventas)
            {
                // string productosConcatenados = string.Join(", ", v.Productos.Select(p => p.Nombre));
                // string productosConcatenados = string.Join(", ", v.Productos.Select(p => p.RodriguezAntorena_Soto.CPresentacion.Gerente.Producto.Nombre));
                string productosConcatenados = string.Join(", ", v.Productos.Cast<ProductoGerente>().Select(p => p.Nombre));

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

        private void BTSBusquedaProd_Click(object sender, EventArgs e)
        {
            string criterio = TBBuscarProducto.Text.Trim().ToLower(); // usar el TextBox real
            IEnumerable<Venta> filtradas = _ventas;

            if (!string.IsNullOrEmpty(criterio))
            {
                switch (modoBusqueda)
                {
                    case "Código de venta":
                        filtradas = filtradas.Where(v => v.CodigoVenta.ToLower().Contains(criterio));
                        break;
                    case "Fecha de venta":
                        if (DateTime.TryParse(criterio, out DateTime fechaBuscada))
                            filtradas = filtradas.Where(v => v.FechaVenta.Date == fechaBuscada.Date);
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

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TBBuscarProducto.Text = "";
            modoBusqueda = "Código de venta";
            tsdFiltroBusqueda.Text = "Buscar por: " + modoBusqueda;
            CargarVentasEnGrid(_ventas);
        }
    }

    // Clases de ejemplo
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
}


