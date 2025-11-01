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

        // --- ADAPTADO DE listaUsuario ---
        // 1. Declarar el enum para el tipo de búsqueda
        private enum TipoBusqueda { None, Dni, Nombre, Estado }
        private TipoBusqueda tipoBusquedaSeleccionado = TipoBusqueda.None;

        // 2. Declarar la BLL como un campo de la clase
        private readonly ClienteBLL clienteBLL;
        // --- FIN ADAPTACIÓN ---


        public listaClientes()
        {
            InitializeComponent();

            // 3. Hook al evento Load del formulario (puedes hacerlo también desde el diseñador)
            this.Load += new System.EventHandler(this.listaClientes_Load);

            string conexionString = "Data Source=DESKTOP-IDH7B7D\\SQLEXPRESS;Initial Catalog=RodriguezAntorena_Soto;Integrated Security=True";

            // 4. Inicializa la capa lógica (ahora usa el campo de la clase)
            clienteBLL = new ClienteBLL(conexionString);

            // 5. Configurar el DataGridView
            ConfigurarDataGrid();

            // Tu código original para el botón de editar
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

        // 6. MÉTODO DE CARGA (Adaptado de listaUsuario)
        private void listaClientes_Load(object sender, EventArgs e)
        {
            // Llama al método de carga al iniciar el formulario
            CargarClientes();
        }

        // 7. MÉTODO CargarClientes (Adaptado de CargarUsuarios)
        public void CargarClientes()
        {
            try
            {
                DGVListaCliente.DefaultCellStyle.ForeColor = Color.Black;

                // Traer datos desde la ClienteBLL
                DataTable clientes = clienteBLL.ListarClientesBLL();

                // Cargar en el DataGridView
                DGVListaCliente.DataSource = clientes;

                // Mostrar cantidad de filas cargadas (opcional)
                /*
                MessageBox.Show($"Se cargaron {clientes.Rows.Count} clientes.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        // 8. CORRECCIÓN CRÍTICA en DataPropertyName
        // Deben coincidir con las columnas del DataTable que devuelve ClienteBLL
        private void ConfigurarDataGrid()
        {
            DGVListaCliente.AutoGenerateColumns = false;
            DGVListaCliente.Columns.Clear();

            // Los DataPropertyName DEBEN coincidir con los nombres de la BBDD/DAL
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "nomYApe_cliente" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "dni_cliente" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "CUIT", DataPropertyName = "cuit" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Provincia", DataPropertyName = "provincia" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ciudad", DataPropertyName = "ciudad" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Domicilio", DataPropertyName = "domicilio" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "telefono" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Correo", DataPropertyName = "correo" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Ingreso", DataPropertyName = "fecha_ingreso" });
            DGVListaCliente.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "estado" }); // Se agrega estado
        }


        // --- LÓGICA DE BÚSQUEDA (Adaptada de listaUsuario) ---
        // (Asumo que tienes 3 botones para setear el tipo de búsqueda y un TextBox llamado TBBuscarPorCliente)

        // Asocia este evento a tu botón "Buscar por DNI"
        private void BBuscarDni_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Dni;
            TBBuscarPorCliente.Text = ""; // Asumo que el TextBox se llama TBBuscarPorCliente
            TBBuscarPorCliente.Text = "Ingrese DNI";
        }

        // Asocia este evento a tu botón "Buscar por Nombre"
        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Nombre;
            TBBuscarPorCliente.Text = "";
            TBBuscarPorCliente.Text = "Ingrese Apellido o Nombre";
        }

        // Asocia este evento a tu botón "Buscar por Estado"
        private void BBuscarEstado_Click(object sender, EventArgs e)
        {
            tipoBusquedaSeleccionado = TipoBusqueda.Estado;
            TBBuscarPorCliente.Text = "";
            TBBuscarPorCliente.Text = "Ingrese 1 (Activo) ó 0 (Inactivo)";
        }


        // 9. MÉTODO DE BÚSQUEDA PRINCIPAL (Adaptado de BTSBusquedaUs_Click)
        // Este es tu método `BBuscarCliente_Click`
        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            if (tipoBusquedaSeleccionado == TipoBusqueda.None)
            {
                MessageBox.Show("Seleccione un tipo de búsqueda primero (DNI, Nombre o Estado).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asumo que tu TextBox se llama TBBuscarPorCliente
            string criterio = TBBuscarPorCliente.Text.Trim();

            // Validación para que el texto placeholder no se use como criterio
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
                        // La BLL ya valida si es numérico
                        resultado = clienteBLL.BuscarClientesBLL(criterio, true); // true → buscar por DNI
                        break;

                    case TipoBusqueda.Nombre:
                        resultado = clienteBLL.BuscarClientesBLL(criterio, false); // false → buscar por nombre
                        break;

                    case TipoBusqueda.Estado:
                        // Adaptación para Cliente (que usa int 0 ó 1)
                        if (!int.TryParse(criterio, out int estadoInt) || (estadoInt != 0 && estadoInt != 1))
                        {
                            MessageBox.Show("Estado inválido. Ingrese 1 para 'Activo' ó 0 para 'Inactivo'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        resultado = FiltrarPorEstado(estadoInt);
                        break;
                }

                // Cargar en el DataGridView
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

        // 10. MÉTODO HELPER PARA FILTRAR ESTADO (Adaptado para INT)
        private DataTable FiltrarPorEstado(int estado)
        {
            // Trae todos los clientes
            DataTable todosClientes = clienteBLL.ListarClientesBLL();

            // Filtra en memoria usando Select (el filtro usa sintaxis SQL)
            // Nota: no se usan comillas ' ' alrededor de {estado} porque es un número.
            DataRow[] filasFiltradas = todosClientes.Select($"estado = {estado}");

            if (filasFiltradas.Length == 0)
                return todosClientes.Clone(); // Retorna tabla vacía pero con la misma estructura

            DataTable dtFiltrado = filasFiltradas.CopyToDataTable();
            return dtFiltrado;
        }


        // --- Tus otros métodos (a completar) ---
        private void BEditCliente_Click(object sender, EventArgs e)
        {
            // 1. Verificar si hay una fila seleccionada
            if (DGVListaCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para editar.",
                                "Selección Requerida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener la fila seleccionada
            DataRowView drv = (DataRowView)DGVListaCliente.SelectedRows[0].DataBoundItem;
            DataRow filaCliente = drv.Row;

            // 3. ABRIR EL FORMULARIO (MÉTODO MODIFICADO)

            // 3.1. Crea la instancia con el constructor vacío
            agregarDatosCliente formEditar = new agregarDatosCliente();

            // 3.2. Setea la propiedad pública con la fila a editar
            formEditar.ClienteParaEditar = filaCliente;

            // 3.3. Muestra el formulario. El evento 'Load' se disparará ahora.
            formEditar.ShowDialog();

            // 4. Refrescar la lista de clientes
            CargarClientes();
        }

        private void TBBuscarPorCliente_Click(object sender, EventArgs e)
        {
            // Lógica si el usuario hace click en el TextBox (ej. limpiar el placeholder)
            if (TBBuscarPorCliente.Text == "Ingrese DNI" || TBBuscarPorCliente.Text == "Ingrese Apellido o Nombre" || TBBuscarPorCliente.Text == "Ingrese 1 (Activo) ó 0 (Inactivo)")
            {
                TBBuscarPorCliente.Text = "";
            }
        }


        private void DGVListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica si haces click en una celda (ej. para editar)
        }

        // Este método estaba en tu código, pero la lógica de búsqueda se movió a 
        // BBuscarDni_Click, BBuscarNombre_Click y BBuscarEstado_Click
        private void BBuscarPor_ButtonClick(object sender, EventArgs e)
        {
            // Quizás este botón abre un menú para elegir el tipo de búsqueda?
            // Por ahora, la lógica se basa en 3 botones separados (DNI, Nombre, Estado)
        }

        private void listaClientes_Load_1(object sender, EventArgs e)
        {

        }
    }
}
