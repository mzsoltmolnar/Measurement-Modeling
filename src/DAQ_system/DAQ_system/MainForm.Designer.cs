namespace DAQ_system
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.strainGauge = new System.Windows.Forms.PictureBox();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerSampling = new System.Windows.Forms.Timer(this.components);
            this.labelOutputVoltge = new System.Windows.Forms.Label();
            this.numericUpDownWeightCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chartOutputVoltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.strainGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutputVoltage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(543, 464);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(663, 464);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(533, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output [mV]:";
            // 
            // strainGauge
            // 
            this.strainGauge.Location = new System.Drawing.Point(12, 47);
            this.strainGauge.Name = "strainGauge";
            this.strainGauge.Size = new System.Drawing.Size(519, 373);
            this.strainGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.strainGauge.TabIndex = 3;
            this.strainGauge.TabStop = false;
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Items.AddRange(new object[] {
            "Strain gauge",
            "10x input divider",
            "2x input multiplier"});
            this.comboBoxChannels.Location = new System.Drawing.Point(537, 64);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(113, 21);
            this.comboBoxChannels.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Channel Name";
            // 
            // timerSampling
            // 
            this.timerSampling.Tick += new System.EventHandler(this.samplingTimer_Tick);
            // 
            // labelOutputVoltge
            // 
            this.labelOutputVoltge.AutoSize = true;
            this.labelOutputVoltge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutputVoltge.Location = new System.Drawing.Point(666, 427);
            this.labelOutputVoltge.Name = "labelOutputVoltge";
            this.labelOutputVoltge.Size = new System.Drawing.Size(17, 24);
            this.labelOutputVoltge.TabIndex = 7;
            this.labelOutputVoltge.Text = "-";
            // 
            // numericUpDownWeightCount
            // 
            this.numericUpDownWeightCount.Location = new System.Drawing.Point(193, 431);
            this.numericUpDownWeightCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWeightCount.Name = "numericUpDownWeightCount";
            this.numericUpDownWeightCount.Size = new System.Drawing.Size(93, 20);
            this.numericUpDownWeightCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight unit count:";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(456, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Acquisition System Modeling";
            // 
            // chartOutputVoltage
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOutputVoltage.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartOutputVoltage.Legends.Add(legend1);
            this.chartOutputVoltage.Location = new System.Drawing.Point(537, 113);
            this.chartOutputVoltage.Name = "chartOutputVoltage";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOutputVoltage.Series.Add(series1);
            this.chartOutputVoltage.Size = new System.Drawing.Size(428, 307);
            this.chartOutputVoltage.TabIndex = 12;
            this.chartOutputVoltage.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Output voltage chart [mV] - Samples";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartOutputVoltage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownWeightCount);
            this.Controls.Add(this.labelOutputVoltge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxChannels);
            this.Controls.Add(this.strainGauge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Data Acquisition System - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strainGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutputVoltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox strainGauge;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerSampling;
        private System.Windows.Forms.Label labelOutputVoltge;
        private System.Windows.Forms.NumericUpDown numericUpDownWeightCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutputVoltage;
        private System.Windows.Forms.Label label5;
    }
}

