using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        //LISTO
        public Persona() 
        {
            Identificacion = string.Empty;
            TipoIdentificacion = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
        }

        public override string ToString() => $"{Identificacion};{Nombres};{Apellidos};{Telefono};{Email};";

        public string Id { get; set; }
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set;}
        public string Telefono { get; set;}
        public string Direccion { get; set; }
        public string Email { get; set;}       
    }
}
