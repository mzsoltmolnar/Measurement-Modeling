namespace Strain_Gauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.strainGauge = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonIncDisp = new System.Windows.Forms.Button();
            this.buttonDecDisp = new System.Windows.Forms.Button();
            this.labelDispMeter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPSUVoltage = new System.Windows.Forms.Label();
            this.checkBoxPowerON = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMeterVoltage = new System.Windows.Forms.Label();
            this.timerSampling = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strainGauge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Strain Gauge Measurement Modeling";
            // 
            // strainGauge
            // 
            this.strainGauge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.strainGauge.Image = global::Strain_Gauge.Properties.Resources.annotations;
            this.strainGauge.InitialImage = null;
            this.strainGauge.Location = new System.Drawing.Point(16, 39);
            this.strainGauge.Name = "strainGauge";
            this.strainGauge.Size = new System.Drawing.Size(691, 454);
            this.strainGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.strainGauge.TabIndex = 13;
            this.strainGauge.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(632, 9);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 14;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonIncDisp
            // 
            this.buttonIncDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncDisp.Location = new System.Drawing.Point(562, 184);
            this.buttonIncDisp.Name = "buttonIncDisp";
            this.buttonIncDisp.Size = new System.Drawing.Size(39, 31);
            this.buttonIncDisp.TabIndex = 16;
            this.buttonIncDisp.Text = "<";
            this.buttonIncDisp.UseVisualStyleBackColor = true;
            this.buttonIncDisp.Click += new System.EventHandler(this.buttonIncDisp_Click);
            // 
            // buttonDecDisp
            // 
            this.buttonDecDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecDisp.Location = new System.Drawing.Point(607, 184);
            this.buttonDecDisp.Name = "buttonDecDisp";
            this.buttonDecDisp.Size = new System.Drawing.Size(39, 31);
            this.buttonDecDisp.TabIndex = 17;
            this.buttonDecDisp.Text = ">";
            this.buttonDecDisp.UseVisualStyleBackColor = true;
            this.buttonDecDisp.Click += new System.EventHandler(this.buttonDecDisp_Click);
            // 
            // labelDispMeter
            // 
            this.labelDispMeter.AutoSize = true;
            this.labelDispMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDispMeter.Location = new System.Drawing.Point(395, 130);
            this.labelDispMeter.Name = "labelDispMeter";
            this.labelDispMeter.Size = new System.Drawing.Size(66, 24);
            this.labelDispMeter.TabIndex = 18;
            this.labelDispMeter.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelPSUVoltage);
            this.groupBox1.Controls.Add(this.checkBoxPowerON);
            this.groupBox1.Location = new System.Drawing.Point(713, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 127);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symmetrical Power Supply ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Output voltage [V]";
            // 
            // labelPSUVoltage
            // 
            this.labelPSUVoltage.AutoSize = true;
            this.labelPSUVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPSUVoltage.Location = new System.Drawing.Point(71, 46);
            this.labelPSUVoltage.Name = "labelPSUVoltage";
            this.labelPSUVoltage.Size = new System.Drawing.Size(57, 20);
            this.labelPSUVoltage.TabIndex = 20;
            this.labelPSUVoltage.Text = "label2";
            this.labelPSUVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPowerON
            // 
            this.checkBoxPowerON.AutoSize = true;
            this.checkBoxPowerON.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPowerON.Location = new System.Drawing.Point(6, 93);
            this.checkBoxPowerON.Name = "checkBoxPowerON";
            this.checkBoxPowerON.Size = new System.Drawing.Size(125, 28);
            this.checkBoxPowerON.TabIndex = 0;
            this.checkBoxPowerON.Text = "Power ON";
            this.checkBoxPowerON.UseVisualStyleBackColor = true;
            this.checkBoxPowerON.CheckedChanged += new System.EventHandler(this.checkBoxPowerON_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelMeterVoltage);
            this.groupBox2.Location = new System.Drawing.Point(719, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 127);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Digital Multimeter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Measured Voltage [V]";
            // 
            // labelMeterVoltage
            // 
            this.labelMeterVoltage.AutoSize = true;
            this.labelMeterVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMeterVoltage.Location = new System.Drawing.Point(68, 64);
            this.labelMeterVoltage.Name = "labelMeterVoltage";
            this.labelMeterVoltage.Size = new System.Drawing.Size(57, 20);
            this.labelMeterVoltage.TabIndex = 20;
            this.labelMeterVoltage.Text = "label6";
            this.labelMeterVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSampling
            // 
            this.timerSampling.Tick += new System.EventHandler(this.timerSampling_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDispMeter);
            this.Controls.Add(this.buttonDecDisp);
            this.Controls.Add(this.buttonIncDisp);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.strainGauge);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Strain Gauge - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strainGauge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox strainGauge;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonIncDisp;
        private System.Windows.Forms.Button buttonDecDisp;
        private System.Windows.Forms.Label labelDispMeter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPSUVoltage;
        private System.Windows.Forms.CheckBox checkBoxPowerON;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMeterVoltage;
        private System.Windows.Forms.Timer timerSampling;
    }
}

