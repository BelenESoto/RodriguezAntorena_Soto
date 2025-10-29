using System;
using System.Data;
using System.Data.SqlClient;

namespace Antorena_Soto.CDatos
{
    public class ClienteDAL
    {
        private readonly string conexionString;

        public ClienteDAL(string conexionString)
        {
            this.conexionString = conexionString;
        }

        //INSERTAR CLIENTE (Orden de parámetros respetado)
        public bool InsertarCliente(string nombre, int dni, string provincia, string ciudad,
                                    string domicilio, long cuit, long telefono, string correo,
                                    DateTime fechaIngreso, int estado)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    // Columnas y valores en el orden solicitado
                    string consulta = @"INSERT INTO Cliente
                                        (nomYApe_cliente, dni_cliente, provincia, ciudad, domicilio, cuit, telefono, correo, fecha_ingreso, estado)
                                      VALUES 
                                        (@nombre, @dni, @provincia, @ciudad, @domicilio, @cuit, @telefono, @correo, @fecha_ingreso, @estado)";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);

                    // Parámetros añadidos en el mismo orden
                    comandoSql.Parameters.AddWithValue("@nombre", nombre);
                    comandoSql.Parameters.AddWithValue("@dni", dni);
                    comandoSql.Parameters.AddWithValue("@provincia", provincia);
                    comandoSql.Parameters.AddWithValue("@ciudad", ciudad);
                    comandoSql.Parameters.AddWithValue("@domicilio", domicilio);
                    comandoSql.Parameters.AddWithValue("@cuit", cuit);
                    comandoSql.Parameters.AddWithValue("@telefono", telefono);
                    comandoSql.Parameters.AddWithValue("@correo", correo);
                    comandoSql.Parameters.AddWithValue("@fecha_ingreso", fechaIngreso);
                    comandoSql.Parameters.AddWithValue("@estado", estado);

                    conexionSql.Open();
                    int filasAfectadas = comandoSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente en la base de datos", ex);
            }
        }

        //LISTAR CLIENTES
        public DataTable ListarClientes()
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    // El orden del SELECT es el que define el DataTable
                    string consulta = @"SELECT nomYApe_cliente, dni_cliente, provincia, ciudad, domicilio, cuit, telefono, correo, fecha_ingreso, estado
                                        FROM Cliente";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql);
                    DataTable tablaClientes = new DataTable();
                    adaptador.Fill(tablaClientes);
                    return tablaClientes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los clientes desde la base de datos", ex);
            }
        }

        //BUSCAR CLIENTES (por DNI o por Nombre)
        // Este método no recibe todos los parámetros, solo el de búsqueda
        public DataTable BuscarClientes(string criterio, bool buscarPorDni)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un criterio de búsqueda.");

            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta;
                    // Columnas en el orden deseado
                    string columnasSelect = "SELECT nomYApe_cliente, dni_cliente, provincia, ciudad, domicilio, cuit, telefono, correo, fecha_ingreso, estado FROM Cliente";

                    if (buscarPorDni)
                    {
                        consulta = $"{columnasSelect} WHERE dni_cliente = @criterio";
                    }
                    else
                    {
                        consulta = $"{columnasSelect} WHERE nomYApe_cliente LIKE '%' + @criterio + '%'";
                    }

                    using (SqlCommand comandoSql = new SqlCommand(consulta, conexionSql))
                    {
                        if (buscarPorDni)
                            comandoSql.Parameters.AddWithValue("@criterio", int.Parse(criterio));
                        else
                            comandoSql.Parameters.AddWithValue("@criterio", criterio);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql))
                        {
                            DataTable tablaClientes = new DataTable();
                            adaptador.Fill(tablaClientes);
                            return tablaClientes;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar clientes en la base de datos", ex);
            }
        }

        // ACTUALIZAR CLIENTE (Orden de parámetros respetado)
        public bool ActualizarCliente(string nombre, int dni, string provincia, string ciudad,
                                    string domicilio, long cuit, long telefono, string correo,
                                    DateTime fechaIngreso, int estado)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    // La sentencia SET no requiere un orden, pero se ha ordenado para claridad
                    string consulta = @"UPDATE Cliente SET
                                            nomYApe_cliente = @nombre,
                                            provincia = @provincia,
                                            ciudad = @ciudad,
                                            domicilio = @domicilio,
                                            cuit = @cuit,
                                            telefono = @telefono,
                                            correo = @correo,
                                            fecha_ingreso = @fecha_ingreso,
                                            estado = @estado
                                      WHERE
                                            dni_cliente = @dni"; // El DNI se usa para el WHERE

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);

                    // Parámetros añadidos en el mismo orden de la firma del método
                    comandoSql.Parameters.AddWithValue("@nombre", nombre);
                    comandoSql.Parameters.AddWithValue("@dni", dni); // El DNI se usa tanto en el WHERE como parámetro
                    comandoSql.Parameters.AddWithValue("@provincia", provincia);
                    comandoSql.Parameters.AddWithValue("@ciudad", ciudad);
                    comandoSql.Parameters.AddWithValue("@domicilio", domicilio);
                    comandoSql.Parameters.AddWithValue("@cuit", cuit);
                    comandoSql.Parameters.AddWithValue("@telefono", telefono);
                    comandoSql.Parameters.AddWithValue("@correo", correo);
                    comandoSql.Parameters.AddWithValue("@fecha_ingreso", fechaIngreso);
                    comandoSql.Parameters.AddWithValue("@estado", estado);

                    conexionSql.Open();
                    int filasAfectadas = comandoSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente en la base de datos", ex);
            }
        }


        // BAJA LÓGICA DE CLIENTE (por DNI)
        // Este método solo necesita el DNI
        public bool BajaCliente(int dniCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                {
                    conn.Open();
                    // Asumimos que '0' significa 'Inactivo'
                    string query = "UPDATE Cliente SET estado = 0 WHERE dni_cliente = @dni";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniCliente);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BajaCliente DAL", ex);
            }
        }
    }
}