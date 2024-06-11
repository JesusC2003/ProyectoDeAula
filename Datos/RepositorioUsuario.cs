using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioUsuario : BaseDatosConexion
    {
        public RepositorioUsuario() { }

        // Método para insertar una fila en la tabla USUARIO
        public int InsertarUsuario(EntidadUsuario usuario)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarUsuario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_nombreusuario", OracleDbType.Varchar2).Value = usuario.NombreUsuario;
                        comando.Parameters.Add("p_contrasena", OracleDbType.Varchar2).Value = usuario.ContraseñaUsuario;

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

        // Método para actualizar una fila en la tabla USUARIO
        public int ActualizarUsuario(EntidadUsuario usuario)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarUsuario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = usuario.IdUsuario;
                        comando.Parameters.Add("p_nombreusuario", OracleDbType.Varchar2).Value = usuario.NombreUsuario;
                        comando.Parameters.Add("p_contrasena", OracleDbType.Varchar2).Value = usuario.ContraseñaUsuario;

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

        // Método para borrar una fila de la tabla USUARIO
        public int EliminarUsuario(int idUsuario)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarUsuario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = idUsuario;
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

        // Método para consultar una fila de la tabla USUARIO
        public EntidadUsuario ConsultarUsuario(int idUsuario)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarUsuario", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = idUsuario;
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

        // Método para consultar todas las filas de la tabla USUARIO
        public List<EntidadUsuario> ConsultarTodosLosUsuarios()
        {
            List<EntidadUsuario> listaUsuarios = new List<EntidadUsuario>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosUsuarios", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaUsuarios.Add(Mapeo(lector));
                            }
                            return listaUsuarios;
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

        // Método para mapear de una fila de la tabla a la entidad USUARIO
        private EntidadUsuario Mapeo(OracleDataReader leer)
        {
            EntidadUsuario usuario = new EntidadUsuario();
            usuario.IdUsuario = leer.GetInt32(0);
            usuario.NombreUsuario = leer.GetString(1);
            usuario.ContraseñaUsuario = leer.GetString(2);

            return usuario;
        }
    }
}
