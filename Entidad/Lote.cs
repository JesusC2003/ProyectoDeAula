using System;


namespace Entidad
{
    public class Lote
    {
        public Lote() 
        {
            IdLote = 0;
            NumeroLote = 0;
        }   

        public int IdLote { get; set; }
        public int NumeroLote { get; set; }
        public DateTime FechaIngreso { get; set; }

    }
}
