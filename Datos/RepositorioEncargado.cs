using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEncargado : Archivo
    {
        public RepositorioEncargado(string RutaArchivo) : base(RutaArchivo) { }

        public override void Eliminar()
        {
            throw new NotImplementedException();
        }

        public override void Guardar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
