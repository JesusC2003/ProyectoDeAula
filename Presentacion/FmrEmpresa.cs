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
using static iTextSharp.text.pdf.PdfDocument;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
        private void FmrEmpresa_Load(object sender, EventArgs e)
        {
            CargarInfo();
            BloquearControles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearControles(this);
            btnModificar.Enabled = false;
            btnVolver.Enabled = false;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarTextBoxNoVaciosEnPanel(panInfo))
            {
                MessageBox.Show("|ADVERTENCIA| - Debe llenar todos los campos");
            }
            else
            {
                empresa.NIT = txtNITEmpresa.Text;
                empresa.Nombre = txtNombreEmpresa.Text;
                empresa.Telefono = txtTelefonoEmpresa.Text;
                empresa.Direccion = txtDireccionEmpresa.Text;
                empresa.Correo = txtCorreoEmpresa.Text;
                MessageBox.Show(servicioEmpresa.Guardar(empresa));
                this.Close();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA DESBLOQUEAR TODOS LOS CONTROLES
        private void DesbloquearControles(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                control.Enabled = true;

                if (control.HasChildren)
                {
                    DesbloquearControles(control);
                }
            }
        }

        //METODO PARA BLOQUEAR  CONTROLES PREDETERMINADOS
        private void BloquearControles()
        {
            panInfo.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;
        }
 
        //METODO PARA VALIDAR QUE EL NO HALLAN CAMPOS VACIOS
        private bool ValidarTextBoxNoVaciosEnPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
                if (control.HasChildren)
                {
                    return ValidarTextBoxNoVaciosEnPanel((Panel)control);
                }
            }
            return true; 
        }

        //METODO PARA CARGAR LA INFORMCAION EN LOS CAMPOS
        private void CargarInfo()
        {
            empresa = servicioEmpresa.GetEmpresa();
            txtNITEmpresa.Text = empresa.NIT;
            txtNombreEmpresa.Text = empresa.Nombre;
            txtTelefonoEmpresa.Text = empresa.Telefono;
            txtDireccionEmpresa.Text = empresa.Direccion;
            txtCorreoEmpresa.Text = empresa.Correo;
        }


    }
}
