using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroSanitario
    {
        //LISTO
        public RegistroSanitario()
        {
            CodigoRegistro = string.Empty;
            TipoTratamiento = string.Empty;
            Observaciones = string.Empty;
        }
        public override string ToString() => $"{CodigoRegistro};{TipoTratamiento};{FechaAplicacion};{Observaciones};{CodigoPollo};{CodigoMedicamento}";
        public string id { get; set; }
        public string CodigoRegistro { get; set; }
        public string TipoTratamiento { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public string Observaciones { get; set; }
        public Pollo CodigoPollo { get; set; }
        public Medicamento CodigoMedicamento { get; set; }
    }
}
