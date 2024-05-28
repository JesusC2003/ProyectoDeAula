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
        private string RutaArchivo = "Archivos\\PERSONAL.txt";
        
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
        public string Eliminar(string identificacion)
        {
            try
            {
                if (repositorioPersonal.BuscarPersona(identificacion) != null)
                {
                    repositorioPersonal.Eliminar(identificacion);
                    RefrescarLista();
                    return ($"|MENSAJE DE CONFIRMACIÓN| - La persona con identificación: {identificacion} fue eliminada con exito");
                }
                else
                {
                    return ($"|MENSAJE DE CONFIRMACIÓN| - No se encontró la identificación: {identificacion} resgistrada en el sistema");
                }
            }
            catch (Exception e)
            {
                return $"|ERROR DE APLICACIÓN|: {e.Message}";
            }
        }
        public PersonalGranjaRespuesta BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                PersonalGranja persona = repositorioPersonal.BuscarPersona(identificacion);
                if (persona != null)
                {
                    return new PersonalGranjaRespuesta(persona);
                }
                else
                {
                    return new PersonalGranjaRespuesta("|MENSAJE DE CONFIRMACIÓN| - La persona a la que busca, no se encuentra registrada");
                }
            }
            catch (Exception e)
            {
                return new PersonalGranjaRespuesta("|ERROR DE APLICACIÓN|:" + e.Message);
            }
        }
        public ConsultaPersonalGranjaRespuesta ConsultarTodos()
        {
            try
            {
                List<PersonalGranja> personas = repositorioPersonal.CargarLista();
                if (personas != null)
                {
                    return new ConsultaPersonalGranjaRespuesta(personas);
                }
                else
                {
                    return new ConsultaPersonalGranjaRespuesta("|MENSAJE DE CONFIRMACIÓN| - Aun no hay personal registrado en el sistema");
                }
            }
            catch (Exception e)
            {
                return new ConsultaPersonalGranjaRespuesta("|ERROR DE APLICACIÓN|: " + e.Message);
            }
        }
        public ConsultaPersonalGranjaRespuesta ConsultaPorRol(string rol)
        {
            try
            {
                List<PersonalGranja> personas = repositorioPersonal.FiltrarPorRol(rol);
                if (personas != null)
                {
                    return new ConsultaPersonalGranjaRespuesta(personas);
                }
                else
                {
                    return new ConsultaPersonalGranjaRespuesta($"|MENSAJE DE CONFIRMACIÓN| - No se encontró personal para el siguiente rol: {rol}");
                }
            }
            catch (Exception e)
            {
                return new ConsultaPersonalGranjaRespuesta("|ERROR DE APLICACIÓN|: " + e.Message);
            }
        }
        public ConsultaPersonalGranjaRespuesta ConsultaPorFechaNacimiento(DateTime fechaNacimiento)
        {
            List<PersonalGranja> personas = repositorioPersonal.FiltrarPorFechaNacimiento(fechaNacimiento);
            try
            {
                if (personas != null)
                {
                    return new ConsultaPersonalGranjaRespuesta(personas);
                }
                else
                {
                    return new ConsultaPersonalGranjaRespuesta($"|MENSAJE DE CONFIRMACIÓN| - No se encontró personal para la fecha ingresada");
                }
            }
            catch (Exception e)
            {
                return new ConsultaPersonalGranjaRespuesta("|ERROR DE APLICACIÓN|: " + e.Message);
            }
        }
    }
    public class PersonalGranjaRespuesta
    {
        public PersonalGranja Persona { get; set; }
        public string Mensaje { get; set; }
        public bool Encontrado { get; set; }

        public PersonalGranjaRespuesta(PersonalGranja persona)
        {
            Persona = new PersonalGranja();
            Persona = persona;
            Encontrado = true;
        }
        public PersonalGranjaRespuesta(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
    }
    public class ConsultaPersonalGranjaRespuesta
    {
        public List<PersonalGranja> Personas { get; set; }
        public string Mensajes { get; set; }
        public bool Encontrado { get; set; }

        public ConsultaPersonalGranjaRespuesta(List<PersonalGranja> personas)
        {
            Personas = new List<PersonalGranja>();
            Personas = personas;
            Encontrado = true;
        }
        public ConsultaPersonalGranjaRespuesta(string mensaje)
        {
            Mensajes = mensaje;
            Encontrado = false;
        }
    }
}
