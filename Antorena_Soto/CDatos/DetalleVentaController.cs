using System;
using System.Data;
using System.Data.SqlClient;
using Antorena_Soto.CDatos; // Para el objeto Detalle_venta

namespace Antorena_Soto.CDatos
{
    public class Detalle_VentaDAL
    {
        private readonly string conexionString;

        public Detalle_VentaDAL(string conexionString)
        {
            this.conexionString = conexionString;
        }

        /// <summary>
        /// Inserta un item de detalle de venta en la BBDD.
        /// </summary>
        public bool InsertarDetalle(Detalle_venta detalle)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    // No se usa SCOPE_IDENTITY porque las PKs vienen de las otras tablas
                    string consulta = @"INSERT INTO Detalle_venta 
                                        (id_factura, id_producto, cantidad, precio)
                                      VALUES 
                                        (@id_factura, @id_producto, @cantidad, @precio)";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);

                    comandoSql.Parameters.AddWithValue("@id_factura", detalle.id_factura);
                    comandoSql.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                    comandoSql.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    // Nota: Tu entidad usa 'double', SQL Server usa 'float' para 'double'
                    // Si tu columna SQL es 'decimal', es mejor usar 'decimal' en C#
                    comandoSql.Parameters.AddWithValue("@precio", detalle.precio);

                    conexionSql.Open();
                    int filasAfectadas = comandoSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el detalle de venta en la BBDD", ex);
            }
        }

        /// <summary>
        /// Lista todos los detalles de una factura específica.
        /// </summary>
        public DataTable ListarDetallesPorFactura(long id_factura)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"SELECT id_factura, id_producto, cantidad, precio 
                                        FROM Detalle_venta
                                        WHERE id_factura = @id_factura";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    comandoSql.Parameters.AddWithValue("@id_factura", id_factura);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql);
                    DataTable tablaDetalles = new DataTable();
                    adaptador.Fill(tablaDetalles);
                    return tablaDetalles;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los detalles de la factura", ex);
            }
        }

        /// <summary>
        /// Actualiza un item de detalle (ej. cambia cantidad o precio).
        /// Necesita la clave compuesta (factura + producto) para saber cuál actualizar.
        /// </summary>
        public bool ActualizarDetalle(Detalle_venta detalle)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"UPDATE Detalle_venta SET
                                            cantidad = @cantidad,
                                            precio = @precio
                                      WHERE
                                            id_factura = @id_factura AND id_producto = @id_producto";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);

                    comandoSql.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                    comandoSql.Parameters.AddWithValue("@precio", detalle.precio);
                    comandoSql.Parameters.AddWithValue("@id_factura", detalle.id_factura);
                    comandoSql.Parameters.AddWithValue("@id_producto", detalle.id_producto);

                    conexionSql.Open();
                    int filasAfectadas = comandoSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el detalle de venta", ex);
            }
        }

        /// <summary>
        /// Elimina un item de detalle específico de una factura.
        /// Necesita la clave compuesta.
        /// </summary>
        public bool EliminarDetalle(long id_factura, int id_producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Detalle_venta WHERE id_factura = @id_factura AND id_producto = @id_producto";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_factura", id_factura);
                        cmd.Parameters.AddWithValue("@id_producto", id_producto);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en EliminarDetalle DAL", ex);
            }
        }
    }
}