using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public partial class FormRecaudacion : Form
    {
        private bool busquedaPorFecha = true;
        private decimal ultimoMonto = 0;
        private int ultimaCantidad = 0;

        private PrintDocument printDocument;

        public FormRecaudacion()
        {
            InitializeComponent();
            InicializarEventosYDocumentos();
        }

        private void FormRecaudacion_Load(object sender, EventArgs e)
        {
            // Estado inicial → visible solo la búsqueda por fecha
            dtpFecha.Visible = true;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private void InicializarEventosYDocumentos()
        {
            // Eventos
            btnPorFecha.Click += BtnPorFecha_Click;
            btnPorPeriodo.Click += BtnPorPeriodo_Click;
            this.btnBuscar.Click += btnBuscar_Click; 
            btnImprimir.Click += BtnImprimir_Click;

            // Documento de impresión
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void BtnPorFecha_Click(object sender, EventArgs e)
        {
            busquedaPorFecha = true;
            dtpFecha.Visible = true;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private void BtnPorPeriodo_Click(object sender, EventArgs e)
        {
            busquedaPorFecha = false;
            dtpFecha.Visible = false;
            dtpDesde.Visible = true;
            dtpHasta.Visible = true;
        }

       
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string reporte = "Reporte de Recaudación\n\n" +
                             lblMonto.Text + "\n" +
                             lblCantidad.Text + "\n\n" +
                             "Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            e.Graphics.DrawString(reporte, new System.Drawing.Font("Arial", 12), System.Drawing.Brushes.Black, new System.Drawing.PointF(100, 100));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Inicializamos valores
            ultimoMonto = 0;
            ultimaCantidad = 0;

            DateTime hoy = DateTime.Today;

            if (busquedaPorFecha)
            {
                DateTime fecha = dtpFecha.Value.Date;

                // Validación: fecha no puede ser futura
                if (fecha > hoy)
                {
                    MessageBox.Show("La fecha no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // detenemos la ejecución
                }

                // Aquí va tu consulta a la base de datos
                ultimoMonto = 1500.75m;
                ultimaCantidad = 23;
            }
            else
            {
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                // Validaciones:
                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (desde > hoy || hasta > hoy)
                {
                    MessageBox.Show("No se pueden seleccionar fechas futuras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Consulta simulada
                ultimoMonto = 5600.20m;
                ultimaCantidad = 94;
            }

            // Actualizamos Labels
            lblMonto.Text = $"Total: ${ultimoMonto}";
            lblCantidad.Text = $"Unidades: {ultimaCantidad}";
        }


        private void btnBuscar_CursorChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void btnPorPeriodo_Click_1(object sender, EventArgs e)
        {

        }
    }
}


