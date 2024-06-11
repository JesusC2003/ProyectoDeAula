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

        private void txtBusquedaPersonal_Leave_1(object sender, EventArgs e)
        {
            if (txtBusquedaPersonal.Text == "")
            {
                txtBusquedaPersonal.Text = "Busqueda";
                txtBusquedaPersonal.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaPersonal_Enter_1(object sender, EventArgs e)
        {
            if (txtBusquedaPersonal.Text == "Busqueda")
            {
                txtBusquedaPersonal.Text = "";
                txtBusquedaPersonal.ForeColor = Color.Black;
            }
        }

        private void btnAñadirPersonal_Click(object sender, EventArgs e)
        {
            frmAgregarPersonal fmrAgregarPersonal = new frmAgregarPersonal();
            fmrAgregarPersonal.Show();
        }
    }
}
