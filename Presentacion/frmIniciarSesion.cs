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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void ValidarInfo()
        {
            string Usuario = this.txtUsuario.Text;
            string Contraseña = this.txtContraseña.Text;

            if (Usuario == "UNICESAR" && Contraseña == "12345")
            {
                frmPrincipal fmrMenu = new frmPrincipal(txtUsuario.Text);
                fmrMenu.Show();
                this.Hide();
                Vaciartodo();
            }
            else
            {
                    MessageBox.Show("Usuario o contraseña no valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vaciartodo(); 
            }

        }
        private void Vaciartodo()
        {
            txtContraseña.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }
     

        private void BtnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        private void BtnMinimizarsesion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnmostrarcontraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnmostrarcontraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            btnmostrarcontraseña.Visible = true;
            btnOcultarContraseña.Visible = false;
        }

        private void frmIniciarSession_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar=true;
            btnOcultarContraseña.Visible=false;
        }

        private void linkLblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmRegistrarUsuario frmRegistrarUsuario = new frmRegistrarUsuario();
            frmRegistrarUsuario.Show();
            txtContraseña.Text = "";
            txtUsuario.Text = "";

        }

        private void pnltitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            ValidarInfo();
        }
    }
}
