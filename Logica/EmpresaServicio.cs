using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpresaServicio
    {
        private readonly RepositorioEmpresa repositorio;
        private string RutaArchivo = "C:\\Users\\ASUS\\Documents\\UNIVERSIDAD POPULAR DEL CESAR\\PROGRAMACIÓN III\\ProyectoDeAula\\Datos\\ArchivosTxt\\EMPRESA.txt";
        
        public EmpresaServicio()
        {
            repositorio = new RepositorioEmpresa(RutaArchivo);
        }
        public string Guardar(string empresa)
        {            
            repositorio.Guardar(empresa);
            return $"|MENSAJE DE CONFIRMACIÓN| - Se ha completado el registro satisfactoriamente"; 
        }
    }
}
