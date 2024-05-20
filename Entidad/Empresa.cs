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
        public Empresa(string nIT, string nombre, string telefono, string direccion, string email, List<PersonalGranja> personalId)
        {
            NIT = nIT;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            PersonalId = personalId;
        }

        public override string ToString() => $"{NIT};{Nombre};{Telefono};{Direccion};{Email};{PersonalId}; ";

        public string NIT { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<PersonalGranja> PersonalId { get; set; }
    }
}
