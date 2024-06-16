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
            int numeroFilasAfectadas = repositorioGalpon.InsertarGalpon(galpon);
            if ( numeroFilasAfectadas > 0)
            {
                return $"{numeroFilasAfectadas} Fila insertada con exito!!!";
            }
            return "|ERROR|- No se guardo la información";
        }
        public string ActualizarGalpon(EntidadGalpon galpon)
        {
            int numeroFilasAfectadas = repositorioGalpon.ActualizarGalpon(galpon);
            if (numeroFilasAfectadas > 0)
            {
                return $"{numeroFilasAfectadas} Fila actualizada con exito!!!";
            }
            return "|ERROR| - La información no fue actualizada";
        }
        public string BorrarGalpon(int idGalpon)
        {
            int numeroFilasAfectadas = repositorioGalpon.BorrarGalpon(idGalpon);
            if (numeroFilasAfectadas > 0)
            {
                return $"{numeroFilasAfectadas} Fila borrada con exito!!!";
            }
            return "|ERROR| - La información no fue borrada";
        }
        public List<EntidadGalpon> ConsultarLosGalpones() 
        {
            return repositorioGalpon.ConsultarTodosLosGalpones();
        }
        public EntidadGalpon ConsultarGalpon(string codigo)
        {
            return repositorioGalpon.ConsultarGalpon(codigo);
        }
        public EntidadGalpon ConsultarGalpon(int codigo)
        {
            return repositorioGalpon.ConsultarGalpon(codigo);
        }
    }
}
