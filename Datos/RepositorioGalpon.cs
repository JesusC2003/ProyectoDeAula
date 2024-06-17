using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioGalpon : BaseDatosConexion
    {
        public RepositorioGalpon() { }
        public int InsertarGalpon(EntidadGalpon galpon)
        {
            string query = "INSERT INTO GALPON (ID_GALPON, CODIGO_GALPON, NOMBRE_GALPON, AREAGALPON, ESTADO_GALPON) " +
                           "VALUES ( :codigoGalpon, :nombreGalpon, :areaGalpon, :estadoGalpon)";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    return EjecutarInsercion(comando, galpon);
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
        // Método para insertar la información en el comando
        private int EjecutarInsercion(OracleCommand comando, EntidadGalpon galpon)
        {
            try
            {                
                comando.Parameters.Add("codigoGalpon", OracleDbType.Varchar2).Value = galpon.CodigoGalpon;
                comando.Parameters.Add("nombreGalpon", OracleDbType.Varchar2).Value = galpon.NombreGalpon;
                comando.Parameters.Add("areaGalpon", OracleDbType.Decimal).Value = galpon.AreaGalpon;
                comando.Parameters.Add("estadoGalpon", OracleDbType.Varchar2).Value = galpon.EstadoGalpon;
                int filasAfectadas = comando.ExecuteNonQuery();
                ConfirmarTransaccion(comando.Transaction);
                return filasAfectadas;
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
        public int ActualizarGalpon(EntidadGalpon galpon)
        {
            string query = "UPDATE GALPON SET NOMBRE_GALPON = :nombreGalpon, AREAGALPON = :areaGalpon, ESTADO_GALPON = :estadoGalpon " +
                           "WHERE ID_GALPON = :idGalpon";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add("nombreGalpon", OracleDbType.Varchar2).Value = galpon.NombreGalpon;
                    comando.Parameters.Add("areaGalpon", OracleDbType.Decimal).Value = galpon.AreaGalpon;
                    comando.Parameters.Add("estadoGalpon", OracleDbType.Varchar2).Value = galpon.EstadoGalpon;
                    comando.Parameters.Add("idGalpon", OracleDbType.Int32).Value = galpon.IdGalpon;

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
        public int BorrarGalpon(int idGalpon)
        {
            string query = "DELETE FROM GALPON WHERE ID_GALPON = :idGalpon";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add("idGalpon", OracleDbType.Int32).Value = idGalpon;

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
        public EntidadGalpon ConsultarGalpon(int idGalpon)
        {
            OracleDataReader lector;
            EntidadGalpon galpon = new EntidadGalpon();
            string query = "SELECT ID_GALPON, CODIGO_GALPON, NOMBRE_GALPON, AREAGALPON, ESTADO_GALPON FROM GALPON WHERE ID_GALPON = :idGalpon";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add(new OracleParameter("idGalpon", idGalpon));
                    lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        galpon = MapeoGalpon(lector);
                    }    
                    lector.Close();
                    ConfirmarTransaccion(comando.Transaction);
                    return galpon;
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
        public EntidadGalpon ConsultarGalpon(string codigoGalpon)
        {
            OracleDataReader lector;
            EntidadGalpon galpon = new EntidadGalpon();
            string query = "SELECT ID_GALPON, CODIGO_GALPON, NOMBRE_GALPON, AREAGALPON, ESTADO_GALPON FROM GALPON WHERE CODIGO_GALPON = :codigoGalpon";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add(new OracleParameter("codigoGalpon", codigoGalpon));
                    lector = comando.ExecuteReader();
                    if (lector.Read()) 
                    {
                        galpon = MapeoGalpon(lector);
                    }                    
                    lector.Close();
                    ConfirmarTransaccion(comando.Transaction);
                    return galpon;
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
        public List<EntidadGalpon> ConsultarTodosLosGalpones()
        {
            List<EntidadGalpon> ListaDeGalpones = new List<EntidadGalpon>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosGalpones", connection))
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
                                ListaDeGalpones.Add(MapeoGalpon(lector));
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Galpones: {ex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al consultar los Galpones: {e.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDeGalpones;
        }
        private EntidadGalpon MapeoGalpon(OracleDataReader lector)
        {
            EntidadGalpon galpon = new EntidadGalpon();

            try
            {
                galpon.IdGalpon = lector.GetInt32(lector.GetOrdinal("ID_GALPON"));
                galpon.CodigoGalpon = lector.GetString(lector.GetOrdinal("CODIGO_GALPON"));
                galpon.NombreGalpon = lector.GetString(lector.GetOrdinal("NOMBRE_GALPON"));
                galpon.AreaGalpon = lector.GetDouble(lector.GetOrdinal("AREAGALPON"));
                galpon.EstadoGalpon = lector.GetString(lector.GetOrdinal("ESTADO_GALPON"));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error de conversión en el mapeo de EntidadGalpon: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadGalpon: {ex.Message}");
            }

            return galpon;
        }
    }
}



