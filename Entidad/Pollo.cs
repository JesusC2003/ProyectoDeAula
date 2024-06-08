

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Entidad
{
    public class Pollo
    {
        public Pollo() 
        {
            IdPollo = 0;
            LotePollo = string.Empty;
            RazaPollo = string.Empty;
            EstadoPollo = string.Empty;
            IdGalpon = new Galpon(); 
            IdInventario = new Inventario();
            IdDetalleFactura = new DetalleFactura();
        }
        public int IdPollo { get; set; }
        public string LotePollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoPollo { get; set; } 
        public DateTime FechaIngreso { get; set; }
        public Galpon IdGalpon { get; set; }
        public Inventario IdInventario { get; set; } 
        public DetalleFactura IdDetalleFactura { get; set; }        
    }
}
