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
   
        private RepositorioPollo repositorioPollo;
        public ServicioPollo() 
        { 
                repositorioPollo = new RepositorioPollo();
        }
        public string GuardarPollo(List <EntidadPollo> pollos)
        {
            int numeroFilasAfectadas = repositorioPollo.InsertarPollos(pollos);
            if (numeroFilasAfectadas > 0)
            {
                return $"{numeroFilasAfectadas} Fila insertada con éxito!!!";
            }
            return "|ERROR| - No se guardó la información";
        }
        public string ActualizarPollo(EntidadPollo pollo)
        {
            try
            {
                int numRegistros = repositorioPollo.ActualizarPollo(pollo);
                if (numRegistros > 0)
                {
                    return $"La información del pollo con ID {pollo.IdPollo} fue actualizada con éxito";
                }
                return "La información del pollo no fue actualizada";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar el pollo: {ex.Message}";
            }
        }
        public string BorrarPollo(int idPollo)
        {
            try
            {
                int numRegistros = repositorioPollo.BorrarPollo(idPollo);
                if (numRegistros > 0)
                {
                    return $"Se eliminó el pollo con ID {idPollo} de la base de datos";
                }
                return "No se encontró el pollo para eliminar";
            }
            catch (Exception ex)
            {
                return $"Error al intentar eliminar el pollo: {ex.Message}";
            }
        }
        public List<EntidadPollo> ConsultarPollos()
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
        public EntidadPollo ConsultarPollo(int idpollo)
        {
           return repositorioPollo.ConsultarPollo(idpollo);
        }
    
    }
}
