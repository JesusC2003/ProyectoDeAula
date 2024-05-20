using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Aplicado
    {
        public Aplicado() { }
        public Aplicado(string numeroSerie, DateTime fechaAplicacion, Pollo polloId, Medicamento medicamentoCodigo)
        {
            NumeroSerie = numeroSerie;
            FechaAplicacion = fechaAplicacion;
            PolloId = polloId;
            MedicamentoCodigo = medicamentoCodigo;
        }

        public override string ToString() => $"{NumeroSerie};{FechaAplicacion};{PolloId};{MedicamentoCodigo}";

        public string NumeroSerie { get; set; } = string.Empty;
        public DateTime FechaAplicacion { get; set; }
        public Pollo PolloId { get; set; }
        public Medicamento MedicamentoCodigo { get; set; }
    }
}
