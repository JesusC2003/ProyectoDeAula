


namespace Entidad
{
    public class Pollo
    {
        public Pollo() 
        {
            IdPollo = 0;
            CodigoPollo = string.Empty;
            RazaPollo = string.Empty;
            EstadoPollo = string.Empty;
        }        
        public int IdPollo { get; set; } 
        public string CodigoPollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoPollo { get; set; } 
        public Galpon IdGalpon { get; set; }
        public Inventario IdInventario { get; set; } 
        public DetalleFactura IdDetalleFactura { get; set; }        
    }
}
