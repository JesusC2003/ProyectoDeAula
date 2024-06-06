using Oracle.ManagedDataAccess.Client;
using System;

namespace Datos
{
    public class BaseDatosConexion
    {
        private string cadenaConexion = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) 
                                         (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)));User Id=Master;Password=123456;";
        OracleConnection conexion = null;
        public BaseDatosConexion()
        {
            conexion = new OracleConnection(cadenaConexion);
        }
        public string AbrirConexion()
        {
            try {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                    return $"Conectado a Oracle: {conexion.ServerVersion}";
                }
                return "Ya se encuentra conectado a Oracle";
            }
            catch (Exception e) { return ($"|ERROR DE CONEXION| - {e.Message}"); }            
        }
        public string CerrarConexion()
        {
            conexion.Close();
            return $"Desconectado de Oracle: {conexion.ServerVersion}";
        }
        public OracleConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
