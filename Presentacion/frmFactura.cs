using System;
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

namespace Presentacion
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog()
            {
                FileName = DateTime.Now.ToString("ddMMyyyy") + ".pdf",
                Filter = "PDF files (*.pdf)|*.pdf"
            };

            string paginahtml = Properties.Resources.PlantillaFactura.ToString();
            paginahtml = paginahtml.Replace("@Cliente", TxtNombreCliente.Text); // Remplazando datos del PDF
            paginahtml = paginahtml.Replace("@Documento", TxtCodigoCliente.Text);
            paginahtml = paginahtml.Replace("@Telefono", TxtTelefonoCliente.Text);
            paginahtml = paginahtml.Replace("@Correo", TxtCorreoCliente.Text);
            paginahtml = paginahtml.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));

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
    }
}

