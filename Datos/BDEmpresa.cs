using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class BDEmpresa : BaseDatosConexion
    {
        private OracleCommand Comando;

        public BDEmpresa()
        {
            Comando = new OracleCommand();
        }

        public string InsertarEmpresa(Empresa empresa)
        {
            string query = "INSERT INTO Empresas (NIT, Nombre, Telefono, Direccion, Correo) " +
                            "VALUES (:NIT, :Nombre, :Telefono, :Direccion, :Correo)";

            using (OracleConnection connection = ObtenerConexion())
            {
                Comando.CommandText = query;
                Comando.Connection = connection;

                Comando.Parameters.Add("NIT", OracleDbType.Varchar2).Value = empresa.NIT;
                Comando.Parameters.Add("Nombre", OracleDbType.Varchar2).Value = empresa.Nombre;
                Comando.Parameters.Add("Telefono", OracleDbType.Varchar2).Value = empresa.Telefono;
                Comando.Parameters.Add("Direccion", OracleDbType.Varchar2).Value = empresa.Direccion;
                Comando.Parameters.Add("Correo", OracleDbType.Varchar2).Value = empresa.Correo;

                try
                {
                    AbrirConexion();
                    int rowsAffected = Comando.ExecuteNonQuery();
                    CerrarConexion();

                    if (rowsAffected > 0)
                    {
                        return "Se insertó la empresa correctamente.";
                    }

                    return "No se pudo insertar la empresa.";
                }
                catch (Exception ex)
                {
                    return $"Error al insertar la empresa: {ex.Message}";
                }
            }
        }
        



    }
}
