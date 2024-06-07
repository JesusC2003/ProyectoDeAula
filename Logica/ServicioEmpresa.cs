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
        private readonly BDEmpresa bDEmpresa;
        public ServicioEmpresa()
        {
            bDEmpresa = new BDEmpresa();
        }

        public string Guardar(Empresa empresa)
        {
            return bDEmpresa.InsertarEmpresa(empresa);
        }




    }
}
