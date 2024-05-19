using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion
{
    public partial class FmrMenuPrincipal : Form
    {
        public FmrMenuPrincipal()
        {
            InitializeComponent();
           
        }
        FmrPersonalGranja granja=new FmrPersonalGranja();

        public void BtnInventario_Click(object sender, EventArgs e)
        {
            SubMenuInventario.Visible = true;
        }

        public void BtnInventarioP_Click(object sender, EventArgs e)
        {

            AbrirFmr(new FmrInventarioPollo());
            SubMenuInventario.Visible = false;  
        }

        public void BtnInventarioG_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioGalpon());
            SubMenuInventario.Visible = false;
        }

        public void BtnInventarioM_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioMedicamento());
            SubMenuInventario.Visible = false;
        }

        public void BtnModificalPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
            SubMenuPersonal.Visible = false;
  
        }

        public void BtnEliminarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
            SubMenuPersonal.Visible = false;
        }

        public void BtnGuardarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
            SubMenuPersonal.Visible = false;
        }

        public void BtnPersonal_Click(object sender, EventArgs e)
        {
            SubMenuPersonal.Visible = true;
        }

        public void AbrirFmr(object Fmr)
        {
            if(this.panelFmr.Controls.Count > 0)
            {
                this.panelFmr.Controls.RemoveAt(0);

                Form fm = Fmr as Form;
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                this.panelFmr.Controls.Add(fm);
                this.panelFmr.Tag = fm;
                fm.Show();
            }
        }

        public void BtnPollo_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPollo());
        }

        private void BtnGalpon_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrGalpon());
        }

        private void BtnAlimento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrAlimento());
        }

        private void BtnMedicamento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrMedicamento());
        }
    }
}
