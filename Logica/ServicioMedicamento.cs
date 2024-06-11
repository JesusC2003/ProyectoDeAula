using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioMedicamento
    {
        private RepositorioMedicamento repositorioMedicamento;

        public ServicioMedicamento() { 

            repositorioMedicamento = new RepositorioMedicamento();

        }
        public string GuardarMedicamento(EntidadMedicamento medicamento)
        {
            if (repositorioMedicamento.InsertarMedicamento(medicamento) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarMedicamento(EntidadMedicamento medicamento)
        {
            if (repositorioMedicamento.ActualizarMedicamento(medicamento) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string BorrarMedicamento(int idMedicamento)
        {
            if (repositorioMedicamento.EliminarMedicamento(idMedicamento) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }
    }
}
