﻿using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioFactura : BaseDatosConexion
    {
        RepositorioCliente repositorioCliente;
        RepositorioEmpresa repositorioEmpresa;
        public RepositorioFactura() 
        {
            repositorioCliente = new RepositorioCliente();
            repositorioEmpresa = new RepositorioEmpresa();
        }

        
        public EntidadFactura ConsultarFactura(int IdFactura)
        {
            List<EntidadFactura> entidadFactura = ConsultarTodoFactura();
            foreach (EntidadFactura Factura in entidadFactura)
            {
                if (Factura.IdFactura == IdFactura)
                {
                    return Factura;
                }
            }
            return null;
        }

        public List<EntidadFactura> ConsultarTodoFactura()
        {
            List<EntidadFactura> ListaDeFacturas = new List<EntidadFactura>();
            try
            {
                using (OracleConnection connection = ObtenerConexion())
                {
                    using (OracleCommand cmd = new OracleCommand("F_ConsultarTodasLasFacturas", connection))
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
                                ListaDeFacturas.Add(MapeoFactura(lector));
                            }
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Error de Oracle al consultar las Facturas: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar las Facturas: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return ListaDeFacturas;
        }

        // Método para mapear de una fila de la tabla a la entidad Factura
        private EntidadFactura MapeoFactura(OracleDataReader lector)
        {
            EntidadFactura factura = new EntidadFactura();

            try
            {
                factura.IdFactura = lector.GetInt32(lector.GetOrdinal("ID_FACTURA"));
                factura.CodigoFactura = lector.GetString(lector.GetOrdinal("CODIGO_FACTURA"));
                factura.FechaFactura = lector.GetDateTime(lector.GetOrdinal("FECHAFACTURA"));
                factura.MontoTotal = lector.GetDouble(lector.GetOrdinal("MONTOTOTAL"));
                //factura.IdCliente = lector.GetInt32(lector.GetOrdinal("ID_CLIENTE"));
                factura.NitEmpresa = repositorioEmpresa.ConsultarEmpresa( lector.GetString(lector.GetOrdinal("NITEMPRESA")));
            }
            catch (InvalidCastException ex)
            {
                throw new Exception($"Error de conversión en el mapeo de EntidadFactura: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception($"Error de índice fuera de rango en el mapeo de EntidadFactura: {ex.Message}");
            }

            return factura;
        }

    }
}

