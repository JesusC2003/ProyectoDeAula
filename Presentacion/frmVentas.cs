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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
        private void GraficaPastel()
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
            series.Points.AddXY("Vendido", 30);
            series.Points.AddXY("Disponible", 50);

            // Configurar las etiquetas para mostrar números
            foreach (var point in series.Points)
            {
                point.Label = "#VALY"; // Mostrar el valor numérico
                point.LegendText = "#VALX (#VALY)"; // Mostrar valor de la categoría y el número en la leyenda
            }

            // Añadir la serie al gráfico
            chart.Series.Add(series);

            // Calcular el total
            double total = 0;
            foreach (var point in series.Points)
            {
                total += point.YValues[0];
            }

            // Opcional: Personalizar la leyenda
            Legend legend = new Legend
            {
                Name = "MiLeyenda",
                Docking = Docking.Bottom,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                BackColor = System.Drawing.Color.LightGray
            };

            // Agregar la leyenda al gráfico
            chart.Legends.Add(legend);

            // Agregar una entrada personalizada para el total
            LegendItem legendItem = new LegendItem
            {
                Name = "Total de Pollos: " + total,
                BorderColor = System.Drawing.Color.Transparent
            };
            chart.Legends["MiLeyenda"].CustomItems.Add(legendItem);

            // Añadir el control Chart al panel
            this.pnlGraficaPastel.Controls.Add(chart);
        }



        private void GraficaBarra()
        {
            // Crear el control Chart
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Crear un área de gráfico
            ChartArea chartArea = new ChartArea();

            // Configurar el eje X para mostrar los meses
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotar las etiquetas si es necesario para mejor visualización

            chart.ChartAreas.Add(chartArea);

            // Crear una serie y añadir datos
            Series series = new Series
            {
                Name = "Ventas",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Column
            };

            // Añadir datos a la serie
            series.Points.AddXY("Enero", 500);
            series.Points.AddXY("Febrero", 700);
            series.Points.AddXY("Marzo", 300);
            series.Points.AddXY("Abril", 400);
            series.Points.AddXY("Mayo", 600);
            series.Points.AddXY("Junio", 750);
            series.Points.AddXY("Julio", 200);
            series.Points.AddXY("Agosto", 500);
            series.Points.AddXY("Septiembre", 650);
            series.Points.AddXY("Octubre", 800);
            series.Points.AddXY("Noviembre", 900);
            series.Points.AddXY("Diciembre", 1000);

            // Añadir la serie al gráfico
            chart.Series.Add(series);

            // Opcional: Personalizar la leyenda
            Legend legend = new Legend
            {
                Name = "Meses",
                Docking = Docking.Bottom,
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.LightGray
            };

            // Agregar la leyenda al gráfico
            chart.Legends.Add(legend);

            // Añadir el control Chart al panel
            this.pnlGraficaBarra.Controls.Add(chart);
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            GraficaBarra();
            GraficaPastel();
        }

        private void txtBusquedaVentas_Leave(object sender, EventArgs e)
        {
            if (txtBusquedaVentas.Text == "")
            {
                txtBusquedaVentas.Text = "Busqueda";
                txtBusquedaVentas.ForeColor = Color.Black;
            }
        }

        private void txtBusquedaVentas_Enter(object sender, EventArgs e)
        {
            if (txtBusquedaVentas.Text == "Busqueda")
            {
                txtBusquedaVentas.Text = "";
                txtBusquedaVentas.ForeColor = Color.Black;
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFactura frmFactura = new frmFactura();
            frmFactura.Show();
        }
    }
 }

