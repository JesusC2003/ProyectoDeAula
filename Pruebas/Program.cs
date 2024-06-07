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
            // string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) 
            //                             (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=God;Password=God;";

            //try
            //{
            //    using (OracleConnection connection = new OracleConnection(connectionString))
            //    {
            //        connection.Open(); // Intenta abrir la conexión
            //        Console.WriteLine("Conexión exitosa.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error al conectar: {ex.Message}");
            //}
            //Console.ReadKey();

            BaseDatosConexion baseDatosConexion = new BaseDatosConexion();

            string mensaje = baseDatosConexion.AbrirConexion();
            Console.WriteLine(mensaje);
            Console.ReadLine();

            mensaje=baseDatosConexion.CerrarConexion();
            Console.WriteLine(mensaje);
            Console.ReadLine();
      


        }
    }
}
