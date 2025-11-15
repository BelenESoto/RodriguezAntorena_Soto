using System;
using System.Data;
using Antorena_Soto.CDatos;

namespace Antorena_Soto.CLogica
{
    //DAL Capa DATOS( Data Access Layer) y BLL Capa LOGICA (Business Logic Layer)
    public class UsuarioBLL
    {
        private readonly UsuarioDAL usuarioDAL;

        //Hicimos otra clase estatica para manejar la sesión del usuario
        public static class SesionUsuario
        {
            // Propiedades para guardar los datos del usuario
            public static int DniUsuario { get; private set; }
            public static string NombreUsuario { get; private set; }
            public static int TipoUsuario { get; private set; }
            public static bool Logueado { get; private set; }


            public static void Login(DataRow filaUsuario)
            {
                DniUsuario = Convert.ToInt32(filaUsuario["id_dni_usuario"]);
                NombreUsuario = Convert.ToString(filaUsuario["nomYApe_usuario"]);
                TipoUsuario = Convert.ToInt32(filaUsuario["tipo_Usuario"]);
                Logueado = true;
            }

            //Para cerrar la sesión y limpiar los datos.
            public static void Logout()
            {
                DniUsuario = 0;
                NombreUsuario = null;
                TipoUsuario = 0;
                Logueado = false;
            }
        }

        public UsuarioBLL(string conexionString)
        {
            usuarioDAL = new UsuarioDAL(conexionString);
        }
        //AGREGAR USUARIO
        public bool AgregarUsuario(string dni, string nombre, string provincia, string ciudad,
                                   string domicilio, long telefono, string correo,
                                   DateTime fechaNacimiento, long cuit, DateTime fechaIngreso, int tipoUsuario,string Estado)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (!int.TryParse(dni, out int dniInt))
                throw new ArgumentException("El DNI debe ser numérico.");

            return usuarioDAL.InsertarUsuario(dniInt, nombre, provincia, ciudad, domicilio, telefono, correo, fechaNacimiento, cuit, fechaIngreso, tipoUsuario, Estado);
        }

        public DataTable ListarUsuariosBLL()
        {
            return usuarioDAL.ListarUsuarios();
        }

        // BUSCAR USUARIOS
        public DataTable BuscarUsuariosBLL(string criterio, bool buscarPorDni)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un valor para la búsqueda.");

            return usuarioDAL.BuscarUsuarios(criterio, buscarPorDni);
        }

        // ELIMINAR USUARIO
        public bool BajaUsuarioBLL(int idUsuario)
        {
           
            if (idUsuario <= 0)
            {
                throw new ArgumentException("El ID de usuario no es válido.");
            }

            return usuarioDAL.BajaUsuario(idUsuario);
        }
    }
}