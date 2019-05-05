using System;
using System.Windows.Forms;

namespace Datalogging
{
    public partial class Form1 : Form
    {
        //Data types
        private readonly Opc _toutOpc;
        private readonly Opc _tEnvOpc;
        private readonly Opc _controlSignalOpc;
        private readonly Opc _setPointOpc;
        private readonly Database _database;



        public Form1()
        {
            //Initialize methods
            InitializeComponent();

            //Create objects
            _toutOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Tout");
            _tEnvOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Tenv");
            _controlSignalOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.ControlSignal");
            _setPointOpc = new Opc("opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Setpoint");
            _database = new Database(@"Data Source=SURFACE-ANDREAS\SQLEXPRESS01;Initial Catalog=TagDatabase;Trusted_Connection=True");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Update database 
            _database.Write(0, _tEnvOpc.GetOpcValue(), _tEnvOpc.GetOpcQuality());
            _database.Write(1, _toutOpc.GetOpcValue(), _toutOpc.GetOpcQuality());
            _database.Write(2, _controlSignalOpc.GetOpcValue(), _controlSignalOpc.GetOpcQuality());
            _database.Write(3, _setPointOpc.GetOpcValue(), _setPointOpc.GetOpcQuality());

            //Update text boxes with time of read/write
            var updateTime = DateTime.Now.ToLongTimeString();
            txtOpcStatus.Text = updateTime.ToString();
            txtDatabaseStatus.Text = updateTime.ToString();

        }
    }
}
