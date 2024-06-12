using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioLote
    {
        private RepositorioLote repositorioLote;

        public ServicioLote()
        {
            repositorioLote = new RepositorioLote();
        }
        public string GuardarLote(EntidadLote lote)
        {
            if (repositorioLote.InsertarLote(lote) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarLote(EntidadLote lote)
        {
            if (repositorioLote.ActualizarLote(lote) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string EliminarLote(int idLote)
        {
            if (repositorioLote.BorrarLote(idLote) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada ";
        }
        public EntidadLote Consultar(int idLote)
        {
            return repositorioLote.ConsultarLote(idLote);
        }
    }
}
