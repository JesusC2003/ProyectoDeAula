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
    public class BDEmpresa : BaseDatosConexion
    {
    

        public BDEmpresa()
        {
        }

        public string InsertarEmpresa(Empresa empresa)
        {
            string query = "INSERT INTO EMPRESA (NIT, NOMBRE, TELEFONO, DIRECCION, CORREO) " +
                            "VALUES (:nit, :nombre, :telefono, :direccion, :correo);";

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
        public string EjecutarInsercion(OracleCommand COMANDO, Empresa empresa ) 
        {
            try
            {
                COMANDO.Parameters.Add("nit", OracleDbType.Varchar2).Value = empresa.NIT;
                COMANDO.Parameters.Add("nombre", OracleDbType.Varchar2).Value = empresa.Nombre;
                COMANDO.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empresa.Telefono;
                COMANDO.Parameters.Add("direccion", OracleDbType.Varchar2).Value = empresa.Direccion;
                COMANDO.Parameters.Add("correo", OracleDbType.Varchar2).Value = empresa.Correo;
                int ColumnasAfectadas = COMANDO.ExecuteNonQuery();
                return ConfirmarInsercion(ColumnasAfectadas);
            }
            catch (OracleException ex)
            {
                return $"|ERROR DE INSERCION| - El proceso no fue completado debido a: {ex.Message}";
            }
            
        }
        public string ConfirmarInsercion(int ColumnasAfectadas)
        {
            if (ColumnasAfectadas > 0)
            {
                return "|MENSAJE DE CONFORMACION| - La información fue guardada.";
            }
            else
            {
                return "|ADVERTENCIA| - La información no fue guardada";
            }           
        }






    }
}
