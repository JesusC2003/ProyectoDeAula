using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPollo
    {
       //public List<EntidadPollo> ConsultarRaza(String raza)
       // {

       //     return repositorioPollo.FiltrarPollosPorRaza(raza);
       // }
        private RepositorioPollo repositorioPollo;
        public ServicioPollo() { 

               repositorioPollo = new RepositorioPollo();
        }
        public List<EntidadPollo> Refrescarlista() 
        {
            try
            {
                List<EntidadPollo> ListaPollo = repositorioPollo.ConsultarTodo();
                return ListaPollo;
            }
            catch (Exception ex) { throw new Exception($"{ex}"); }
          
        }
        public string GuardarPollo(EntidadPollo pollo)
        {
            if (pollo == new EntidadPollo())
            {
                return "registre la informacion";
            }
            else { 
                if (repositorioPollo.InsertarPollo(pollo) > 0)
                {
                    return "La informacion fue guardada con exito";
                }
                return "la informacion no fue guardada";
            }
        }
        public string ActualizarPollo(EntidadPollo pollo)
        {
            if (repositorioPollo.ActualizarPollo(pollo) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }
        public string BorrarPollo(int idPollo)
        {
            if (repositorioPollo.EliminarPollo(idPollo) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }



    }
}
