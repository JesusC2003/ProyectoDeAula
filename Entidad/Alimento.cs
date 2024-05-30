using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    //LISTO
    public class Alimento
    {
        public Alimento() { }
        public override string ToString() => $"{CodigoAlimento};{Marca};{TipoAlimento}";
        public string Id { get; set; }
        public string CodigoAlimento { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string TipoAlimento { get; set; } = string.Empty;
    }
}
