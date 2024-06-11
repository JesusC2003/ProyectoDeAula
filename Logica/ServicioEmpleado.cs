using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioEmpleado
    {
        private RepositorioEmpleado repositorioEmpleado;
        public ServicioEmpleado()
        {

            repositorioEmpleado = new RepositorioEmpleado();

        }  

        public string GuardarEmpleado(EntidadEmpleado empleado)
        {
            if (repositorioEmpleado.InsertarEmpleado(empleado) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }
        public string ActualizarEmpleado(EntidadEmpleado empleado)
        {
            if (repositorioEmpleado.ActualizarEmpleado(empleado) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string BorrarEmpleado(int idEmpleado)
        {
            if (repositorioEmpleado.BorrarEmpleado(idEmpleado) > 0)
            {
                return "La informacion fue borrado con exito";
            }
            return "la informacion no fue borrado";
        }
    }
     
}
