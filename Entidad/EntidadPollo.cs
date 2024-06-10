

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Entidad
{
    public class EntidadPollo
    {
        public EntidadPollo() 
        {
            IdPollo = 0;
            CodigoPollo = string.Empty;
            RazaPollo = string.Empty;
            EstadoPollo = string.Empty;
            IdGalpon = new EntidadGalpon(); 
            LotePollo = new EntidadLote();
            IdDetalleFactura = new EntidadDetalleFactura();
        }
        public int IdPollo { get; set; }
        public string CodigoPollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoPollo { get; set; } 
        public EntidadGalpon IdGalpon { get; set; }
        public EntidadLote LotePollo { get; set; } 
        public EntidadDetalleFactura IdDetalleFactura { get; set; }        
    }
}
