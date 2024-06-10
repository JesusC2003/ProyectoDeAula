

namespace Entidad
{
    public class EntidadAsignado
    {
        public EntidadAsignado() 
        {
            IdAsignado = 0;
            IdEmpleado =new EntidadEmpleado();
            IdGalpon = new EntidadGalpon();

        }
        
        public int IdAsignado { get; set; } 
        public EntidadEmpleado IdEmpleado { get; set; }
        public EntidadGalpon IdGalpon { get; set; }
    }
}
    