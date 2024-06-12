using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioDetalleFactura : BaseDatosConexion
    {
        RepositorioFactura repositorioFactura;
        public RepositorioDetalleFactura() 
        { 
            repositorioFactura = new RepositorioFactura(); 
        }

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
        public EntidadDetalleFactura ConsultarDetalleFactura(int idGalpon)
        {
            List<EntidadDetalleFactura> entidadDetalles = ConsultarTodoDetalleFactura();
            foreach (EntidadDetalleFactura detalleFactura in entidadDetalles)
            {
                if (detalleFactura.IdDetalleFactura == idGalpon)
                {
                    return detalleFactura;
                }
            }
            return null;
        }


        // Método para consultar todos los registros de la tabla DETALLE_FACTURA
        public List<EntidadDetalleFactura> ConsultarTodoDetalleFactura()
        {
            List<EntidadDetalleFactura> ListaDeDetallesFactura = new List<EntidadDetalleFactura>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosDetallesFactura", connection))
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
                                ListaDeDetallesFactura.Add(MapeoDetalleFactura(lector));
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Detalles de Factura: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los Detalles de Factura: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDeDetallesFactura;
        }

        // Método para mapear de una fila de la tabla a la entidad DetalleFactura
        private EntidadDetalleFactura MapeoDetalleFactura(OracleDataReader lector)
        {
            EntidadDetalleFactura detalleFactura = new EntidadDetalleFactura();

            try
            {
                detalleFactura.IdDetalleFactura = lector.GetInt32(lector.GetOrdinal("ID_DETALLE_FACTURA"));
                detalleFactura.CantidadVenta = lector.GetInt32(lector.GetOrdinal("CANTIDAD"));
                detalleFactura.PrecioUnitario = lector.GetDouble(lector.GetOrdinal("PRECIOUNITARIO"));
                detalleFactura.IdFactura = repositorioFactura.ConsultarFactura( lector.GetInt32(lector.GetOrdinal("FK_FACTURA")));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error de conversión en el mapeo de EntidadDetalleFactura: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadDetalleFactura: {ex.Message}");
            }

            return detalleFactura;
        }

    }
}
