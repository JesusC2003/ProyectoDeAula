

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
            EdadPollo = string.Empty;
            NumeroLote = string.Empty;
            IdGalpon = new EntidadGalpon(); 
            IdDetalleFactura = new EntidadDetalleFactura();
        }
        public int IdPollo { get; set; }
        public string CodigoPollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoPollo { get; set; }
        public string EdadPollo {  get; set; }
        public string NumeroLote { get; set; }
        public DateTime FechaIngreso { get; set; }
        public EntidadGalpon IdGalpon { get; set; }
        public EntidadDetalleFactura IdDetalleFactura { get; set; }        
    }
}
