using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab4
{
    class Drawer
    {
        private Chart chart;
        private double maxY, minY;


        public Drawer(Chart chart) { this.chart = chart; }

        public void SetMaxMin(double value)
        {
            chart.ChartAreas[0].AxisX.Maximum = value + 3;
            chart.ChartAreas[0].AxisX.Minimum = value - 7;
        }
        public void Draw(double x, double y)
        {
            if (x > 7) SetMaxMin(x);
            chart.Series[0].Points.AddXY(x, y);
        }

        public void Start(double x, double y)
        {
            chart.Series[0].Points.Clear();
            SetMaxMin(7);
            Draw(x, y);
        }
    }
}
