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
        public ServicioPollo() 
        { 
                repositorioPollo = new RepositorioPollo();
        }

        public string GuardarPollo(List<EntidadPollo> pollos)
        {
            try
            {
                return repositorioPollo.InsertarPollos(pollos);
            }
            catch (Exception ex) {  return $"ERROR EN SERVICIO POLLO: {ex}"; }
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

        public List<EntidadPollo> listapollo()
        {
            return repositorioPollo.ConsultarTodo();
        }
        public bool existePollo(string ID)
        {
            EntidadPollo pollo = new EntidadPollo();
            if (repositorioPollo.ConsultarPollo(ID) == pollo )
            {
                return true;
            }
            return false;
        }
        

    }
}
