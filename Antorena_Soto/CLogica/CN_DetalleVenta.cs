using System;
using System.Data;
using Antorena_Soto.CDatos; // Para Detalle_venta y Detalle_VentaDAL

namespace Antorena_Soto.CLogica
{


    /// Clase simple para transportar los items del carrito  entre el form 'ventaAgregar' y 'ventaConfirmar'.
    public class DetalleVentaDTO
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; } // Usamos decimal para la plata
    }

    public class Detalle_VentaBLL
        {
        
         private readonly Detalle_VentaDAL detalleDAL;

         public Detalle_VentaBLL(string conexionString)
            {
            detalleDAL = new Detalle_VentaDAL(conexionString);
            }

         public bool AgregarDetalle(Detalle_venta detalle)
            {
            
            if (detalle.id_factura <= 0)
                throw new ArgumentException("El ID de la factura no es válido.");

            if (detalle.id_producto <= 0)
                throw new ArgumentException("El ID del producto no es válido.");

            if (detalle.cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            if (detalle.precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");
           
            return detalleDAL.InsertarDetalle(detalle);
            }

         public bool ActualizarDetalleBLL(Detalle_venta detalle)
            {
           
             if (detalle.id_factura <= 0 || detalle.id_producto <= 0)
                throw new ArgumentException("Los IDs de factura y producto no pueden estar vacíos.");

             if (detalle.cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

             if (detalle.precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a cero.");
           
            return detalleDAL.ActualizarDetalle(detalle);
         }

         public DataTable ListarDetallesPorFacturaBLL(long id_factura)
            {
                 if (id_factura <= 0)
                    throw new ArgumentException("El ID de la factura no es válido.");

                return detalleDAL.ListarDetallesPorFactura(id_factura);
         }

            public bool EliminarDetalleBLL(long id_factura, int id_producto)
            {
             if (id_factura <= 0)
                throw new ArgumentException("El ID de la factura no es válido.");

                if (id_producto <= 0)
                throw new ArgumentException("El ID del producto no es válido.");

                return detalleDAL.EliminarDetalle(id_factura, id_producto);
            }
    }
}