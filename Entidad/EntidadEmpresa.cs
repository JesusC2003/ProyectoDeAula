

namespace Entidad
{
    public class EntidadEmpresa
    {        
        public EntidadEmpresa() 
        {
            NIT = string.Empty;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Correo = string.Empty;
        }
        public string NIT { get; set; } 
        public string Nombre { get; set; } 
        public string Telefono { get; set; } 
        public string Direccion { get; set; }
        public string Correo { get; set; } 
    }
}
