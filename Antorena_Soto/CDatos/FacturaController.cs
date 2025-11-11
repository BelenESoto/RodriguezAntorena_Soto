using System;
using System.Data;
using System.Data.SqlClient;
using Antorena_Soto.CDatos; // Para el objeto Factura

namespace Antorena_Soto.CDatos
{
    public class FacturaDAL
    {
        private readonly string conexionString;

        public FacturaDAL(string conexionString)
        {
            this.conexionString = conexionString;
        }

        /// <summary>
        /// Inserta una factura y devuelve el nuevo Nro de Factura (IDENTITY).
        /// </summary>
        /// <returns>El nro_factura (long) generado por la base de datos.</returns>
        public long InsertarFactura(Factura factura)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    // La consulta inserta los datos Y DEVUELVE el ID generado
                    // Asumimos que la tabla tiene la columna 'estado' y la insertamos como '1' (Activa)
                    string consulta = @"INSERT INTO Factura 
                                        (tipo_factura, id_cliente, fecha_factura, forma_pago, monto_total, estado_factura, vendedor_id)
                                      VALUES 
                                        (@tipo_factura, @id_cliente, @fecha_factura, @forma_pago, @monto_total, 1, @vendedor_id);
                                      
                                      SELECT CAST(SCOPE_IDENTITY() AS BIGINT);"; // Devuelve el último ID (long)

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);

                    comandoSql.Parameters.AddWithValue("@tipo_factura", factura.tipo_factura);
                    comandoSql.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
                    comandoSql.Parameters.AddWithValue("@fecha_factura", factura.fecha_factura);
                    comandoSql.Parameters.AddWithValue("@forma_pago", factura.forma_pago);
                    comandoSql.Parameters.AddWithValue("@monto_total", factura.monto_total);
                    comandoSql.Parameters.AddWithValue("@vendedor_id", factura.vendedor_id);
                    conexionSql.Open();

                    // Usamos ExecuteScalar porque la consulta devuelve un solo valor (el nuevo ID)
                    object resultado = comandoSql.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt64(resultado);
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener el ID de la factura insertada.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la factura en la base de datos", ex);
            }
        }

        /// <summary>
        /// Lista todas las facturas (idealmente debería filtrar por estado=1)
        /// </summary>
        public DataTable ListarFacturas()
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    // Agregamos la columna 'estado' al select
                    string consulta = @"SELECT nro_factura, tipo_factura, id_cliente, fecha_factura, forma_pago, monto_total, estado_factura,vendedor_id 
                                        FROM Factura WHERE estado_factura = 1";
                    // Opcional: WHERE estado = 1 (para listar solo activas)

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql);
                    DataTable tablaFacturas = new DataTable();
                    adaptador.Fill(tablaFacturas);
                    return tablaFacturas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las facturas desde la base de datos", ex);
            }
        }

        /// <summary>
        /// Busca facturas por NroFactura o IdCliente.
        /// </summary>
        public DataTable BuscarFacturas(string criterio, bool buscarPorNroFactura)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consultaBase = "SELECT nro_factura, tipo_factura, id_cliente, fecha_factura, forma_pago, monto_total, estado_factura,vendedor_id FROM Factura";
                    string consultaWhere;

                    if (buscarPorNroFactura)
                    {
                        consultaWhere = " WHERE nro_factura = @criterio";
                    }
                    else
                    {
                        consultaWhere = " WHERE id_cliente = @criterio";
                    }

                    using (SqlCommand comandoSql = new SqlCommand(consultaBase + consultaWhere, conexionSql))
                    {
                        if (buscarPorNroFactura)
                            comandoSql.Parameters.AddWithValue("@criterio", long.Parse(criterio));
                        else
                            comandoSql.Parameters.AddWithValue("@criterio", int.Parse(criterio));

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql))
                        {
                            DataTable tablaFacturas = new DataTable();
                            adaptador.Fill(tablaFacturas);
                            return tablaFacturas;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar facturas en la base de datos", ex);
            }
        }

        /// <summary>
        /// Actualiza una factura en la BBDD.
        /// </summary>
        public bool ActualizarFactura(Factura factura)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"UPDATE Factura SET
                                            tipo_factura = @tipo_factura,
                                            id_cliente = @id_cliente,
                                            fecha_factura = @fecha_factura,
                                            forma_pago = @forma_pago,
                                            monto_total = @monto_total
                                            estado = @estado_factura 
                                            vendedor_id = @vendedor_id
                                      WHERE
                                            nro_factura = @nro_factura";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);

                    comandoSql.Parameters.AddWithValue("@tipo_factura", factura.tipo_factura);
                    comandoSql.Parameters.AddWithValue("@id_cliente", factura.id_cliente);
                    comandoSql.Parameters.AddWithValue("@fecha_factura", factura.fecha_factura);
                    comandoSql.Parameters.AddWithValue("@forma_pago", factura.forma_pago);
                    comandoSql.Parameters.AddWithValue("@monto_total", factura.monto_total);
                    comandoSql.Parameters.AddWithValue("@nro_factura", factura.nro_factura);
                    comandoSql.Parameters.AddWithValue("@estado_factura", factura.estado_factura);
                    comandoSql.Parameters.AddWithValue("@vendedor_id", factura.vendedor_id);

                    conexionSql.Open();
                    int filasAfectadas = comandoSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la factura en la base de datos", ex);
            }
        }

        // --- MÉTODO MODIFICADO (Baja Lógica) ---
        /// <summary>
        /// Realiza una BAJA LÓGICA de una factura (la marca como inactiva/anulada).
        /// Asume que existe una columna 'estado' (int) donde 0 = Inactiva.
        /// </summary>
        public bool BajaLogicaFactura(long nroFactura)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                {
                    conn.Open();
                    // CAMBIO: De DELETE a UPDATE para baja lógica
                    string query = "UPDATE Factura SET estado_factura = 0 WHERE nro_factura = @nro_factura";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nro_factura", nroFactura);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0; // true si actualizó, false si no
                    }
                }
            }
            catch (Exception ex)
            {
                // Renombramos la excepción para que coincida con el método
                throw new Exception("Error en BajaLogicaFactura DAL", ex);
            }
        }
    }
}
