using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BDPollo 
    {
        //public RepositorioPollo(string RutaArchivo) : base(RutaArchivo) { }

        //public void Guardar(Pollo pollo)
        //{
        //    FileStream file = new FileStream(RutaDeArchivo, FileMode.Append);
        //    StreamWriter writer = new StreamWriter(file);
        //    writer.WriteLine(pollo.ToString());
        //    writer.Close();
        //    file.Close();
        //}
        //public Pollo Buscar(string IDPollo)
        //{
        //    List<Pollo> pollo = ConsultarTodos();
        //    foreach (var item in pollo)
        //    {
        //        if (EsEncontrado(item.IdPollo, IDPollo))
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
        //private bool EsEncontrado(string IDRegistrado, string IDBuscada)
        //{
        //    return IDRegistrado == IDBuscada;
        //}
        //public List<Pollo> ConsultarTodos()
        //{
        //    List<Pollo> pollo = new List<Pollo>();
        //    FileStream file = new FileStream(RutaDeArchivo, FileMode.OpenOrCreate, FileAccess.Read);
        //    StreamReader reader = new StreamReader(file);
        //    string linea = string.Empty;
        //    while ((linea = reader.ReadLine()) != null)
        //    {
        //        Pollo pollito = MapeoPorLinea(linea);
        //        pollo.Add(pollito);
        //    }
        //    reader.Close();
        //    file.Close();
        //    return pollo;
        //}
        //private Pollo MapeoPorLinea(string linea)
        //{
        //    Pollo pollo = new Pollo();
        //    char delimitador = ';';
        //    string[] MatrizPollo = linea.Split(delimitador);
        //    pollo.IdPollo = MatrizPollo[0];
        //    pollo.Estado = MatrizPollo[1];
        //    pollo.Fechaingreso = Convert.ToDateTime(MatrizPollo[2]);
        //    pollo.FechaSalida = Convert.ToDateTime(MatrizPollo[3]);
        //    pollo.RazaPollo = MatrizPollo[4];
        //    pollo.PeriodoEngorde = int.Parse(MatrizPollo[5]);
        //    pollo.Peso = int.Parse(MatrizPollo[6]);
        //    //pollo.Codigolnventario = MatrizPollo[7];
        //    //pollo.CodigoGalpon = MatrizPollo[8];
        //    //pollo.MedicamentoAplicado= MatrizPollo[9];
        //    return pollo;
        //}
        //public void Modificar(Pollo polloNuevo, Pollo polloViejo)
        //{
        //    List<Pollo> pollo = new List<Pollo>();
        //    pollo = ConsultarTodos();
        //    FileStream file = new FileStream(RutaDeArchivo, FileMode.Create);
        //    file.Close();
        //    foreach (var item in pollo)
        //    {
        //        if (!EsEncontrado(item.IdPollo, polloViejo.IdPollo))
        //        {
        //            Guardar(item);
        //        }
        //        else
        //        {
        //            Guardar(polloNuevo);
        //        }
        //    }
        //}
        //public void Eliminar(string IDPollo)
        //{
        //    List<Pollo> pollo = new List<Pollo>();
        //    pollo = ConsultarTodos();
        //    FileStream file = new FileStream(RutaDeArchivo, FileMode.Create);
        //    file.Close();
        //    foreach (var item in pollo)
        //    {
        //        if (!EsEncontrado(item.IdPollo, IDPollo))
        //        {
        //            Guardar(item);
        //        }
        //    }
        //}
        //public List<Pollo> FiltrarRaza(string raza)
        //{
        //    return ConsultarTodos().Where(p => p.RazaPollo.Equals(raza)).ToList();
        //}
    }
}
