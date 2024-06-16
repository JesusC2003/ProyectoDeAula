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
    public partial class frmSalud : Form
    {
        public frmSalud()
        {
            InitializeComponent();
        }
        private void frmSalud_Load(object sender, EventArgs e)
        {
        
        }


        private void txtBusquedaSalud_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaSalud.Text == "")
            {
                txtBusquedaSalud.Text = "Busqueda";
                txtBusquedaSalud.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaSalud_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaSalud.Text == "Busqueda")
            {
                txtBusquedaSalud.Text = "";
                txtBusquedaSalud.ForeColor = Color.Black;
            }
        }

        private void btnControlPeso_Click(object sender, EventArgs e)
        {
           frmControldePeso frmControldePeso = new frmControldePeso();
            frmControldePeso.Show();
        }
    }
}
