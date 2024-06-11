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
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLblIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmIniciarSesion frmIniciarSession = new frmIniciarSesion();
            frmIniciarSession.Show();
            this.Hide();
        }

        private void btnOcultarContraseñaR_Click(object sender, EventArgs e)
        {
            txtContraseñaRegistrar.UseSystemPasswordChar = true;
            btnmostrarcontraseñaR.Visible = true;
            btnOcultarContraseñaR.Visible = false;
        }

        private void btnmostrarcontraseñaR_Click(object sender, EventArgs e)
        {
            txtContraseñaRegistrar.UseSystemPasswordChar = false;
            btnmostrarcontraseñaR.Visible = false;
            btnOcultarContraseñaR.Visible = true;
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            txtContraseñaRegistrar.UseSystemPasswordChar = true;
            btnOcultarContraseñaR.Visible = false;
        }


        private void pnltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
