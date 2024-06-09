using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Entidad;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RepositorioEmpresa : BaseDatosConexion
    {
        public RepositorioEmpresa() {  }

        //METODO PARA INSERTAR EMPRESA A LA BASE DE DATOS
        public string InsertEmpresa(Empresa empresa)
        {
            string query = "INSERT INTO EMPRESA (NIT, NOMBRE, TELEFONO, DIRECCION, CORREO) " +
                            "VALUES (:nit, :nombre, :telefono, :direccion, :correo)";

            string mensajeConexion = AbrirConexion();
            if (mensajeConexion.StartsWith("|ERROR DE CONEXION|"))
            {
                return mensajeConexion;
            }
            try 
            {
                using (OracleCommand Comando = new OracleCommand(query, ObtenerConexion()))
                {
                    return EjecutarInsercion(Comando, empresa);
                }
            } catch (OracleException ex) { return $"|ERROR|: {ex.Message}"; } 
            finally { CerrarConexion(); }
                     
        } 
        
        //METODO INSERTAR INFORMACION AL COMANDO
        private string EjecutarInsercion(OracleCommand COMANDO, Empresa empresa ) 
        {
            try
            {
                COMANDO.Parameters.Add("nit", OracleDbType.Varchar2).Value = empresa.NIT;
                COMANDO.Parameters.Add("nombre", OracleDbType.Varchar2).Value = empresa.Nombre;
                COMANDO.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empresa.Telefono;
                COMANDO.Parameters.Add("direccion", OracleDbType.Varchar2).Value = empresa.Direccion;
                COMANDO.Parameters.Add("correo", OracleDbType.Varchar2).Value = empresa.Correo;
                int FilasAfectadas = COMANDO.ExecuteNonQuery();
                return ConfirmarInsercion(FilasAfectadas);
            }
            catch (OracleException ex)
            {
                return $"|ERROR DE INSERCION| - El proceso no fue completado debido a: {ex.Message}";
            }            
        }
        
        //METODO PARA CONFIRMAR LA INSERCION DE LA INFORMACION DE EMPRESA
        private string ConfirmarInsercion(int FilasAfectadas)
        {
            if (FilasAfectadas > 0)
            {
                return "La información fue";
            }
            else
            {
                return "La información no fue guardada";
            }           
        }
        
        //METODO PARA CONSULTAR INFORMACION DE EMPRESA EN LA BASE DE DATOS
        public Empresa SelectEmpresa() 
        {
            OracleDataReader Leer;
            Empresa empresa = new Empresa();
            string query = "SELECT * FROM EMPRESA";
            try 
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    string mensajeConexion = AbrirConexion();
                    Leer= comando.ExecuteReader();
                    empresa = Map(Leer);
                    Leer.Close();
                    return empresa;
                }
            }catch (OracleException ex) { throw ex; }
            finally { CerrarConexion(); }
        }

        //METODO PARA CONVERTIR EL TIPO DE LA INFORMACION TRAIDA DE LA BASE DE DATOS A EMPRESA
        public Empresa Map(OracleDataReader leer) 
        {
            Empresa empresa = new Empresa();
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

        //METODO PARA ACTUALIZAR INFORMACION EN LA BASE DE DATOS
        public string UpdateEmpresa(Empresa empresa)
        {
            string query = "UPDATE EMPRESA SET NOMBRE = :nombre, TELEFONO = :telefono, DIRECCION = :direccion, CORREO = :correo " +
                           "WHERE NIT = :nit";
            AbrirConexion();
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = empresa.Nombre;
                    comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empresa.Telefono;
                    comando.Parameters.Add("direccion", OracleDbType.Varchar2).Value = empresa.Direccion;
                    comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = empresa.Correo;
                    comando.Parameters.Add("nit", OracleDbType.Varchar2).Value = empresa.NIT;

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return ConfirmarInsercion(filasAfectadas);
                }
            }
            catch (OracleException ex)
            {
                return $"|ERROR|: {ex.Message}";
            }
            finally
            {
                CerrarConexion();
            }
        }

        //METODO PARA CONFIRMAR SI EXISTE UN EMPRESA
        public bool ExisteEmpresa()
        {
            string query = "SELECT COUNT(*) FROM EMPRESA";
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    string mensajeConexion = AbrirConexion();
                    if (mensajeConexion.StartsWith("|ERROR DE CONEXION|"))
                    {
                        throw new InvalidOperationException(mensajeConexion);
                    }

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (OracleException ex)
            {
                throw new Exception($"Error al verificar la existencia de empresas: {ex.Message}", ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        //METODO PARA ELIMINAR LA INFORMCAION DE LA EMPRESA DE LA BASE DE DATOS
        public string DeleteEmpresa()
        {
            string query = "DELETE FROM EMPRESA";
            try
            {
                using (OracleCommand comando = new OracleCommand(query, ObtenerConexion()))
                {
                    AbrirConexion();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return "|MENSAJE DE CONFIRMACIÓN| - La información fue eliminada correctamente.";
                    }
                    else
                    {
                        return "|ADVERTENCIA| - No se encontró informacion en la base de datos.";
                    }
                }
            }
            catch (OracleException ex) { return $"|ERROR|: {ex.Message}"; }
            finally { CerrarConexion(); }
        }
    }
}
