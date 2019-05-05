using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpcDA_Client
{
    public partial class Form1 : Form
    {
        private readonly Opc _opc = new Opc();
        public Form1()
        {
            InitializeComponent();
        }


        private void connectBtn_Click(object sender, EventArgs e)
        {
            var connected = _opc.Connect(opcUrlTxt.Text);
            if (connected)
            {
                connectBtn.Text = "Disconnect";
                timer1.Start();
            }
            else
            {
                connectBtn.Text = "Connect";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var opcValue = _opc.GetOpcValue();
            if (opcValue < 32)
            {
                cTherm.Value = opcValue;
                fTherm.Value = Scaling.CtoF(opcValue);
                
            }
            else
            {
                cTherm.Value = Scaling.FtoC(opcValue);
                fTherm.Value = opcValue;
            }
            tempGraph.PlotYAppend(cTherm.Value);
        }

    }
}
