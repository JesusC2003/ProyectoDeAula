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
    public partial class frmMedicamento : Form
    {
        public frmMedicamento()
        {
            InitializeComponent();
        }
        private void txtBusquedaMedicamento_Leave_1(object sender, EventArgs e)
        {
            if (txtBusquedaMedicamento.Text == "")
            {
                txtBusquedaMedicamento.Text = "Busqueda";
                txtBusquedaMedicamento.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaMedicamento_Enter_1(object sender, EventArgs e)
        {
            if (txtBusquedaMedicamento.Text == "Busqueda")
            {
                txtBusquedaMedicamento.Text = "";
                txtBusquedaMedicamento.ForeColor = Color.Black;
            }
        }

        private void btnAñadirMedicamento_Click(object sender, EventArgs e)
        {
            frmAgregarMedicamento fmrAgregarMedicamento = new frmAgregarMedicamento();
            fmrAgregarMedicamento.Show();
        }
    }
}
