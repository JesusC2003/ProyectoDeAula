using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPollo : Archivo
    {
        public RepositorioPollo(string RutaArchivo) : base(RutaArchivo) { }
    
        public void Guardar(Pollo pollo)
        {
            throw new NotImplementedException();
        }
        public void Modificar()
        {
            throw new NotImplementedException();
        }
        public void Eliminar(string IDPollo)
        {  
            throw new NotImplementedException();
        }
 

        

        
    }
}
