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

namespace Monitoring
{
    public partial class Form1 : Form
    {
        private readonly List<Tag> _tagList;
        private List<ActiveAlarm> _alarmList;
        private Tag _selectedTag;
        private int _blinkStatus = 0;

        //Objects
        private readonly Database _database = new Database(@"Data Source=DESKTOP-PNGCAGM\SQLEXPRESS;Initial Catalog=TagDatabase;Trusted_Connection=True");

        public Form1()
        {
            InitializeComponent();
            _tagList = _database.GetTagData();

            foreach (var tag in _tagList)
            {
                comboTag.DisplayMember = "TagName";
                comboTag.ValueMember = "TagId";
                comboTag.Items.Add(tag);
            }
        }

        public void UpdateGraph(Tag tag)
        {
            chart1.DataSource = tag.History;
            chart1.Series.Clear();

            //Axis
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 30;
            chart1.ChartAreas[0].AxisY.Interval = 2;

            //Defining series
            chart1.Series.Add("Temperature Output");
            chart1.Series["Temperature Output"].ChartType = SeriesChartType.Line;
            chart1.Series["Temperature Output"].XValueType = ChartValueType.Time;

            //Series values
            chart1.Series["Temperature Output"].XValueMember = "TimeStamp";
            chart1.Series["Temperature Output"].YValueMembers = "Value";
        }

        public void AlarmColors(DataGridView grid)
        {
            //Defining colors
            var red = new DataGridViewCellStyle { BackColor = Color.Red };
            var yellow = new DataGridViewCellStyle { BackColor = Color.Yellow };
            var white = new DataGridViewCellStyle { BackColor = Color.White };

            //Hide alarm sign on tag if no alarm
            if(_alarmList.Find(x => x.TagId == _tagList.Find(y => y.TagName.Contains("Tout")).TagId) == null)
                alarmTout.Visible = false;

            //Iterating over grid rows
            foreach (DataGridViewRow row in grid.Rows)
                //Checks if not acknowledged
                if (Convert.ToBoolean(row.Cells[3].Value) == false)
                {
                    //Checks alarmtype
                    switch (row.Cells[4].Value)
                    {
                        case "HH":
                        case "LL":
                            row.DefaultCellStyle = _blinkStatus > 3 ? red : white;
                            break;
                        case "H":
                        case "L":
                            if (_blinkStatus > 3)
                            {
                                if (Convert.ToInt32(row.Cells[0].Value) ==
                                    _tagList.Find(x => x.TagName.Contains("Tout")).TagId)
                                {
                                    alarmTout.Visible = true;
                                }

                                row.DefaultCellStyle = yellow;
                            }
                            else
                            {
                                if (Convert.ToInt32(row.Cells[0].Value) ==
                                    _tagList.Find(x => x.TagName.Contains("Tout")).TagId)
                                {
                                    alarmTout.Visible = false;
                                }

                                row.DefaultCellStyle = white;
                            }

                            break;
                    }
                }
                else
                {
                    switch (row.Cells[4].Value)
                    {
                        case "HH":
                        case "LL":
                            row.DefaultCellStyle = red;
                            break;
                        case "H":
                        case "L":
                            if (Convert.ToInt32(row.Cells[0].Value) ==
                                _tagList.Find(x => x.TagName.Contains("Tout")).TagId)
                            {
                                alarmTout.Visible = true;
                            }

                            row.DefaultCellStyle = yellow;
                            break;
                    }
                }
        }

        private void SampleTime_Tick(object sender, EventArgs e)
        {
            //Get values from database 
            _alarmList = _database.GetAlarmList();
            foreach (var tag in _tagList)
            {
                tag.History = _database.GetTagHistory(tag);
            }
            
            //Selecting tag values
            var tOut = Math.Round(_tagList.Find(x => x.TagName.Contains("Tout")).History[0].Value, 2);
            var tEnv = Math.Round(_tagList.Find(x => x.TagName.Contains("Tenv")).History[0].Value, 2);
            var controlSignal =
                Math.Round(_tagList.Find(x => x.TagName.Contains("Controlsignal")).History[0].Value * 20, 2);
            var setPoint = Math.Round(_tagList.Find(x => x.TagName.Contains("Setpoint")).History[0].Value, 2);
            var tempOutletZero = _tagList.Find(x => x.TagName.Contains("Tout")).Zero;
            var tempOutletSpan = _tagList.Find(x => x.TagName.Contains("Tout")).Span;
            var outletLimitHigh = _tagList.Find(x => x.TagName.Contains("Tout")).AlarmLimit;

            //Textboxes
            textTout.Text = tOut + "°C";
            txtOutletTempBarValue.Text = tOut + "°C";
            textTenv.Text =  tEnv + "°C";
            textControlSignal.Text =  controlSignal + "%";
            textSetpoint.Text =  setPoint + "°C";

            txtOutletTempLimitHigh.Text = outletLimitHigh.ToString() + "°C";
            txtDateAndTimeAirheater.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm");
            txtDateAndTimeAlarmlist.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm");

            //Trackbars
            tbSetpoint.Minimum = Convert.ToInt32(tempOutletZero);
            tbSetpoint.Maximum = Convert.ToInt32(tempOutletSpan);
            tbSetpoint.Value = Convert.ToInt32(setPoint);
            tbOutletLimitHigh.Minimum = Convert.ToInt32(tempOutletZero);
            tbOutletLimitHigh.Maximum = Convert.ToInt32(tempOutletSpan);
            tbOutletLimitHigh.Value = Convert.ToInt32(outletLimitHigh);
            
            //Progress bars
            pbOutletTemp.Minimum = Convert.ToInt32(tempOutletZero);
            pbOutletTemp.Maximum = Convert.ToInt32(tempOutletSpan);
            pbOutletTemp.Value = Convert.ToInt32(tOut);
            

            //Graph
            _selectedTag = comboTag.SelectedItem as Tag;
            if (_selectedTag != null)
            {
                UpdateGraph(_selectedTag);
            }

            //Table
            dgAlarmlist.DataSource = _alarmList;
            dgAlarmlistAirheater.DataSource = _alarmList;
            AlarmColors(dgAlarmlist);
            AlarmColors(dgAlarmlistAirheater);

            //Blink time on/off
            if (_blinkStatus < 7)
                _blinkStatus++;
            else
                _blinkStatus = 0;

        }

        public void btnAcknowledge_Click(object sender, EventArgs e)
        {
            _database.SetAcknowledgedAlarm(true);
        }
    }
}
