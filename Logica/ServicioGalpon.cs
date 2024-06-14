using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   
    public class ServicioGalpon
    {

        private RepositorioGalpon repositorioGalpon;

        public ServicioGalpon()
        {
            repositorioGalpon = new RepositorioGalpon();
        }

        public string GuardarGalpon(EntidadGalpon galpon)
        {
            if (repositorioGalpon.InsertarGalpon(galpon) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarGalpon(EntidadGalpon galpon)
        {
            if (repositorioGalpon.ActualizarGalpon(galpon) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string BorrarGalpon(int idGalpon)
        {
            if (repositorioGalpon.BorrarGalpon(idGalpon) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }
        public List<EntidadGalpon> listaGalpon() 
        {
            return repositorioGalpon.ConsultarTodosLosGalpones();
        }
        public EntidadGalpon ConsultaGalpon(string codigo)
        {
            return repositorioGalpon.ConsultarGalpon(codigo);
        }
        public EntidadGalpon ConsultaGalpon(int codigo)
        {
            return repositorioGalpon.ConsultarGalpon(codigo);
        }
    }
}
