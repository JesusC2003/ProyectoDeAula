
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using Entidad;
using System.Collections.Generic;
using Logica;
using System.Diagnostics.Eventing.Reader;
using iTextSharp.tool.xml.html;

namespace Presentacion
{
    public partial class frmPollo : Form
    {
        string Lote = string.Empty;
        public ServicioPollo ServicioPollo;
        ServicioGalpon servicioGalpon;
        DataTable dataTable;
        public frmPollo()
        {
            ServicioPollo = new ServicioPollo();
            servicioGalpon = new ServicioGalpon();
            InitializeComponent();
            CargarVista();
        }

        //EVENTOS
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlGestion.Enabled = true;
            txtLote.Focus();
            dgvPollo.Columns.Clear();
            InicializarDataTable();
            NuevoPanel();
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (ValidarControlesVacíos(pnlGestion))
            {
                MessageBox.Show("Complete todos los campos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Lote = txtLote.Text;
                AñadirInfoDatatable();
                LimpiarControles(pnlGestion);
                DialogResult respuesta = MessageBox.Show("Información agregada con exito. ¿Desea continuar registrando datos?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    NuevoPanel();
                }
                else { BloquearControles(); }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDataGridView())
                {
                    MessageBox.Show("El DataGridView está vacío. No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ConvertirDataTableALista();
            } catch (Exception xe) { MessageBox.Show($"{xe}"); }           
        }


        //METODOS
        private DataTable ConvertirListaADataTable(List<EntidadPollo> listaDePollos)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID POLLO", typeof(int));
            dataTable.Columns.Add("CODIGO POLLO", typeof(string));
            dataTable.Columns.Add("RAZA POLLO", typeof(string));
            dataTable.Columns.Add("ESTADO POLLO", typeof(string));
            dataTable.Columns.Add("EDAD POLLO", typeof(string));
            dataTable.Columns.Add("NUMERO LOTE", typeof(string));
            dataTable.Columns.Add("FECHA INGRESO", typeof(DateTime));
            dataTable.Columns.Add("GALPON", typeof(string));


            foreach (var pollo in listaDePollos)
            {
                DataRow row = dataTable.NewRow();
                row["ID POLLO"] = pollo.IdPollo;
                row["CODIGO POLLO"] = pollo.CodigoPollo;
                row["RAZA POLLO"] = pollo.RazaPollo;
                row["ESTADO POLLO"] = pollo.EstadoPollo;
                row["EDAD POLLO"] = pollo.EdadPollo;
                row["NUMERO LOTE"] = pollo.NumeroLote;
                row["FECHA INGRESO"] = pollo.FechaIngreso;
                row["GALPON"] = pollo.IdGalpon.NombreGalpon;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        private void ConvertirDataTableALista()
        {
            List<EntidadPollo> listaPollos = new List<EntidadPollo>();

            try
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    EntidadPollo pollo = new EntidadPollo();

                    pollo.FechaIngreso = Convert.ToDateTime(row["FechaIngreso"]);
                    pollo.EstadoPollo = Convert.ToString(row["EstadoPollo"]);
                    pollo.NumeroLote = Convert.ToString(row["NumeroLote"]);
                    pollo.EdadPollo = Convert.ToString(row["EdadPollo"]);
                    pollo.IdGalpon = servicioGalpon.ConsultaGalpon(Convert.ToInt32(row["Galpon"]));
                    pollo.RazaPollo = Convert.ToString(row["RazaPollo"]);


                    listaPollos.Add(pollo);
                }

                ServicioPollo.GuardarPollo(listaPollos);

                MessageBox.Show("Información guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarVista()
        {
            ServicioPollo = new ServicioPollo();
            try
            {
                dataTable =new DataTable();
                dataTable = ConvertirListaADataTable(ServicioPollo.listapollo());
                dgvPollo.DataSource = dataTable;
                BloquearControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }
        private void BloquearControles()
        {
            pnlGestion.Enabled = false;
            txtFechaIngreso.ReadOnly = true;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void NuevoPanel()
        {            
            LimpiarControles(pnlGestion);
            txtLote.Text = Lote;
            txtFechaIngreso.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cmbEstado.Text = "Vivo";
            cmbEstado.Enabled = false;
            txtLote.Focus();     
        }
        private bool ValidarControlesVacíos (Panel contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        control.Focus();
                        return true;
                    }
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.SelectedItem == null || string.IsNullOrWhiteSpace(comboBox.Text))
                    {
                        control.Focus();
                        return true;
                    }
                }
                else if (control.HasChildren)
                {
                    if (ValidarControlesVacíos((Panel)control))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void LimpiarControles(Panel contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    LimpiarControles((Panel)control); 
                }
            }
        }
        private void InicializarDataTable()
        {
            dataTable= new DataTable();

            dataTable.Columns.Add("FechaIngreso", typeof(DateTime));
            dataTable.Columns.Add("EstadoPollo", typeof(string));
            dataTable.Columns.Add("NumeroLote", typeof(string));
            dataTable.Columns.Add("EdadPollo", typeof(string));
            dataTable.Columns.Add("Galpon", typeof(string));
            dataTable.Columns.Add("RazaPollo", typeof(string));

            dgvPollo.DataSource = dataTable;
        }
        private void AñadirInfoDatatable()
        {
            try {
                DataRow row = dataTable.NewRow();
                row["FechaIngreso"] = Convert.ToDateTime(txtFechaIngreso.Text);
                row["EstadoPollo"] = cmbEstado.SelectedItem.ToString(); // Usar SelectedItem para obtener el texto
                row["NumeroLote"] = txtLote.Text;
                row["EdadPollo"] = cmbEdad.SelectedItem.ToString(); // Usar SelectedItem para obtener el texto
                row["Galpon"] = cmbGalpon.SelectedItem.ToString(); // Usar SelectedItem para obtener el texto
                row["RazaPollo"] = txtRaza.Text;

                dataTable.Rows.Add(row);
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private bool ValidarDataGridView()
        {
            return dgvPollo.Rows.Count == 0 || (dgvPollo.Rows.Count == 1 && dgvPollo.Rows[0].IsNewRow);
        }

    }
}
