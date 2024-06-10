using System;

namespace Entidad
{
    public class Factura
    {
        public Factura() {
            IdFactura = 0;
            CodigoFactura= string.Empty;
            MontoTotal = 0;
            IdCliente = new Cliente();
            NitEmpresa = new Empresa();
        }
        public int IdFactura {  get; set; }
        public string CodigoFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoTotal { get; set; }
        public Cliente IdCliente { get; set; }
        public Empresa NitEmpresa { get; set; }
    }
}
