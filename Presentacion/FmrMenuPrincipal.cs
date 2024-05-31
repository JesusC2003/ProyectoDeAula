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
                SubMenu.Visible = false;
        }
        private void PersonalizarSubMenu()
        {
            SubMenuAlimento.Visible = false;
            SubMenuGalpon.Visible = false;
            PanelSubMenuMedicamento.Visible = false;
            PanelSubMenuPersonal.Visible = false;
            PanelSubMenuInventario.Visible = false;
            panelSubMenuPollo.Visible = false;
        }

        public void OcultarSubMenu()
        {
            SubMenuAlimento.Visible = false;
            SubMenuGalpon.Visible = false;
            PanelSubMenuMedicamento.Visible = false;
            PanelSubMenuPersonal.Visible = false;
            PanelSubMenuInventario.Visible = false;
            panelSubMenuPollo.Visible = false;
        }
        public void AbrirFmr(object Fmr)
        {
            if(this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);

                Form fm = Fmr as Form;
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fm);
                this.panelContenedor.Tag = fm;
                fm.Show();
                Titulo.Visible=false;
                labelHora.Visible=false;
                labelFecha.Visible=false;
            }
        }


        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void BtnPollo_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuPollo);
        }
        private void BtnGuardarPollo_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPollo());
            OcultarSubMenu();
        }

        private void BtnModificalPollo_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnEliminarPollo_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnGalpon_Click(object sender, EventArgs e)
        {
  
            MostrarSubMenu(SubMenuGalpon);
        }

        private void btnGuardarGalpon_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrGalpon());
            OcultarSubMenu();
        }

        private void BtnModificarGalpon_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnEliminarGalpon_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnAlimento_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuAlimento);
        }

        private void BtnGuardarAlimento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrAlimento());
            OcultarSubMenu();
        }

        private void BtnModificarAlimento_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnEliminarAlimento_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuMedicamento);
        }

        private void BtnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrMedicamento());

            OcultarSubMenu();
        }

        private void BtnModificarMedicamento_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuPersonal);
        }

        private void BtnGuardarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonalGranja());
            OcultarSubMenu();
        }

        private void BtnModificarPersonal_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnEliminarPersonal_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenuInventario);
        }

        private void BtnInventariopollo_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioPollo());
            OcultarSubMenu();
        }

        private void BtnInventarioMedicamento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioMedicamento());
            OcultarSubMenu();
        }

        private void BtnInventarioGalpon_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrInventarioGalpon());
            OcultarSubMenu();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
