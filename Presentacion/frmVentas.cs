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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void txtBusquedaVentas_Leave_1(object sender, EventArgs e)
        {
            if (txtBusquedaVentas.Text == "")
            {
                txtBusquedaVentas.Text = "Busqueda";
                txtBusquedaVentas.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaVentas_Enter_1(object sender, EventArgs e)
        {
            if (txtBusquedaVentas.Text == "Busqueda")
            {
                txtBusquedaVentas.Text = "";
                txtBusquedaVentas.ForeColor = Color.Black;
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }
    }
 }

