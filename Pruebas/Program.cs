using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Datos;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseDatosConexion baseDatosConexion = new BaseDatosConexion();

            string mensaje = baseDatosConexion.AbrirConexion();
            Console.WriteLine(mensaje);
            Console.ReadLine();

            baseDatosConexion.CerrarConexion();
            Console.WriteLine("Conexion cerrada");
            Console.ReadLine();
      


        }
    }
}
