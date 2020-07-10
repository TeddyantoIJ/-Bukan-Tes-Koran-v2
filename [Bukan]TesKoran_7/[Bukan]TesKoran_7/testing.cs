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

namespace _Bukan_TesKoran_7
{
    public partial class testing : Form
    {
        new List<int> Strike = new List<int>();
        public testing()
        {
            InitializeComponent();
            cekGrafik();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        public void cekGrafik()
        {
            Strike.Add(10);
            Strike.Add(15);
            Strike.Add(20);
            Strike.Add(30);
            Strike.Add(40);


            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = Strike.Count;

            chart.AxisY.Minimum = Strike.Min();
            chart.AxisY.Maximum = Strike.Max();

            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Beruntun");
            chart1.Series["Beruntun"].ChartType = SeriesChartType.Line;
            chart1.Series["Beruntun"].Color = Color.Green;
            chart1.Series[0].IsVisibleInLegend = true;
            MessageBox.Show(Strike.Count.ToString());

            for (int i = 1; i <= Strike.Count; i++)
            {
                MessageBox.Show(Strike[i-1].ToString());
                chart1.Series["Beruntun"].Points.AddXY(i, Strike[i-1]);
            }


        }
    }
}
