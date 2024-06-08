using System;

namespace Entidad
{
    public class Factura
    {
        public Factura() {
            IdFactura = 0;
            MontoTotal = 0;
            IdCliente = new Cliente();
            NitEmpresa = new Empresa();
        }
        public int IdFactura {  get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoTotal { get; set; }
        public Cliente IdCliente { get; set; }
        public Empresa NitEmpresa { get; set; }
    }
}
