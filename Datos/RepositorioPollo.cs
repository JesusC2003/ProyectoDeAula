
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
        public int InsertarPollos(List<EntidadPollo> pollos)
        {
            int num = 0;
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
                        num = EjecutarInsercion(comando, pollo);
                    }
                }
                ConfirmarTransaccion(transaccion);
                return num;
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Método para insertar la información en el comando
        private int EjecutarInsercion(OracleCommand comando, EntidadPollo pollo)
        {
            try
            {
                comando.Parameters.Add("fechaIngreso", OracleDbType.Date).Value = pollo.FechaIngreso;
                comando.Parameters.Add("estadoPollo", OracleDbType.Varchar2).Value = pollo.EstadoPollo;
                comando.Parameters.Add("numeroLote", OracleDbType.Varchar2).Value = pollo.NumeroLote;
                comando.Parameters.Add("edadPollo", OracleDbType.Varchar2).Value = pollo.EdadPollo;
                comando.Parameters.Add("fkGalpon", OracleDbType.Int32).Value = pollo.IdGalpon.IdGalpon;
                comando.Parameters.Add("razaPollo", OracleDbType.Varchar2).Value = pollo.RazaPollo;

                return comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Método para actualizar una fila en la tabla POLLO
        public int ActualizarPollo(EntidadPollo pollo)
        {
            string query = "UPDATE POLLO SET RAZA_POLLO = :razaPollo, ESTADO_POLLO = :estadoPollo, " +
                           "FK_GALPON = :fkGalpon, NUMERO_LOTE = :numeroLote,  " +
                           "EDAD_POLLO = :edadPollo, FECHA_INGRESO = :fechaIngreso " +
                           "WHERE ID_POLLO = :idPollo";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add("razaPollo", OracleDbType.Varchar2).Value = pollo.RazaPollo;
                    comando.Parameters.Add("estadoPollo", OracleDbType.Varchar2).Value = pollo.EstadoPollo;
                    comando.Parameters.Add("fkGalpon", OracleDbType.Int32).Value = pollo.IdGalpon.IdGalpon;
                    comando.Parameters.Add("numeroLote", OracleDbType.Varchar2).Value = pollo.NumeroLote;
                    comando.Parameters.Add("edadPollo", OracleDbType.Varchar2).Value = pollo.EdadPollo;
                    comando.Parameters.Add("fechaIngreso", OracleDbType.Date).Value = pollo.FechaIngreso;
                    comando.Parameters.Add("idPollo", OracleDbType.Int32).Value = pollo.IdPollo;

                    int filasAfectadas = comando.ExecuteNonQuery();
                    ConfirmarTransaccion(comando.Transaction);
                    return filasAfectadas;
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                MessageBox.Show(ex.Message); 
                return 0;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Método para borrar una fila de la tabla POLLO
        public int BorrarPollo(int idPollo)
        {
            string query = "DELETE FROM POLLO WHERE ID_POLLO = :idPollo";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add("idPollo", OracleDbType.Int32).Value = idPollo;

                    int filasAfectadas = comando.ExecuteNonQuery();
                    ConfirmarTransaccion(comando.Transaction);
                    return filasAfectadas;
                }
            }
            catch (Exception)
            {
                DeshacerTransaccion(transaccion);
                return 0;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public EntidadPollo ConsultarPollo(string codPollo)
        {
            OracleDataReader lector;
            EntidadPollo pollo = new EntidadPollo();
            string query = "SELECT ID_POLLO, CODIGO_POLLO, RAZA_POLLO, ESTADO_POLLO, FK_GALPON, NUMERO_LOTE, FK_DETALLEFACTURA, EDAD_POLLO, FECHA_INGRESO " +
                           "FROM POLLO WHERE ID_POLLO = :codPollo";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add(new OracleParameter("codPollo", codPollo));
                    lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        pollo = Mapeo(lector);
                    }
                    lector.Close();
                    ConfirmarTransaccion(comando.Transaction);
                    return pollo;
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        // Método para consultar una fila de la tabla POLLO
        public EntidadPollo ConsultarPollo(int idPollo)
        {
            OracleDataReader lector;
            EntidadPollo pollo = new EntidadPollo();
            string query = "SELECT ID_POLLO, CODIGO_POLLO, RAZA_POLLO, ESTADO_POLLO, FK_GALPON, NUMERO_LOTE, FK_DETALLEFACTURA, EDAD_POLLO, FECHA_INGRESO " +
                           "FROM POLLO WHERE ID_POLLO = :idPollo";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add(new OracleParameter("idPollo", idPollo));
                    lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        pollo = Mapeo(lector);
                    }
                    lector.Close();
                    ConfirmarTransaccion(comando.Transaction);
                    return pollo;
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                throw ex;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public List<EntidadPollo> ConsultarTodo()
        {
            List<EntidadPollo> ListaDePollos = new List<EntidadPollo>();
            OracleTransaction transaccion = null; 

            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    // Iniciar transacción desde la conexión obtenida
                    transaccion = IniciarTransaccion();

                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosPollos", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        OracleParameter cursorParameter = new OracleParameter();
                        cursorParameter.OracleDbType = OracleDbType.RefCursor;
                        cursorParameter.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(cursorParameter);

                        cmd.Transaction = transaccion;

                        using (OracleDataReader lector = cmd.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                ListaDePollos.Add(Mapeo(lector));
                            }
                        }
                    }

                    ConfirmarTransaccion(transaccion);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Pollos: {ex.Message}");
                if (transaccion != null)
                {
                    DeshacerTransaccion(transaccion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los Pollos: {ex.Message}");
                if (transaccion != null)
                {
                    DeshacerTransaccion(transaccion);
                }
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
