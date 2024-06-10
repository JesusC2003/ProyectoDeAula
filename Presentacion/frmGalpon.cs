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

        private void BtnAgregarG_Click(object sender, EventArgs e)
        {
            frmAgregarGalpon Agregargalpon= new frmAgregarGalpon();
            Agregargalpon.Show();
        }

        private void TxtBusquedaGalpon_Leave(object sender, EventArgs e)
        {
            if (TxtBusquedaGalpon.Text == "")
            {
                TxtBusquedaGalpon.Text = "Busqueda";
                TxtBusquedaGalpon.ForeColor = Color.White;
            }
        }

        private void TxtBusquedaGalpon_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaGalpon.Text == "Busqueda")
            {
                TxtBusquedaGalpon.Text = "";
                TxtBusquedaGalpon.ForeColor = Color.White;
            }
        }
    }
}
