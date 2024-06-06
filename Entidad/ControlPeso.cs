using System;


namespace Entidad
{
    public class ControlPeso
    {
        public ControlPeso() 
        {
            Codigo = string.Empty;
            Peso = 0;
        }        

        public string Codigo { get; set; }
        public int Peso { get; set; }
        public DateTime FechaControl { get; set; }
        public Pollo IdPollo { get; set; }
    }
}
