using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioRegistroSanitario : BaseDatosConexion
    {
        RepositorioMedicamento repositorioMedicamento;
        RepositorioPollo repositorioPollo;
        public RepositorioRegistroSanitario() {
            repositorioMedicamento = new RepositorioMedicamento();
            repositorioPollo = new RepositorioPollo();
        }

        // Método para insertar una fila en la tabla REGISTRO_SANITARIO
        public int InsertarRegistroSanitario(EntidadRegistroSanitario registro)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarRegistroSanitario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_fecha_aplicacion", OracleDbType.Date).Value = registro.FechaAplicacion;
                        comando.Parameters.Add("p_observaciones", OracleDbType.Varchar2).Value = registro.Observaciones;
                        comando.Parameters.Add("p_fk_pollo", OracleDbType.Int32).Value = registro.IdPollo.IdPollo;
                        comando.Parameters.Add("p_fk_medicamento", OracleDbType.Int32).Value = registro.IdMedicamento.IdMedicamento;

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

        // Método para actualizar una fila en la tabla REGISTRO_SANITARIO
        public int ActualizarRegistroSanitario(EntidadRegistroSanitario registro)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarRegistroSanitario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_registro", OracleDbType.Int32).Value = registro.IdRegistro;
                        comando.Parameters.Add("p_fecha_aplicacion", OracleDbType.Date).Value = registro.FechaAplicacion;
                        comando.Parameters.Add("p_observaciones", OracleDbType.Varchar2).Value = registro.Observaciones;
                        comando.Parameters.Add("p_fk_pollo", OracleDbType.Int32).Value = registro.IdPollo.IdPollo;
                        comando.Parameters.Add("p_fk_medicamento", OracleDbType.Int32).Value = registro.IdMedicamento.IdMedicamento;

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

        // Método para borrar una fila de la tabla REGISTRO_SANITARIO
        public int EliminarRegistroSanitario(int idRegistro)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarRegistroSanitario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_registro", OracleDbType.Int32).Value = idRegistro;
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

        // Método para consultar una fila de la tabla REGISTRO_SANITARIO
        public EntidadRegistroSanitario ConsultarRegistroSanitario(int idRegistro)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarRegistroSanitario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_registro", OracleDbType.Int32).Value = idRegistro;
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

        // Método para consultar todas las filas de la tabla REGISTRO_SANITARIO
        public List<EntidadRegistroSanitario> ConsultarTodosLosRegistrosSanitarios()
        {
            List<EntidadRegistroSanitario> listaRegistros = new List<EntidadRegistroSanitario>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosRegistrosSanitarios", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaRegistros.Add(Mapeo(lector));
                            }
                            return listaRegistros;
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

        // Método para mapear de una fila de la tabla a la entidad REGISTRO_SANITARIO
        private EntidadRegistroSanitario Mapeo(OracleDataReader leer)
        {
            EntidadRegistroSanitario registro = new EntidadRegistroSanitario();
            registro.IdRegistro = leer.GetInt32(0);
            registro.FechaAplicacion = leer.GetDateTime(1);
            registro.Observaciones = leer.GetString(2);
            registro.IdPollo = repositorioPollo.ConsultarPollo(leer.GetInt32(3));
            registro.IdMedicamento = repositorioMedicamento.ConsultarMedicamento (leer.GetInt32(4));

            return registro;
        }
    }
}
