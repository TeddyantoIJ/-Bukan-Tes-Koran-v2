using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _Bukan_TesKoran_7
{
    public partial class UiGrafik : UserControl
    {
        public int TotalBenar = 0;
        public bool done = false;

        public List<int> Strike = new List<int>();
        public UiGrafik()
        {
            InitializeComponent();
            TotalBenar = 0;
            bunifuElipse.ApplyElipse(panelHasil,15);
        }
        public void cekGrafik()
        {
            


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
            chart.AxisY.Interval = 1;

            chart1.Series.Add("Beruntun");
            chart1.Series["Beruntun"].ChartType = SeriesChartType.Line;
            chart1.Series["Beruntun"].Color = Color.Green;
            chart1.Series[0].IsVisibleInLegend = false;
            //MessageBox.Show(Strike.Count.ToString());

            for (int i = 1; i <= Strike.Count; i++)
            {
                //MessageBox.Show(Strike[i - 1].ToString());
                chart1.Series["Beruntun"].Points.AddXY(i, Strike[i - 1]);
            }


        }
        private void UiGrafik_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            done = true;
            this.Visible = false;
        }
    }
}
