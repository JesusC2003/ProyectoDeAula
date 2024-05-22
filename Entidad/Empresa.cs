using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empresa
    {
        public Empresa() { }

        public override string ToString()
        {
            return $"{NIT};{Nombre};{Telefono};{Direccion};{Email};";
        }

        public const string NIT  = "12345678-9";
        public const string Nombre = "Pollo Feliz";
        public const string Telefono = "3214567809";
        public const string Direccion = "Kilometro 4 vía La Paz";
        public const string Email = "pollofeliz@coorporation.co";
        public List<PersonalGranja> ListaPersonal{ get; set; }
    }
}
