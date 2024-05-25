using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPersonalGranja : Archivo
    {
        private List<PersonalGranja> personas;
        PersonalGranja personalGranja;
        public RepositorioPersonalGranja(string RutaArchivo) : base(RutaArchivo) { }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Guardar(PersonalGranja personal)
        {
            FileStream archivo = new FileStream(RutaDeArchivo, FileMode.Append);
            StreamWriter escribir = new StreamWriter(archivo);
            escribir.WriteLine(personal.ToString());
            escribir.Close();
            archivo.Close();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
        public PersonalGranja BuscarPersona (string ID) 
        {
            personas = CargarLista();
            foreach (var individuo in personas)
            {
                if (individuo.IdPersonal == ID)
                {
                    return individuo;
                }
            }
            return null;
        }

        public List<PersonalGranja> CargarLista()
        {
            personas.Clear();
            personas = new List<PersonalGranja>();
            FileStream archivo = new FileStream(RutaDeArchivo, FileMode.Append);
            StreamReader leer = new StreamReader(archivo);
            string linea = leer.ReadLine();
            while (linea != null)
            {
                personalGranja = MapeoPorLinea(linea);
                personas.Add(personalGranja);
            }
            leer.Close();
            archivo.Close ();
            return personas;
        }
        private PersonalGranja MapeoPorLinea(string linea)
        {
            personalGranja = new PersonalGranja();
            string[] MatrizPersona= linea.Split(';');
            personalGranja.IdPersonal = MatrizPersona[0];
            personalGranja.Nombres = MatrizPersona[1];
            personalGranja.Apellido1 = MatrizPersona[2];
            personalGranja.Apellido2 = MatrizPersona[3];
            personalGranja.Telefono = MatrizPersona[4];
            personalGranja.Rol = MatrizPersona[5];
            personalGranja.EmailPersonal = MatrizPersona[6];
            personalGranja.FechaNacimiento = Convert.ToDateTime(MatrizPersona[7]);
            return personalGranja;
        }
        
    
    
    }
}
