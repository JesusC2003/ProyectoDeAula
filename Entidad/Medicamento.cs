using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Medicamento
    {
        public Medicamento(string codigoMedicamento, string nombreMedicamento, Inventario nombreinventario)
        {
            CodigoMedicamento = codigoMedicamento;
            NombreMedicamento = nombreMedicamento;
            Nombreinventario = nombreinventario;
        }
        public override string ToString()=> $"{CodigoMedicamento};{NombreMedicamento};{Nombreinventario};{PolloMedicado}";
        public string CodigoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }         
        public Inventario Nombreinventario { get; set; }
        public List<Aplicado> PolloMedicado { get; set; }
    }
}
