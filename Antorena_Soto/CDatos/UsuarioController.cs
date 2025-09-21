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
                                    string domicilio, string telefono, string correo, long cuit,
                                    DateTime fechaNacimiento, DateTime fechaIngreso, int tipoUsuario)
        {
            try
            {
                using (SqlConnection conexionSql = new SqlConnection(conexionString))
                {
                    string consulta = @"INSERT INTO Usuario
                                    (id_dni_usuario, nomYApe_usuario, provincia, ciudad, domicilio, telefono, correo, cuit, fechaNacimiento, fechaIngreso,tipoUsuario)
                                     VALUES (@dni, @nombre, @provincia, @ciudad, @domicilio, @telefono, @correo, @cuit, @fechaNacimiento, @fechaIngreso, @tipoUsuario)";

                    SqlCommand comandoSql = new SqlCommand(consulta, conexionSql);
                    comandoSql.Parameters.AddWithValue("@dni", dni);
                    comandoSql.Parameters.AddWithValue("@nombre", nombre);
                    comandoSql.Parameters.AddWithValue("@provincia", provincia);
                    comandoSql.Parameters.AddWithValue("@ciudad", ciudad);
                    comandoSql.Parameters.AddWithValue("@domicilio", domicilio);
                    comandoSql.Parameters.AddWithValue("@telefono", telefono);
                    comandoSql.Parameters.AddWithValue("@correo", correo);
                    comandoSql.Parameters.AddWithValue("@cuit", cuit);
                    comandoSql.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    comandoSql.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    comandoSql.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);

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
                    string consulta = "SELECT * FROM Usuario";
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

    }


}