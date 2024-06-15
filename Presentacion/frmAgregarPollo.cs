using Entidad;
using System;
using Logica;
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
    public partial class frmAgregarPollo : Form
    {
        ServicioPollo servicioPollo;
        ServicioGalpon servicioGalpon;
        ServicioLote ServicioLote;
        public frmAgregarPollo()
        {
            servicioGalpon = new ServicioGalpon();
            ServicioLote = new ServicioLote();
            servicioPollo = new ServicioPollo();
            InitializeComponent();
        }
        private void btnSalirPollo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarPollo_Click(object sender, EventArgs e)
        {
            if (EncontrarTextBoxVacios(this))
            {
                MessageBox.Show("Todos los campos son obligatorios", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(servicioPollo.GuardarPollo(MapeoAEntidad()), "EN HORA BUENA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private EntidadPollo MapeoAEntidad()
        {
            EntidadPollo  pollo= new EntidadPollo();
            pollo.CodigoPollo = txtCodigoPollo.Text; 
            pollo.RazaPollo= cmbRazaPollo.SelectedItem.ToString();
            pollo.EstadoPollo= cmbEstado.SelectedItem?.ToString();
            pollo.IdGalpon = servicioGalpon.Consultar( cmbGalpon.SelectedIndex);
            pollo.LotePollo = ServicioLote.Consultar(cmbLote.SelectedIndex);


            return pollo;
        }

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
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
