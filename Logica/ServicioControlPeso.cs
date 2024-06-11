using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioControlPeso
    {
        private RepositorioControlPeso repositorioControlPeso;

        public ServicioControlPeso() { 
                repositorioControlPeso = new RepositorioControlPeso();

        }

        public string GuardarControlPeso(EntidadControlPeso controlPeso)
        {
            if (repositorioControlPeso.InsertarControlPeso(controlPeso) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarControlPeso(EntidadControlPeso controlPeso)
        {
            if (repositorioControlPeso.ActualizarControlPeso(controlPeso) > 0)
            {
                return "La informacion fue  Actualizada con exito";
            }
            return "la informacion no fue  Actualizada";
        }
        public string BorrarControlPeso(int idControlPeso)
        {
            if (repositorioControlPeso.BorrarControlPeso(idControlPeso) > 0)
            {
                return "La informacion fue  borrada con exito";
            }
            return "la informacion no fue  borrada";
        }

    }
}
