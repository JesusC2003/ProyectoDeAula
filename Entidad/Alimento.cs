using System;
using System.Security.Cryptography.X509Certificates;


namespace Entidad
{
    public class Alimento
    {
        public Alimento() 
        {
            IdAlimento = 0;
            MarcaAlimento = string.Empty;
            TipoAlimento = string.Empty;
            IdInventario = new Inventario();
        }
        
        public int IdAlimento { get; set; }
        public string MarcaAlimento { get; set; } 
        public string TipoAlimento {  get; set; } 
        public DateTime FechaCadudcidad { get; set; } 
        public Inventario IdInventario { get; set; }
    }
}
