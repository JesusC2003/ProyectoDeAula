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
    public partial class frmAlimento : Form
    {
        public frmAlimento()
        {
            InitializeComponent();
        }

        private void txtBusquedaAlimento_Leave_1(object sender, EventArgs e)
        {
            if (txtBusquedaAlimento.Text == "")
            {
                txtBusquedaAlimento.Text = "Busqueda";
                txtBusquedaAlimento.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaAlimento_Enter_1(object sender, EventArgs e)
        {
            if (txtBusquedaAlimento.Text == "Busqueda")
            {
                txtBusquedaAlimento.Text = "";
                txtBusquedaAlimento.ForeColor = Color.Black;
            }
        }

        private void btnAñadirAlimento_Click(object sender, EventArgs e)
        {
            frmAgregarAlimento fmrAgregarAlimento = new frmAgregarAlimento();
            fmrAgregarAlimento.Show();
        }
    }
}
