using Entidad;
using Guna.UI2.WinForms;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.text.pdf.PdfDocument;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Presentacion
{
    public partial class frmEmpresa : Form
    {
        private static frmEmpresa instance;
        ServicioEmpresa servicioEmpresa;
        public frmEmpresa()
        {
            InitializeComponent();
            servicioEmpresa = new ServicioEmpresa();
        }
        public static frmEmpresa GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmEmpresa();
            }
            return instance;
        }
        private void FmrEmpresa_Load(object sender, EventArgs e)
        {
            Limpiar();
            DesbloquearControles(this);
            if (servicioEmpresa.RespuestaExisteEmpresa())
            {
                CargarInfo();
                BloquearControles(this);
            }
            else
            {               
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearControles(this);
            txtNITEmpresa.Enabled = false;
            btnModificar.Enabled = false;
            btnVolver.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EncontrarTextBoxVacios(this))
            {
                MessageBox.Show("Todos los campos son obligatorios","ADVERTENCIA",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!servicioEmpresa.RespuestaExisteEmpresa())
                {
                    MessageBox.Show(servicioEmpresa.Guardar(MapeoAEntidad()),"EN HORA BUENA!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(servicioEmpresa.Actualizar(MapeoAEntidad()),"EN HORA BUENA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta acción borrará tus datos de la base de datos de forma indefinida ¿Estás seguro que deseas continuar", "CONFIRMAR ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show(servicioEmpresa.EliminarEmpresa());
            }
            else
            {
                MessageBox.Show("Acción cancelada", "DIALOGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (servicioEmpresa.RespuestaExisteEmpresa())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor llene la información solicitada", "DIALOGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNITEmpresa.Focus();
            }
        }

        //METODO PARA DESBLOQUEAR CONTROLES PREDETERMINADOS
        private void DesbloquearControles(Control contenedor)
        {
            bool hayInformacion = servicioEmpresa.RespuestaExisteEmpresa();

            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox || control.Name == "btnGuardar" || control.Name == "btnEliminar")
                {
                    control.Enabled = true;
                }
                if (control.HasChildren)
                {
                    DesbloquearControles(control);
                }
            }
        }

        //METODO PARA BLOQUEAR  CONTROLES PREDETERMINADOS
        private void BloquearControles(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox || control.Name == "btnGuardar" || control.Name == "btnEliminar")
                {
                    control.Enabled = false;
                }

                if (control.HasChildren)
                {
                    BloquearControles(control);
                }
            }
        }

        //METODO PARA ENCONTRAR TEXTBOX VACIOS EN EL FORMULARIO
        private bool EncontrarTextBoxVacios(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        control.Focus();
                        return true;
                    }
                }
                if (control.HasChildren)
                {
                    if (EncontrarTextBoxVacios(control))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //METODO PARA CARGAR TODOS LOS DATOS DE LA BASE AL FORMULARIO
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
        
        //METODO PARA PASAR LA INFORMACION DE TEXTBOX A ENTIDAD
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
        
        //METODO PARA LIMPIAR TEXTBOX
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
