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
    public partial class frmmenuiniciar : Form
    {
        public frmmenuiniciar()
        {
            InitializeComponent();
            FechayHora.Enabled = true;
        }
        private void FechayHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
        }
    }
}
