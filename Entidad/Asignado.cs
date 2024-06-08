

namespace Entidad
{
    public class Asignado
    {
        public Asignado() 
        {
            IdAsignado = 0;
            IdEmpleado =new Empleado();
            IdGalpon = new Galpon();

        }
        
        public int IdAsignado { get; set; } 
        public Empleado IdEmpleado { get; set; }
        public Galpon IdGalpon { get; set; }
    }
}
    