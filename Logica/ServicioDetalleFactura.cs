using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioDetalleFactura
    {

        private RepositorioDetalleFactura repositorioDetalleFactura;

        public ServicioDetalleFactura()
        {
            repositorioDetalleFactura = new RepositorioDetalleFactura();
        }
        public string GuardarDetalleFactura(EntidadDetalleFactura detalleFactura)
        {
            if (repositorioDetalleFactura.InsertarDetalleFactura(detalleFactura) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }

        public string ActualizarDetalleFactura(EntidadDetalleFactura detalleFactura)
        {
            if (repositorioDetalleFactura.ActualizarDetalleFactura(detalleFactura) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string BorrarDetalleFactura(int idDetalleFactura)
        {
            if (repositorioDetalleFactura.BorrarDetalleFactura(idDetalleFactura) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }
    }
}
