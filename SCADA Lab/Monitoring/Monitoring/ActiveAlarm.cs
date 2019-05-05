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
    public class ActiveAlarm
    {
        //Columns in ALARM table from SQL
        public int TagId { get; set; }
        public int AlarmId { get; set; }
        public DateTime ActivationTime { get; set; }
        public bool Acknowledged { get; set; }
        public string AlarmType { get; set; }
        public string Description { get; set; }
        public int AlarmLimit { get; set; }
       
        //The whole ALARM tabel from SQL
        public List<ActiveAlarm> Alarm { get; set; }


    }
}
