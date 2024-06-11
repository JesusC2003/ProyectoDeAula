using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioRegistroAlimentacion : BaseDatosConexion
    {
        RepositorioGalpon repositorioGalpon;
        RepositorioAlimento repositorioAlimento;
        public RepositorioRegistroAlimentacion() 
        {
            repositorioAlimento = new RepositorioAlimento();
            repositorioGalpon = new RepositorioGalpon();
        }

        // Método para insertar una fila en la tabla REGISTRO_ALIMENTACION
        public int InsertarRegistroAlimentacion(EntidadRegistroAlimentacion registro)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarRegistroAlimentacion", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_cantidad_alimento", OracleDbType.Int32).Value = registro.CantidadAlimento;
                        comando.Parameters.Add("p_cantidad_agua", OracleDbType.Int32).Value = registro.CantidadAgua;
                        comando.Parameters.Add("p_fecha_aplicacion", OracleDbType.Date).Value = registro.FechaAplicacion;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = registro.IdGalpon.IdGalpon;
                        comando.Parameters.Add("p_fk_alimento", OracleDbType.Int32).Value = registro.IdAlimento.IdAlimento;

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

        // Método para actualizar una fila en la tabla REGISTRO_ALIMENTACION
        public int ActualizarRegistroAlimentacion(EntidadRegistroAlimentacion registro)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarRegistroAlimentacion", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_registro_alimentacion", OracleDbType.Int32).Value = registro.IdRegistroAlimentacion;
                        comando.Parameters.Add("p_cantidad_alimento", OracleDbType.Int32).Value = registro.CantidadAlimento;
                        comando.Parameters.Add("p_cantidad_agua", OracleDbType.Int32).Value = registro.CantidadAgua;
                        comando.Parameters.Add("p_fecha_aplicacion", OracleDbType.Date).Value = registro.FechaAplicacion;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = registro.IdGalpon.IdGalpon;
                        comando.Parameters.Add("p_fk_alimento", OracleDbType.Int32).Value = registro.IdAlimento.IdAlimento;

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

        // Método para borrar una fila de la tabla REGISTRO_ALIMENTACION
        public int EliminarRegistroAlimentacion(int idRegistroAlimentacion)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarRegistroAlimentacion", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_registro_alimentacion", OracleDbType.Int32).Value = idRegistroAlimentacion;
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

        // Método para consultar una fila de la tabla REGISTRO_ALIMENTACION
        public EntidadRegistroAlimentacion ConsultarRegistroAlimentacion(int idRegistroAlimentacion)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarRegistroAlimentacion", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_registro_alimentacion", OracleDbType.Int32).Value = idRegistroAlimentacion;
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

        // Método para consultar todas las filas de la tabla REGISTRO_ALIMENTACION
        public List<EntidadRegistroAlimentacion> ConsultarTodosLosRegistrosDeAlimentacion()
        {
            List<EntidadRegistroAlimentacion> listaRegistros = new List<EntidadRegistroAlimentacion>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosRegistrosDeAlimentacion", ObtenerConexion()))
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

        // Método para mapear de una fila de la tabla a la entidad REGISTRO_ALIMENTACION
        private EntidadRegistroAlimentacion Mapeo(OracleDataReader leer)
        {
            EntidadRegistroAlimentacion registro = new EntidadRegistroAlimentacion();
            registro.IdRegistroAlimentacion = leer.GetInt32(0);
            registro.CantidadAlimento = leer.GetInt32(1);
            registro.CantidadAgua = leer.GetInt32(2);
            registro.FechaAplicacion = leer.GetDateTime(3);
            registro.IdGalpon = repositorioGalpon.ConsultarGalpon(leer.GetInt32(4));
            registro.IdAlimento = repositorioAlimento.ConsultarAlimento(leer.GetInt32(5));

            return registro;
        }
    }
}
