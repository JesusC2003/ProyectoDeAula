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

        private void BtnAgregarA_Click(object sender, EventArgs e)
        {
            frmAgregarAlimento fmrAgregarAlimento = new frmAgregarAlimento();   
            fmrAgregarAlimento.Show();  
        }

        private void TxtBusquedaAlimento_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaAlimento.Text == "Busqueda")
            {
                TxtBusquedaAlimento.Text = "";
                TxtBusquedaAlimento.ForeColor = Color.White;
            }
        }

        private void TxtBusquedaAlimento_Leave(object sender, EventArgs e)
        {
            if (TxtBusquedaAlimento.Text == "")
            {
                TxtBusquedaAlimento.Text = "Busqueda";
                TxtBusquedaAlimento.ForeColor = Color.White;
            }
        }
    }
}
