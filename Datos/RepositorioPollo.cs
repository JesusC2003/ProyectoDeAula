
using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioPollo : BaseDatosConexion
    {
        
        RepositorioGalpon RepositorioGalpon;
        RepositorioDetalleFactura RepositorioDetalleFactura;
        RepositorioLote RepositorioLote;
        public RepositorioPollo() {
            RepositorioLote = new RepositorioLote();
            RepositorioGalpon = new RepositorioGalpon();
            RepositorioDetalleFactura = new RepositorioDetalleFactura();
        }

        // Método para insertar una fila en la tabla POLLO
        public int InsertarPollo(EntidadPollo pollo)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarPollo", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_codigo_pollo", OracleDbType.Varchar2).Value = pollo.CodigoPollo;
                        comando.Parameters.Add("p_raza_pollo", OracleDbType.Varchar2).Value = pollo.RazaPollo;
                        comando.Parameters.Add("p_estado_pollo", OracleDbType.Varchar2).Value = pollo.EstadoPollo;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = pollo.IdGalpon.IdGalpon;
                        comando.Parameters.Add("p_fk_lote", OracleDbType.Int32).Value = pollo.LotePollo.IdLote;
                        comando.Parameters.Add("p_fk_detallefactura", OracleDbType.Int32).Value = null;

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

        // Método para actualizar una fila en la tabla POLLO
        public int ActualizarPollo(EntidadPollo pollo)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarPollo", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_pollo", OracleDbType.Int32).Value = pollo.IdPollo;
                        comando.Parameters.Add("p_codigo_pollo", OracleDbType.Varchar2).Value = pollo.CodigoPollo;
                        comando.Parameters.Add("p_raza_pollo", OracleDbType.Varchar2).Value = pollo.RazaPollo;
                        comando.Parameters.Add("p_estado_pollo", OracleDbType.Varchar2).Value = pollo.EstadoPollo;
                        comando.Parameters.Add("p_fk_galpon", OracleDbType.Int32).Value = pollo.IdGalpon.IdGalpon;
                        comando.Parameters.Add("p_fk_lote", OracleDbType.Int32).Value = pollo.LotePollo.IdLote;
                        comando.Parameters.Add("p_fk_detallefactura", OracleDbType.Int32).Value = pollo.IdDetalleFactura.IdDetalleFactura;

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

        // Método para borrar una fila de la tabla POLLO
        public int EliminarPollo(int idPollo)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarPollo", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_pollo", OracleDbType.Int32).Value = idPollo;
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

        // Método para consultar una fila de la tabla POLLO
        public EntidadPollo ConsultarPollo(int idPollo)
        {
            EntidadPollo pollo = null;
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarPollo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro de entrada
                        cmd.Parameters.Add("p_id_pollo", OracleDbType.Int32).Value = idPollo;

                        OracleParameter cursorParameter = new OracleParameter();
                        cursorParameter.OracleDbType = OracleDbType.RefCursor;
                        cursorParameter.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(cursorParameter);

                        AbrirConexion();
                        using (OracleDataReader lector = cmd.ExecuteReader())
                        {
                            
                            if (lector.Read())
                            {                               
                                pollo = Mapeo(lector);
                            }
                            
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar el Pollo: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar el Pollo: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return pollo;
        }
       
        //Metodo para consultar todas las filas de una tabla
        public List<EntidadPollo> ConsultarTodo()
        {
            List<EntidadPollo> ListaDePollos = new List<EntidadPollo>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosPollos", connection))
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
                                ListaDePollos.Add(Mapeo(lector));
                            }

                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Pollo: {ex.Message}");
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Error al consultar los Pollo: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDePollos;
        }
        
        // Método para mapear de una fila de la tabla a la entidad POLLO
        private EntidadPollo Mapeo(OracleDataReader leer)
        {
            EntidadPollo pollo = new EntidadPollo();

            try
            {
                
                pollo.IdPollo = leer.GetInt32(0);
                pollo.CodigoPollo = leer.GetString(1);
                pollo.RazaPollo = leer.GetString(2);
                pollo.EstadoPollo = leer.GetString(3);
                pollo.IdGalpon = RepositorioGalpon.ConsultarGalpon(leer.GetInt32(4));
                pollo.LotePollo = RepositorioLote.ConsultarLote(leer.GetInt32(5));
                pollo.IdDetalleFactura = RepositorioDetalleFactura.ConsultarDetalleFactura(leer.GetInt32(6));

            }
            // Manejo de la excepción InvalidCastException y IndexOutOfRangeException
            catch (InvalidCastException ex)
            {
                throw new Exception ($"Error de conversión en el mapeo de EntidadPollo: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadPollo: {ex.Message}");
            }

            return pollo;
        }
        
        //METODOS PARA FILTRAR LA LISTA DE POLLOS
        public List<EntidadPollo> FiltrarPollosPorEstado(string estadoDeseado)
        {
            try 
            {
                return ConsultarTodo().Where(pollo => pollo.EstadoPollo.Equals(estadoDeseado)).ToList();
            }
            catch (Exception ex) { throw new Exception($"Error al filtrar los pollos por Estado: {ex.Message}"); }
        }
        public List<EntidadPollo> FiltrarPollosPorRaza(string razaDeseada)
        {
            try
            {
                return ConsultarTodo().Where(pollo => pollo.RazaPollo.Equals(razaDeseada)).ToList();
            }
            catch (Exception ex) { throw new Exception($"Error al filtrar los pollos por Raza {ex.Message}"); } 
        }
        public List<EntidadPollo> FiltrarPollosPorGalpon(string IdGalpon)
        {
            try
            {
                return ConsultarTodo().Where(pollo => pollo.IdGalpon.NombreGalpon.Equals(IdGalpon)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar los pollos por galpón: {ex.Message}");
            }
        }
    
        public void Pruebas(OracleDataReader lector)
        {
            StringBuilder mensaje = new StringBuilder();
            while (lector.Read()) 
            {
                mensaje.AppendLine($"ID_POLLO: {lector.GetInt32(0)}, CODIGO_POLLO: {lector.GetString(1)}, RAZA_POLLO: {lector.GetString(2)}, ESTADO_POLLO: {lector.GetString(3)}, FK_GALPON: {lector.GetInt32(4)}, FK_LOTE: {lector.GetInt32(5)}, FK_DETALLEFACTURA: {lector.GetInt32(6)}");

            }
            MessageBox.Show(mensaje.ToString(), "Datos del POLLO");
        }
    }
}
