
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FmrPollo : Form
    {
        private string ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                         (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)));User Id=Master;Password=123456;";
        public FmrPollo()
        {
            InitializeComponent();
            cargar();
        }

        
        private void cargar()
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString))
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("consultarpollo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        OracleParameter cursorParameter = new OracleParameter();
                        cursorParameter.OracleDbType = OracleDbType.RefCursor;
                        cursorParameter.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cursorParameter);
                        //cmd.Parameters.Add("registros",OracleType.Cursor).Direction=ParameterDirection.Output;
                        OracleDataAdapter adapta = new OracleDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapta.Fill(dt);
                        dtgPollo.DataSource = dt;
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (OracleConnection connection = new OracleConnection(ConnectionString))
        //        try
        //        {
        //            connection.Open();
        //            using (OracleCommand cmd = new OracleCommand("consultarpollo", connection)) 
        //            { 
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                OracleParameter cursorParameter = new OracleParameter();
        //                cursorParameter.OracleDbType = OracleDbType.RefCursor;
        //                cursorParameter.Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add(cursorParameter);
        //                //cmd.Parameters.Add("registros",OracleType.Cursor).Direction=ParameterDirection.Output;
        //                OracleDataAdapter adapta = new OracleDataAdapter(cmd);
        //                DataTable dt = new DataTable();
        //                adapta.Fill(dt);
        //                dtgPollo.DataSource = dt;
        //                connection.Close();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //}
    }
}
