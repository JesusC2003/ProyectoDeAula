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
using System.Net.NetworkInformation;
namespace Presentacion
{
    public partial class FmrMenuPrincipal : Form
    {
        public FmrMenuPrincipal()
        {
            InitializeComponent();
            HoraFecha.Enabled = true;
            OcultarSubMenu();
           
        }
        FmrPersonalGranja granja=new FmrPersonalGranja();

        [DllImport("user32.dll", EntryPoint= "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void MostrarSubMenu(Panel SubMenu)
        {
            if  (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenuInventario.Visible = false;
        }
        public void OcultarSubMenu()
        {
            SubMenuInventario.Visible = false;
            SubMenuPersonal.Visible = false;
        }
        public void BtnInventarioP_Click(object sender, EventArgs e)
        {

            AbrirFmr(new FmrInventarioPollo());
           
        }

        public void BtnInventarioG_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioGalpon());
        }

        public void BtnInventarioM_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioMedicamento());
           
        }

        public void BtnModificalPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
         
  
        }

        public void BtnEliminarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
           
        }

        public void BtnGuardarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
          
        }

        public void BtnPersonal_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuPersonal);
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

        private void BtnDeslizar_Click_1(object sender, EventArgs e)
        {
            if (panelbotones.Width == 199)
            {
                panelbotones.Width = 46;
            }
            else
            {
                panelbotones.Width = 199;
            }
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuInventario);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yy");
        }
    }
}
