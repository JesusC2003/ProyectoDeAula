

namespace Entidad
{
    public class EntidadGalpon
    {
        public EntidadGalpon()
        {
            IdGalpon = 0;
            AreaGalpon = 0;
            EstadoGalpon = string.Empty;
        }

        public int CalcularCapacidad(int AreaGalpon)
        {
            int Capacidad = 0 ;
            Capacidad = AreaGalpon * 12;
            return Capacidad; 
        } 

        public int IdGalpon { get; set; }
        public string CodigoGalpon { get; set; }
        public double AreaGalpon { get; set; }
        public string EstadoGalpon { get; set; }       

    }
}
    