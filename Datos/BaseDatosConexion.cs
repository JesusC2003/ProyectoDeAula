﻿using Oracle.ManagedDataAccess.Client;
using System;

namespace Datos
{
    public abstract class BaseDatosConexion
    {
        private string cadenaConexion = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                         "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=AdminHensys;Password=2024;";
        OracleConnection conexion;
        public BaseDatosConexion()
        {
            conexion = new OracleConnection(cadenaConexion);
        }
        protected bool AbrirConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                    return true;
                }
                return false; // Ya está conectado a Oracle
            }
            catch (OracleException ex){ throw new Exception($"|ERROR DE CONEXION| - {ex.Message}"); }
        }
        protected void CerrarConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
        protected OracleConnection ObtenerConexion()
        {
            return conexion;
        }
        

    }
}
