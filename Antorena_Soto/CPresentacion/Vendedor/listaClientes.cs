using Antorena_Soto.CLogica;
using CPresentacion.Vendedor;
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
        public static BindingList<Cliente> ListaClientes { get; } = new BindingList<Cliente>();


        public listaClientes()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            DGVListaCliente.DataSource = ListaClientes;

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

            // Asociar evento
            BEditCliente.Click += BEditCliente_Click;

            // Agregar al formulario
            PGerente2.Controls.Add(BEditCliente);
        }
        private void ConfigurarDataGrid()
        {
            DGVListaCliente.AutoGenerateColumns = false;

            DGVListaCliente.Columns.Clear();
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "DNI" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CUIT", DataPropertyName = "Cuit" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Provincia", DataPropertyName = "Provincia" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ciudad", DataPropertyName = "Ciudad" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Domicilio", DataPropertyName = "Domicilio" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "NumeroTelefono" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Correo", DataPropertyName = "Correo" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Ingreso", DataPropertyName = "FechaIng" });
        }

       
            private void BEditCliente_Click(object sender, EventArgs e)
        {
            if (DGVListaCliente.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente clienteSeleccionado = DGVListaCliente.CurrentRow.DataBoundItem as Cliente;

            if (clienteSeleccionado == null) return;

            // Abrir el form de edición con los datos del cliente
            agregarDatosCliente formEditar = new agregarDatosCliente(clienteSeleccionado);
            formEditar.FormClosed += (s, args) =>
            {
                // refrescar grid después de editar
                DGVListaCliente.Refresh();
            };
            formEditar.ShowDialog();
        }
        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {

        }

        private void TBBuscarPorCliente_Click(object sender, EventArgs e)
        {

        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void DGVListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        


    }
}
