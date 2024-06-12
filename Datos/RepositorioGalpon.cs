using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioGalpon : BaseDatosConexion
    {
        public RepositorioGalpon() { }

        public int InsertarGalpon(EntidadGalpon galpon)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_InsertarGalpon", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_codigo_galpon", OracleDbType.Varchar2).Value = galpon.CodigoGalpon;
                        comando.Parameters.Add("p_nombre_galpon", OracleDbType.Varchar2).Value = galpon.NombreGalpon;
                        comando.Parameters.Add("p_area_galpon", OracleDbType.Double).Value = galpon.AreaGalpon;
                        comando.Parameters.Add("p_estado_galpon", OracleDbType.Varchar2).Value = galpon.EstadoGalpon;

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

        public int ActualizarGalpon(EntidadGalpon galpon)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_ActualizarGalpon", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;

                        comando.Parameters.Add("p_id_galpon", OracleDbType.Int32).Value = galpon.IdGalpon;
                        comando.Parameters.Add("p_codigo_galpon", OracleDbType.Varchar2).Value = galpon.CodigoGalpon;
                        comando.Parameters.Add("p_nombre_galpon", OracleDbType.Varchar2).Value = galpon.NombreGalpon;
                        comando.Parameters.Add("p_area_galpon", OracleDbType.Double).Value = galpon.AreaGalpon;
                        comando.Parameters.Add("p_estado_galpon", OracleDbType.Varchar2).Value = galpon.EstadoGalpon;

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

        public int BorrarGalpon(int idGalpon)
        {
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("P_BorrarGalpon", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_galpon", OracleDbType.Int32).Value = idGalpon;
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

        public EntidadGalpon ConsultarGalpon(int idGalpon)
        {
            List<EntidadGalpon> Galpon = ConsultarTodoGalpon();
            foreach (EntidadGalpon galpon in Galpon)
            {
                if (galpon.IdGalpon ==idGalpon)
                {
                    return galpon;
                }
            }
            return null;
        }

        public List<EntidadGalpon> ConsultarTodoGalpon()
        {
            List<EntidadGalpon> ListaDeGalpones = new List<EntidadGalpon>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosGalpones", connection))
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
                                ListaDeGalpones.Add(MapeoGalpon(lector));
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar los Galpones: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los Galpones: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDeGalpones;
        }

        private EntidadGalpon MapeoGalpon(OracleDataReader lector)
        {
            EntidadGalpon galpon = new EntidadGalpon();

            try
            {
                galpon.IdGalpon = lector.GetInt32(lector.GetOrdinal("ID_GALPON"));
                galpon.CodigoGalpon = lector.GetString(lector.GetOrdinal("CODIGO_GALPON"));
                galpon.NombreGalpon = lector.GetString(lector.GetOrdinal("NOMBRE_GALPON"));
                galpon.AreaGalpon = lector.GetDouble(lector.GetOrdinal("AREAGALPON"));
                galpon.EstadoGalpon = lector.GetString(lector.GetOrdinal("ESTADO_GALPON"));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error de conversión en el mapeo de EntidadGalpon: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadGalpon: {ex.Message}");
            }

            return galpon;
        }
    }
}



