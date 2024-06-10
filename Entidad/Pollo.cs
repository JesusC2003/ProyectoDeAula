

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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
            IdGalpon = new Galpon(); 
            LotePollo = new Lote();
            IdDetalleFactura = new DetalleFactura();
        }
        public int IdPollo { get; set; }
        public string CodigoPollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoPollo { get; set; } 
        public Galpon IdGalpon { get; set; }
        public Lote LotePollo { get; set; } 
        public DetalleFactura IdDetalleFactura { get; set; }        
    }
}
