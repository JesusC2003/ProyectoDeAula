

namespace Entidad
{
    public class DetalleFactura
    {
        public DetalleFactura() 
        {
            IdDetalleFactura = 0;
            CantidadVenta = 0;
            PrecioUnitario = 0;
            IdFactura = new Factura();
        }
        public int IdDetalleFactura { get; set; }
        public int CantidadVenta { get; set; }
        public double PrecioUnitario { get; set; }
        public Factura IdFactura { get; set; }
    }
}
