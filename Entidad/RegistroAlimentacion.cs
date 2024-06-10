using System;


namespace Entidad
{
    public class RegistroAlimentacion
    {

        public RegistroAlimentacion() 
        {
            IdRegistroAlimentacion=0;
            CantidadAgua = 0;
            CantidadAlimento = 0;
            IdGalpon = new Galpon();
            IdAlimento = new Alimento();
        }

        public int IdRegistroAlimentacion { get; set; }
        public int CantidadAlimento { get; set; }
        public int CantidadAgua { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public Galpon IdGalpon { get; set; }
        public Alimento IdAlimento { get; set; }
    }
}
