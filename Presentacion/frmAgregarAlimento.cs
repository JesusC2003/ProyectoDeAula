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
    public partial class frmAgregarAlimento : Form
    {
        public frmAgregarAlimento()
        {
            InitializeComponent();
        }

        private void BtnSalirAlimento_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
