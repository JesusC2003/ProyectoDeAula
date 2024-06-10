using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioEmpresa
    {
        private readonly RepositorioEmpresa repositorioEmpresa;
        public ServicioEmpresa()
        {
            repositorioEmpresa = new RepositorioEmpresa();
        }

        //METODO PARA GUARDAR EMPRESA
        public string Guardar(EntidadEmpresa empresa)
        {
            return $"{ repositorioEmpresa.InsertEmpresa(empresa)} guardada con exito";
        }

        //METODO PARA ACTUALIZAR EMPRESA
        public string Actualizar(EntidadEmpresa empresa)
        {
            return $"{repositorioEmpresa.UpdateEmpresa(empresa)} actulizada con exito";
        }

        //METODO PARA CARGAR INFORMACION EMPRESA
        public EntidadEmpresa GetEmpresa() 
        {
            EntidadEmpresa empresa = new EntidadEmpresa();
            if (RespuestaExisteEmpresa())
            {
                empresa = repositorioEmpresa.SelectEmpresa();
                return empresa;
            }
            return empresa;
        } 
        
        //METODO PARA ELIMINAR EMPRESA
        public string EliminarEmpresa()
        {
            return repositorioEmpresa.DeleteEmpresa();
        }
        //METODO PARA SABER SI EXISTE EMPRESA
        public bool RespuestaExisteEmpresa()
        {
            return repositorioEmpresa.ExisteEmpresa();
        }
    }
}
