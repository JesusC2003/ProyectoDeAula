using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioAlimento : BaseDatosConexion
    {
        public RepositorioAlimento() { }

        // Método para insertar una fila en la tabla ALIMENTO
        public int InsertarAlimento(EntidadAlimento alimento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarAlimento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_codigo_alimento", OracleDbType.Varchar2).Value = alimento.CodigoAlimento;
                        comando.Parameters.Add("p_marca_alimento", OracleDbType.Varchar2).Value = alimento.MarcaAlimento;
                        comando.Parameters.Add("p_tipo_alimento", OracleDbType.Varchar2).Value = alimento.TipoAlimento;
                        comando.Parameters.Add("p_fecha_caducidad", OracleDbType.Date).Value = alimento.FechaCaducidad;

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

        // Método para actualizar una fila en la tabla ALIMENTO
        public int ActualizarAlimento(EntidadAlimento alimento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarAlimento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_alimento", OracleDbType.Int32).Value = alimento.IdAlimento;
                        comando.Parameters.Add("p_codigo_alimento", OracleDbType.Varchar2).Value = alimento.CodigoAlimento;
                        comando.Parameters.Add("p_marca_alimento", OracleDbType.Varchar2).Value = alimento.MarcaAlimento;
                        comando.Parameters.Add("p_tipo_alimento", OracleDbType.Varchar2).Value = alimento.TipoAlimento;
                        comando.Parameters.Add("p_fecha_caducidad", OracleDbType.Date).Value = alimento.FechaCaducidad;

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

        // Método para borrar una fila de la tabla ALIMENTO
        public int EliminarAlimento(int idAlimento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarAlimento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_alimento", OracleDbType.Int32).Value = idAlimento;
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

        // Método para consultar una fila de la tabla ALIMENTO
        public EntidadAlimento ConsultarAlimento(int idAlimento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarAlimento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_alimento", OracleDbType.Int32).Value = idAlimento;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return Mapeo(lector);
                            }
                            else
                            {
                                return null;
                            }
                        }
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

        // Método para consultar todas las filas de la tabla ALIMENTO
        public List<EntidadAlimento> ConsultarTodosLosAlimentos()
        {
            List<EntidadAlimento> listaAlimentos = new List<EntidadAlimento>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosAlimentos", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaAlimentos.Add(Mapeo(lector));
                            }
                            return listaAlimentos;
                        }
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

        // Método para mapear de una fila de la tabla a la entidad ALIMENTO
        private EntidadAlimento Mapeo(OracleDataReader leer)
        {
            EntidadAlimento alimento = new EntidadAlimento();
            alimento.IdAlimento = leer.GetInt32(0);
            alimento.CodigoAlimento = leer.GetString(1);
            alimento.MarcaAlimento = leer.GetString(2);
            alimento.TipoAlimento = leer.GetString(3);
            alimento.FechaCaducidad = leer.GetDateTime(4);

            return alimento;
        }
    }
}
