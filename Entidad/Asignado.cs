

namespace Entidad
{
    public class Asignado
    {
        public Asignado() 
        {
            Codigo = string.Empty;
        }
        
        public string Codigo { get; set; } 
        public Empleado IdEmpleado { get; set; }
        public Galpon IdGalpon { get; set; }
    }
}
    