using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

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
            EntidadGalpon entidadGalpon = new EntidadGalpon();
            List<EntidadGalpon> listaGalpones = ConsultarTodosLosGalpones();
            foreach (EntidadGalpon galpon in listaGalpones)
            {
                if (galpon.IdGalpon == idGalpon)
                {
                    return galpon;
                }
            }
            return entidadGalpon;
        }
        public EntidadGalpon ConsultarGalpon(string CodigoGalpon)
        {
            EntidadGalpon entidadGalpon = new EntidadGalpon();
            List<EntidadGalpon> listaGalpones = ConsultarTodosLosGalpones();
            foreach (EntidadGalpon galpon in listaGalpones)
            {
                if (galpon.CodigoGalpon == CodigoGalpon)
                {
                    return galpon;
                }
            }
            return entidadGalpon;
        }


        public List<EntidadGalpon> ConsultarTodosLosGalpones()
        {
            List<EntidadGalpon> listaGalpones = new List<EntidadGalpon>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosGalpones", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaGalpones.Add(Mapeo(lector));
                            }
                            return listaGalpones;
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

        private EntidadGalpon Mapeo(OracleDataReader leer)
        {
            EntidadGalpon galpon = new EntidadGalpon();
            galpon.IdGalpon = leer.GetInt32(0);
            galpon.CodigoGalpon = leer.GetString(1);
            galpon.NombreGalpon = leer.GetString(2);
            galpon.AreaGalpon = leer.GetDouble(3);
            galpon.EstadoGalpon = leer.GetString(4);

            return galpon;
        }
    }
}



