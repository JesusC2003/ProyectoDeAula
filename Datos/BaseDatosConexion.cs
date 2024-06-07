using Oracle.ManagedDataAccess.Client;
using System;

namespace Datos
{
    public class BaseDatosConexion
    {
        private string cadenaConexion = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) 
                                         (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=God;Password=God;";
        OracleConnection conexion;
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
                return "Ya está conectado a Oracle";
            }
            catch (OracleException xe) { return ($"|ERROR DE CONEXION| - {xe.Message}"); }            
        }

        public void CerrarConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
        public OracleConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
