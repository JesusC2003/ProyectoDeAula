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
    public partial class frmAgregarPollo : Form
    {
        public frmAgregarPollo()
        {
            InitializeComponent();
        }

        private void BtnSalirPollo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}