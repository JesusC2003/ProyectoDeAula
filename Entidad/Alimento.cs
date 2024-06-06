using System;


namespace Entidad
{
    public class Alimento
    {
        public Alimento() 
        {
            IdAlimento = 0;
            CodigoAlimento = string.Empty;
            MarcaAlimento = string.Empty;
            TipoAlimento = string.Empty;
        }
        
        public int IdAlimento { get; set; }
        public string CodigoAlimento { get; set; } 
        public string MarcaAlimento { get; set; } 
        public string TipoAlimento {  get; set; } 
        public DateTime FechaCadudcidad { get; set; } 
        public Inventario IdInventario { get; set; }
    }
}
