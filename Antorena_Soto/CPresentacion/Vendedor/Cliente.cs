namespace CPresentacion.Vendedor  // ajustá según tu proyecto
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Domicilio { get; set; }
        public string NumeroTelefono { get; set; }
        public string Correo { get; set; }

        // Constructor vacío
        public Cliente() { }

        // Constructor con parámetros opcional
        public Cliente(string nombre, string dni, string provincia, string ciudad, string domicilio, string numero, string correo)
        {
            Nombre = nombre;
            DNI = dni;
            Provincia = provincia;
            Ciudad = ciudad;
            Domicilio = domicilio;
            NumeroTelefono = numero;
            Correo = correo;
        }
    }
}
