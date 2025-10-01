using System;
using System.Data;
using System.Data.SqlClient;

namespace Antorena_Soto.CDatos
{
    public class UsuarioDAL
    {
        private readonly string conexionString;

        public UsuarioDAL(string conexionString)
        {
            this.conexionString = conexionString;
        }

        //INSERTAR USUARIO
        public bool InsertarUsuario(int dni, string nombre, string provincia, string ciudad,
                                    string domicilio, long telefono, string correo,
                                    DateTime fechaNacimiento, long cuit, DateTime fechaIngreso, int tipoUsuario, string Estado)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"INSERT INTO Usuario
                                    (id_dni_usuario, nomYApe_usuario, provincia, ciudad, domicilio, telefono, correo, fecha_nacimiento, cuit, fecha_ingreso,tipo_Usuario,Estado)
                                     VALUES (@dni, @nombre, @provincia, @ciudad, @domicilio, @telefono, @correo, @fecha_nacimiento, @cuit, @fecha_ingreso, @tipo_Usuario,@estado)";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    comandoSql.Parameters.AddWithValue("@dni", dni);
                    comandoSql.Parameters.AddWithValue("@nombre", nombre);
                    comandoSql.Parameters.AddWithValue("@provincia", provincia);
                    comandoSql.Parameters.AddWithValue("@ciudad", ciudad);
                    comandoSql.Parameters.AddWithValue("@domicilio", domicilio);
                    comandoSql.Parameters.AddWithValue("@telefono", telefono);
                    comandoSql.Parameters.AddWithValue("@correo", correo);                   
                    comandoSql.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                    comandoSql.Parameters.AddWithValue("@cuit", cuit);
                    comandoSql.Parameters.AddWithValue("@fecha_ingreso", fechaIngreso);
                    comandoSql.Parameters.AddWithValue("@tipo_Usuario", tipoUsuario);
                    comandoSql.Parameters.AddWithValue("@estado", Estado);
                    conexionSql.Open();
                    int filasAfectadas = comandoSql.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el usuario en la base de datos", ex);
            }

        }
        //LISTAR USUARIO

        public DataTable ListarUsuarios()
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"SELECT id_dni_usuario, nomYApe_usuario, provincia, ciudad, domicilio, telefono, correo, fecha_nacimiento, cuit, fecha_ingreso, tipo_Usuario,Estado
                                        FROM Usuario ";
                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql);
                    DataTable tablaUsuarios = new DataTable();
                    adaptador.Fill(tablaUsuarios);
                    return tablaUsuarios;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los usuarios desde la base de datos", ex);
            }
        }

        public DataTable BuscarUsuarios(string criterio, bool buscarPorDni)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un criterio de búsqueda.");

            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta;

                    if (buscarPorDni)
                    {
                        consulta = @"SELECT id_dni_usuario, nomYApe_usuario, provincia, ciudad, domicilio, telefono, correo, fecha_nacimiento, cuit, fecha_ingreso, tipo_Usuario,Estado
                             FROM Usuario WHERE id_dni_usuario = @criterio ";
                    }
                    else
                    {
                        consulta = @"SELECT id_dni_usuario, nomYApe_usuario, provincia, ciudad, domicilio, telefono, correo, fecha_nacimiento, cuit, fecha_ingreso, tipo_Usuario,Estado
                             FROM Usuario WHERE nomYApe_usuario LIKE '%' + @criterio + '%'";
                    }

                    using (SqlCommand comandoSql = new SqlCommand(consulta, conexionSql))
                    {
                        if (buscarPorDni)
                            comandoSql.Parameters.AddWithValue("@criterio", int.Parse(criterio));
                        else
                            comandoSql.Parameters.AddWithValue("@criterio", criterio);

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comandoSql))
                        {
                            DataTable tablaUsuarios = new DataTable();
                            adaptador.Fill(tablaUsuarios);
                            return tablaUsuarios;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar usuarios en la base de datos", ex);
            }
        }

        // ELIMINAR USUARIO POR DNI
        public bool BajaUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexionString))
                {
                    conn.Open();
                    string query = "UPDATE Usuario SET Estado = 'Inactivo' WHERE id_dni_usuario = @dni";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", idUsuario);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0; // true si eliminó, false si no
                    }
                }
            }
            catch (Exception ex)
            {
                // Podés loguear o lanzar una excepción personalizada
                throw new Exception("Error en BajaUsuario DAL", ex);
            }
        }

    }


}