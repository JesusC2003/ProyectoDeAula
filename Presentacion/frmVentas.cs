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

        private void TxtBusquedaVentas_Leave(object sender, EventArgs e)
        {
            if (TxtBusquedaVentas.Text == "")
            {
                TxtBusquedaVentas.Text = "Busqueda";
                TxtBusquedaVentas.ForeColor = Color.White;
            }
        }

        private void TxtBusquedaVentas_Enter(object sender, EventArgs e)
        {
            if (TxtBusquedaVentas.Text == "Busqueda")
            {
                TxtBusquedaVentas.Text = "";
                TxtBusquedaVentas.ForeColor = Color.White;
            }
        }
    }
 }

