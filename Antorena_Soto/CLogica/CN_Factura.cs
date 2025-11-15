using System;
using System.Data;
using Antorena_Soto.CDatos; 

namespace Antorena_Soto.CLogica
{

    public class FacturaBLL
    {
        
        private readonly FacturaDAL facturaDAL;

        public FacturaBLL(string conexionString)
        {
            facturaDAL = new FacturaDAL(conexionString);
        }

       
        public Factura AgregarFactura(Factura factura)
        {
            // --- INICIO REGLAS DE NEGOCIO / VALIDACIONES ---
            if (factura.id_cliente <= 0)
                throw new ArgumentException("El ID del cliente no es válido.");

            if (string.IsNullOrWhiteSpace(factura.tipo_factura))
                throw new ArgumentException("El tipo de factura es obligatorio.");

            if (string.IsNullOrWhiteSpace(factura.forma_pago))
                throw new ArgumentException("La forma de pago es obligatoria.");

            if (factura.monto_total <= 0)
                throw new ArgumentException("El monto total debe ser mayor a cero.");

            if (factura.fecha_factura > DateTime.Now.AddDays(1))
                throw new ArgumentException("La fecha de la factura no puede ser futura.");
            
            long nuevoNroFactura = facturaDAL.InsertarFactura(factura);

            if (nuevoNroFactura > 0)
            {
                factura.nro_factura = nuevoNroFactura;
                return factura;
            }
            else
            {
                throw new Exception("Error al obtener el número de factura desde la base de datos.");
            }
        }

       
        public bool ActualizarFacturaBLL(Factura factura)
        {
            //  VALIDACIONES 
            if (factura.nro_factura <= 0)
                throw new ArgumentException("El Nro. de factura a actualizar no es válido.");

            if (factura.id_cliente <= 0)
                throw new ArgumentException("El ID del cliente no es válido.");

            if (factura.monto_total <= 0)
                throw new ArgumentException("El monto total debe ser mayor a cero.");
           

            return facturaDAL.ActualizarFactura(factura);
        }

    
        public DataTable ListarFacturasBLL()
        {
            return facturaDAL.ListarFacturas();
        }

       
        public DataTable BuscarFacturasBLL(string criterio, bool buscarPorNroFactura)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un valor para la búsqueda.");

            if (buscarPorNroFactura)
            {
                if (!long.TryParse(criterio, out _))
                    throw new ArgumentException("Si busca por Nro. Factura, el criterio debe ser numérico (long).");
            }
            else
            {
                if (!int.TryParse(criterio, out _))
                    throw new ArgumentException("Si busca por ID Cliente, el criterio debe ser numérico (int).");
            }

            return facturaDAL.BuscarFacturas(criterio, buscarPorNroFactura);
        }

        public bool BajaFacturaBLL(long nroFactura)
        {
            if (nroFactura <= 0)
            {
                throw new ArgumentException("El Nro. de factura no es válido.");
            }

            return facturaDAL.BajaLogicaFactura(nroFactura);
        }
    }
}
