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
        public PersonalGranja() 
        { 
            
        }

        public PersonalGranja(string identificaion, string nombres, string apellido1, string apellido2, string telefono, string rol, string horasDeTrabajo, DateTime fechaNacimiento)
        {
            Identificaion = identificaion;
            Nombres = nombres;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Telefono = telefono;
            Rol = rol;
            HorasDeTrabajo = horasDeTrabajo;
            FechaNacimiento = fechaNacimiento;
        }

        public string Identificaion { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set;}
        public string Apellido2 { get; set;}
        public string Telefono { get; set;}
        public string Rol { get; set;}
        public string HorasDeTrabajo { get; set;}
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
