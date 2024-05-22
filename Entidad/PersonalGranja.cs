using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PersonalGranja
    {
        public PersonalGranja() { }
        public PersonalGranja(string idPersonal, string nombres, string apellido1, string apellido2, string telefono, string rol, string emailpersonal, DateTime fechaNacimiento)
        {
            IdPersonal = idPersonal;
            Nombres = nombres;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Telefono = telefono;
            Rol = rol;
            EmailPersonal = emailpersonal;
            FechaNacimiento = fechaNacimiento;
        }
        private int edad;
        public override string ToString()
        {
            return $"{IdPersonal};{Nombres};{Apellido1};{Apellido2};{Telefono};{Rol};{EmailPersonal};{Convert.ToString(edad =CalcularEdad(FechaNacimiento))};";
        }

        public string IdPersonal { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set;}
        public string Apellido2 { get; set;}
        public string Telefono { get; set;}
        public string Rol { get; set;}
        public string EmailPersonal { get; set;}
        public DateTime FechaNacimiento { get; set; }        
        
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (DateTime.Today.Month < fechaNacimiento.Month || (DateTime.Today.Month == fechaNacimiento.Month && DateTime.Today.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }
    }
}
