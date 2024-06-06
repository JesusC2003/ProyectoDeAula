using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class BDEmpresa : Archivo
    {
        public BDEmpresa(string RutaArchivo) : base(RutaArchivo) { }
        public void Guardar(string empresa) 
        {
            FileStream Archivo = new FileStream(RutaDeArchivo, FileMode.Create);
            StreamWriter Escribir = new StreamWriter(Archivo);
            Escribir.WriteLine(empresa.ToString());
            Escribir.Close();
            Archivo.Close();
        }
    }
}
