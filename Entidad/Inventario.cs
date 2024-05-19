using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Inventario
    {
        public Inventario(string nombrelnventario, DateTime fechaUltimaActualizacion, DateTime fechaRecepcion, string proveedor, PersonalGranja idPersonalGranja)
        {
            Nombrelnventario = nombrelnventario;
            FechaUltimaActualizacion = fechaUltimaActualizacion;
            FechaRecepcion = fechaRecepcion;
            Proveedor = proveedor;
            IdPersonalGranja = idPersonalGranja;
        }
        public override string ToString() => $"{Nombrelnventario};{FechaUltimaActualizacion};{FechaRecepcion};{Proveedor};{IdPersonalGranja}; {Polloid};{MedicamentoCodigo};{GalponId} ";

        public string Nombrelnventario { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public  string Proveedor { get; set; }
        public List<Pollo> Polloid { get; set; }
        public List<Medicamento> MedicamentoCodigo { get; set; }
        public List<Galpon> GalponId { get; set; }
        public PersonalGranja IdPersonalGranja { get; set; }        
    }
}
