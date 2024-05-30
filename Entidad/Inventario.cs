using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Inventario
    {
        //LISTO
        public Inventario() 
        { 
            CodigoRegistro = string.Empty;
            CantidadDisponible = string.Empty;
            Descripcion = string.Empty;
        } 
        
        public override string ToString() => $"{CodigoRegistro};{CantidadDisponible};{Descripcion};{FechaIngresoInventario}";

        public string Id { get; set; }
        public string CodigoRegistro { get; set; }
        public string CantidadDisponible { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaIngresoInventario { get; set; }

    }
}
