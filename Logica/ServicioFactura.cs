using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioFactura
    {

        private RepositorioFactura RepositorioFactura;

        public ServicioFactura()
        {
            RepositorioFactura = new RepositorioFactura();
        }

        //public string GuardarFactura(EntidadFactura factura)
        //{
        //    if (RepositorioFactura.InsertarFactura(factura) > 0)
        //    {
        //        return "La informacion fue guardada con exito";
        //    }
        //    return "la informacion no fue guardada";
        //}

        //public string ActualizarFactura(EntidadFactura factura)
        //{
        //    if (RepositorioFactura.ActualizarFactura(factura) > 0)
        //    {
        //        return "La informacion fue actualizada con exito";
        //    }
        //    return "la informacion no fue actualizada";
        //}

        //public string BorrarFactura(int idFactura)
        //{
        //    if (RepositorioFactura.BorrarFactura(idFactura) > 0)
        //    {
        //        return "La informacion fue borrada con exito";
        //    }
        //    return "la informacion no fue borrada";
        //}

    }
}
