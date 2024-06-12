using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioLote : BaseDatosConexion
    {
        public RepositorioLote() { }

        public int InsertarLote(EntidadLote lote)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarLote", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_numero_lote", OracleDbType.Int32).Value = lote.NumeroLote;
                        comando.Parameters.Add("p_fecha_ingreso", OracleDbType.Date).Value = lote.FechaIngreso;

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

        public int ActualizarLote(EntidadLote lote)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarLote", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_lote", OracleDbType.Int32).Value = lote.IdLote;
                        comando.Parameters.Add("p_numero_lote", OracleDbType.Int32).Value = lote.NumeroLote;
                        comando.Parameters.Add("p_fecha_ingreso", OracleDbType.Date).Value = lote.FechaIngreso;

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

        public int BorrarLote(int idLote)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarLote", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_lote", OracleDbType.Int32).Value = idLote;
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

        public EntidadLote ConsultarLote(int idGalpon)
        {
            List<EntidadLote> lotes = ConsultarTodoLote();
            foreach (EntidadLote lote in lotes)
            {
                if (lote.IdLote == idGalpon)
                {
                    return lote;
                }
            }
            return null;
        }

        public List<EntidadLote> ConsultarTodoLote()
        {
            List<EntidadLote> ListaDeLotes = new List<EntidadLote>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosLotes", connection))
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
                                ListaDeLotes.Add(MapeoLote(lector));
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Lotes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los Lotes: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDeLotes;
        }

        // Método para mapear de una fila de la tabla a la entidad Lote
        private EntidadLote MapeoLote(OracleDataReader lector)
        {
            EntidadLote lote = new EntidadLote();

            try
            {
                lote.IdLote = lector.GetInt32(lector.GetOrdinal("ID_LOTE"));
                lote.NumeroLote = lector.GetString(lector.GetOrdinal("NUMERO_LOTE"));
                lote.FechaIngreso = lector.GetDateTime(lector.GetOrdinal("FECHA_INGRESO"));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error de conversión en el mapeo de EntidadLote: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadLote: {ex.Message}");
            }

            return lote;
        }


    }
}

