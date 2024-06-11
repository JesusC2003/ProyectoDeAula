﻿
using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

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
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarPollo", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("p_id_pollo", OracleDbType.Int32).Value = idPollo;
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

        // Método para consultar todas las filas de la tabla POLLO
        public List<EntidadPollo> ConsultarTodosLosPollos()
        {
            List<EntidadPollo> listaPollos = new List<EntidadPollo>();
            if (AbrirConexion())
            {
                try
                {
                    using (OracleCommand comando = new OracleCommand("F_ConsultarTodosLosPollos", ObtenerConexion()))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        using (OracleDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                listaPollos.Add(Mapeo(lector));
                            }
                            return listaPollos;
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

        // Método para mapear de una fila de la tabla a la entidad POLLO
        private EntidadPollo Mapeo(OracleDataReader leer)
        {
            EntidadPollo pollo = new EntidadPollo();
            pollo.IdPollo = leer.GetInt32(0);
            pollo.CodigoPollo = leer.GetString(1);
            pollo.RazaPollo = leer.GetString(2);
            pollo.EstadoPollo = leer.GetString(3);
            pollo.IdGalpon = RepositorioGalpon.ConsultarGalpon(leer.GetInt32(4));
            pollo.LotePollo = RepositorioLote.ConsultarLote(leer.GetInt32(5));
            pollo.IdDetalleFactura = RepositorioDetalleFactura.ConsultarDetalleFactura(leer.GetInt32(6));

            return pollo;
        }
    }
}
