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
    public partial class Form1 : Form
    {
        private Panel pnlContenedor;
        public Form1()
        {
            InitializeComponent();
            CrearPanelConSombra();
        }

        //private void CrearPanelConSombra()
        //{
        //    pnlContenedor = new Panel
        //    {
        //        Size = new Size(300, 200),
        //        Location = new Point(60, 60), // Ajustar la posición para que la sombra sea visible
        //        BackColor = Color.White
        //    };

        //    pnlSombra = new Panel
        //    {
        //        Size = new Size(pnlContenedor.Width + 10, pnlContenedor.Height + 10),
        //        Location = new Point(pnlContenedor.Left - 5, pnlContenedor.Top - 5),
        //        BackColor = Color.Gray,
        //        Visible = true
        //    };

        //    this.Controls.Add(pnlSombra);
        //    this.Controls.Add(pnlContenedor);
        //}

        private void CrearPanelConSombra()
        {
            pnlContenedor = new Panel
            {
                Size = new Size(300, 200),
                Location = new Point(50, 50),
                BackColor = Color.White
            };

            pnlContenedor.Paint += new PaintEventHandler(DibujarSombra);
            this.Controls.Add(pnlContenedor);
        }

        private void DibujarSombra(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            using (Graphics g = e.Graphics)
            {
                int sombraSize = 10;
                Rectangle rect = new Rectangle(sombraSize, sombraSize, panel.Width - sombraSize, panel.Height - sombraSize);
                using (Brush b = new SolidBrush(Color.FromArgb(100, Color.Gray)))
                {
                    g.FillRectangle(b, rect);
                }
            }
        }
    }
}
