using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

        public EntidadCliente ConsultarGalpon(int idCliente)
        {
            List<EntidadCliente> Clientes = ConsultarTodoCliente();
            foreach (EntidadCliente cliente in Clientes)
            {
                if (cliente.Id == idCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        public List<EntidadCliente> ConsultarTodoCliente()
        {
            List<EntidadCliente> ListaDeClientes = new List<EntidadCliente>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosClientes", connection))
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
                                ListaDeClientes.Add(MapeoCliente(lector));
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Clientes: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los Clientes: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDeClientes;
        }

        // Método para mapear de una fila de la tabla a la entidad Cliente
        private EntidadCliente MapeoCliente(OracleDataReader lector)
        {
            EntidadCliente cliente = new EntidadCliente();

            try
            {
                cliente.Id = lector.GetInt32(lector.GetOrdinal("ID_CLIENTE"));
                cliente.Identificacion = lector.GetString(lector.GetOrdinal("IDENTIFICACION"));
                cliente.TipoIdentificacion = lector.GetString(lector.GetOrdinal("TIPO_IDENTIFICACION"));
                cliente.Nombres = lector.GetString(lector.GetOrdinal("NOMBRES"));
                cliente.Apellidos = lector.GetString(lector.GetOrdinal("APELLIDOS"));
                cliente.Telefono = lector.GetString(lector.GetOrdinal("TELEFONO"));
                cliente.Correo = lector.GetString(lector.GetOrdinal("CORREO"));
                cliente.TipoCliente = lector.GetString(lector.GetOrdinal("TIPO_CLIENTE"));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error de conversión en el mapeo de EntidadCliente: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadCliente: {ex.Message}");
            }

            return cliente;
        }

    }
}


