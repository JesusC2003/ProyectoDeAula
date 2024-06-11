using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioAlimento
    {
        private RepositorioAlimento repositorioAlimento;
        public ServicioAlimento() { 
        
            repositorioAlimento = new RepositorioAlimento();
        }

        public string GuardarAlimento(EntidadAlimento alimento)
        {
            if (repositorioAlimento.InsertarAlimento(alimento) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarAlimento(EntidadAlimento alimento)
        {
            if (repositorioAlimento.ActualizarAlimento(alimento) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string BorrarAlimento(int idAlimento)
        {
            if (repositorioAlimento.EliminarAlimento(idAlimento) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }


    }
}
