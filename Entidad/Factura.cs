using System;

namespace Entidad
{
    public class Factura
    {
        public Factura() {
            Id = 0;
            Codigo = string.Empty;
            MontoTotal = 0;
        }
        public int Id {  get; set; }
        public string Codigo { get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoTotal { get; set; }
        public Cliente IdCliente { get; set; }
        public Empresa NitEmpresa { get; set; }
    }
}
