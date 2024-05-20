using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Archivo
    {
        protected string RutaDeArchivo;

        public Archivo(string RutaArchivo)
        {
            this.RutaDeArchivo = RutaArchivo;
        }              
    }
}
