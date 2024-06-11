using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioCliente : BaseDatosConexion
    {
        public RepositorioCliente() { }

        // Método para insertar una fila en la tabla CLIENTE
        public int InsertarCliente(EntidadCliente cliente)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarCliente", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = cliente.Identificacion;
                        comando.Parameters.Add("p_tipo_identificacion", OracleDbType.Varchar2).Value = cliente.TipoIdentificacion;
                        comando.Parameters.Add("p_nombres", OracleDbType.Varchar2).Value = cliente.Nombres;
                        comando.Parameters.Add("p_apellidos", OracleDbType.Varchar2).Value = cliente.Apellidos;
                        comando.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                        comando.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = cliente.Correo;
                        comando.Parameters.Add("p_tipo_cliente", OracleDbType.Varchar2).Value = cliente.TipoCliente;

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

        // Método para actualizar una fila en la tabla CLIENTE
        public int ActualizarCliente(EntidadCliente cliente)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarCliente", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = cliente.Id;
                        comando.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = cliente.Identificacion;
                        comando.Parameters.Add("p_tipo_identificacion", OracleDbType.Varchar2).Value = cliente.TipoIdentificacion;
                        comando.Parameters.Add("p_nombres", OracleDbType.Varchar2).Value = cliente.Nombres;
                        comando.Parameters.Add("p_apellidos", OracleDbType.Varchar2).Value = cliente.Apellidos;
                        comando.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                        comando.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = cliente.Correo;
                        comando.Parameters.Add("p_tipo_cliente", OracleDbType.Varchar2).Value = cliente.TipoCliente;

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

        // Método para borrar una fila de la tabla CLIENTE
        public int BorrarCliente(int idCliente)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarCliente", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = idCliente;

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

        // Método para consultar una fila de la tabla CLIENTE
        public EntidadCliente ConsultarCliente(int idCliente)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarCliente", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = idCliente;
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

        // Método para consultar todas las filas de la tabla CLIENTE
        public List<EntidadCliente> ConsultarTodosLosClientes()
        {
            List<EntidadCliente> listaClientes = new List<EntidadCliente>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosClientes", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaClientes.Add(Mapeo(lector));
                            }
                            return listaClientes;
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

        // Método para mapear de una fila de la tabla a la entidad CLIENTE
        private EntidadCliente Mapeo(OracleDataReader leer)
        {
            EntidadCliente cliente = new EntidadCliente();
            cliente.Id = leer.GetInt32(0);
            cliente.Identificacion = leer.GetString(1);
            cliente.TipoIdentificacion = leer.GetString(2);
            cliente.Nombres = leer.GetString(3);
            cliente.Apellidos = leer.GetString(4);
            cliente.Telefono = leer.GetString(5);
            cliente.Correo = leer.GetString(6);
            cliente.TipoCliente = leer.GetString(7);

            return cliente;
        }
    }
}


