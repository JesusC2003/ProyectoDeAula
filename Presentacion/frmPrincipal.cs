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
        public string nombreUsuario;
        public frmPrincipal(string nombreUsuario)
            {
                InitializeComponent();
                this.Load += new EventHandler(frmPrincipal_Load);
                this.nombreUsuario = nombreUsuario;
                lblUsuario.Text = "Conectado A: " + nombreUsuario;    
            }
        private void ShowFormInPanel(Form form)
        {
            // Limpiar cualquier control existente en el panel
            pnlContenedor.Controls.Clear();

            // Configurar el formulario a mostrar
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            pnlContenedor.Controls.Add(form);
            form.Show();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        frmPersonal granja = new frmPersonal();


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
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);

                Form fm = Fmr as Form;
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                this.pnlContenedor.Controls.Add(fm);
                this.pnlContenedor.Tag = fm;
                fm.Show();
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
            if (pnlContenedor.Controls.Count > 0 )
            {
                if (pnlsubconfiguracion.Visible)
                {
                    pnlsubconfiguracion.Visible = false;
                }
                else
                {
                    pnlsubconfiguracion.Parent = this;
                    pnlsubconfiguracion.BringToFront();
                    pnlsubconfiguracion.Visible = true;
                }
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
            DialogResult resultado = MessageBox.Show("¿Está seguro de cerrar sesión, " + nombreUsuario + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) { 
                this.Close();
                frmIniciarSession fmrIniciarSeccion = new frmIniciarSession();
                fmrIniciarSeccion.Show();
             }
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            AbrirFmr(new frmFactura());
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmmenuiniciar()); // Cambiar al formulario menuiniciar
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmmenuiniciar());
        }
    }
}
