using System;
using System.Data;
using Antorena_Soto.CDatos;

namespace Antorena_Soto.CLogica
{
    //DAL Capa DATOS( Data Access Layer) y BLL Capa LOGICA (Business Logic Layer)
    public class UsuarioBLL
    {
        private readonly UsuarioDAL usuarioDAL;

        public UsuarioBLL(string conexionString)
        {
            usuarioDAL = new UsuarioDAL(conexionString);
        }

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
            // Acá podrías agregar validaciones de negocio antes de llamar al DAL
            if (idUsuario <= 0)
            {
                throw new ArgumentException("El ID de usuario no es válido.");
            }

            return usuarioDAL.BajaUsuario(idUsuario);
        }
    }
}