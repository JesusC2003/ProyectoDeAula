using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Encargado
    {
        public Encargado() { }
        public Encargado(string numeroSerie, string ocupacion, PersonalGranja personalId, Galpon galponId)
        {
            NumeroSerie = numeroSerie;
            Ocupacion = ocupacion;
            PersonalId = personalId;
            GalponId = galponId;
        }

        public override string ToString()=> $"{NumeroSerie};{Ocupacion};{PersonalId};{GalponId};";

        public string NumeroSerie { get; set; }
        public string Ocupacion { get; set; }
        public PersonalGranja PersonalId { get; set; }
        public Galpon GalponId { get; set; }
    }
}
    