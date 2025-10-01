using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antorena_Soto.CPresentacion.Vendedor
{
    public class Venta
    {
        public int Codigo_Venta { get; set; }      // lo podés autogenerar
        public DateTime Fecha_Venta { get; set; }
        public string Vendedor_Resp { get; set; }  // por ahora vacío
        public string Cliente_Venta { get; set; }
        public string Ciudad_Venta { get; set; }
        public string Medio_Pago_Venta { get; set; }
        public string Detalle_Prod_Venta { get; set; } // vacío por ahora
        public decimal Total_Venta { get; set; }
    }
}
