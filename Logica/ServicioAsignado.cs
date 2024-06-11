using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioAsignado
    {
        private RepositorioAsignado repositorioAsignado;

        public ServicioAsignado()
        {
            repositorioAsignado = new RepositorioAsignado();

        }

        public string GuardarAsginado(EntidadAsignado asignado)
        {
            if (repositorioAsignado.InsertarAsignado(asignado) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }
        public string ActualizarAsginado(EntidadAsignado asignado)
        {
            if (repositorioAsignado.ActualizarAsignado(asignado) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue  actualizada ";
        }

        public string EliminarAsginado(int idAsignado)
        {
            if (repositorioAsignado.BorrarAsignado(idAsignado) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue  borrada ";
        }
    }
}
