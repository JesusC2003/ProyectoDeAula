using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{


    public partial class frmPrincipal : Form
    {
            public frmPrincipal()
            {
                InitializeComponent();
                Horayfecha.Enabled = true;
            }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        frmPersonal granja = new frmPersonal();



        private void Horayfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text =  DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");

        }


        private void BtnCerrarPrograma_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }


        public void AbrirFmr(object Fmr)
        {
            if (this.PnlContenedor.Controls.Count > 0)
            {
                this.PnlContenedor.Controls.RemoveAt(0);

                Form fm = Fmr as Form;
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                this.PnlContenedor.Controls.Add(fm);
                this.PnlContenedor.Tag = fm;
                fm.Show();
                lblHora.Visible = false;
                lblFecha.Visible= false;
            }
        }

        private void BtnPollo_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmPollo());   
        }

        private void BtnGalpon_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmGalpon());
        }

        private void BtnMedicamento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmMedicamento()); 
        }

        private void BtnAlimento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmAlimento());
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmPersonal());
        }



        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmVentas());
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (pnlsubconfiguracion.Visible==false)
            {
                pnlsubconfiguracion.Visible = true;
            }
            else
            {
                pnlsubconfiguracion.Visible=false;
            }

        }

        private void BtnDatosEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa frmempresa = frmEmpresa.GetInstance();
            frmempresa.Show();
            frmempresa.BringToFront();
            pnlsubconfiguracion.Visible = false;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmIniciarSeccion fmrIniciarSeccion= new frmIniciarSeccion();
            fmrIniciarSeccion.Show();
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmFactura());
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            lblFecha.Visible = true;
            lblHora.Visible = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }











        //// public void AbrirFmr(object Fmr)
        // {
        //     if (this.panelContenedor.Controls.Count > 0)
        //     {
        //         this.panelContenedor.Controls.RemoveAt(0);

        //         Form fm = Fmr as Form;
        //         fm.TopLevel = false;
        //         fm.Dock = DockStyle.Fill;
        //         this.panelContenedor.Controls.Add(fm);
        //         this.panelContenedor.Tag = fm;
        //         fm.Show();
        //         Titulo.Visible = false;
        //         labelHora.Visible = false;
        //         labelFecha.Visible = false;
        //     }
        // }
    }
}
