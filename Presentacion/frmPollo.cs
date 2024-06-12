
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Drawing;
using Logica;
using Entidad;
using System.Collections.Generic;

namespace Presentacion
{
    public partial class frmPollo : Form
    {
        ServicioPollo servicioPollo;
        //private string ConnectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                         //(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)));User Id=AdminHensys;Password=2024;";
        public frmPollo()
        {
            InitializeComponent();
            CargarDataGridView();
            //cargar();
        }

        //private void cargar()
        //{
        //    using (OracleConnection connection = new OracleConnection(ConnectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            using (OracleCommand cmd = new OracleCommand("F_ConsultarTodosLosPollos", connection))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                // Crear y configurar el parámetro de salida para el cursor
        //                OracleParameter cursorParameter = new OracleParameter();
        //                cursorParameter.OracleDbType = OracleDbType.RefCursor;
        //                cursorParameter.Direction = ParameterDirection.ReturnValue;
        //                cmd.Parameters.Add(cursorParameter);

        //                // Ejecutar el comando y llenar el DataTable con el cursor
        //                OracleDataAdapter adapta = new OracleDataAdapter(cmd);
        //                DataTable dt = new DataTable();
        //                adapta.Fill(dt);

        //                // Asignar el DataTable al DataGridView
        //                dgvPollo.DataSource = dt;

        //                connection.Close();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}
        
        private void txtBusquedapollo_Leave_1(object sender, EventArgs e)
        {
            if (txtBusquedapollo.Text == "")
            {
                txtBusquedapollo.Text = "Busqueda";
                txtBusquedapollo.ForeColor = Color.Black;
            }
        }

        private void txtBusquedapollo_Enter_1(object sender, EventArgs e)
        {
            if (txtBusquedapollo.Text == "Busqueda")
            {
                txtBusquedapollo.Text = "";
                txtBusquedapollo.ForeColor = Color.Black;
            }
        }
        private void btnAñadirPollo_Click(object sender, EventArgs e)
        {
            frmAgregarPollo pollo = new frmAgregarPollo();
            pollo.Show();
        }

        public void CargarDataGridView()
        {
            try
            {
                servicioPollo = new ServicioPollo();
                DataTable table = MapearListaADateTable(servicioPollo.Refrescarlista());
                dgvVista.DataSource = table;
            }
            catch (Exception ex) { MessageBox.Show($"No se pudieron cargar los datos debido a: {ex}"); }            
        }
        public DataTable MapearListaADateTable(List<EntidadPollo> listaDePollos)
        {
            DataTable table = CrearColumnas();

            foreach (var pollo in listaDePollos)
            {
                DataRow row = table.NewRow();
                row["ID"] = pollo.IdPollo;
                row["CODIGO"] = pollo.CodigoPollo;
                row["RAZA"] = pollo.RazaPollo;
                row["ESTADO"] = pollo.EstadoPollo;
                row["GALPON"] = pollo.IdGalpon.NombreGalpon;
                row["LOTE"] = pollo.LotePollo.NumeroLote;
                table.Rows.Add(row);
            }
            return table;
        }
        public DataTable CrearColumnas()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("CODIGO", typeof(string));
            dataTable.Columns.Add("RAZA", typeof(string));
            dataTable.Columns.Add("ESTADO", typeof(string));
            dataTable.Columns.Add("GALPON", typeof(string));
            dataTable.Columns.Add("LOTE", typeof(string));

            return dataTable;
        }

    }
}
