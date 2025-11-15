using System;
using System.Data;
using Antorena_Soto.CDatos;

namespace Antorena_Soto.CLogica
{
    // DAL Capa DATOS( Data Access Layer) y BLL Capa LOGICA (Business Logic Layer)
    public class ClienteBLL 
    {
        
        private readonly ClienteDAL clienteDAL;

        public ClienteBLL(string conexionString)
        {
            clienteDAL = new ClienteDAL(conexionString);
        }

        public bool AgregarCliente(string nombre, string dni, string provincia, string ciudad,
                                   string domicilio, long cuit, long telefono, string correo,
                                   DateTime fechaIngreso, int estado)
        {
           
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI es obligatorio.");

            if (!int.TryParse(dni, out int dniInt) || dniInt <= 0)
                throw new ArgumentException("El DNI debe ser un número positivo válido.");

            return clienteDAL.InsertarCliente(nombre, dniInt, provincia, ciudad, domicilio, cuit, telefono, correo, fechaIngreso, estado);
        }

        public bool ActualizarCliente(string nombre, string dni, string provincia, string ciudad,
                                      string domicilio, long cuit, long telefono, string correo,
                                      DateTime fechaIngreso, int estado)
        {
          
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI es obligatorio.");

            if (!int.TryParse(dni, out int dniInt) || dniInt <= 0)
                throw new ArgumentException("El DNI debe ser un número positivo válido.");

           
            return clienteDAL.ActualizarCliente(nombre, dniInt, provincia, ciudad, domicilio, cuit, telefono, correo, fechaIngreso, estado);
        }

        // LISTAR CLIENTES
        public DataTable ListarClientesBLL()
        {
            return clienteDAL.ListarClientes();
        }

        // BUSCAR CLIENTES
        public DataTable BuscarClientesBLL(string criterio, bool buscarPorDni)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un valor para la búsqueda.");

            if (buscarPorDni)
            {
                if (!int.TryParse(criterio, out int _))
                    throw new ArgumentException("Si busca por DNI, el criterio debe ser numérico.");
            }

            return clienteDAL.BuscarClientes(criterio, buscarPorDni);
        }

        // BAJA (LÓGICA) DE CLIENTE
        public bool BajaClienteBLL(int dniCliente)
        {
            if (dniCliente <= 0)
            {
                throw new ArgumentException("El DNI del cliente no es válido.");
            }

            return clienteDAL.BajaCliente(dniCliente);
        }
    }
}