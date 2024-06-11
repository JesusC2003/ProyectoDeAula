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
        }
        private void txtBusquedaGalpon_Leave_1(object sender, EventArgs e)
        {
                        if (txtBusquedaGalpon.Text == "")
            {
                txtBusquedaGalpon.Text = "Busqueda";
                txtBusquedaGalpon.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaGalpon_Enter_1(object sender, EventArgs e)
        {
            if (txtBusquedaGalpon.Text == "Busqueda")
            {
                txtBusquedaGalpon.Text = "";
                txtBusquedaGalpon.ForeColor = Color.Black;
            }
        }

        private void btnAñadirGalpon_Click(object sender, EventArgs e)
        {
            frmAgregarGalpon Agregargalpon = new frmAgregarGalpon();
            Agregargalpon.Show();
        }
    }
}
