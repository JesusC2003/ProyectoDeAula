using Oracle.ManagedDataAccess.Client;
using System;

namespace Datos
{
    public abstract class BaseDatosConexion 
    {
        private string cadenaConexion = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                         "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XEPDB1)));User Id=AdminHensys;Password=2024;";
        OracleConnection conexion;
        protected BaseDatosConexion()
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
                return false;
            }
            catch (OracleException ex)
            {
                throw new Exception($"Error al abrir la conexión: {ex.Message}", ex);
            }
        }

        protected void CerrarConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        protected OracleTransaction IniciarTransaccion()
        {
            try
            {
                AbrirConexion();
                return conexion.BeginTransaction();
            }
            catch (OracleException ex)
            {
                CerrarConexion();
                throw new Exception($"Error al iniciar la transacción: {ex.Message}", ex);
            }
        }

        protected void ConfirmarTransaccion(OracleTransaction transaccion)
        {
            try
            {
                transaccion.Commit();
            }
            catch (OracleException ex)
            {
                transaccion.Rollback();
                CerrarConexion();
                throw new Exception($"Error al confirmar la transacción: {ex.Message}", ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        protected void DeshacerTransaccion(OracleTransaction transaccion)
        {
            try
            {
                transaccion.Rollback();
            }
            catch (OracleException ex)
            {
                CerrarConexion();
                throw new Exception($"Error al deshacer la transacción: {ex.Message}", ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        protected OracleConnection ObtenerConexion()
        {
            return conexion;
        }

    }
}
