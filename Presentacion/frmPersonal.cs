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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void BtnBuscarPersonal_Click(object sender, EventArgs e)
        {

        }
        private void TxtBusquedaPersonal_Leave(object sender, EventArgs e)
        {
            if (TxtBusquedaPersonal.Text == "")
            {
                TxtBusquedaPersonal.Text = "Busqueda";
                TxtBusquedaPersonal.ForeColor = Color.White;
            }
        }

        private void TxtBusquedaPersonal_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaPersonal.Text == "Busqueda")
            {
                TxtBusquedaPersonal.Text = "";
                TxtBusquedaPersonal.ForeColor = Color.White;
            }
        }

        private void BtnAgregarPersonal_Click(object sender, EventArgs e)
        {
            frmAgregarPersonal fmrAgregarPersonal   = new frmAgregarPersonal();
            fmrAgregarPersonal.Show();
        }

        private void FmrPersonal_Load(object sender, EventArgs e)
        {

        }



        private void TxtBusquedaPersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboFiltradoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEditarPersonal_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerPersonal_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarPersonal_Click(object sender, EventArgs e)
        {

        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
