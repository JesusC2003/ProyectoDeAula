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
        private void txtBusquedaPersonal_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaPersonal.Text == "")
            {
                txtBusquedaPersonal.Text = "Busqueda";
                txtBusquedaPersonal.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaPersonal_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaPersonal.Text == "Busqueda")
            {
                txtBusquedaPersonal.Text = "";
                txtBusquedaPersonal.ForeColor = Color.Black;
            }
        }
    }
}
