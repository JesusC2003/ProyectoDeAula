

namespace Entidad
{
    public class Cliente :Persona
    {
        public Cliente() 
        {
            Id = 0;
            Identificacion=string.Empty;
            TipoIdentificacion = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            TipoCliente = string.Empty;
        }
        public string TipoCliente { get; set; }
    }
}
