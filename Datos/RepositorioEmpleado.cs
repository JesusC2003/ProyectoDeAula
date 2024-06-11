using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioEmpleado : BaseDatosConexion
    {
        public RepositorioEmpleado() { }

        // Método para insertar un registro en la tabla EMPLEADO
        public int InsertarEmpleado(EntidadEmpleado empleado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarEmpleado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = empleado.Identificacion;
                        comando.Parameters.Add("p_tipo_identificacion", OracleDbType.Varchar2).Value = empleado.TipoIdentificacion;
                        comando.Parameters.Add("p_nombres", OracleDbType.Varchar2).Value = empleado.Nombres;
                        comando.Parameters.Add("p_apellidos", OracleDbType.Varchar2).Value = empleado.Apellidos;
                        comando.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = empleado.Telefono;
                        comando.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = empleado.Correo;
                        comando.Parameters.Add("p_cargo", OracleDbType.Varchar2).Value = empleado.Cargo;
                        comando.Parameters.Add("p_salario", OracleDbType.Double).Value = empleado.Salario;
                        comando.Parameters.Add("p_departamento", OracleDbType.Varchar2).Value = empleado.Departamento;
                        comando.Parameters.Add("p_fk_empresa", OracleDbType.Int32).Value = empleado.NitEmpresa.NIT;
                        comando.Parameters.Add("p_fk_usuario", OracleDbType.Int32).Value = empleado.IdUsuario.IdUsuario;
                        comando.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = empleado.IdUsuario;

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

        // Método para actualizar un registro en la tabla EMPLEADO
        public int ActualizarEmpleado(EntidadEmpleado empleado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarEmpleado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_empleado", OracleDbType.Int32).Value = empleado.Id;
                        comando.Parameters.Add("p_identificacion", OracleDbType.Varchar2).Value = empleado.Identificacion;
                        comando.Parameters.Add("p_tipo_identificacion", OracleDbType.Varchar2).Value = empleado.TipoIdentificacion;
                        comando.Parameters.Add("p_nombres", OracleDbType.Varchar2).Value = empleado.Nombres;
                        comando.Parameters.Add("p_apellidos", OracleDbType.Varchar2).Value = empleado.Apellidos;
                        comando.Parameters.Add("p_telefono", OracleDbType.Varchar2).Value = empleado.Telefono;
                        comando.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = empleado.Correo;
                        comando.Parameters.Add("p_cargo", OracleDbType.Varchar2).Value = empleado.Cargo;
                        comando.Parameters.Add("p_salario", OracleDbType.Double).Value = empleado.Salario;
                        comando.Parameters.Add("p_departamento", OracleDbType.Varchar2).Value = empleado.Departamento;
                        comando.Parameters.Add("p_nit_empresa", OracleDbType.Varchar2).Value = empleado.NitEmpresa;
                        comando.Parameters.Add("p_id_usuario", OracleDbType.Int32).Value = empleado.IdUsuario;

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

        // Método para borrar un registro de la tabla EMPLEADO
        public int BorrarEmpleado(int idEmpleado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarEmpleado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_empleado", OracleDbType.Int32).Value = idEmpleado;
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

        // Método para consultar un registro de la tabla EMPLEADO
        public EntidadEmpleado ConsultarEmpleado(int idEmpleado)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarEmpleado", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_empleado", OracleDbType.Int32).Value = idEmpleado;
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

        // Método para consultar todos los registros de la tabla EMPLEADO
        public List<EntidadEmpleado> ConsultarTodosLosEmpleados()
        {
            List<EntidadEmpleado> listaEmpleados = new List<EntidadEmpleado>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosEmpleados", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaEmpleados.Add(Mapeo(lector));
                            }
                            return listaEmpleados;
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
        // Método para mapear un registro de la tabla a la entidad EMPLEADO
        private EntidadEmpleado Mapeo(OracleDataReader leer)
        {
            EntidadEmpleado empleado = new EntidadEmpleado();
            empleado.Id = leer.GetInt32(0);
            empleado.Identificacion = leer.GetString(1);
            empleado.TipoIdentificacion = leer.GetString(2);
            empleado.Nombres = leer.GetString(3);
            empleado.Apellidos = leer.GetString(4);
            empleado.Telefono = leer.GetString(5);
            empleado.Correo = leer.GetString(6);
            empleado.Cargo = leer.GetString(7);
            empleado.Salario = leer.GetDouble(8);
            empleado.Departamento = leer.GetString(9);
            empleado.NitEmpresa = new EntidadEmpresa() { NIT = leer.GetString(10) };
            empleado.IdUsuario = new EntidadUsuario() { IdUsuario = leer.GetInt32(11) };

            return empleado;
        }
    }
}



    




