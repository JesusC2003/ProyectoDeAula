using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioControlPeso : BaseDatosConexion
    {
        public RepositorioControlPeso() { }

        // Método para insertar un registro en la tabla CONTROL_PESO
        public int InsertarControlPeso(EntidadControlPeso controlPeso)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarControlPeso", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_peso", OracleDbType.Int32).Value = controlPeso.Peso;
                        comando.Parameters.Add("p_fecha_control", OracleDbType.Date).Value = controlPeso.FechaControl;
                        comando.Parameters.Add("p_fk_pollo", OracleDbType.Int32).Value = controlPeso.IdPollo.IdPollo;

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

        // Método para actualizar un registro en la tabla CONTROL_PESO
        public int ActualizarControlPeso(EntidadControlPeso controlPeso)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarControlPeso", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_control_peso", OracleDbType.Int32).Value = controlPeso.IdControlPeso;
                        comando.Parameters.Add("p_peso", OracleDbType.Int32).Value = controlPeso.Peso;
                        comando.Parameters.Add("p_fecha_control", OracleDbType.Date).Value = controlPeso.FechaControl;
                        comando.Parameters.Add("p_fk_pollo", OracleDbType.Int32).Value = controlPeso.IdPollo.IdPollo;

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

        // Método para eliminar un registro de la tabla CONTROL_PESO
        public int BorrarControlPeso(int idControlPeso)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarControlPeso", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_control_peso", OracleDbType.Int32).Value = idControlPeso;
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

        // Método para consultar un registro de la tabla CONTROL_PESO por su ID
        public EntidadControlPeso ConsultarControlPeso(int idControlPeso)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarControlPeso", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_control_peso", OracleDbType.Int32).Value = idControlPeso;
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

        // Método para consultar todos los registros de la tabla CONTROL_PESO
        public List<EntidadControlPeso> ConsultarTodosLosControlesDePeso()
        {
            List<EntidadControlPeso> listaControlesPeso = new List<EntidadControlPeso>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosControlesDePeso", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaControlesPeso.Add(Mapeo(lector));
                            }
                            return listaControlesPeso;
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

        // Método para mapear de una fila de la tabla a la entidad CONTROL_PESO
        private EntidadControlPeso Mapeo(OracleDataReader leer)
        {
            EntidadControlPeso controlPeso = new EntidadControlPeso();
            controlPeso.IdControlPeso = leer.GetInt32(0);
            controlPeso.Peso = leer.GetInt32(1);
            controlPeso.FechaControl = leer.GetDateTime(2);
            controlPeso.IdPollo.IdPollo = leer.GetInt32(3);

            return controlPeso;
        }
    }
}
