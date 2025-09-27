using System;
using System.Drawing;

namespace Antorena_Soto.CPresentacion.Gerente
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public Image Imagen { get; set; }
        public DateTime FechaModificacion { get; set; }
    }

}