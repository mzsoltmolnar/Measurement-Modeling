namespace Pressure_Meas
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
            this.pressureTransducer = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxPWRON = new System.Windows.Forms.CheckBox();
            this.timerSampling = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelPresGauge = new System.Windows.Forms.Label();
            this.labelAmpMet = new System.Windows.Forms.Label();
            this.labelPSUVolt = new System.Windows.Forms.Label();
            this.buttonIncPres = new System.Windows.Forms.Button();
            this.buttonDecPres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pressureTransducer)).BeginInit();
            this.SuspendLayout();
            // 
            // pressureTransducer
            // 
            this.pressureTransducer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pressureTransducer.Image = global::Pressure_Meas.Properties.Resources.annotations;
            this.pressureTransducer.InitialImage = null;
            this.pressureTransducer.Location = new System.Drawing.Point(12, 41);
            this.pressureTransducer.Name = "pressureTransducer";
            this.pressureTransducer.Size = new System.Drawing.Size(827, 465);
            this.pressureTransducer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pressureTransducer.TabIndex = 14;
            this.pressureTransducer.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(764, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 15;
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
            this.label4.Size = new System.Drawing.Size(432, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pressure Transducer Measurement Modeling";
            // 
            // checkBoxPWRON
            // 
            this.checkBoxPWRON.AutoSize = true;
            this.checkBoxPWRON.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPWRON.Location = new System.Drawing.Point(704, 214);
            this.checkBoxPWRON.Name = "checkBoxPWRON";
            this.checkBoxPWRON.Size = new System.Drawing.Size(198, 28);
            this.checkBoxPWRON.TabIndex = 17;
            this.checkBoxPWRON.Text = "checkBoxPWRON";
            this.checkBoxPWRON.UseVisualStyleBackColor = true;
            this.checkBoxPWRON.CheckedChanged += new System.EventHandler(this.checkBoxPWRON_CheckedChanged);
            // 
            // timerSampling
            // 
            this.timerSampling.Tick += new System.EventHandler(this.timerSampling_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(721, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "V";
            // 
            // labelPresGauge
            // 
            this.labelPresGauge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelPresGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPresGauge.Location = new System.Drawing.Point(328, 282);
            this.labelPresGauge.Name = "labelPresGauge";
            this.labelPresGauge.Size = new System.Drawing.Size(66, 25);
            this.labelPresGauge.TabIndex = 20;
            this.labelPresGauge.Text = "labelPresGauge";
            this.labelPresGauge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmpMet
            // 
            this.labelAmpMet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelAmpMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAmpMet.Location = new System.Drawing.Point(456, 78);
            this.labelAmpMet.Name = "labelAmpMet";
            this.labelAmpMet.Size = new System.Drawing.Size(75, 25);
            this.labelAmpMet.TabIndex = 21;
            this.labelAmpMet.Text = "labelAmpMet";
            this.labelAmpMet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPSUVolt
            // 
            this.labelPSUVolt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelPSUVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPSUVolt.Location = new System.Drawing.Point(636, 156);
            this.labelPSUVolt.Name = "labelPSUVolt";
            this.labelPSUVolt.Size = new System.Drawing.Size(79, 25);
            this.labelPSUVolt.TabIndex = 22;
            this.labelPSUVolt.Text = "labelPSUVolt";
            this.labelPSUVolt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIncPres
            // 
            this.buttonIncPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncPres.Location = new System.Drawing.Point(96, 454);
            this.buttonIncPres.Name = "buttonIncPres";
            this.buttonIncPres.Size = new System.Drawing.Size(42, 42);
            this.buttonIncPres.TabIndex = 23;
            this.buttonIncPres.Text = ">";
            this.buttonIncPres.UseVisualStyleBackColor = true;
            this.buttonIncPres.Click += new System.EventHandler(this.buttonIncPres_Click);
            // 
            // buttonDecPres
            // 
            this.buttonDecPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecPres.Location = new System.Drawing.Point(34, 454);
            this.buttonDecPres.Name = "buttonDecPres";
            this.buttonDecPres.Size = new System.Drawing.Size(42, 42);
            this.buttonDecPres.TabIndex = 24;
            this.buttonDecPres.Text = "<";
            this.buttonDecPres.UseVisualStyleBackColor = true;
            this.buttonDecPres.Click += new System.EventHandler(this.buttonDecPres_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 518);
            this.Controls.Add(this.buttonDecPres);
            this.Controls.Add(this.buttonIncPres);
            this.Controls.Add(this.labelPSUVolt);
            this.Controls.Add(this.labelAmpMet);
            this.Controls.Add(this.labelPresGauge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPWRON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.pressureTransducer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pressure Transducer - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pressureTransducer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pressureTransducer;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxPWRON;
        private System.Windows.Forms.Timer timerSampling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPresGauge;
        private System.Windows.Forms.Label labelAmpMet;
        private System.Windows.Forms.Label labelPSUVolt;
        private System.Windows.Forms.Button buttonIncPres;
        private System.Windows.Forms.Button buttonDecPres;
    }
}

