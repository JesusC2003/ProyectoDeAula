

namespace Entidad
{
    public class Cliente :Persona
    {
        Cliente() 
        {
            Id = 0;
            Identificacion=string.Empty;
            TipoIdentificacion = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            CodigoCliente = string.Empty;
            TipoCliente = string.Empty;
        }
        public string CodigoCliente {  get; set; }
        public string TipoCliente { get; set; }
    }
}
