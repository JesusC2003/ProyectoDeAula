

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Entidad
{
    public class Pollo
    {
        public Pollo() 
        {
            LotePollo = string.Empty;
            RazaPollo = string.Empty;
            EstadoPollo = string.Empty;
        }        
        public string LotePollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoPollo { get; set; } 
        public DateTime FechaIngreso { get; set; }
        public Galpon IdGalpon { get; set; }
        public Inventario IdInventario { get; set; } 
        public DetalleFactura IdDetalleFactura { get; set; }        
    }
}
