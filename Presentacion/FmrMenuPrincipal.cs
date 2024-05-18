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
    public partial class FmrMenuPrincipal : Form
    {
        public FmrMenuPrincipal()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form Fmr)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = Fmr;
            Fmr.TopLevel = false;
            Fmr.FormBorderStyle = FormBorderStyle.None;
            Fmr.Dock = DockStyle.Fill;
            panelFmr.Controls.Add(Fmr);
            panelFmr.Tag = Fmr;
            Fmr.BringToFront();
            Fmr.Show();
        }
    }
}
