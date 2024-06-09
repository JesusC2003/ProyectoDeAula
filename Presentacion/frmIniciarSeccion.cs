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
    public partial class frmIniciarSeccion : Form
    {
        public frmIniciarSeccion()
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
                frmPrincipal fmrMenu = new frmPrincipal();
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

        private void BtnRestaurarsesion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurarsesion.Visible = false;
            BtnMaximizarSesion.Visible = true;
        }

        private void BtnMinimizarsesion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizarSesion_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizarSesion.Visible = false;
            BtnRestaurarsesion.Visible = true;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Leave_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;

            }
        }

        private void BtnAcceder_Click_1(object sender, EventArgs e)
        {
            ValidarInfo();
        }
    }
}
