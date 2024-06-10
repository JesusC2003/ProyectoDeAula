using System;

namespace Entidad
{
    public class EntidadFactura
    {
        public EntidadFactura() {
            IdFactura = 0;
            CodigoFactura= string.Empty;
            MontoTotal = 0;
            IdCliente = new EntidadCliente();
            NitEmpresa = new EntidadEmpresa();
        }
        public int IdFactura {  get; set; }
        public string CodigoFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoTotal { get; set; }
        public EntidadCliente IdCliente { get; set; }
        public EntidadEmpresa NitEmpresa { get; set; }
    }
}
