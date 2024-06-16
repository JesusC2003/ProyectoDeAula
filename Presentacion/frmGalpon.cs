using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmGalpon : Form
    {
        public frmGalpon()
        {
            InitializeComponent();
            CargarDataGridView();
        }

        public void CargarDataGridView()
        {
            ServicioGalpon servicioGalpon = new ServicioGalpon();
            try
            {
                DataTable dataTable = ConvertirListaADataTable(servicioGalpon.listaGalpon());
                dgvGalpon.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private DataTable ConvertirListaADataTable(List<EntidadGalpon> listaDeGalpones)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("CODIGO", typeof(string));
            dataTable.Columns.Add("NOMBRE", typeof(string));
            dataTable.Columns.Add("AREA", typeof(decimal));
            dataTable.Columns.Add("ESTADO", typeof(string));

            foreach (var galpon in listaDeGalpones)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = galpon.IdGalpon;
                row["CODIGO"] = galpon.CodigoGalpon;
                row["NOMBRE"] = galpon.NombreGalpon;
                row["AREA"] = galpon.AreaGalpon;
                row["ESTADO"] = galpon.EstadoGalpon;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        private void ConfigurarDataGridView()
        {            
            dgvGalpon.AllowUserToAddRows = false; // Deshabilitar la opción de añadir filas por el usuario
            dgvGalpon.ReadOnly = false; // Asegurar que el DataGridView no sea solo de lectura
            dgvGalpon.Enabled = true; // Asegurar que el DataGridView esté habilitado

            // Asegurarse de que todas las filas y celdas no sean solo de lectura y sean visibles
            foreach (DataGridViewRow row in dgvGalpon.Rows)
            {
                row.ReadOnly = false;
                row.Visible = true;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBusquedaGalpon_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaGalpon.Text == "")
            {
                txtBusquedaGalpon.Text = "Busqueda";
                txtBusquedaGalpon.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaGalpon_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaGalpon.Text == "Busqueda")
            {
                txtBusquedaGalpon.Text = "";
                txtBusquedaGalpon.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaEmpleado.Text == "")
            {
                txtBusquedaEmpleado.Text = "Busqueda";
                txtBusquedaEmpleado.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaEmpleado.Text == "Busqueda")
            {
                txtBusquedaEmpleado.Text = "";
                txtBusquedaEmpleado.ForeColor = Color.Black;
            }
        }

        private void btnRegistrarAlimento_Click(object sender, EventArgs e)
        {
            frmAgregarAlimento Alimento = new frmAgregarAlimento();
            Alimento.Show();
        }
    }
}
