using FontAwesome.Sharp;
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
    public partial class ventaConfirmar : Form
    {

        private bool buscarPorDni = false;
        private bool buscarPorNombre = false;
        public ventaConfirmar()
        {
            InitializeComponent();
        }

        private void LDatosBajaUs_Click(object sender, EventArgs e)
        {

        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPorDni = true;
            buscarPorNombre = false;
            MessageBox.Show("Búsqueda configurada por DNI.");
        }

        private void pORNOMBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPorDni = false;
            buscarPorNombre = true;
            MessageBox.Show("Búsqueda configurada por NOMBRE.");
        }

        private void BTSBusquedaCliente_Click(object sender, EventArgs e)
        {
            string input = TBBuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo de búsqueda de cliente no puede estar vacío.");
                return;
            }

            if (buscarPorDni)
            {
                if (!long.TryParse(input, out _))
                {
                    MessageBox.Show("Debe ingresar un DNI válido (número).");
                    return;
                }
                MessageBox.Show($"Buscando cliente por DNI: {input}");
            }
            else if (buscarPorNombre)
            {
                if (long.TryParse(input, out _))
                {
                    MessageBox.Show("El NOMBRE no puede ser numérico.");
                    return;
                }
                MessageBox.Show($"Buscando cliente por Nombre: {input}");
            }
            else
            {
                MessageBox.Show("Debe seleccionar si desea buscar por DNI o por NOMBRE.");
            }
        }

        private void TBDniFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCuitFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombreFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBCiudadFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBMedioPagoFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBTipoFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBMontoFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTFechaNacVendedor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            // Validaciones de factura
            if (string.IsNullOrWhiteSpace(TBNombreFact.Text))
            {
                MessageBox.Show("Debe completar el Nombre para la factura.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBCuitFact.Text) || !long.TryParse(TBCuitFact.Text, out _))
            {
                MessageBox.Show("Debe ingresar un CUIT válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBDniFact.Text) || !long.TryParse(TBDniFact.Text, out _))
            {
                MessageBox.Show("Debe ingresar un DNI válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBCiudadFact.Text))
            {
                MessageBox.Show("Debe completar la Ciudad.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBMedioPagoFact.Text))
            {
                MessageBox.Show("Debe seleccionar un Medio de Pago.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBTipoFact.Text))
            {
                MessageBox.Show("Debe completar el Tipo de Factura.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBMontoFact.Text) || !decimal.TryParse(TBMontoFact.Text, out _))
            {
                MessageBox.Show("Debe ingresar un Monto válido.");
                return;
            }

            if (DTFechaAct.Value.Date != DateTime.Today)
            {
                MessageBox.Show("La fecha de la factura debe ser la fecha actual.");
                return;
            }

            // Si todo está correcto:
            MessageBox.Show("Factura creada con éxito.");
            MessageBox.Show("Venta agregada exitosamente.");

            CrearBotonesFactura();

        }

       

        private void CrearBotonesFactura()
        {
            // Botón Imprimir Factura
            IconButton BImprimirFact = new IconButton
            {
                Text = "Imprimir Factura",
                IconChar = IconChar.Print,
                IconColor = Color.Black,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Dock = DockStyle.Left,
                Height = 50,
                Width = 280,
                Name = "BImprimirFact"
            };
            // 🚫 Por ahora sin funcionalidad
            BImprimirFact.Click += (s, e) =>
            {
                MessageBox.Show("Funcionalidad de impresión aún no implementada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Botón Ver Factura
            IconButton BVerFactura = new IconButton
            {
                Text = "Ver Factura",
                IconChar = IconChar.FileInvoiceDollar,
                IconColor = Color.Black,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Dock = DockStyle.Right,
                Height = 40,
                Width = 280,
                Name = "BVerFactura"
            };
            BVerFactura.Click += (s, e) =>
            {
                // Abrir el form facturaVenta
                facturaVenta formFactura = new facturaVenta();
                formFactura.ShowDialog();
            };

            // 🔹 Agregar los botones al formulario (podés usar un panel si lo preferís)
            PFacturaOpciones.Controls.Add(BVerFactura);
            PFacturaOpciones.Controls.Add(BImprimirFact);

            // Los pongo arriba de todo
            BVerFactura.BringToFront();
            BImprimirFact.BringToFront();
        }


        private void ventaConfirmar_Load(object sender, EventArgs e)
        {

        }
    }
}

