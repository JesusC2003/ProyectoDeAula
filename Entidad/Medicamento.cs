using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Medicamento
    {
        //LISTO
        public Medicamento() {
            CodigoMedicamento = string.Empty;
            NombreMedicamento = string.Empty;
            Descripcion = string.Empty;
        }

        public override string ToString()=> $"{CodigoMedicamento};{NombreMedicamento};{Descripcion}";
        public string Id { get; set; }
        public string CodigoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public string Descripcion { get; set; }
    }
}
