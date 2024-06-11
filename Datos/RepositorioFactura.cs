using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioFactura : BaseDatosConexion
    {
        public RepositorioFactura() { }

        public int InsertarFactura(EntidadFactura factura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_codigo_factura", OracleDbType.Varchar2).Value = factura.CodigoFactura;
                        comando.Parameters.Add("p_fecha_factura", OracleDbType.Date).Value = factura.FechaFactura;
                        comando.Parameters.Add("p_monto_total", OracleDbType.Double).Value = factura.MontoTotal;
                        comando.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = factura.IdCliente.Id;
                        comando.Parameters.Add("p_nitempresa", OracleDbType.Varchar2).Value = factura.NitEmpresa.NIT;

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

        public int ActualizarFactura(EntidadFactura factura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_factura", OracleDbType.Int32).Value = factura.IdFactura;
                        comando.Parameters.Add("p_codigo_factura", OracleDbType.Varchar2).Value = factura.CodigoFactura;
                        comando.Parameters.Add("p_fecha_factura", OracleDbType.Date).Value = factura.FechaFactura;
                        comando.Parameters.Add("p_monto_total", OracleDbType.Double).Value = factura.MontoTotal;
                        comando.Parameters.Add("p_id_cliente", OracleDbType.Int32).Value = factura.IdCliente.Id;
                        comando.Parameters.Add("p_nitempresa", OracleDbType.Varchar2).Value = factura.NitEmpresa.NIT;

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

        public int BorrarFactura(int idFactura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_factura", OracleDbType.Int32).Value = idFactura;
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

        public EntidadFactura ConsultarFactura(int idFactura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_factura", OracleDbType.Int32).Value = idFactura;
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

        public List<EntidadFactura> ConsultarTodasLasFacturas()
        {
            List<EntidadFactura> listaFacturas = new List<EntidadFactura>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodasLasFacturas", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaFacturas.Add(Mapeo(lector));
                            }
                            return listaFacturas;
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

        private EntidadFactura Mapeo(OracleDataReader leer)
        {
            EntidadFactura factura = new EntidadFactura();
            factura.IdFactura = leer.GetInt32(0);
            factura.CodigoFactura = leer.GetString(1);
            factura.FechaFactura = leer.GetDateTime(2);
            factura.MontoTotal = leer.GetDouble(3);
            factura.IdCliente = new EntidadCliente() { Id = leer.GetInt32(4) };
            factura.NitEmpresa = new EntidadEmpresa() { NIT = leer.GetString(5) };

            return factura;
        }
    }
}

