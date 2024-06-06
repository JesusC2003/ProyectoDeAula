using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BDUsuario 
    {
    //    private List<Persona> personas;
    //    Persona personalGranja;
    //    public RepositorioPersonalGranja(string RutaArchivo) : base(RutaArchivo) { }

    //    public void Guardar(Persona personal)
    //    {
    //        FileStream archivo = new FileStream(RutaDeArchivo, FileMode.Append);
    //        StreamWriter escribir = new StreamWriter(archivo);
    //        escribir.WriteLine(personal.ToString());
    //        escribir.Close();
    //        archivo.Close();
    //    }
    //    public void Modificar(Persona NuevoRegistro, Persona ViejoRegistro)
    //    {
    //        personas = new List<Persona>();
    //        personas = CargarLista();
    //        FileStream Archivo = new FileStream(RutaDeArchivo, FileMode.Create);
    //        Archivo.Close();
    //        foreach (var individuo in personas)
    //        {
    //            if (!EncontrarPersona(individuo.IdPersonal, ViejoRegistro.IdPersonal))
    //            {
    //                Guardar(individuo);
    //            }
    //            else
    //            {
    //                Guardar(NuevoRegistro);
    //            }
    //        }
    //    }
    //    public void Eliminar(string identificacion)
    //    {
    //        personas = new List<Persona>();
    //        personas = CargarLista();
    //        FileStream Archivo = new FileStream(RutaDeArchivo, FileMode.Create);
    //        Archivo.Close();
    //        foreach (var persona in personas)
    //        {
    //            if (!EncontrarPersona(persona.IdPersonal, identificacion))
    //            {
    //                Guardar(persona);
    //            }
    //        }
    //    }
    //    public Persona BuscarPersona (string ID) 
    //    {
    //        personas = CargarLista();
    //        foreach (var individuo in personas)
    //        {
    //            if (EncontrarPersona(individuo.IdPersonal,ID))
    //            {
    //                return individuo;
    //            }
    //        }
    //        return null;
    //    }
    //    private bool EncontrarPersona(string IdRegistrada, string IdBuscada)
    //    {
    //        return IdRegistrada == IdBuscada;
    //    }
    //    public List<Persona> CargarLista()
    //    {
    //        personas.Clear();
    //        personas = new List<Persona>();
    //        FileStream archivo = new FileStream(RutaDeArchivo, FileMode.Append);
    //        StreamReader leer = new StreamReader(archivo);
    //        string linea = leer.ReadLine();
    //        while (linea != null)
    //        {
    //            personalGranja = MapeoPorLinea(linea);
    //            personas.Add(personalGranja);
    //        }
    //        leer.Close();
    //        archivo.Close ();
    //        return personas;
    //    }
    //    private Persona MapeoPorLinea(string linea)
    //    {
    //        personalGranja = new Persona();
    //        string[] MatrizPersona= linea.Split(';');
    //        personalGranja.IdPersonal = MatrizPersona[0];
    //        personalGranja.Nombres = MatrizPersona[1];
    //        personalGranja.Apellido1 = MatrizPersona[2];
    //        personalGranja.Apellido2 = MatrizPersona[3];
    //        personalGranja.Telefono = MatrizPersona[4];
    //        personalGranja.Rol = MatrizPersona[5];
    //        personalGranja.EmailPersonal = MatrizPersona[6];
    //        personalGranja.FechaNacimiento = Convert.ToDateTime(MatrizPersona[7]);
    //        return personalGranja;
    //    }
    //    public List<Persona> FiltrarPorRol(string rol)
    //    {
    //        return CargarLista().Where(p => p.Rol.Equals(rol)).ToList();
    //    }
    //    public List<Persona> FiltrarPorFechaNacimiento(DateTime fechaNacimiento)
    //    {
    //        return CargarLista().Where(p =>p.FechaNacimiento.Equals(fechaNacimiento)).ToList();
    //    }
    
    }
}
