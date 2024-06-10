﻿using System;
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



        private void BtnAgregarM_Click(object sender, EventArgs e)
        {
            frmAgregarMedicamento fmrAgregarMedicamento = new frmAgregarMedicamento();
            fmrAgregarMedicamento.Show();
        }

        private void TxtBusquedaMedicamento_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaMedicamento.Text == "")
            {
                txtBusquedaMedicamento.Text = "Busqueda";
                txtBusquedaMedicamento.ForeColor = Color.White;
            }
        }

        private void TxtBusquedaMedicamento_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaMedicamento.Text == "Busqueda")
            {
                txtBusquedaMedicamento.Text = "";
                txtBusquedaMedicamento.ForeColor = Color.White;
            }
        }
    }
}
