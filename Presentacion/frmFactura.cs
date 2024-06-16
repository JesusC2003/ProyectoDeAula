﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using System.Drawing.Printing;
using iTextSharp.tool.xml;
using System.Text.Json.Serialization;
using Logica;
using Entidad;

namespace Presentacion
{
   
    public partial class frmFactura : Form
    {
        ServicioEmpresa servicioEmpresa;
        public frmFactura()
        {
            InitializeComponent();
        }

        private bool IsValidFilePath(string path)
        {
            char[] invalidChars = Path.GetInvalidPathChars();
            foreach (char c in invalidChars)
            {
                if (path.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            GenerarFactura();
        }
        private void GenerarFactura()
        {
            servicioEmpresa = new ServicioEmpresa();
            EntidadEmpresa empresa = servicioEmpresa.GetEmpresa();

            SaveFileDialog guardar = new SaveFileDialog()
            {
                FileName = DateTime.Now.ToString("ddMMyyyy") + ".pdf",
                Filter = "PDF files (*.pdf)|*.pdf"
            };

            string paginahtml = Properties.Resources.PlantillaFactura.ToString();
            paginahtml = paginahtml.Replace("@NIT", empresa.NIT);
            paginahtml = paginahtml.Replace("@DireccionEmpresa", empresa.Direccion); //cambiar por los txt correspondientes
            paginahtml = paginahtml.Replace("@TelefonoEmpresa", empresa.Telefono);
            paginahtml = paginahtml.Replace("@CorreoEmpresa", empresa.Correo);
            paginahtml = paginahtml.Replace("@IdFactura", txtNombresCliente.Text);
            paginahtml = paginahtml.Replace("@Cliente", txtNombresCliente.Text); // Remplazando datos del PDF
            paginahtml = paginahtml.Replace("@Identificacion", txtidentificacionCliente.Text);
            paginahtml = paginahtml.Replace("@@tipoidentificacion", cmbTipoCliente.Text);
            paginahtml = paginahtml.Replace("@Telefono", txtTelefonoCliente.Text);
            paginahtml = paginahtml.Replace("@Correo", txtCorreoCliente.Text);
            paginahtml = paginahtml.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
            //se crea un string para recorrer las columnas 
            string fila = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvFacturacion.Rows)//se recorre todo lo que tenga fila
            {
                fila += "<tr>";
                fila += "<td>" + row.Cells["Item"].Value.ToString() + "</td>";
                fila += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                fila += "<td>" + row.Cells["Peso"].Value.ToString() + "</td>";
                fila += "<td>" + row.Cells["P.Unitario"].Value.ToString() + "</td>";
                fila += "</tr>";
                total += decimal.Parse(row.Cells["P.Unitario"].Value.ToString());
            }
            paginahtml = paginahtml.Replace("@Filas", fila);
            paginahtml = paginahtml.Replace("@Total", total.ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string fileName = guardar.FileName;
                if (IsValidFilePath(fileName))
                {
                    try
                    {
                        using (FileStream stream = new FileStream(fileName, FileMode.Create))
                        {
                            Document pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);

                            pdfdoc.Open();
                            pdfdoc.Add(new Phrase(""));

                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.fondo4, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(80, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfdoc.LeftMargin, pdfdoc.Top - 60);
                            pdfdoc.Add(img);

                            using (StringReader reader = new StringReader(paginahtml))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfdoc, reader);
                            }

                            pdfdoc.Close();
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Error en la ruta del archivo: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al generar el PDF: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("La ruta del archivo contiene caracteres inválidos.");
                }
            }
        }
        private void btnCancelaroperacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

