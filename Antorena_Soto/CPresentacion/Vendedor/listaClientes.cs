using Antorena_Soto.CDatos;
using Antorena_Soto.CLogica;
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
    public partial class listaClientes : Form
    {
        Button BEditCliente;
        private enum TipoBusqueda { None, Dni, Nombre, Estado }
        private TipoBusqueda tipoBusquedaSeleccionado = TipoBusqueda.None;
        private readonly ClienteBLL clienteBLL;
       
        public listaClientes()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.listaClientes_Load);
            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";
            clienteBLL = new ClienteBLL(conexionString);

            ConfigurarDataGrid();

            //Hacemos un boton dentro del panel cuando se crea el formulario para editar los cliente
            BEditCliente = new Button
            {
                Text = "EDITAR CLIENTE",
                BackColor = Color.White,
                ForeColor = Color.MidnightBlue,
                Font = new Font("Verdana", 10, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                Height = 40,
                Width = 120,
            };
            BEditCliente.Click += BEditCliente_Click;
            PGerente2.Controls.Add(BEditCliente);
        }

        private void listaClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        public void CargarClientes()
        {
            try
            {
                DGVListaCliente.DefaultCellStyle.ForeColor = Color.Black;

                DataTable clientes = clienteBLL.ListarClientesBLL();
                DGVListaCliente.DataSource = clientes;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDataGrid()
        {
            DGVListaCliente.AutoGenerateColumns = false;
            DGVListaCliente.Columns.Clear();
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "nomYApe_cliente" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "dni_cliente" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CUIT", DataPropertyName = "cuit" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Provincia", DataPropertyName = "provincia" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ciudad", DataPropertyName = "ciudad" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Domicilio", DataPropertyName = "domicilio" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "telefono" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Correo", DataPropertyName = "correo" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Ingreso", DataPropertyName = "fecha_ingreso" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "estado" });
        }

        private void BBuscarDni_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Dni;
            TBBuscarPorCliente.Text = ""; 
            TBBuscarPorCliente.Text = "Ingrese DNI";
        }

        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Nombre;
            TBBuscarPorCliente.Text = "";
            TBBuscarPorCliente.Text = "Ingrese Apellido o Nombre";
        }

        private void BBuscarEstado_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Estado;
            TBBuscarPorCliente.Text = "";
            TBBuscarPorCliente.Text = "Ingrese 1 (Activo) ó 0 (Inactivo)";
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            if (tipoBusquedaSeleccionado == TipoBusqueda.None)
            {
                MessageBox.Show("Seleccione un tipo de búsqueda primero (DNI, Nombre o Estado).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string criterio = TBBuscarPorCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(criterio) || criterio == "Ingrese DNI" || criterio == "Ingrese Apellido o Nombre" || criterio == "Ingrese 1 (Activo) ó 0 (Inactivo)")
            {
                MessageBox.Show("Ingrese un valor para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable resultado = null;

            try
            {
                switch (tipoBusquedaSeleccionado)
                {
                    case TipoBusqueda.Dni:
                        resultado = clienteBLL.BuscarClientesBLL(criterio, true); // true → buscar por DNI
                        break;

                    case TipoBusqueda.Nombre:
                        resultado = clienteBLL.BuscarClientesBLL(criterio, false); // false → buscar por nombre
                        break;

                    case TipoBusqueda.Estado:
                        if (!int.TryParse(criterio, out int estadoInt) || (estadoInt != 0 && estadoInt != 1))
                        {
                            MessageBox.Show("Estado inválido. Ingrese 1 para 'Activo' ó 0 para 'Inactivo'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        resultado = FiltrarPorEstado(estadoInt);
                        break;
                }

                DGVListaCliente.DataSource = resultado;

                if (resultado != null)
                {
                    MessageBox.Show($"Se encontraron {resultado.Rows.Count} cliente(s).", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable FiltrarPorEstado(int estado)
        {
            DataTable todosClientes = clienteBLL.ListarClientesBLL();

            DataRow[] filasFiltradas = todosClientes.Select($"estado = {estado}");

            if (filasFiltradas.Length == 0)
                return todosClientes.Clone(); 

            DataTable dtFiltrado = filasFiltradas.CopyToDataTable();
            return dtFiltrado;
        }

        private void BEditCliente_Click(object sender, EventArgs e)
        {
           
            if (DGVListaCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para editar.",
                                "Selección Requerida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            
            DataRowView drv = (DataRowView)DGVListaCliente.SelectedRows[0].DataBoundItem;
            DataRow filaCliente = drv.Row;
            agregarDatosCliente formEditar = new agregarDatosCliente();

            formEditar.ClienteParaEditar = filaCliente;
            formEditar.ShowDialog();

            CargarClientes();
        }

        private void TBBuscarPorCliente_Click(object sender, EventArgs e)
        {
            if (TBBuscarPorCliente.Text == "Ingrese DNI" || TBBuscarPorCliente.Text == "Ingrese Apellido o Nombre" || TBBuscarPorCliente.Text == "Ingrese 1 (Activo) ó 0 (Inactivo)")
            {
                TBBuscarPorCliente.Text = "";
            }
        }


        private void DGVListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {
        }

        private void listaClientes_Load_1(object sender, EventArgs e)
        {

        }
    }
}
