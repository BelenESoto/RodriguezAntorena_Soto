using Antorena_Soto.CPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Antorena_Soto.CDatos
{
    public class CD_Producto
    {
        private readonly string conexionString;

        public CD_Producto(string conexionString)
        {
            this.conexionString = conexionString;
        }

        //BUSCAR PRODUCTOS BD 
        public DataTable BuscarProductosBD(string criterio, bool buscarPorCod)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un criterio de búsqueda.");

            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta;

                    if (buscarPorCod)
                    {
                        consulta = @"SELECT nombre_prod, codigo_prod, estado_prod, descripcion_prod, 
                                  categoria_prod, precio_prod, stock_prod, imagen_prod, fechaModif_prod 
                             FROM Producto WHERE codigo_prod = @criterio ";
                    }
                    else
                    {
                        consulta = @"SELECT nombre_prod, codigo_prod, estado_prod, descripcion_prod, 
                                  categoria_prod, precio_prod, stock_prod, imagen_prod, fechaModif_prod 
                             FROM Producto WHERE nombre_prod LIKE '%' + @criterio + '%'";
                    }

                    using (SqlCommand comandoSql = new SqlCommand(consulta, conexionSql))
                    {
                        if (buscarPorCod)
                            comandoSql.Parameters.AddWithValue("@criterio", int.Parse(criterio));
                        else
                            comandoSql.Parameters.AddWithValue("@criterio", criterio);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql))
                        {
                            DataTable tablaProductos = new DataTable();
                            adaptador.Fill(tablaProductos);
                            return tablaProductos;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar usuarios en la base de datos", ex);
            }
        }
        // LISTAR PRODUCTOS (TODOS o solo activos)

        public DataTable ListarProductos(bool soloActivos = true)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                string query = soloActivos
                    ? "SELECT * FROM Producto WHERE estado_prod = 1"
                    : "SELECT * FROM Producto";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // INSERTAR PRODUCTO BD
        public bool InsertarProducto(string nombre, int codigo, bool estado, string descripcion,
            int categoria, decimal precio, int stock, byte[] imagen, DateTime fechaModif)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                string query = @"INSERT INTO Producto 
                                 (nombre_prod, codigo_prod, estado_prod, descripcion_prod, 
                                  categoria_prod, precio_prod, stock_prod, imagen_prod, fechaModif_prod)
                                 VALUES 
                                 (@nombre, @codigo, @estado, @descripcion, 
                                  @categoria, @precio, @stock, @imagen, @fechaModif)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@fechaModif", fechaModif);

                if (imagen != null)
                    cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = imagen;
                else
                    cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = DBNull.Value;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        //LISTAR PRODUCTOS FUNCION CON BD
        public DataTable ListarProductosBD()
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"SELECT nombre_prod, codigo_prod, 
                                 CASE 
                                     WHEN estado_prod = 1 THEN 'Activo'
                                     ELSE 'Inactivo'
                                 END AS estado_prod, descripcion_prod, categoria_prod, precio_prod, 
                                 stock_prod, imagen_prod, fechaModif_prod FROM Producto ";
                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql);
                    DataTable tablaProducto = new DataTable();
                    adaptador.Fill(tablaProducto);
                    return tablaProducto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los productos desde la base de datos", ex);
            }
        }

        // ELIMINAR PRODUCTO POR CODIGO (BAJA LÓGICA) BD
        public bool BajaProductoBD(int codigoP)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                {
                    conn.Open();
                    string query = "UPDATE Producto SET estado_prod = 0 WHERE codigo_prod = @codigo_prod";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo_prod", codigoP);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BajaProducto ", ex);
            }
        }

        // BAJA LÓGICA DEL PRODUCTO (estado = 0)

        public bool BajaProducto(int codigo)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                string query = "UPDATE Producto SET estado_prod = 0 WHERE codigo_prod = @codigo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // MODIFICAR PRODUCTO bd
        public bool ModificarProductoBD(string nombre, int codigo, bool estado, string descripcion, int categoria, decimal precio,
                                       int stock, byte[] imagen, DateTime fechaModif)
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                string query = @"UPDATE Producto 
                                 SET nombre_prod=@nombre,
                                     estado_prod=@estado,
                                     descripcion_prod=@descripcion,
                                     categoria_prod=@categoria,
                                     precio_prod=@precio,
                                     stock_prod=@stock,
                                      imagen_prod = @imagen,
                                     fechaModif_prod=@fechaModif 
                                 WHERE codigo_prod=@codigo;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@fechaModif", fechaModif);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                if (imagen != null)
                    cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = imagen;
                else
                    cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = DBNull.Value;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // REPORTE DE VENTAS POR PRODUCTO

        public DataTable ReporteVentas()
        {
            using (SqlConnection conn = new SqlConnection(conexionString))
            {
                string query = @"SELECT p.nombre_prod AS Producto, 
                                        SUM(v.cantidad) AS TotalVendido, 
                                        SUM(v.total) AS TotalImporte
                                 FROM Venta v
                                 INNER JOIN Producto p ON v.codigo_prod = p.codigo_prod
                                 GROUP BY p.nombre_prod";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool ActualizarStock(int idProducto, int cantidadComprada)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                {
                    conn.Open();
                    string query = @"UPDATE Producto SET
                                stock_prod = stock_prod - @cantidad
                             WHERE
                                codigo_prod = @idProducto";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", cantidadComprada);
                        cmd.Parameters.AddWithValue("@idProducto", idProducto); 

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ActualizarStock DAL", ex);
            }
        }
    }
}
