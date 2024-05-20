using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Empresa empresa = new Empresa();
            PolloServicio polloServicio = new PolloServicio();
            Pollo pollo = new Pollo();
            //empresa.NIT = "1234567";
            //empresa.Nombre = "LIMPIEZA SAS";
            //empresa.Telefono = "3224567890";
            //empresa.Direccion = "Calle 13";
            //empresa.Email = "limpieza@gmail.com";
            //Console.WriteLine(empresa.ToString());
            //Console.ReadKey();

            //prueba del metodo edad
            //PersonalGranja person=new PersonalGranja();
            //DateTime fechaNacimiento = new DateTime(2003, 11, 1);
            //var edad =  person.CalcularEdad(fechaNacimiento);
            //Console.WriteLine(edad);
            //Console.ReadKey();  


            //Console.WriteLine(" --------------------PRUEBA DEL METODO GUARDAR EN ARCHIVOS-------------------");
            
            //Pollo pollo = new Pollo("123456", "Viva", new DateTime(2024, 7, 5), "Criolla", 46.5, null, null, null);
            //Console.WriteLine(pollo.ToString());         
            //Console.ReadLine();
            //String mensaje = polloServicio.Guardar(pollo);
            //Console.WriteLine(mensaje);
            //Console.ReadLine();   

            Console.WriteLine(" --------------------PRUEBA DEL METODO BUSCAR EN ARCHIVOS-------------------");
            string BUSCAR = string.Empty;
            PolloRespuesta polloRespuesta = polloServicio.BuscarPorIdentificacion(BUSCAR);
            if (polloRespuesta.Encontrado == true)
                Console.WriteLine(polloRespuesta.pollo.ToString());
            else
            {
                Console.WriteLine(polloRespuesta.Mensaje);
            }
            Console.ReadLine();



        }
    }
}
