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
        ServicioEmpresa servicioEmpresa;
        public FmrEmpresa()
        {
            InitializeComponent();
            servicioEmpresa = new ServicioEmpresa();
        }
        private void FmrEmpresa_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarInfo();
            DesbloquearControles();
            BloquearControles();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
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
                if (!servicioEmpresa.RespuestaExisteEmpresa())
                {
                    MessageBox.Show(servicioEmpresa.Guardar(MapeoAEntidad()));
                }
                else
                {
                    MessageBox.Show(servicioEmpresa.Actualizar(MapeoAEntidad()));
                }
                this.Close();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            //FmrPrincipal fmrPrincipal = new FmrPrincipal();
            //fmrPrincipal.Show();
            this.Close();
        }

        //METODO PARA DESBLOQUEAR TODOS LOS CONTROLES
        private void DesbloquearControles()
        {
            foreach (Control control in panInfo.Controls)
            {
                if (control.Name != "txt.NitEmpresa")
                {
                    control.Enabled = true;
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

        //METODO PARA VALIDAR QUE NO HALLAN CAMPOS VACIOS
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
            }
            return true;
        }

        //METODO PARA MAPEAR LA INFORMCAION A LOS TEXTBOX
        private void CargarInfo()
        {
            Empresa empresa = new Empresa();
            empresa = servicioEmpresa.GetEmpresa();
            txtNITEmpresa.Text = empresa.NIT;
            txtNombreEmpresa.Text = empresa.Nombre;
            txtTelefonoEmpresa.Text = empresa.Telefono;
            txtDireccionEmpresa.Text = empresa.Direccion;
            txtCorreoEmpresa.Text = empresa.Correo;
        }
        private Empresa MapeoAEntidad()
        {
            Empresa empresa = new Empresa();
            empresa.NIT = txtNITEmpresa.Text;
            empresa.Nombre = txtNombreEmpresa.Text;
            empresa.Telefono = txtTelefonoEmpresa.Text;
            empresa.Direccion = txtDireccionEmpresa.Text;
            empresa.Correo = txtCorreoEmpresa.Text;
            return empresa;
        }
        private void Limpiar()
        {
            foreach (Control control in panInfo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text= string.Empty;
                }
            }
        }
    } 
}
