using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPollo
    {
        private RepositorioPollo RepositorioPollo;
        public ServicioPollo() { 

               RepositorioPollo = new RepositorioPollo();

        }

        public string GuardarPollo(EntidadPollo pollo)
        {
            if (RepositorioPollo.InsertarPollo(pollo) > 0)
            {
                return "La informacion fue guardada con exito";
            }
            return "la informacion no fue guardada";
        }
        public string ActualizarPollo(EntidadPollo pollo)
        {
            if (RepositorioPollo.ActualizarPollo(pollo) > 0)
            {
                return "La informacion fue actualizada con exito";
            }
            return "la informacion no fue actualizada";
        }

        public string BorrarPollo(int idPollo)
        {
            if (RepositorioPollo.EliminarPollo(idPollo) > 0)
            {
                return "La informacion fue borrada con exito";
            }
            return "la informacion no fue borrada";
        }



        //    private readonly RepositorioPollo repositorioPollo;
        //    private string RutaArchivo = "C:\\Users\\ASUS\\Documents\\UNIVERSIDAD POPULAR DEL CESAR\\PROGRAMACIÓN III\\ProyectoDeAula\\Datos\\ArchivosTxt\\POLLO.txt";
        //    private List<Pollo> pollos;
        //    public PolloServicio() { 
        //        repositorioPollo = new RepositorioPollo(RutaArchivo);
        //    }
        //    public string Guardar(Pollo pollo)
        //    {
        //        try
        //        {
        //            if (repositorioPollo.Buscar(pollo.IdPollo) == null)
        //            {
        //                repositorioPollo.Guardar(pollo);
        //                return $"|MENSAJE DE CONFIRMACIÓN| - Se ha completado el registro satisfactoriamente";
        //            }
        //            else
        //            {
        //                return $"|ERROR| - El sistema indica que la idetificación: {pollo.IdPollo} ya " +
        //                    $"se encuentra registrada, por lo tanto se cancela el proceso de guardado";
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            return $"|ERROR DE LA APLICACIÓN|: {e.Message}";
        //        }
        //    }
        //    public string Eliminar(string IDPollo)
        //    {
        //        try
        //        {
        //            if (repositorioPollo.Buscar(IDPollo) != null)
        //            {
        //                repositorioPollo.Eliminar(IDPollo);
        //                return ($"|MENSAJE DE CONFIRMACIÓN| - El registro: {IDPollo} fue eliminado satisfactoriamente");
        //            }
        //            else
        //            {
        //                return ($"|MENSAJE DE CONFIRMACIÓN| - En nustros archivos, no se encuentra registrado un pollo con identificacion: {IDPollo}");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            return $"|ERROR EN LA APLICACION|: {e.Message}";
        //        }
        //    }
        //    public PolloRespuesta BuscarPorIdentificacion(string IDPollo)
        //    {
        //        try
        //        {
        //            Pollo pollo = repositorioPollo.Buscar(IDPollo);
        //            if (pollo != null)
        //            {
        //                return new PolloRespuesta(pollo);
        //            }
        //            else
        //            {
        //                return new PolloRespuesta("|MENSAJE CONFIRMACION| - El pollo no fue encontrado");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            return new PolloRespuesta("|ERROR EN LA APLICACION|: " + e.Message);
        //        }
        //    }
        //    public ConsultaPolloRespuesta ConsultarTodos()
        //    {
        //        try
        //        {
        //            List<Pollo> pollos = repositorioPollo.ConsultarTodos();
        //            if (pollos != null)
        //            {
        //                return new ConsultaPolloRespuesta(pollos);
        //            }
        //            else
        //            {
        //                return new ConsultaPolloRespuesta("|MENSAJE DE CONFIRMACIÓN| - Este pollo no se encuentra registrado");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            return new ConsultaPolloRespuesta("|ERROR EN LA APLICACIÓN|: " + e.Message);
        //        }
        //    }
        //    public ConsultaPolloRespuesta ConsultarPorRaza(string raza)
        //    {
        //        try
        //        {
        //            List<Pollo> pollos = repositorioPollo.FiltrarRaza(raza);
        //            if (pollos != null)
        //            {
        //                return new ConsultaPolloRespuesta(pollos);
        //            }
        //            else
        //            {
        //                return new ConsultaPolloRespuesta("|MENSAJE DE CONFIRMACIÓN| - Este pollo no se encuentra registrado");
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            return new ConsultaPolloRespuesta("|ERROR EN LA APLICACIÓN|: " + e.Message);
        //        }
        //    }
        //}
        //public class PolloRespuesta
        //{        
        //    public Pollo pollo { get; set; }
        //    public string Mensaje { get; set; }
        //    public bool Encontrado { get; set; }
        //    public PolloRespuesta(Pollo pollito)
        //    {
        //        pollo = new Pollo();
        //        pollo = pollito;
        //        Encontrado = true;
        //    }
        //    public PolloRespuesta(string mensaje)
        //    {
        //        Mensaje = mensaje;
        //        Encontrado = false;
        //    }
        //}
        //public class ConsultaPolloRespuesta
        //{
        //    public List<Pollo> Pollos { get; set; }
        //    public string Mensaje { get; set; }
        //    public bool Encontrado { get; set; }
        //    public ConsultaPolloRespuesta(List<Pollo> pollitos)
        //    {
        //        Pollos = new List<Pollo>();
        //        Pollos = pollitos;
        //        Encontrado = true;
        //    }
        //    public ConsultaPolloRespuesta(string mensaje)
        //    {
        //        Mensaje = mensaje;
        //        Encontrado = false;
        //    }
    }
}
