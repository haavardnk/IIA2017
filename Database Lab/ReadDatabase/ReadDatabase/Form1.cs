using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ReadDatabase
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateGraph(List<Measurement> measurementList)
        {
            chart1.DataSource = measurementList;
            chart1.Series.Clear();
            chart1.Series.Add("Sensor Log");
            chart1.Series["Sensor Log"].ChartType = SeriesChartType.Line;
            chart1.Series["Sensor Log"].XValueType = ChartValueType.Time;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;

            chart1.ChartAreas[0].AxisX.Interval = 20;
            chart1.ChartAreas[0].AxisY.Minimum = 18;

            chart1.Series["Sensor Log"].XValueMember = "TimeStamp";
            chart1.Series["Sensor Log"].YValueMembers = "CelsiusValue";     
        }

        public void CalculateStats(List<Measurement> list)
        {
            var valueList = new List<double>();
            foreach (var measurement in list)
            {
               valueList.Add(measurement.CelsiusValue);
            }

            textAvg.Text = Math.Round(valueList.Average(), 2).ToString();
            textMin.Text = Math.Round(valueList.Min(), 2).ToString();
            textMax.Text = Math.Round(valueList.Max(), 2).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var measurementList = Measurement.GetMeasurements();
            gridMeasurementList.DataSource = measurementList;
            UpdateGraph(measurementList);

            CalculateStats(measurementList);

        }


    }
}
