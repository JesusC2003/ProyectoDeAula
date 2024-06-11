using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioAsignado : BaseDatosConexion
    {
        public RepositorioAsignado() { }

        // Método para insertar una fila en la tabla ASIGNADO
        public int InsertarAsignado(EntidadAsignado asignado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarAsignado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_fk_empleado", OracleDbType.Int32).Value = asignado.IdEmpleado.Id;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = asignado.IdGalpon.IdGalpon;

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

        // Método para actualizar una fila en la tabla ASIGNADO
        public int ActualizarAsignado(EntidadAsignado asignado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarAsignado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_asignado", OracleDbType.Int32).Value = asignado.IdAsignado;
                        comando.Parameters.Add("p_fk_empleado", OracleDbType.Int32).Value = asignado.IdEmpleado.Id;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = asignado.IdGalpon.IdGalpon;

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

        // Método para borrar una fila de la tabla ASIGNADO
        public int BorrarAsignado(int idAsignado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarAsignado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_asignado", OracleDbType.Int32).Value = idAsignado;

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

        // Método para consultar una fila de la tabla ASIGNADO
        public EntidadAsignado ConsultarAsignado(int idAsignado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarAsignado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_asignado", OracleDbType.Int32).Value = idAsignado;
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

        // Método para consultar todas las filas de la tabla ASIGNADO
        public List<EntidadAsignado> ConsultarTodosLosAsignados()
        {
            List<EntidadAsignado> listaAsignados = new List<EntidadAsignado>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosAsignados", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaAsignados.Add(Mapeo(lector));
                            }
                            return listaAsignados;
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

        // Método para mapear de una fila de la tabla a la entidad ASIGNADO
        private EntidadAsignado Mapeo(OracleDataReader leer)
        {
            EntidadAsignado asignado = new EntidadAsignado();
            asignado.IdAsignado = leer.GetInt32(0);
            asignado.IdEmpleado.Id = leer.GetInt32(1); 
            asignado.IdGalpon.IdGalpon = leer.GetInt32(2); 

            return asignado;
        }
    }
}
