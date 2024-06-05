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
    public partial class FmrPersonal : Form
    {
        public FmrPersonal()
        {
            InitializeComponent();
        }

        private void BtnBuscarPersonal_Click(object sender, EventArgs e)
        {

        }

        private void dgvPersonal_Leave(object sender, EventArgs e)
        {
            if (TxtBusquedaPersonal.Text == "")
            {
                TxtBusquedaPersonal.Text = "Busqueda";
                TxtBusquedaPersonal.ForeColor = Color.White;
            }
        }

        private void dgvPersonal_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaPersonal.Text == "Busqueda")
            {
                TxtBusquedaPersonal.Text = "";
                TxtBusquedaPersonal.ForeColor = Color.White;
            }
        }

        private void BtnAgregarPersonal_Click(object sender, EventArgs e)
        {
            FmrAgregarPersonal fmrAgregarPersonal   = new FmrAgregarPersonal();
            fmrAgregarPersonal.Show();
        }
    }
}
