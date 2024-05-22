using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Empresa empresa = new Empresa();
            //PolloServicio polloServicio = new PolloServicio();
            //Pollo pollo = new Pollo();
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

            //Console.WriteLine(" --------------------PRUEBA DEL METODO BUSCAR EN ARCHIVOS-------------------");
            //string BUSCAR = string.Empty;
            //PolloRespuesta polloRespuesta = polloServicio.BuscarPorIdentificacion(BUSCAR);
            //if (polloRespuesta.Encontrado == true)
            //    Console.WriteLine(polloRespuesta.pollo.ToString());
            //else
            //{
            //    Console.WriteLine(polloRespuesta.Mensaje);
            //}
            //Console.ReadLine();

            
            //----------------------------------------------------------------------------------------------------------------------------------------
            //Empresa empresa = new Empresa();
            //List<PersonalGranja> ListaPersonas = new List<PersonalGranja>();
            //PersonalGranja persona = new PersonalGranja(
            //    "12345",
            //    "Juan",
            //    "Perez",
            //    "Gonzales",
            //    "3214567809",
            //    "Oficios Varios",
            //    "Juan@gmail.com",
            //    new DateTime(2000, 05, 22));
            //PersonalGranja persona2 = new PersonalGranja(
            //    "67890",
            //    "Camila",
            //    "Gutierres",
            //    "Mendoza",
            //    "3004896213",
            //    "Secretaria",
            //    "Cami@gmail.com",
            //    new DateTime(1995, 02, 12));
            //PersonalGranja persona3 = new PersonalGranja(
            //    "54321",
            //    "María",
            //    "Gnecco",
            //    "Bustamante",
            //    "3108976543",
            //    "Gerente",
            //    "Maria@gmail.com",
            //    new DateTime(2003, 01, 07));

            //ListaPersonas.Add(persona);
            //ListaPersonas.Add(persona2);
            //ListaPersonas.Add(persona3);

            //empresa.ListaPersonal = ListaPersonas;
            //int TotalDatos = empresa.ListaPersonal.Count;
            //int Bandera = 1;
            //Console.WriteLine("--------- DATOS DE LA EMPRESA -------------");
            //Console.WriteLine();
            //separarInfoEmpresa(empresa.ToString());
            //Console.WriteLine();            
            //Console.WriteLine("************ LISTA DE EMPLEADOS ************");
            //foreach (var item in empresa.ListaPersonal)
            //{                
            //    separarInfoPersonal(item.ToString());
            //    if (Bandera < TotalDatos)
            //    {
            //        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            //    }
            //    Bandera++;
            //}
            //Console.WriteLine("-------------------------------------------");
            //Console.ReadKey();
            //-----------------------------------------------------------------------------------------------------------------------------------------



            Empresa empresa = new Empresa();
            EmpresaServicio empresaServicio = new EmpresaServicio();
            Console.WriteLine(empresaServicio.Guardar(empresa.ToString()));
            Console.ReadKey();




        }
        private static void separarInfoPersonal(string dato)
        {
            var linea = dato.Split(';');
            Console.WriteLine();
            Console.WriteLine($"id: {linea[0]}");
            Console.WriteLine($"Nombre: {linea[1]}");
            Console.WriteLine($"Apellidos: {linea[2]} {linea[3]}");
            Console.WriteLine($"Telefono: {linea[4]}");
            Console.WriteLine($"Rol: {linea[5]}");
            Console.WriteLine($"Email: {linea[6]}");
            Console.WriteLine($"Edad {linea[7]}");          
        }
        private static void separarInfoEmpresa(string dato)
        {
            var linea = dato.Split(';');
            Console.WriteLine($"NIT: {linea[0]}");
            Console.WriteLine($"Nombre: {linea[1]}");
            Console.WriteLine($"Telefono: {linea[2]}");
            Console.WriteLine($"Direrccion: {linea[3]}");
            Console.WriteLine($"Email: {linea[4]}");
        }
    }
}
