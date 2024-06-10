using System;


namespace Entidad
{
    public class EntidadRegistroAlimentacion
    {

        public EntidadRegistroAlimentacion() 
        {
            IdRegistroAlimentacion=0;
            CantidadAgua = 0;
            CantidadAlimento = 0;
            IdGalpon = new EntidadGalpon();
            IdAlimento = new EntidadAlimento();
        }

        public int IdRegistroAlimentacion { get; set; }
        public int CantidadAlimento { get; set; }
        public int CantidadAgua { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public EntidadGalpon IdGalpon { get; set; }
        public EntidadAlimento IdAlimento { get; set; }
    }
}
