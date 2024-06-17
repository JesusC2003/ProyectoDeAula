﻿using Entidad;
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
    public partial class frmPollo : Form
    {
        string Lote = string.Empty;
        int opcion = 0;
        ServicioPollo servicioPollo;
        ServicioGalpon servicioGalpon;
        DataTable dataTable;
        public frmPollo()
        {
            InitializeComponent();
            servicioPollo = new ServicioPollo();
            servicioGalpon = new ServicioGalpon();
            CargarVista();
        }

        private void txtBusquedaPollo_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaPollo.Text == "")
            {
                txtBusquedaPollo.Text = "Busqueda";
                txtBusquedaPollo.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaPollo_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaPollo.Text == "Busqueda")
            {
                txtBusquedaPollo.Text = "";
                txtBusquedaPollo.ForeColor = Color.Black;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LlenarcmbGalpon();
            pnlGestionPollo.Enabled = true;
            txtRazaPollo.Focus();
            dgvPollo.Columns.Clear();
            btnModificar.Enabled = false;
            opcion = 1;
            InicializarDataTable();
            NuevoPanel();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPollo.SelectedRows.Count > 0)
                {
                    LlenarcmbGalpon();
                    pnlGestionPollo.Enabled = true;
                    txtRazaPollo.Focus();
                    dgvPollo.Columns.Clear();
                    btnNuevo.Enabled = false;
                    opcion = 2;
                    InicializarDataTable();
                    NuevoPanel();

                    DataGridViewRow filaSeleccionada = dgvPollo.SelectedRows[0];

                    int valorColumna = Convert.ToInt32(filaSeleccionada.Cells["ID POLLO"].Value);
                    servicioPollo = new ServicioPollo();
                    EntidadPollo pollo = new EntidadPollo();
                    pollo = servicioPollo.ConsultarPollo(valorColumna);
                    txtcodigoPollo.Text = pollo.CodigoPollo;
                    txtFechaIngreso.Text = Convert.ToString(pollo.FechaIngreso);
                    txtRazaPollo.Text = pollo.RazaPollo;
                    txtLote.Text = pollo.NumeroLote;
                    cmbEdadPollo.Text = pollo.EdadPollo;
                    cmbEstadoPollo.Text = pollo.EstadoPollo;
                    cmbGalpon.Text = pollo.IdGalpon.IdGalpon.ToString();


                }
                else { MessageBox.Show("seleccione una fila"); }
            }catch (Exception ex) { MessageBox.Show($"No hay fila seleccionada {ex}"); }
            
           
        }

        private void btnEliminarPollo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPollo_Click(object sender, EventArgs e)
        {
            switch (opcion) 
            {
                case 1: GuardarInfo();
                    btnModificar.Enabled=true;
                    break;
                case 2: MessageBox.Show("AQUI VA MODIFICAR INFO");
                    btnNuevo.Enabled = true;
                    break;
            }
        }

        private void btnQuitarPollo_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvPollo.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar las filas seleccionadas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Iterar sobre todas las filas seleccionadas y eliminarlas
                    foreach (DataGridViewRow filaSeleccionada in dgvPollo.SelectedRows)
                    {
                        dgvPollo.Rows.Remove(filaSeleccionada);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelarPollo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Si cancela la operación no se guardara ningún cambio ¿Está seguro de que desea cancelar la operación?","CANCELAR",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                LimpiarControles(pnlGestionPollo);
                CargarVista();
            }
            
        }

        //METODOS
        private void MapeoAEntidad()
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
                    pollo.IdGalpon = servicioGalpon.ConsultarGalpon(Convert.ToInt32(row["Galpon"]));
                    pollo.RazaPollo = Convert.ToString(row["RazaPollo"]);


                    listaPollos.Add(pollo);
                }

                servicioPollo.GuardarPollo(listaPollos);

                MessageBox.Show("Información guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable MapeoADataTable(List<EntidadPollo> listaDePollos)
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
        private bool EncontrarControleVacíos(Panel contenedor)
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
                else if (control.HasChildren && control is Panel)
                {
                    if (EncontrarControleVacíos((Panel)control))
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
                else if (control.HasChildren && control is Panel)
                {
                    LimpiarControles((Panel)control);
                }
            }
        }
        private void InicializarDataTable()
        {
            dataTable = new DataTable();

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
            try
            {
                DataRow row = dataTable.NewRow();
                row["FechaIngreso"] = Convert.ToDateTime(txtFechaIngreso.Text);
                row["EstadoPollo"] = cmbEstadoPollo.SelectedItem.ToString(); 
                row["NumeroLote"] = txtLote.Text;
                row["EdadPollo"] = cmbEdadPollo.SelectedItem.ToString(); 
                row["Galpon"] = cmbGalpon.SelectedValue.ToString();
                row["RazaPollo"] = txtRazaPollo.Text;

                dataTable.Rows.Add(row);
            }
            catch (Exception ex) { MessageBox.Show($"{ex}"); }
        }
        private void CargarVista()
        {
            servicioPollo = new ServicioPollo();
            try
            {
                dataTable = new DataTable();
                dataTable = MapeoADataTable(servicioPollo.ConsultarPollos());
                dgvPollo.DataSource = dataTable;
                BloquearControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }
        private void LlenarcmbGalpon()
        {
            cmbGalpon.SelectedIndex = -1;
            cmbGalpon.DataSource = servicioGalpon.ConsultarLosGalpones();
            cmbGalpon.DisplayMember = "NombreGalpon";
            cmbGalpon.ValueMember = "IdGalpon";

            
        }
        private void BloquearControles()
        {
            pnlGestionPollo.Enabled = false;
            txtFechaIngreso.ReadOnly = true;
            cmbEstadoPollo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void NuevoPanel()
        {
            LimpiarControles(pnlGestionPollo);
            txtLote.Text = Lote;
            
            txtFechaIngreso.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cmbEstadoPollo.Text = "Vivo";
            cmbEstadoPollo.Enabled = false;
            txtcodigoPollo.Enabled = false;
            txtFechaIngreso.Enabled= false;
            txtRazaPollo.Focus();
        }
        private bool ValidarDataGridView()
        {
            return dgvPollo.Rows.Count == 0 || (dgvPollo.Rows.Count == 1 && dgvPollo.Rows[0].IsNewRow);
        }
        private void GuardarInfo()
        {
            if (EncontrarControleVacíos(pnlGestionPollo))
            {
                MessageBox.Show("Complete todos los campos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Lote = txtLote.Text;
                AñadirInfoDatatable();
                LimpiarControles(pnlGestionPollo);
                DialogResult respuesta = MessageBox.Show("Información agregada con exito. ¿Desea continuar registrando datos?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    NuevoPanel();
                }
                else
                {
                    if (ValidarDataGridView())
                    {
                        MessageBox.Show("El DataGridView está vacío. No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    respuesta = MessageBox.Show("Confirme que desea guardar la información", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        MapeoAEntidad();
                        LimpiarControles(pnlGestionPollo);
                        BloquearControles();
                        CargarVista();
                    }
                }
            }
        }
    }
}
