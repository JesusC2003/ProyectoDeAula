using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
            Horayfecha.Enabled = true;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        FmrPersonal granja = new FmrPersonal();



        private void BtnDeslizar_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 185)
            {
                panelMenuVertical.Width= 50;

            }
            else
            {

                panelMenuVertical.Width = 185;
            }
        }



        private void Horayfecha_Tick(object sender, EventArgs e)
        {
            laHora.Text =  DateTime.Now.ToString("hh:mm:ss tt");
            Fecha.Text = DateTime.Now.ToString("dd/MM/yy");

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
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);

                Form fm = Fmr as Form;
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fm);
                this.PanelContenedor.Tag = fm;
                fm.Show();
                laHora.Visible = false;
                Fecha.Visible= false;
            }
        }

        private void BtnPollo_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPollo());   
        }

        private void BtnGalpon_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrGalpon());
        }

        private void BtnMedicamento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrMedicamento()); 
        }

        private void BtnAlimento_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrAlimento());
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrPersonal());
        }



        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrVentas());
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (panelsubconfiguracion.Visible==false)
            {
                panelsubconfiguracion.Visible = true;
            }
            else
            {
                panelsubconfiguracion.Visible=false;
            }

        }

        private void BtnDatosEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFmr(new FmrEmpresa());
            panelsubconfiguracion.Visible = false;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FmrIniciarSeccion fmrIniciarSeccion= new FmrIniciarSeccion();
            fmrIniciarSeccion.Show();
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
