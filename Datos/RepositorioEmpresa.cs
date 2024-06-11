using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace Datos
{
    public class RepositorioEmpresa : BaseDatosConexion
    {
        public RepositorioEmpresa() { }

        // Método para insertar una empresa en la base de datos
        public string InsertarEmpresa(EntidadEmpresa empresa)
        {
            string query = "INSERT INTO EMPRESA (NIT, NOMBRE, TELEFONO, DIRECCION, CORREO) " +
                            "VALUES (:nit, :nombre, :telefono, :direccion, :correo)";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    return EjecutarInsercion(comando, empresa);
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                return $"|ERROR|: {ex.Message}";
            }
        }

        // Método para insertar la información en el comando
        private string EjecutarInsercion(OracleCommand comando, EntidadEmpresa empresa)
        {
            try
            {
                comando.Parameters.Add("nit", OracleDbType.Varchar2).Value = empresa.NIT;
                comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = empresa.Nombre;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empresa.Telefono;
                comando.Parameters.Add("direccion", OracleDbType.Varchar2).Value = empresa.Direccion;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = empresa.Correo;
                int filasAfectadas = comando.ExecuteNonQuery();
                ConfirmarTransaccion(comando.Transaction);
                return ConfirmarInsercion(filasAfectadas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método para confirmar la inserción de la información de la empresa
        private string ConfirmarInsercion(int filasAfectadas)
        {
            if (filasAfectadas > 0)
            {
                return "La información fue guardada correctamente.";
            }
            else
            {
                return "La información no fue guardada.";
            }
        }

        // Método para consultar la información de la empresa en la base de datos
        public EntidadEmpresa ConsultarEmpresa()
        {
            OracleDataReader lector;
            EntidadEmpresa empresa = new EntidadEmpresa();
            string query = "SELECT * FROM EMPRESA";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    lector = comando.ExecuteReader();
                    empresa = Mapeo(lector);
                    lector.Close();
                    ConfirmarTransaccion(comando.Transaction);
                    return empresa;
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                throw ex;
            }
        }
        public EntidadEmpresa ConsultarEmpresa(string nit)
        {
            OracleDataReader lector;
            EntidadEmpresa empresa = new EntidadEmpresa();
            string query = "SELECT * FROM EMPRESA";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    lector = comando.ExecuteReader();
                    empresa = Mapeo(lector);
                    lector.Close();
                    ConfirmarTransaccion(comando.Transaction);
                    return empresa;
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                throw ex;
            }
        }
        // Método para convertir el tipo de la información de la base de datos a empresa
        private EntidadEmpresa Mapeo(OracleDataReader leer)
        {
            EntidadEmpresa empresa = new EntidadEmpresa();
            if (leer.Read())
            {
                empresa.NIT = Convert.ToString(leer["NIT"]);
                empresa.Nombre = Convert.ToString(leer["NOMBRE"]);
                empresa.Telefono = Convert.ToString(leer["TELEFONO"]);
                empresa.Direccion = Convert.ToString(leer["DIRECCION"]);
                empresa.Correo = Convert.ToString(leer["CORREO"]);
            }
            return empresa;
        }

        // Método para actualizar la información en la base de datos
        public string ActualizarEmpresa(EntidadEmpresa empresa)
        {
            string query = "UPDATE EMPRESA SET NOMBRE = :nombre, TELEFONO = :telefono, DIRECCION = :direccion, CORREO = :correo " +
                           "WHERE NIT = :nit";

            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = empresa.Nombre;
                    comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empresa.Telefono;
                    comando.Parameters.Add("direccion", OracleDbType.Varchar2).Value = empresa.Direccion;
                    comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = empresa.Correo;
                    comando.Parameters.Add("nit", OracleDbType.Varchar2).Value = empresa.NIT;

                    int filasAfectadas = comando.ExecuteNonQuery();
                    ConfirmarTransaccion(comando.Transaction);
                    return ConfirmarInsercion(filasAfectadas);
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                return $"|ERROR|: {ex.Message}";
            }
        }

        // Método para verificar si existe una empresa
        public bool ExisteEmpresa()
        {
            string query = "SELECT COUNT(*) FROM EMPRESA";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    ConfirmarTransaccion(comando.Transaction);
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                throw new Exception($"Error al verificar la existencia de empresas: {ex.Message}", ex);
            }
        }

        // Método para eliminar la información de la empresa de la base de datos
        public string EliminarEmpresa()
        {
            string query = "DELETE FROM EMPRESA";
            OracleTransaction transaccion = IniciarTransaccion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Transaction = transaccion;
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        ConfirmarTransaccion(comando.Transaction);
                        return "|MENSAJE DE CONFIRMACIÓN| - La información fue eliminada correctamente.";
                    }
                    else
                    {
                        DeshacerTransaccion(comando.Transaction);
                        return "|ADVERTENCIA| - No se encontró información en la base de datos.";
                    }
                }
            }
            catch (Exception ex)
            {
                DeshacerTransaccion(transaccion);
                return $"|ERROR|: {ex.Message}";
            }
        }
    }
}
