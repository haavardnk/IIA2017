namespace OpcDA_Client
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
            this.fTherm = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.tempGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.cTherm = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.opcUrlTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fTherm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTherm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fTherm
            // 
            this.fTherm.Location = new System.Drawing.Point(126, 28);
            this.fTherm.Name = "fTherm";
            this.fTherm.Size = new System.Drawing.Size(97, 325);
            this.fTherm.TabIndex = 0;
            // 
            // tempGraph
            // 
            this.tempGraph.Location = new System.Drawing.Point(21, 28);
            this.tempGraph.Name = "tempGraph";
            this.tempGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.tempGraph.Size = new System.Drawing.Size(405, 313);
            this.tempGraph.TabIndex = 1;
            this.tempGraph.UseColorGenerator = true;
            this.tempGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.tempGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // cTherm
            // 
            this.cTherm.Location = new System.Drawing.Point(23, 28);
            this.cTherm.Name = "cTherm";
            this.cTherm.Size = new System.Drawing.Size(97, 325);
            this.cTherm.TabIndex = 2;
            // 
            // opcUrlTxt
            // 
            this.opcUrlTxt.AccessibleName = "";
            this.opcUrlTxt.Location = new System.Drawing.Point(27, 382);
            this.opcUrlTxt.Name = "opcUrlTxt";
            this.opcUrlTxt.Size = new System.Drawing.Size(324, 20);
            this.opcUrlTxt.TabIndex = 3;
            this.opcUrlTxt.Tag = "";
            this.opcUrlTxt.Text = "opc://localhost/Matrikon.OPC.Simulation.1/Bucket Brigade.Real4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tempGraph);
            this.groupBox1.Location = new System.Drawing.Point(244, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 359);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph - Celsius";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cTherm);
            this.groupBox2.Controls.Add(this.fTherm);
            this.groupBox2.Location = new System.Drawing.Point(9, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 359);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "°F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "°C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Opc URL:";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(27, 411);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(125, 30);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 453);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.opcUrlTxt);
            this.Name = "Form1";
            this.Text = "OPC DA Client";
            ((System.ComponentModel.ISupportInitialize)(this.fTherm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTherm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.Thermometer fTherm;
        private NationalInstruments.UI.WindowsForms.WaveformGraph tempGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.Thermometer cTherm;
        private System.Windows.Forms.TextBox opcUrlTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

