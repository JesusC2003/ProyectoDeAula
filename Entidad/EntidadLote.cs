using System;


namespace Entidad
{
    public class EntidadLote
    {
        public EntidadLote() 
        {
            IdLote = 0;
            NumeroLote = string.Empty;
        }   

        public int IdLote { get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
