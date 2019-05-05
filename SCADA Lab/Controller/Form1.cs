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

namespace Controller
{
    public partial class Form1 : Form
    {
        public PidController Controller = new PidController(0.0,0.0,0.0, 5.0, 0.0);
        public Simulator Sim = new Simulator(0.0,0.0,0.0,0.0);
        public List<Measurement> MeasurementList= new List<Measurement>();

        public Opc ToutOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Tout");
        public Opc TenvOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Tenv");
        public Opc ControlSignalOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.ControlSignal");
        public Opc SetpointOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Setpoint");

        public DaqAi Tout;
        public DaqAi Tenv;
        public DaqAo ControlSignal;

        public DaqAi RegOutput;
        public DaqAo RegInput;


        public Form1()
        {
            InitializeComponent();
            Controller.Kp = Convert.ToDouble(textKp.Text);
            Controller.Ti = Convert.ToDouble(textTi.Text);
            Controller.Td = Convert.ToDouble(textTd.Text);
            Controller.SetPoint = Convert.ToDouble(textSetPoint.Text);

            Sim.Kh = Convert.ToDouble(textKh.Text);
            Sim.TempEnv = Convert.ToDouble(textTenv.Text);
            Sim.ThetaT = Convert.ToDouble(textThetaT.Text);
            Sim.ThetaD = Convert.ToDouble(textThetaD.Text);
        }
        public void UpdateGraphs(List<Measurement> measurementList)
        {
            chart1.DataSource = measurementList;
            chart1.Series.Clear();
            chart1.Series.Add("Temperature Output");
            chart1.Series["Temperature Output"].ChartType = SeriesChartType.Line;
            chart1.Series["Temperature Output"].XValueType = ChartValueType.Time;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;

            chart1.ChartAreas[0].AxisX.Interval = 5;
            chart1.ChartAreas[0].AxisY.Interval = 2;
            chart1.ChartAreas[0].AxisY.Minimum = Sim.TempEnv - 2;

            chart1.Series["Temperature Output"].XValueMember = "Time";
            chart1.Series["Temperature Output"].YValueMembers = "y";

            chart2.DataSource = measurementList;
            chart2.Series.Clear();
            chart2.Series.Add("Control Signal");
            chart2.Series["Control Signal"].ChartType = SeriesChartType.Line;
            chart2.Series["Control Signal"].XValueType = ChartValueType.Time;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;

            chart2.ChartAreas[0].AxisX.Interval = 5;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 5;

            chart2.Series["Control Signal"].XValueMember = "Time";
            chart2.Series["Control Signal"].YValueMembers = "u";
        }

        public void SimulateProcess(double dt)
        {
            double u;
            double y;
            if (tabPid.SelectedTab == tabSimPID)
            {
                u = Controller.ControlVariable(Sim.ProcessVariable, dt);

                y = Sim.Simulate(u, dt);
            }
            else
            {
                RegOutput = new DaqAi("ai2");
                RegInput = new DaqAo("ao1");

                RegInput.SetValue(Clamp((Sim.ProcessVariable*4)/50+1));
                u = RegOutput.GetVoltValue();
                y = Sim.Simulate(u, dt);
            }

            UpdateVariables(u, y);
        }

        public void HardwareProcess(double dt)
        {
            Tout = new DaqAi("ai0");
            Tenv = new DaqAi("ai1");
            ControlSignal = new DaqAo("ao0");
            
            var y = Tout.GetCelsiusValue();
            double u;

            if (tabPid.SelectedTab == tabSimPID)
            {
                u = Controller.ControlVariable(y, dt);
            }
            else
            {
                RegOutput = new DaqAi("ai2");
                RegInput = new DaqAo("ao1");

                RegInput.SetValue(Clamp(Tout.GetVoltValue()));
                u = RegOutput.GetVoltValue();

                textToPID.Text = Math.Round(Clamp(Tout.GetVoltValue()),2).ToString();
                textFromPID.Text = Math.Round(u,2).ToString();
            }
            
            ControlSignal.SetValue(Clamp(u));

            textTenvh.Text = Math.Round(Tenv.GetCelsiusValue(),2).ToString();
            textTouth.Text = Math.Round(y,2).ToString();
            textOuth.Text = Math.Round(u,2).ToString();

            UpdateVariables(u, y);
        }

        public double Clamp(double value)
        {
            if (value >= 5)
                return 5;
            else if (value <= 0)
            {
                return 0;
            }
            else
            {
                return value;
            }
        }

        public void UpdateVariables(double u, double y)
        {
            var measurement = new Measurement(Controller.SetPoint, u, y);
            MeasurementList.Add(measurement);
            if (MeasurementList.Count >= 500)
                MeasurementList.RemoveAt(0);

            UpdateGraphs(MeasurementList);

            textU.Text = Math.Round(u,2).ToString();
            textY.Text = Math.Round(y,2).ToString();

            ToutOpc.SetOpcValue(y);
            TenvOpc.SetOpcValue(Sim.TempEnv);
            ControlSignalOpc.SetOpcValue(u);
            SetpointOpc.SetOpcValue(Controller.SetPoint);
        }

        private void sampleTime_Tick(object sender, EventArgs e)
        {
            double sample = sampleTime.Interval;
            var dt = sample / 1000;

            if (tabProcess.SelectedTab == tabSim)
            {
                SimulateProcess(dt);
            }
            else
            {
                HardwareProcess(dt);
            }
            

        }

        private void textTi_TextChanged_1(object sender, EventArgs e)
        {
            Controller.Ti = Convert.ToDouble(textTi.Text);
        }

        private void textTd_TextChanged_1(object sender, EventArgs e)
        {
            Controller.Td = Convert.ToDouble(textTd.Text);
        }

        private void textKh_TextChanged_1(object sender, EventArgs e)
        {
            Sim.Kh = Convert.ToDouble(textKh.Text);
        }

        private void textTenv_TextChanged_1(object sender, EventArgs e)
        {
            Sim.TempEnv = Convert.ToDouble(textTenv.Text);
        }

        private void textThetaT_TextChanged_1(object sender, EventArgs e)
        {
            Sim.ThetaT = Convert.ToDouble(textThetaT.Text);
        }

        private void textThetaD_TextChanged_1(object sender, EventArgs e)
        {
            Sim.ThetaD = Convert.ToDouble(textThetaD.Text);
        }

        private void textSetPoint_TextChanged(object sender, EventArgs e)
        {
            Controller.SetPoint = Convert.ToDouble(textSetPoint.Text);
        }

    }
}
