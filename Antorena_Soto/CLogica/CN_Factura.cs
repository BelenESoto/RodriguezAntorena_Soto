using System;
using System.Data;
using Antorena_Soto.CDatos; // Para Factura y FacturaDAL

namespace Antorena_Soto.CLogica
{
    public class FacturaBLL
    {
        // Dependencia de la capa DAL de Factura
        private readonly FacturaDAL facturaDAL;

        public FacturaBLL(string conexionString)
        {
            // Instancia de FacturaDAL
            facturaDAL = new FacturaDAL(conexionString);
        }

        /// <summary>
        /// Agrega una nueva factura a la BBDD.
        /// </summary>
        /// <param name="factura">Objeto factura SIN nro_factura (será asignado por la BBDD)</param>
        /// <returns>El mismo objeto factura, pero con el 'nro_factura' asignado por la BBDD.</returns>
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
            // --- FIN REGLAS DE NEGOCIO ---

            // Se llama al DAL. Asumimos que InsertarFactura devuelve el nuevo ID (long)
            long nuevoNroFactura = facturaDAL.InsertarFactura(factura);

            if (nuevoNroFactura > 0)
            {
                // Asignamos el ID devuelto al objeto antes de retornarlo
                factura.nro_factura = nuevoNroFactura;
                return factura;
            }
            else
            {
                throw new Exception("Error al obtener el número de factura desde la base de datos.");
            }
        }

        /// <summary>
        /// Actualiza una factura existente.
        /// </summary>
        public bool ActualizarFacturaBLL(Factura factura)
        {
            // --- INICIO REGLAS DE NEGOCIO / VALIDACIONES ---
            if (factura.nro_factura <= 0)
                throw new ArgumentException("El Nro. de factura a actualizar no es válido.");

            if (factura.id_cliente <= 0)
                throw new ArgumentException("El ID del cliente no es válido.");

            if (factura.monto_total <= 0)
                throw new ArgumentException("El monto total debe ser mayor a cero.");
            // --- FIN REGLAS DE NEGOCIO ---

            return facturaDAL.ActualizarFactura(factura);
        }

        /// <summary>
        /// Obtiene todas las facturas.
        /// </summary>
        public DataTable ListarFacturasBLL()
        {
            return facturaDAL.ListarFacturas();
        }

        /// <summary>
        /// Busca facturas por Nro de Factura (long) o por ID de Cliente (int).
        /// </summary>
        /// <param name="criterio">El número a buscar (como string)</param>
        /// <param name="buscarPorNroFactura">True: busca por Nro. Factura. False: busca por ID Cliente.</param>
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

        // --- MÉTODO MODIFICADO (Baja Lógica) ---
        /// <summary>
        /// Realiza una baja lógica (anulación) de una factura.
        /// </summary>
        public bool BajaFacturaBLL(long nroFactura)
        {
            // Validación de negocio
            if (nroFactura <= 0)
            {
                throw new ArgumentException("El Nro. de factura no es válido.");
            }

            // Llama al método de baja lógica en la DAL
            return facturaDAL.BajaLogicaFactura(nroFactura);
        }
    }
}
