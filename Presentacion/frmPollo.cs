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
        public frmPollo()
        {
            InitializeComponent();
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
    }
}
