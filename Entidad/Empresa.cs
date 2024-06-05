using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empresa
    {
        //LISTO
        public Empresa() 
        {
            NIT = string.Empty;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
        }
        public override string ToString() => $"{NIT};{Nombre};{Telefono};{Direccion};{Email};";
        public string NIT {  get; set; }
        public string Nombre {  get; set; }
        public string Telefono {  get; set; }
        public string Direccion {  get; set; }
        public string Email {  get; set; }
    }
}
