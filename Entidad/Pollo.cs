using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pollo
    {
        //LISTO
        public Pollo() 
        {
            CodigoPollo = string.Empty;
            RazaPollo = string.Empty;
            EstadoSalud = string.Empty;
            Fechaingreso = DateTime.Today;
        }        
        public override string ToString() => $"{CodigoPollo};{RazaPollo};{EstadoSalud};{Fechaingreso};{FechaSalida};";
        public string Id { get; set; } 
        public string CodigoPollo { get; set; }
        public string RazaPollo { get; set; }
        public string EstadoSalud { get; set; } 
        public DateTime Fechaingreso { get; set; } 
        public DateTime FechaSalida { get; set; }        
    }
}
