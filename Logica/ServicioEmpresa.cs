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
        private readonly RepositorioEmpresa bDEmpresa;
        public ServicioEmpresa()
        {
            bDEmpresa = new RepositorioEmpresa();
        }

        //METODO PARA GUARDAR EMPRESA
        public string Guardar(Empresa empresa)
        {
            return bDEmpresa.InsertEmpresa(empresa);
        }

        //METODO PARA CARGAR INFORMACION EMPRESA
        public Empresa GetEmpresa() 
        {
            Empresa empresa = new Empresa();
            empresa = bDEmpresa.SelectEmpresa();
            return empresa;
        }


    }
}
