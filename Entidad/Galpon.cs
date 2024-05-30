using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Galpon
    {
        //LISTO
        public Galpon() 
        {
            CodigoGalpon = string.Empty;
            AreaGalpon = string.Empty;
            EstadoGalpon = string.Empty;
        }
        public override string ToString() => $"{CodigoGalpon};{AreaGalpon};{EstadoGalpon}";

        public string IdGalpon { get; set; }
        public string CodigoGalpon { get; set; }
        public string AreaGalpon { get; set; }
        public string EstadoGalpon { get; set; }       

    }
}
