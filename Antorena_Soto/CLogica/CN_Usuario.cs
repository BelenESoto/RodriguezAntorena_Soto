using System;
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
                                   string domicilio, string telefono, string correo, long cuit,
                                   DateTime fechaNacimiento, DateTime fechaIngreso, int tipoUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (!int.TryParse(dni, out int dniInt))
                throw new ArgumentException("El DNI debe ser numérico.");

            return usuarioDAL.InsertarUsuario(dniInt, nombre, provincia, ciudad, domicilio, telefono, correo, cuit, fechaNacimiento, fechaIngreso, tipoUsuario);
        }
    }
}