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
    public partial class FmrIniciarSeccion : Form
    {
        public FmrIniciarSeccion()
        {
            InitializeComponent();
        }
        private void ValidarInfo()
        {
            string Usuario = this.txtUsuario.Text;
            string Contraseña = this.txtContraseña.Text;

            if (Usuario == "UNICESAR" && Contraseña == "12345")
            {
                FmrMenuPrincipal fmrMenu = new FmrMenuPrincipal();
                fmrMenu.Show();
                this.Hide();
                Vaciartodo();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no valido","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Vaciartodo();
            }
        }
        private void Vaciartodo()
        {
            txtContraseña.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor= Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar= true;

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            ValidarInfo();
        }
    }
}
