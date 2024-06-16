using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class frmSalud : Form
    {
        public frmSalud()
        {
            InitializeComponent();
        }
        private void frmSalud_Load(object sender, EventArgs e)
        {
            Grafica();
        }

        private void Grafica()
        {
            // Crear el control Chart
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Crear un área de gráfico
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Crear una serie y añadir datos
            Series series = new Series
            {
                Name = "Series1",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            // Añadir datos a la serie
            series.Points.AddXY("Vivo", 30);
            series.Points.AddXY("Muerto", 20);

            // Configurar las etiquetas para mostrar porcentajes
            foreach (var point in series.Points)
            {
                point.Label = "#PERCENT{P1}"; // P1 muestra el porcentaje con 1 decimal
                point.LegendText = "#VALX (#PERCENT{P1})"; // Mostrar valor de la categoría y porcentaje en la leyenda
            }

            // Añadir la serie al gráfico
            chart.Series.Add(series);

            // Opcional: Personalizar la leyenda
            
            Legend legend = new Legend
            {
                Name = "MiLeyenda",
                Docking = Docking.Bottom,
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.LightGray
            };
            chart.Legends.Add(legend);

            // Añadir el control Chart al panel
            this.pnlGrafica.Controls.Add(chart);
        }
        private void txtBusquedaSalud_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaSalud.Text == "")
            {
                txtBusquedaSalud.Text = "Busqueda";
                txtBusquedaSalud.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaSalud_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaSalud.Text == "Busqueda")
            {
                txtBusquedaSalud.Text = "";
                txtBusquedaSalud.ForeColor = Color.Black;
            }
        }


    }
}
