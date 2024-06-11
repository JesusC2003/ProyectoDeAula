using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioMedicamento : BaseDatosConexion
    {
        public RepositorioMedicamento() { }

        // Método para insertar una fila en la tabla MEDICAMENTO
        public int InsertarMedicamento(EntidadMedicamento medicamento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarMedicamento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_codigo_medicamento", OracleDbType.Varchar2).Value = medicamento.CodigoMedicamento;
                        comando.Parameters.Add("p_nombre_medicamento", OracleDbType.Varchar2).Value = medicamento.NombreMedicamento;
                        comando.Parameters.Add("p_descripcion_medicamento", OracleDbType.Varchar2).Value = medicamento.DescripcionMedicamento;
                        comando.Parameters.Add("p_fecha_caducidad", OracleDbType.Date).Value = medicamento.FechaCaducidad;

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

        // Método para actualizar una fila en la tabla MEDICAMENTO
        public int ActualizarMedicamento(EntidadMedicamento medicamento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarMedicamento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_medicamento", OracleDbType.Int32).Value = medicamento.IdMedicamento;
                        comando.Parameters.Add("p_codigo_medicamento", OracleDbType.Varchar2).Value = medicamento.CodigoMedicamento;
                        comando.Parameters.Add("p_nombre_medicamento", OracleDbType.Varchar2).Value = medicamento.NombreMedicamento;
                        comando.Parameters.Add("p_descripcion_medicamento", OracleDbType.Varchar2).Value = medicamento.DescripcionMedicamento;
                        comando.Parameters.Add("p_fecha_caducidad", OracleDbType.Date).Value = medicamento.FechaCaducidad;

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

        // Método para borrar una fila de la tabla MEDICAMENTO
        public int EliminarMedicamento(int idMedicamento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarMedicamento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_medicamento", OracleDbType.Int32).Value = idMedicamento;
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

        // Método para consultar una fila de la tabla MEDICAMENTO
        public EntidadMedicamento ConsultarMedicamento(int idMedicamento)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarMedicamento", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_medicamento", OracleDbType.Int32).Value = idMedicamento;
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

        // Método para consultar todas las filas de la tabla MEDICAMENTO
        public List<EntidadMedicamento> ConsultarTodosLosMedicamentos()
        {
            List<EntidadMedicamento> listaMedicamentos = new List<EntidadMedicamento>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosMedicamentos", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaMedicamentos.Add(Mapeo(lector));
                            }
                            return listaMedicamentos;
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

        // Método para mapear de una fila de la tabla a la entidad MEDICAMENTO
        private EntidadMedicamento Mapeo(OracleDataReader leer)
        {
            EntidadMedicamento medicamento = new EntidadMedicamento();
            medicamento.IdMedicamento = leer.GetInt32(0);
            medicamento.CodigoMedicamento = leer.GetString(1);
            medicamento.NombreMedicamento = leer.GetString(2);
            medicamento.DescripcionMedicamento = leer.GetString(3);
            medicamento.FechaCaducidad = leer.GetDateTime(4);

            return medicamento;
        }
    }
}
