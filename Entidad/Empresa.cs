using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empresa
    {
        public Empresa()
        {
            NIT = string.Empty;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
        }

        public Empresa(string nit, string nombre, string telefono, string direccion, string email)
        {
            NIT = nit;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public override string ToString()
        {
            return $"NIT:{NIT}; NOMBRE:{Nombre}; TELEFONO:{Telefono}; DIRECCION:{Direccion}; EMAIL:{Email}";
        }
        
        public string NIT { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}
