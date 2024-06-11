using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioDetalleFactura : BaseDatosConexion
    {
        public RepositorioDetalleFactura() { }

        // Método para insertar un registro en la tabla DETALLE_FACTURA
        public int InsertarDetalleFactura(EntidadDetalleFactura detalleFactura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarDetalleFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = detalleFactura.CantidadVenta;
                        comando.Parameters.Add("p_precio_unitario", OracleDbType.Double).Value = detalleFactura.PrecioUnitario;
                        comando.Parameters.Add("p_fk_factura", OracleDbType.Int32).Value = detalleFactura.IdFactura.IdFactura;

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

        // Método para actualizar un registro en la tabla DETALLE_FACTURA
        public int ActualizarDetalleFactura(EntidadDetalleFactura detalleFactura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarDetalleFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_detalle_factura", OracleDbType.Int32).Value = detalleFactura.IdDetalleFactura;
                        comando.Parameters.Add("p_cantidad", OracleDbType.Int32).Value = detalleFactura.CantidadVenta;
                        comando.Parameters.Add("p_precio_unitario", OracleDbType.Double).Value = detalleFactura.PrecioUnitario;
                        comando.Parameters.Add("p_fk_factura", OracleDbType.Int32).Value = detalleFactura.IdFactura.IdFactura;

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

        // Método para eliminar un registro de la tabla DETALLE_FACTURA
        public int BorrarDetalleFactura(int idDetalleFactura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarDetalleFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_detalle_factura", OracleDbType.Int32).Value = idDetalleFactura;
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

        // Método para consultar un registro de la tabla DETALLE_FACTURA por su ID
        public EntidadDetalleFactura ConsultarDetalleFactura(int idDetalleFactura)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarDetalleFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_detalle_factura", OracleDbType.Int32).Value = idDetalleFactura;
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

        // Método para consultar todos los registros de la tabla DETALLE_FACTURA
        public List<EntidadDetalleFactura> ConsultarTodosLosDetallesDeFactura()
        {
            List<EntidadDetalleFactura> listaDetallesFactura = new List<EntidadDetalleFactura>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosDetallesDeFactura", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaDetallesFactura.Add(Mapeo(lector));
                            }
                            return listaDetallesFactura;
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

        // Método para mapear de una fila de la tabla a la entidad DETALLE_FACTURA
        private EntidadDetalleFactura Mapeo(OracleDataReader leer)
        {
            EntidadDetalleFactura detalleFactura = new EntidadDetalleFactura();
            detalleFactura.IdDetalleFactura = leer.GetInt32(0);
            detalleFactura.CantidadVenta = leer.GetInt32(1);
            detalleFactura.PrecioUnitario = leer.GetDouble(2);
            detalleFactura.IdFactura.IdFactura = leer.GetInt32(3);

            return detalleFactura;
        }
    }
}
