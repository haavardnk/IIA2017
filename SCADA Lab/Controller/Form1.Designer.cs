namespace Controller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sampleTime = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabProcess = new System.Windows.Forms.TabControl();
            this.tabSim = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textThetaD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textKh = new System.Windows.Forms.TextBox();
            this.textTenv = new System.Windows.Forms.TextBox();
            this.textThetaT = new System.Windows.Forms.TextBox();
            this.tabHard = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textTenvh = new System.Windows.Forms.TextBox();
            this.textTouth = new System.Windows.Forms.TextBox();
            this.textOuth = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textSetPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKp = new System.Windows.Forms.TextBox();
            this.textTi = new System.Windows.Forms.TextBox();
            this.textTd = new System.Windows.Forms.TextBox();
            this.tabPid = new System.Windows.Forms.TabControl();
            this.tabSimPID = new System.Windows.Forms.TabPage();
            this.tabHardPID = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textToPID = new System.Windows.Forms.TextBox();
            this.textFromPID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.tabSim.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabHard.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPid.SuspendLayout();
            this.tabSimPID.SuspendLayout();
            this.tabHardPID.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(97, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1323, 600);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(97, 603);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1323, 488);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // sampleTime
            // 
            this.sampleTime.Enabled = true;
            this.sampleTime.Tick += new System.EventHandler(this.sampleTime_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tout[°C]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 816);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "u[V]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(509, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 1094);
            this.panel1.TabIndex = 15;
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.tabSim);
            this.tabProcess.Controls.Add(this.tabHard);
            this.tabProcess.Location = new System.Drawing.Point(52, 447);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.SelectedIndex = 0;
            this.tabProcess.Size = new System.Drawing.Size(360, 357);
            this.tabProcess.TabIndex = 16;
            // 
            // tabSim
            // 
            this.tabSim.Controls.Add(this.groupBox2);
            this.tabSim.Location = new System.Drawing.Point(8, 39);
            this.tabSim.Name = "tabSim";
            this.tabSim.Padding = new System.Windows.Forms.Padding(3);
            this.tabSim.Size = new System.Drawing.Size(344, 310);
            this.tabSim.TabIndex = 0;
            this.tabSim.Text = "Simulation";
            this.tabSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textThetaD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textKh);
            this.groupBox2.Controls.Add(this.textTenv);
            this.groupBox2.Controls.Add(this.textThetaT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 324);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "thetaD";
            // 
            // textThetaD
            // 
            this.textThetaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textThetaD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textThetaD.Location = new System.Drawing.Point(175, 237);
            this.textThetaD.Name = "textThetaD";
            this.textThetaD.Size = new System.Drawing.Size(147, 44);
            this.textThetaD.TabIndex = 6;
            this.textThetaD.Text = "2";
            this.textThetaD.TextChanged += new System.EventHandler(this.textThetaD_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "thetaT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tenv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kh";
            // 
            // textKh
            // 
            this.textKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textKh.Location = new System.Drawing.Point(175, 70);
            this.textKh.Name = "textKh";
            this.textKh.Size = new System.Drawing.Size(147, 44);
            this.textKh.TabIndex = 0;
            this.textKh.Text = "3,5";
            this.textKh.TextChanged += new System.EventHandler(this.textKh_TextChanged_1);
            // 
            // textTenv
            // 
            this.textTenv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTenv.Location = new System.Drawing.Point(175, 126);
            this.textTenv.Name = "textTenv";
            this.textTenv.Size = new System.Drawing.Size(147, 44);
            this.textTenv.TabIndex = 1;
            this.textTenv.Text = "21";
            this.textTenv.TextChanged += new System.EventHandler(this.textTenv_TextChanged_1);
            // 
            // textThetaT
            // 
            this.textThetaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textThetaT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textThetaT.Location = new System.Drawing.Point(175, 182);
            this.textThetaT.Name = "textThetaT";
            this.textThetaT.Size = new System.Drawing.Size(147, 44);
            this.textThetaT.TabIndex = 2;
            this.textThetaT.Text = "22";
            this.textThetaT.TextChanged += new System.EventHandler(this.textThetaT_TextChanged_1);
            // 
            // tabHard
            // 
            this.tabHard.Controls.Add(this.label13);
            this.tabHard.Controls.Add(this.label14);
            this.tabHard.Controls.Add(this.label15);
            this.tabHard.Controls.Add(this.textTenvh);
            this.tabHard.Controls.Add(this.textTouth);
            this.tabHard.Controls.Add(this.textOuth);
            this.tabHard.Location = new System.Drawing.Point(8, 39);
            this.tabHard.Name = "tabHard";
            this.tabHard.Padding = new System.Windows.Forms.Padding(3);
            this.tabHard.Size = new System.Drawing.Size(344, 310);
            this.tabHard.TabIndex = 1;
            this.tabHard.Text = "Hardware";
            this.tabHard.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 37);
            this.label13.TabIndex = 11;
            this.label13.Text = "Output";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 37);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tout";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 37);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tenv";
            // 
            // textTenvh
            // 
            this.textTenvh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenvh.Location = new System.Drawing.Point(174, 24);
            this.textTenvh.Name = "textTenvh";
            this.textTenvh.Size = new System.Drawing.Size(147, 44);
            this.textTenvh.TabIndex = 6;
            this.textTenvh.Text = "3,5";
            // 
            // textTouth
            // 
            this.textTouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTouth.Location = new System.Drawing.Point(174, 80);
            this.textTouth.Name = "textTouth";
            this.textTouth.Size = new System.Drawing.Size(147, 44);
            this.textTouth.TabIndex = 7;
            this.textTouth.Text = "21";
            // 
            // textOuth
            // 
            this.textOuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOuth.Location = new System.Drawing.Point(174, 136);
            this.textOuth.Name = "textOuth";
            this.textOuth.Size = new System.Drawing.Size(147, 44);
            this.textOuth.TabIndex = 8;
            this.textOuth.Text = "22";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textU);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textY);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(52, 820);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 193);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Process Variables";
            // 
            // textU
            // 
            this.textU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textU.ForeColor = System.Drawing.Color.MediumBlue;
            this.textU.Location = new System.Drawing.Point(70, 56);
            this.textU.Name = "textU";
            this.textU.Size = new System.Drawing.Size(252, 44);
            this.textU.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 37);
            this.label8.TabIndex = 10;
            this.label8.Text = "u";
            // 
            // textY
            // 
            this.textY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textY.ForeColor = System.Drawing.Color.MediumBlue;
            this.textY.Location = new System.Drawing.Point(70, 113);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(252, 44);
            this.textY.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textSetPoint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textKp);
            this.groupBox1.Controls.Add(this.textTi);
            this.groupBox1.Controls.Add(this.textTd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 305);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PID Controller";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 37);
            this.label10.TabIndex = 7;
            this.label10.Text = "Setpoint";
            // 
            // textSetPoint
            // 
            this.textSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textSetPoint.Location = new System.Drawing.Point(175, 235);
            this.textSetPoint.Name = "textSetPoint";
            this.textSetPoint.Size = new System.Drawing.Size(147, 44);
            this.textSetPoint.TabIndex = 6;
            this.textSetPoint.Text = "25";
            this.textSetPoint.TextChanged += new System.EventHandler(this.textSetPoint_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Td";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kp";
            // 
            // textKp
            // 
            this.textKp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textKp.Location = new System.Drawing.Point(175, 67);
            this.textKp.Name = "textKp";
            this.textKp.Size = new System.Drawing.Size(147, 44);
            this.textKp.TabIndex = 0;
            this.textKp.Text = "1,6";
            // 
            // textTi
            // 
            this.textTi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTi.Location = new System.Drawing.Point(175, 123);
            this.textTi.Name = "textTi";
            this.textTi.Size = new System.Drawing.Size(147, 44);
            this.textTi.TabIndex = 1;
            this.textTi.Text = "16";
            this.textTi.TextChanged += new System.EventHandler(this.textTi_TextChanged_1);
            // 
            // textTd
            // 
            this.textTd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTd.Location = new System.Drawing.Point(175, 179);
            this.textTd.Name = "textTd";
            this.textTd.Size = new System.Drawing.Size(147, 44);
            this.textTd.TabIndex = 2;
            this.textTd.Text = "0";
            this.textTd.TextChanged += new System.EventHandler(this.textTd_TextChanged_1);
            // 
            // tabPid
            // 
            this.tabPid.Controls.Add(this.tabSimPID);
            this.tabPid.Controls.Add(this.tabHardPID);
            this.tabPid.Location = new System.Drawing.Point(52, 68);
            this.tabPid.Name = "tabPid";
            this.tabPid.SelectedIndex = 0;
            this.tabPid.Size = new System.Drawing.Size(360, 361);
            this.tabPid.TabIndex = 21;
            // 
            // tabSimPID
            // 
            this.tabSimPID.Controls.Add(this.groupBox1);
            this.tabSimPID.Location = new System.Drawing.Point(8, 39);
            this.tabSimPID.Name = "tabSimPID";
            this.tabSimPID.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimPID.Size = new System.Drawing.Size(344, 314);
            this.tabSimPID.TabIndex = 0;
            this.tabSimPID.Text = "Simulation";
            this.tabSimPID.UseVisualStyleBackColor = true;
            // 
            // tabHardPID
            // 
            this.tabHardPID.Controls.Add(this.groupBox3);
            this.tabHardPID.Location = new System.Drawing.Point(8, 39);
            this.tabHardPID.Name = "tabHardPID";
            this.tabHardPID.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardPID.Size = new System.Drawing.Size(344, 314);
            this.tabHardPID.TabIndex = 1;
            this.tabHardPID.Text = "Hardware";
            this.tabHardPID.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textToPID);
            this.groupBox3.Controls.Add(this.textFromPID);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 305);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID Controller";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 37);
            this.label18.TabIndex = 4;
            this.label18.Text = "From reg";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 37);
            this.label19.TabIndex = 3;
            this.label19.Text = "To reg";
            // 
            // textToPID
            // 
            this.textToPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToPID.Location = new System.Drawing.Point(175, 67);
            this.textToPID.Name = "textToPID";
            this.textToPID.Size = new System.Drawing.Size(147, 44);
            this.textToPID.TabIndex = 0;
            this.textToPID.Text = "1,6";
            // 
            // textFromPID
            // 
            this.textFromPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFromPID.Location = new System.Drawing.Point(175, 123);
            this.textFromPID.Name = "textFromPID";
            this.textFromPID.Size = new System.Drawing.Size(147, 44);
            this.textFromPID.TabIndex = 1;
            this.textFromPID.Text = "16";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1179);
            this.Controls.Add(this.tabPid);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabProcess);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(2000, 1250);
            this.Name = "Form1";
            this.Text = "Control System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProcess.ResumeLayout(false);
            this.tabSim.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabHard.ResumeLayout(false);
            this.tabHard.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPid.ResumeLayout(false);
            this.tabSimPID.ResumeLayout(false);
            this.tabHardPID.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer sampleTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabProcess;
        private System.Windows.Forms.TabPage tabSim;
        private System.Windows.Forms.TabPage tabHard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textThetaD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKh;
        private System.Windows.Forms.TextBox textTenv;
        private System.Windows.Forms.TextBox textThetaT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textTenvh;
        private System.Windows.Forms.TextBox textTouth;
        private System.Windows.Forms.TextBox textOuth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKp;
        private System.Windows.Forms.TextBox textTi;
        private System.Windows.Forms.TextBox textTd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSetPoint;
        private System.Windows.Forms.TabControl tabPid;
        private System.Windows.Forms.TabPage tabSimPID;
        private System.Windows.Forms.TabPage tabHardPID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textToPID;
        private System.Windows.Forms.TextBox textFromPID;
    }
}

