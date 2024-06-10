

namespace Entidad
{
    public class EntidadDetalleFactura
    {
        public EntidadDetalleFactura() 
        {
            IdDetalleFactura = 0;
            CantidadVenta = 0;
            PrecioUnitario = 0;
            IdFactura = new EntidadFactura();
        }
        public int IdDetalleFactura { get; set; }
        public int CantidadVenta { get; set; }
        public double PrecioUnitario { get; set; }
        public EntidadFactura IdFactura { get; set; }
    }
}
