using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Asignado
    {
        public Asignado() { }
        public Asignado(string numeroSerie, string ocupacion, Persona personalId, Galpon galponId)
        {
            NumeroSerie = numeroSerie;
            Ocupacion = ocupacion;
            PersonalId = personalId;
            GalponId = galponId;
        }

        public override string ToString()=> $"{NumeroSerie};{Ocupacion};{PersonalId};{GalponId};";

        public string NumeroSerie { get; set; }
        public string Ocupacion { get; set; }
        public Persona PersonalId { get; set; }
        public Galpon GalponId { get; set; }
    }
}
    