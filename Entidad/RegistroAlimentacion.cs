using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroAlimentacion
    {
        //LISTO
        public RegistroAlimentacion() { }

        public override string ToString() => $"{CantidadAlimento};{CantidadAgua};{FechaAplicacion};{CodigoGalpon};{CodigoAlimento}";

        public string id { get; set; }
        public int CantidadAlimento { get; set; }
        public int CantidadAgua { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public Galpon CodigoGalpon { get; set; }
        public Alimento CodigoAlimento { get; set; }
    }
}
