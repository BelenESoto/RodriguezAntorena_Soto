using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.Vendedor;
using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.SuperAdministrador;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antorena_Soto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menuSuperAdm());


        }
    }
}
//AltaProductos
// Form1()
