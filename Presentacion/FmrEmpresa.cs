using Entidad;
using Logica;
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
    public partial class FmrEmpresa : Form
    {
        Empresa empresa;
        ServicioEmpresa servicioEmpresa;
        public FmrEmpresa()
        {
            InitializeComponent();
            empresa = new Empresa();
            servicioEmpresa = new ServicioEmpresa();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            empresa.NIT = txtNITEmpresa.Text;
            empresa.Nombre =txtNombreEmpresa.Text;
            empresa.Telefono = txtTelefonoEmpresa.Text;
            empresa.Direccion = txtDireccionEmpresa.Text;
            empresa.Correo = txtCorreoEmpresa.Text;
            MessageBox.Show(servicioEmpresa.Guardar(empresa));

        }
    }
}
