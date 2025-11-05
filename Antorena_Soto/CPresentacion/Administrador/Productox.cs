using System;
using System.Drawing;

namespace Antorena_Soto.CPresentacion.Administrador
{
    public class Productox
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public bool Estado { get; set; } = true;
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Image Imagen { get; set; }
        public DateTime FechaModificacion { get; set; }
  
    }

}