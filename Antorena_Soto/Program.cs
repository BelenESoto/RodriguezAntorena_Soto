using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.Gerente;
using Antorena_Soto.CPresentacion.SuperAdministrador;
using Antorena_Soto.CPresentacion.Vendedor;
using CPresentacion.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

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
            Application.Run(new menuVendedor());


        }
    }
    namespace CPresentacion.Vendedor
    {
        public static class RepositorioClientes
        {
            public static BindingList<Cliente> ListaClientes { get; } = new BindingList<Cliente>();
        }
    }

}
//AltaProductos
// Form1()
//FormMenuGerente