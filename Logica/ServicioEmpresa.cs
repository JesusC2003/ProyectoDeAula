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

        //METODO PARA GUARDAR O ACTUALIZAR EMPRESA
        public string Guardar(Empresa empresa)
        {
            return repositorioEmpresa.InsertEmpresa(empresa);
        }
        public string Actualizar(Empresa empresa)
        {
            return repositorioEmpresa.UpdateEmpresa(empresa);
        }

        //METODO PARA CARGAR INFORMACION EMPRESA
        public Empresa GetEmpresa() 
        {
            Empresa empresa = new Empresa();
            empresa = repositorioEmpresa.SelectEmpresa();
            return empresa;
        } 
        
        //METODO PARA SABER SI EXISTE EMPRESA
        public bool RespuestaExisteEmpresa()
        {
            return repositorioEmpresa.ExisteEmpresa();
        }
    }
}
