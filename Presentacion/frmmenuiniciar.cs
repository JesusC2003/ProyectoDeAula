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
    public partial class frmmenuiniciar : Form
    {
        public frmmenuiniciar()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmmenuiniciar_Load);
        }

        private void frmmenuiniciar_Load(object sender, EventArgs e)
        {
            // Ruta de la imagen original (puedes cambiar esto a la ruta de tu imagen)
            string inputFile = "C:\\Users\\hewlett packard\\OneDrive\\Escritorio\\Segungod\\ProyectoDeAula\\Presentacion\\Resources\\Logo_Hensys.PNG";
            // Color que se quiere hacer transparente (por ejemplo, blanco)
            Color backgroundColor = Color.White;

            // Quitar el fondo de la imagen y mostrarla en el PictureBox
            Bitmap resultImage = RemoveBackground(inputFile, backgroundColor);

            // Mostrar la imagen original y la imagen con fondo transparente
            picoriginal.Image = new Bitmap(inputFile);
            picresultado.Image = resultImage;
        }
        private Bitmap RemoveBackground(string inputFile, Color backgroundColor)
        {
            using (Bitmap bitmap = new Bitmap(inputFile))
            {
                // Crear un nuevo Bitmap para la imagen resultante
                Bitmap resultBitmap = new Bitmap(bitmap.Width, bitmap.Height);

                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);

                        // Si el color del píxel es igual al color de fondo, hacerlo transparente
                        if (pixelColor.ToArgb() == backgroundColor.ToArgb())
                        {
                            resultBitmap.SetPixel(x, y, Color.Transparent);
                        }
                        else
                        {
                            resultBitmap.SetPixel(x, y, pixelColor);
                        }
                    }
                }

                return resultBitmap;
            }
        }
    }
}
