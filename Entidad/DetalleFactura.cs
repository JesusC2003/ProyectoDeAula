

namespace Entidad
{
    public class DetalleFactura
    {
        public DetalleFactura() 
        {
            Id = 0;
            Codigo=string.Empty;
            Cantidad = 0;
            PrecioUnitario = 0;
        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public Factura IdFactura { get; set; }
    }
}
