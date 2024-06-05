using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ControlPeso
    {
        public ControlPeso() { }

        public override string ToString() => $"{FechaControl};{Peso};{CodigoPollo}";

        public int Id { get; set; }
        public DateTime FechaControl { get; set; }
        public int Peso { get; set; }
        public Pollo CodigoPollo { get; set; }
    }
}
