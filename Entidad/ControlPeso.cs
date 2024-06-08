using System;


namespace Entidad
{
    public class ControlPeso
    {
        public ControlPeso() 
        {
            IdControlPeso = 0;
            Peso = 0;
            IdPollo = new Pollo();
        }        

        public int IdControlPeso { get; set; }
        public int Peso { get; set; }
        public DateTime FechaControl { get; set; }
        public Pollo IdPollo { get; set; }
    }
}
