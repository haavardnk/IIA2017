namespace Monitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textControlSignal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTenv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboTag = new System.Windows.Forms.ComboBox();
            this.SampleTime = new System.Windows.Forms.Timer(this.components);
            this.Alarmlist = new System.Windows.Forms.GroupBox();
            this.dgAlarmlistAirheater = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alarmTout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDateAndTimeAirheater = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAcknowledge = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgAlarmlist = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDateAndTimeAlarmlist = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutletTempLimitHigh = new System.Windows.Forms.TextBox();
            this.txtOutletTempBarValue = new System.Windows.Forms.TextBox();
            this.textSetpoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbOutletTemp = new System.Windows.Forms.ProgressBar();
            this.tbOutletLimitHigh = new System.Windows.Forms.TrackBar();
            this.tbSetpoint = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Alarmlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarmlistAirheater)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarmlist)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutletLimitHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetpoint)).BeginInit();
            this.SuspendLayout();
            // 
            // textControlSignal
            // 
            this.textControlSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textControlSignal.ForeColor = System.Drawing.Color.MediumBlue;
            this.textControlSignal.Location = new System.Drawing.Point(413, 148);
            this.textControlSignal.Margin = new System.Windows.Forms.Padding(4);
            this.textControlSignal.Name = "textControlSignal";
            this.textControlSignal.Size = new System.Drawing.Size(216, 44);
            this.textControlSignal.TabIndex = 1;
            this.textControlSignal.Text = "0-100%";
            this.textControlSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heater";
            // 
            // textTout
            // 
            this.textTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTout.ForeColor = System.Drawing.Color.MediumBlue;
            this.textTout.Location = new System.Drawing.Point(752, 814);
            this.textTout.Margin = new System.Windows.Forms.Padding(4);
            this.textTout.Name = "textTout";
            this.textTout.Size = new System.Drawing.Size(216, 44);
            this.textTout.TabIndex = 3;
            this.textTout.Text = "35°C";
            this.textTout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(814, 873);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tout";
            // 
            // textTenv
            // 
            this.textTenv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenv.ForeColor = System.Drawing.Color.MediumBlue;
            this.textTenv.Location = new System.Drawing.Point(81, 814);
            this.textTenv.Margin = new System.Windows.Forms.Padding(4);
            this.textTenv.Name = "textTenv";
            this.textTenv.Size = new System.Drawing.Size(216, 44);
            this.textTenv.TabIndex = 5;
            this.textTenv.Text = "20°C";
            this.textTenv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 873);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tenv";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(19, 78);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(669, 555);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // comboTag
            // 
            this.comboTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTag.FormattingEnabled = true;
            this.comboTag.Location = new System.Drawing.Point(267, 25);
            this.comboTag.Margin = new System.Windows.Forms.Padding(4);
            this.comboTag.Name = "comboTag";
            this.comboTag.Size = new System.Drawing.Size(216, 45);
            this.comboTag.TabIndex = 8;
            // 
            // SampleTime
            // 
            this.SampleTime.Enabled = true;
            this.SampleTime.Tick += new System.EventHandler(this.SampleTime_Tick);
            // 
            // Alarmlist
            // 
            this.Alarmlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Alarmlist.Controls.Add(this.dgAlarmlistAirheater);
            this.Alarmlist.Location = new System.Drawing.Point(5, 6);
            this.Alarmlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Alarmlist.Name = "Alarmlist";
            this.Alarmlist.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Alarmlist.Size = new System.Drawing.Size(1541, 172);
            this.Alarmlist.TabIndex = 11;
            this.Alarmlist.TabStop = false;
            this.Alarmlist.Text = "Alarmlist";
            // 
            // dgAlarmlistAirheater
            // 
            this.dgAlarmlistAirheater.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgAlarmlistAirheater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlarmlistAirheater.Location = new System.Drawing.Point(6, 30);
            this.dgAlarmlistAirheater.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAlarmlistAirheater.Name = "dgAlarmlistAirheater";
            this.dgAlarmlistAirheater.RowTemplate.Height = 33;
            this.dgAlarmlistAirheater.Size = new System.Drawing.Size(1535, 127);
            this.dgAlarmlistAirheater.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.alarmTout);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textTout);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textTenv);
            this.groupBox2.Controls.Add(this.textControlSignal);
            this.groupBox2.Location = new System.Drawing.Point(719, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1028, 992);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System overview";
            // 
            // alarmTout
            // 
            this.alarmTout.AutoSize = true;
            this.alarmTout.BackColor = System.Drawing.Color.Yellow;
            this.alarmTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTout.Location = new System.Drawing.Point(975, 817);
            this.alarmTout.Name = "alarmTout";
            this.alarmTout.Size = new System.Drawing.Size(39, 37);
            this.alarmTout.TabIndex = 12;
            this.alarmTout.Text = "A";
            this.alarmTout.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 219);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(954, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.txtDateAndTimeAirheater);
            this.groupBox3.Location = new System.Drawing.Point(1552, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(191, 172);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // txtDateAndTimeAirheater
            // 
            this.txtDateAndTimeAirheater.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDateAndTimeAirheater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateAndTimeAirheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDateAndTimeAirheater.Location = new System.Drawing.Point(32, 30);
            this.txtDateAndTimeAirheater.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateAndTimeAirheater.Multiline = true;
            this.txtDateAndTimeAirheater.Name = "txtDateAndTimeAirheater";
            this.txtDateAndTimeAirheater.Size = new System.Drawing.Size(127, 109);
            this.txtDateAndTimeAirheater.TabIndex = 11;
            this.txtDateAndTimeAirheater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Controls.Add(this.comboTag);
            this.groupBox4.Location = new System.Drawing.Point(5, 528);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(709, 649);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tag";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(15, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1775, 1226);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1759, 1179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alarmlist";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnReset);
            this.groupBox7.Controls.Add(this.btnAcknowledge);
            this.groupBox7.Location = new System.Drawing.Point(453, 981);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(557, 172);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(335, 59);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 59);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAcknowledge
            // 
            this.btnAcknowledge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAcknowledge.Location = new System.Drawing.Point(55, 59);
            this.btnAcknowledge.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcknowledge.Name = "btnAcknowledge";
            this.btnAcknowledge.Size = new System.Drawing.Size(221, 59);
            this.btnAcknowledge.TabIndex = 18;
            this.btnAcknowledge.Text = "Acknowledge";
            this.btnAcknowledge.UseVisualStyleBackColor = true;
            this.btnAcknowledge.Click += new System.EventHandler(this.btnAcknowledge_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgAlarmlist);
            this.groupBox6.Location = new System.Drawing.Point(44, 28);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(1535, 925);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // dgAlarmlist
            // 
            this.dgAlarmlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlarmlist.Location = new System.Drawing.Point(21, 29);
            this.dgAlarmlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAlarmlist.Name = "dgAlarmlist";
            this.dgAlarmlist.RowTemplate.Height = 33;
            this.dgAlarmlist.Size = new System.Drawing.Size(1491, 874);
            this.dgAlarmlist.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDateAndTimeAlarmlist);
            this.groupBox5.Location = new System.Drawing.Point(44, 981);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(369, 172);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // txtDateAndTimeAlarmlist
            // 
            this.txtDateAndTimeAlarmlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDateAndTimeAlarmlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateAndTimeAlarmlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDateAndTimeAlarmlist.Location = new System.Drawing.Point(47, 69);
            this.txtDateAndTimeAlarmlist.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateAndTimeAlarmlist.Name = "txtDateAndTimeAlarmlist";
            this.txtDateAndTimeAlarmlist.Size = new System.Drawing.Size(273, 37);
            this.txtDateAndTimeAlarmlist.TabIndex = 12;
            this.txtDateAndTimeAlarmlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Alarmlist);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1759, 1179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Airheater";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtOutletTempLimitHigh);
            this.groupBox1.Controls.Add(this.txtOutletTempBarValue);
            this.groupBox1.Controls.Add(this.textSetpoint);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbOutletTemp);
            this.groupBox1.Controls.Add(this.tbOutletLimitHigh);
            this.groupBox1.Controls.Add(this.tbSetpoint);
            this.groupBox1.Location = new System.Drawing.Point(5, 185);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(707, 338);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outlet temperature";
            // 
            // txtOutletTempLimitHigh
            // 
            this.txtOutletTempLimitHigh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutletTempLimitHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutletTempLimitHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtOutletTempLimitHigh.Location = new System.Drawing.Point(580, 188);
            this.txtOutletTempLimitHigh.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutletTempLimitHigh.Name = "txtOutletTempLimitHigh";
            this.txtOutletTempLimitHigh.Size = new System.Drawing.Size(87, 31);
            this.txtOutletTempLimitHigh.TabIndex = 23;
            // 
            // txtOutletTempBarValue
            // 
            this.txtOutletTempBarValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutletTempBarValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutletTempBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtOutletTempBarValue.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtOutletTempBarValue.Location = new System.Drawing.Point(580, 134);
            this.txtOutletTempBarValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutletTempBarValue.Name = "txtOutletTempBarValue";
            this.txtOutletTempBarValue.Size = new System.Drawing.Size(87, 31);
            this.txtOutletTempBarValue.TabIndex = 22;
            // 
            // textSetpoint
            // 
            this.textSetpoint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textSetpoint.Location = new System.Drawing.Point(580, 84);
            this.textSetpoint.Margin = new System.Windows.Forms.Padding(4);
            this.textSetpoint.Name = "textSetpoint";
            this.textSetpoint.Size = new System.Drawing.Size(87, 31);
            this.textSetpoint.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "High limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Setpoint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Value";
            // 
            // pbOutletTemp
            // 
            this.pbOutletTemp.Location = new System.Drawing.Point(167, 131);
            this.pbOutletTemp.Margin = new System.Windows.Forms.Padding(4);
            this.pbOutletTemp.Name = "pbOutletTemp";
            this.pbOutletTemp.Size = new System.Drawing.Size(377, 38);
            this.pbOutletTemp.TabIndex = 17;
            // 
            // tbOutletLimitHigh
            // 
            this.tbOutletLimitHigh.Location = new System.Drawing.Point(152, 165);
            this.tbOutletLimitHigh.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutletLimitHigh.Maximum = 100;
            this.tbOutletLimitHigh.Name = "tbOutletLimitHigh";
            this.tbOutletLimitHigh.Size = new System.Drawing.Size(407, 90);
            this.tbOutletLimitHigh.TabIndex = 3;
            this.tbOutletLimitHigh.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbOutletLimitHigh.Value = 22;
            // 
            // tbSetpoint
            // 
            this.tbSetpoint.Location = new System.Drawing.Point(152, 85);
            this.tbSetpoint.Margin = new System.Windows.Forms.Padding(4);
            this.tbSetpoint.Maximum = 100;
            this.tbSetpoint.Name = "tbSetpoint";
            this.tbSetpoint.Size = new System.Drawing.Size(407, 90);
            this.tbSetpoint.TabIndex = 1;
            this.tbSetpoint.Value = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1759, 1179);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Process 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1759, 1179);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Process 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1797, 1246);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1823, 1317);
            this.Name = "Form1";
            this.Text = "Process Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Alarmlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarmlistAirheater)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarmlist)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOutletLimitHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSetpoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textControlSignal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTenv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboTag;
        private System.Windows.Forms.Timer SampleTime;
        private System.Windows.Forms.GroupBox Alarmlist;
        private System.Windows.Forms.DataGridView dgAlarmlistAirheater;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgAlarmlist;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtDateAndTimeAirheater;
        private System.Windows.Forms.Button btnAcknowledge;
        private System.Windows.Forms.TextBox txtDateAndTimeAlarmlist;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TrackBar tbSetpoint;
        private System.Windows.Forms.TrackBar tbOutletLimitHigh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbOutletTemp;
        private System.Windows.Forms.TextBox txtOutletTempLimitHigh;
        private System.Windows.Forms.TextBox txtOutletTempBarValue;
        private System.Windows.Forms.TextBox textSetpoint;
        private System.Windows.Forms.Label alarmTout;
    }
}

