using System;
using System.Data;
using Antorena_Soto.CDatos;

namespace Antorena_Soto.CLogica
{
    // DAL Capa DATOS( Data Access Layer) y BLL Capa LOGICA (Business Logic Layer)
    public class ClienteBLL // Clase renombrada
    {
        // Dependencia de la capa DAL de Cliente
        private readonly ClienteDAL clienteDAL;

        public ClienteBLL(string conexionString)
        {
            // Instancia de ClienteDAL
            clienteDAL = new ClienteDAL(conexionString);
        }

        // AGREGAR CLIENTE
        // Los parámetros respetan el orden: nombre, dni, provincia...
        public bool AgregarCliente(string nombre, string dni, string provincia, string ciudad,
                                   string domicilio, long cuit, long telefono, string correo,
                                   DateTime fechaIngreso, int estado)
        {
            // --- INICIO REGLAS DE NEGOCIO / VALIDACIONES ---
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI es obligatorio.");

            // Validamos que el DNI (string) sea un número (int)
            if (!int.TryParse(dni, out int dniInt) || dniInt <= 0)
                throw new ArgumentException("El DNI debe ser un número positivo válido.");

            // (Aquí se pueden agregar más validaciones, ej. formato de CUIT, correo, etc.)
            // --- FIN REGLAS DE NEGOCIO ---

            // Se llama al DAL con los parámetros en el orden correcto
            return clienteDAL.InsertarCliente(nombre, dniInt, provincia, ciudad, domicilio, cuit, telefono, correo, fechaIngreso, estado);
        }

        // ACTUALIZAR CLIENTE (Método agregado)
        // Los parámetros respetan el orden: nombre, dni, provincia...
        public bool ActualizarCliente(string nombre, string dni, string provincia, string ciudad,
                                      string domicilio, long cuit, long telefono, string correo,
                                      DateTime fechaIngreso, int estado)
        {
            // --- INICIO REGLAS DE NEGOCIO / VALIDACIONES ---
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI es obligatorio.");

            if (!int.TryParse(dni, out int dniInt) || dniInt <= 0)
                throw new ArgumentException("El DNI debe ser un número positivo válido.");

            // --- FIN REGLAS DE NEGOCIO ---

            // Se llama al DAL con los parámetros en el orden correcto
            return clienteDAL.ActualizarCliente(nombre, dniInt, provincia, ciudad, domicilio, cuit, telefono, correo, fechaIngreso, estado);
        }

        // LISTAR CLIENTES
        public DataTable ListarClientesBLL()
        {
            // Simplemente reenviamos la llamada al DAL
            return clienteDAL.ListarClientes();
        }

        // BUSCAR CLIENTES
        public DataTable BuscarClientesBLL(string criterio, bool buscarPorDni)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un valor para la búsqueda.");

            // Validación adicional: si busca por DNI, debe ser numérico
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
            // Validación simple de negocio
            if (dniCliente <= 0)
            {
                throw new ArgumentException("El DNI del cliente no es válido.");
            }

            // Llamada al DAL
            return clienteDAL.BajaCliente(dniCliente);
        }
    }
}