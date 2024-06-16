
using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioPollo : BaseDatosConexion
    {
        
        RepositorioGalpon RepositorioGalpon;
        RepositorioDetalleFactura RepositorioDetalleFactura;

        public RepositorioPollo()
        {
            RepositorioGalpon = new RepositorioGalpon();
            RepositorioDetalleFactura = new RepositorioDetalleFactura();
        }

        // Método para insertar una fila en la tabla POLLO
        public string InsertarPollos(List<EntidadPollo> pollos)
        {
            string query = "INSERT INTO POLLO (FECHA_INGRESO, ESTADO_POLLO, NUMERO_LOTE, EDAD_POLLO, FK_GALPON, RAZA_POLLO) " +
                           "VALUES (:fechaIngreso, :estadoPollo, :numeroLote, :edadPollo, :fkGalpon, :razaPollo)";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                foreach (var pollo in pollos)
                {
                    using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                    {
                        comando.Transaction = transaccion;
                        EjecutarInsercion(comando, pollo);
                    }
                }

                ConfirmarTransaccion(transaccion);
                return $"Se insertaron {pollos.Count} pollos correctamente.";
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                return $"|ERROR|: {ex.Message}";
            }
        }

        // Método para insertar la información en el comando
        private void EjecutarInsercion(OracleCommand comando, EntidadPollo pollo)
        {
            try
            {
                comando.Parameters.Add("fechaIngreso", OracleDbType.Date).Value = pollo.FechaIngreso;
                comando.Parameters.Add("estadoPollo", OracleDbType.Varchar2).Value = pollo.EstadoPollo;
                comando.Parameters.Add("numeroLote", OracleDbType.Varchar2).Value = pollo.NumeroLote;
                comando.Parameters.Add("edadPollo", OracleDbType.Varchar2).Value = pollo.EdadPollo;
                comando.Parameters.Add("fkGalpon", OracleDbType.Int32).Value = pollo.IdGalpon.IdGalpon;
                comando.Parameters.Add("razaPollo", OracleDbType.Varchar2).Value = pollo.RazaPollo;

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método para actualizar una fila en la tabla POLLO
        public int ActualizarPollo(EntidadPollo pollo)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarPollo", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_pollo", OracleDbType.Int32).Value = pollo.IdPollo;
                        comando.Parameters.Add("p_codigo_pollo", OracleDbType.Varchar2).Value = pollo.CodigoPollo;
                        comando.Parameters.Add("p_raza_pollo", OracleDbType.Varchar2).Value = pollo.RazaPollo;
                        comando.Parameters.Add("p_estado_pollo", OracleDbType.Varchar2).Value = pollo.EstadoPollo;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = pollo.IdGalpon.IdGalpon;
                        comando.Parameters.Add("p_fk_detallefactura", OracleDbType.Int32).Value = pollo.IdDetalleFactura.IdDetalleFactura;

                        return comando.ExecuteNonQuery();
                    }
                }
                catch (OracleException ex)
                {
                    throw new Exception($"|ERROR|: {ex.Message}");
                }
                finally
                {
                    CerrarConexion();
                }
            }
            else
            {
                throw new Exception("Error al abrir la conexión.");
            }
        }

        // Método para borrar una fila de la tabla POLLO
        public int EliminarPollo(int idPollo)
        {
            string query = "DELETE FROM POLLO WHERE ID_POLLO = ";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        ConfirmarTransaccion(comando.Transaction);
                        return filasAfectadas;
                    }
                    else
                    {
                        DeshacerTransaccion(comando.Transaction);
                        return filasAfectadas;
                    }
                }
            }
            catch (OracleException ex) { throw new Exception($"{ex}"); }
        }

        // Método para consultar una fila de la tabla POLLO
        public EntidadPollo ConsultarPollo(int IdPoLLO)
        {
            EntidadPollo entidadPollo = new EntidadPollo();
            List<EntidadPollo> listapollos = ConsultarTodo();
            foreach (EntidadPollo pollo in listapollos)
            {
                if (pollo.IdPollo == IdPoLLO)
                {
                    return pollo;
                }
            }
            return entidadPollo;
        }
        public EntidadPollo ConsultarPollo(string CodigoPollo)
        {
            EntidadPollo entidadPollo = new EntidadPollo();
            List<EntidadPollo> listapollos = ConsultarTodo();
            foreach (EntidadPollo pollo in listapollos)
            {
                if (pollo.CodigoPollo == CodigoPollo)
                {
                    return pollo;
                }
            }
            return entidadPollo;
        }
       
        //Metodo para consultar todas las filas de una tabla
        public List<EntidadPollo> ConsultarTodo()
        {
            List<EntidadPollo> ListaDePollos = new List<EntidadPollo>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosPollos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Crear y configurar el parámetro de salida para el cursor
                        OracleParameter cursorParameter = new OracleParameter();
                        cursorParameter.OracleDbType = OracleDbType.RefCursor;
                        cursorParameter.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(cursorParameter);

                        AbrirConexion();
                        using (OracleDataReader lector = cmd.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                ListaDePollos.Add(Mapeo(lector));
                            }

                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Pollo: {ex.Message}");
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Error al consultar los Pollo: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDePollos;
        }
        
        // Método para mapear de una fila de la tabla a la entidad POLLO
        private EntidadPollo Mapeo(OracleDataReader lector)
        {
            EntidadPollo pollo = new EntidadPollo();

            pollo.IdPollo = Convert.ToInt32(lector["ID_POLLO"]);
            pollo.CodigoPollo = Convert.ToString(lector["CODIGO_POLLO"]);
            pollo.RazaPollo = Convert.ToString(lector["RAZA_POLLO"]);
            pollo.EstadoPollo = Convert.ToString(lector["ESTADO_POLLO"]);
            pollo.EdadPollo = Convert.ToString(lector["EDAD_POLLO"]);
            pollo.NumeroLote = Convert.ToString(lector["NUMERO_LOTE"]);
            pollo.FechaIngreso = Convert.ToDateTime(lector["FECHA_INGRESO"]);
            pollo.IdGalpon = RepositorioGalpon.ConsultarGalpon(Convert.ToInt32(lector["FK_GALPON"]));

            return pollo;
        }

        //METODOS PARA FILTRAR LA LISTA DE POLLOS
        public List<EntidadPollo> FiltrarPollosPorEstado(string estadoDeseado)
        {
            try
            {
                return ConsultarTodo().Where(pollo => pollo.EstadoPollo.Equals(estadoDeseado)).ToList();
            }
            catch (Exception ex) { throw new Exception($"Error al filtrar los pollos por Estado: {ex.Message}"); }
        }
        public List<EntidadPollo> FiltrarPollosPorRaza(string razaDeseada)
        {
            try
            {

                return ConsultarTodo().Where(pollo => pollo.RazaPollo.Equals(razaDeseada)).ToList();
            }
            catch (Exception ex) { throw new Exception($"Error al filtrar los pollos por Raza {ex.Message}"); }
        }
        public List<EntidadPollo> FiltrarPollosPorGalpon(string IdGalpon)
        {
            try
            {

                return ConsultarTodo().Where(pollo => pollo.IdGalpon.NombreGalpon.Equals(IdGalpon)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar los pollos por galpón: {ex.Message}");
            }
        }
        private void Prueba(OracleDataReader lector)
        {
            StringBuilder mensaje = new StringBuilder();
            while (lector.Read())
            {
                mensaje.Append($"ID_POLLO: {Convert.ToInt32(lector["ID_POLLO"])}, ");
                mensaje.Append($"CODIGO_POLLO: {Convert.ToString(lector["CODIGO_POLLO"])}, ");
                mensaje.Append($"RAZA_POLLO: {Convert.ToString(lector["RAZA_POLLO"])}, ");
                mensaje.Append($"ESTADO_POLLO: {Convert.ToString(lector["ESTADO_POLLO"])}, ");
                mensaje.Append($"FK_GALPON: {RepositorioGalpon.ConsultarGalpon( Convert.ToInt32(lector["FK_GALPON"]))}, ");


            }
            MessageBox.Show(mensaje.ToString());
        }
    }
}
