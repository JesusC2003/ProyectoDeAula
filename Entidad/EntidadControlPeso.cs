using System;


namespace Entidad
{
    public class EntidadControlPeso
    {
        public EntidadControlPeso() 
        {
            IdControlPeso = 0;
            Peso = 0;
            IdPollo = new EntidadPollo();
        }        

        public int IdControlPeso { get; set; }
        public int Peso { get; set; }
        public DateTime FechaControl { get; set; }
        public EntidadPollo IdPollo { get; set; }
    }
}
