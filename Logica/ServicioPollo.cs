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
        private RepositorioPollo RepositorioPollo;
        public ServicioPollo() { 

               RepositorioPollo = new RepositorioPollo();
        }

        public string GuardarPollo(List<EntidadPollo> pollos)
        {
            try
            {
                return RepositorioPollo.InsertarPollos(pollos);
            }
            catch (Exception ex) {  return $"ERROR EN SERVICIO POLLO: {ex}"; }
        }
        public string ActualizarPollo(EntidadPollo pollo)
        {
            if (RepositorioPollo.ActualizarPollo(pollo) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }
        public string BorrarPollo(int idPollo)
        {
            if (RepositorioPollo.EliminarPollo(idPollo) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }
        public List<EntidadPollo> listapollo()
        {
            return RepositorioPollo.ConsultarTodosLosPollos();
        }
        public bool existePollo(string ID)
        {
            EntidadPollo pollo = new EntidadPollo();
            if (RepositorioPollo.ConsultarPollo(ID) == pollo )
            {
                return true;
            }
            return false;
        }
        
    }
}
