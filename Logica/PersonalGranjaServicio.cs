using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PersonalGranjaServicio
    {
        private readonly RepositorioPersonalGranja repositorioPersonal;
        private string RutaArchivo = "C:\\Users\\ASUS\\Documents\\UNIVERSIDAD POPULAR DEL CESAR\\PROGRAMACIÓN III\\ProyectoDeAula\\Datos\\ArchivosTxt\\PERSONAL.txt";
        
        public PersonalGranjaServicio()
        {
            repositorioPersonal = new RepositorioPersonalGranja(RutaArchivo);
        }
        public List<PersonalGranja> RefrescarLista()
        {
            return repositorioPersonal.CargarLista();
        }

        public string Guardar (PersonalGranja persona)
        {
            try
            {
                if (repositorioPersonal.BuscarPersona(persona.IdPersonal)==null)
                {
                    repositorioPersonal.Guardar(persona);
                    RefrescarLista();
                    return $"|MENSAJE DE CONFIRMACIÓN| - Se ha completado el registro satisfactoriamente";
                }
                else
                {
                    return $"|PROCESO NO COMPLETADO| - El sistema indica que la identificación ya ha sido registrada.";
                }
            }catch (Exception e)
            {
                return $"|ERROR DE APLICACION|: {e.Message}";
            }
        }
        
        





    }
}
