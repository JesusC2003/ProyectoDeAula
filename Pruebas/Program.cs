﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            empresa.NIT = "1234567";
            empresa.Nombre = "LIMPIEZA SAS";
            empresa.Telefono = "3224567890";
            empresa.Direccion = "Calle 13";
            empresa.Email = "limpieza@gmail.com";
            Console.WriteLine(empresa.ToString());
            Console.ReadKey();




        }
    }
}
