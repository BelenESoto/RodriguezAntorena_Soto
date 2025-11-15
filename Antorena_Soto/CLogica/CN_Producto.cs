using Antorena_Soto.CDatos;
using Antorena_Soto.CPresentacion.Administrador;
using Antorena_Soto.CPresentacion.Gerente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;



namespace Antorena_Soto.CLogica
{
    public class CN_Producto
    {
        private readonly CD_Producto cd_Producto;

        public CN_Producto(string conexionString)
        {
            cd_Producto = new CD_Producto(conexionString); 
        }

        //   ALTA DE PRODUCTO en bd 

        public bool AgregarProducto(string nombre, string codigo, string categoria,
                                string precio, string descripcion, string stock,
                                bool estado, DateTime fechaModif, byte[] imagen = null)
        {
            // VALIDACIONES OBLIGATORIAS
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El campo 'Nombre del producto' no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(codigo) || !int.TryParse(codigo, out int codigoInt) || codigoInt <= 0)
                throw new ArgumentException("Debe ingresar un código de producto válido (número mayor a 0).");

            if (!int.TryParse(categoria, out int categoriaInt) || categoriaInt <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");

            if (!decimal.TryParse(precio, out decimal precioDec) || precioDec < 0)
                throw new ArgumentException("Debe ingresar un precio válido (número mayor o igual a 0).");

            if (string.IsNullOrWhiteSpace(stock) || !int.TryParse(stock, out int stockInt) || stockInt < 0)
                throw new ArgumentException("Debe ingresar un stock válido (número mayor o igual a 0).");

            if (!bool.TryParse(estado.ToString(), out bool estadoBool))
                throw new ArgumentException("El estado del producto debe ser verdadero o falso.");

            return cd_Producto.InsertarProducto(
                nombre, codigoInt, estado, descripcion, categoriaInt, precioDec, stockInt, imagen, fechaModif);
        }
       
        //   LISTAR USUARIOS BD 
        public DataTable ListarProductosBLL()
        {
            return cd_Producto.ListarProductosBD();
        }

        //   MODIFICACIÓN DE PRODUCTO bd -
        public bool ModificarProductoBBL(string codigo, string nombre, string categoria,
                                      string precio, string descripcion, string stock,
                                      bool estado, DateTime fechaModif, byte[] imagen = null)
        {   // VALIDACIONES OBLIGATORIAS
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El campo 'Nombre del producto' no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(codigo) || !int.TryParse(codigo, out int codigoInt) || codigoInt <= 0)
                throw new ArgumentException("Debe ingresar un código de producto válido (número mayor a 0).");

            if (!int.TryParse(categoria, out int categoriaInt) || categoriaInt <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida.");

            if (!decimal.TryParse(precio, out decimal precioDec) || precioDec < 0)
                throw new ArgumentException("Debe ingresar un precio válido (número mayor o igual a 0).");

            if (string.IsNullOrWhiteSpace(stock) || !int.TryParse(stock, out int stockInt) || stockInt < 0)
                throw new ArgumentException("Debe ingresar un stock válido (número mayor o igual a 0).");

            return cd_Producto.ModificarProductoBD(
              nombre, codigoInt, estado, descripcion, categoriaInt, precioDec, stockInt, imagen, fechaModif);
        }


        //   BAJA LÓGICA (estado = 0) 

        public bool BajaProducto(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo) || !int.TryParse(codigo, out int codigoInt) || codigoInt <= 0)
                throw new ArgumentException("Debe seleccionar un producto válido para dar de baja.");
            return cd_Producto.BajaProductoBD(codigoInt);

        }

        // ELIMINAR PRODUCTO EN BD 
        public bool BajaProductoBLL(int codigoP)
        {
            if (codigoP <= 0)
            {
                throw new ArgumentException("El codigo no es válido.");
            }
            return cd_Producto.BajaProductoBD(codigoP);
        }

        // BUSCAR PRODUCTOS EN BD
        public DataTable BuscarProductosBLL(string criterio, bool buscarPorCod)
        {
            if (string.IsNullOrWhiteSpace(criterio))
                throw new ArgumentException("Debe ingresar un valor para la búsqueda.");

            return cd_Producto.BuscarProductosBD(criterio, buscarPorCod);
        }

        
        //   LISTAR PRODUCTOS BD
        public DataTable ListarProductos()
        {
            return cd_Producto.ListarProductosBD();
        }

        
        public List<Productox> ListaProductos()
        {
            DataTable tabla = cd_Producto.ListarProductos(); // devuelve DataTable

            List<Productox> lista = new List<Productox>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Productox
                {
                    Codigo = Convert.ToInt32(fila["Codigo"]),
                    Nombre = fila["Nombre"].ToString(),
                    Categoria = fila["Categoria"].ToString(),
                    Precio = Convert.ToDecimal(fila["Precio"]),
                    Stock = Convert.ToInt32(fila["Stock"]),
                    Descripcion = fila["Descripcion"].ToString(),
                    Estado = Convert.ToBoolean(fila["Estado"]),
                    FechaModificacion = Convert.ToDateTime(fila["FechaModificacion"]),
                    Imagen = fila["Imagen"] == DBNull.Value ? null : (Image)fila["Imagen"]
                });
            }

            return lista;
        }


        public DataTable ReporteVentas()
        {
            return cd_Producto.ReporteVentas();
        }
        public bool ActualizarStockBLL(int idProducto, int cantidadComprada)
        {
            if (idProducto <= 0)
                throw new ArgumentException("El ID del producto no es válido.");

            if (cantidadComprada <= 0)
                throw new ArgumentException("La cantidad comprada debe ser mayor a cero.");

            return cd_Producto.ActualizarStock(idProducto, cantidadComprada);
        }
    }
}
