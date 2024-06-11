using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioCliente
    {
        private RepositorioCliente repositorioCliente;
        public ServicioCliente() {
            repositorioCliente = new RepositorioCliente();
            
        }

        public string GuardarCliente(EntidadCliente cliente)
        {
            if (repositorioCliente.InsertarCliente(cliente) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarCliente(EntidadCliente cliente)
        {
            if (repositorioCliente.ActualizarCliente(cliente) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }
        public string EliminarCliente(int idCliente)
        {
            if (repositorioCliente.BorrarCliente(idCliente) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }

    }
}
