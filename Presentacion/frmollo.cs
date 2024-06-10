
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Drawing;

namespace Presentacion
{
    public partial class frmPollo : Form
    {
        private string ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                         (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)));User Id=God;Password=God;";
        public frmPollo()
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
                    using (OracleCommand cmd = new OracleCommand("p_consultar_pollo", connection))
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
                        dgvPollo.DataSource = dt;
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void TxtBusquedapollo_Enter(object sender, EventArgs e)
        {
            if (txtBusquedapollo.Text == "Busqueda")
            {
                txtBusquedapollo.Text = "";
                txtBusquedapollo.ForeColor = Color.White;
            }
        }

        private void TxtBusquedapollo_Leave(object sender, EventArgs e)
        {
            if (txtBusquedapollo.Text == "")
            {
                txtBusquedapollo.Text = "Busqueda";
                txtBusquedapollo.ForeColor = Color.White;
            }
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            frmAgregarPollo pollo   = new frmAgregarPollo();
            pollo.Show();
        }
    }
}
