namespace solarCell
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
            this.checkBoxPSUON = new System.Windows.Forms.CheckBox();
            this.timerSampling = new System.Windows.Forms.Timer(this.components);
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelMultiThermocouple = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.pictureBoxDisplayScene = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMultiThermistor = new System.Windows.Forms.Label();
            this.labelMultiPT100 = new System.Windows.Forms.Label();
            this.labelPSUVoltage = new System.Windows.Forms.Label();
            this.labelThermometTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temperature Measurement Measurement Modeling";
            // 
            // checkBoxPSUON
            // 
            this.checkBoxPSUON.AutoSize = true;
            this.checkBoxPSUON.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPSUON.Location = new System.Drawing.Point(746, 415);
            this.checkBoxPSUON.Name = "checkBoxPSUON";
            this.checkBoxPSUON.Size = new System.Drawing.Size(60, 28);
            this.checkBoxPSUON.TabIndex = 69;
            this.checkBoxPSUON.Text = "ON";
            this.checkBoxPSUON.UseVisualStyleBackColor = true;
            // 
            // timerSampling
            // 
            this.timerSampling.Tick += new System.EventHandler(this.timerSampling_Tick);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(763, 7);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 73;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelMultiThermocouple
            // 
            this.labelMultiThermocouple.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMultiThermocouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMultiThermocouple.Location = new System.Drawing.Point(54, 280);
            this.labelMultiThermocouple.Name = "labelMultiThermocouple";
            this.labelMultiThermocouple.Size = new System.Drawing.Size(71, 25);
            this.labelMultiThermocouple.TabIndex = 75;
            this.labelMultiThermocouple.Text = "labelAmpMeter";
            this.labelMultiThermocouple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(310, 408);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 20);
            this.label27.TabIndex = 76;
            this.label27.Text = "Ω";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.Location = new System.Drawing.Point(769, 365);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 24);
            this.label28.TabIndex = 77;
            this.label28.Text = "V";
            // 
            // pictureBoxDisplayScene
            // 
            this.pictureBoxDisplayScene.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDisplayScene.Image")));
            this.pictureBoxDisplayScene.Location = new System.Drawing.Point(16, 36);
            this.pictureBoxDisplayScene.Name = "pictureBoxDisplayScene";
            this.pictureBoxDisplayScene.Size = new System.Drawing.Size(822, 452);
            this.pictureBoxDisplayScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplayScene.TabIndex = 19;
            this.pictureBoxDisplayScene.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(177, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "kΩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "mV";
            // 
            // labelMultiThermistor
            // 
            this.labelMultiThermistor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMultiThermistor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMultiThermistor.Location = new System.Drawing.Point(183, 280);
            this.labelMultiThermistor.Name = "labelMultiThermistor";
            this.labelMultiThermistor.Size = new System.Drawing.Size(71, 25);
            this.labelMultiThermistor.TabIndex = 80;
            this.labelMultiThermistor.Text = "label3";
            this.labelMultiThermistor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMultiPT100
            // 
            this.labelMultiPT100.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMultiPT100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMultiPT100.Location = new System.Drawing.Point(313, 280);
            this.labelMultiPT100.Name = "labelMultiPT100";
            this.labelMultiPT100.Size = new System.Drawing.Size(71, 25);
            this.labelMultiPT100.TabIndex = 81;
            this.labelMultiPT100.Text = "label5";
            this.labelMultiPT100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPSUVoltage
            // 
            this.labelPSUVoltage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelPSUVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPSUVoltage.Location = new System.Drawing.Point(692, 365);
            this.labelPSUVoltage.Name = "labelPSUVoltage";
            this.labelPSUVoltage.Size = new System.Drawing.Size(71, 25);
            this.labelPSUVoltage.TabIndex = 82;
            this.labelPSUVoltage.Text = "label6";
            this.labelPSUVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThermometTemp
            // 
            this.labelThermometTemp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelThermometTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelThermometTemp.Location = new System.Drawing.Point(692, 168);
            this.labelThermometTemp.Name = "labelThermometTemp";
            this.labelThermometTemp.Size = new System.Drawing.Size(71, 25);
            this.labelThermometTemp.TabIndex = 83;
            this.labelThermometTemp.Text = "label7";
            this.labelThermometTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(741, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "°C";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelThermometTemp);
            this.Controls.Add(this.labelPSUVoltage);
            this.Controls.Add(this.labelMultiPT100);
            this.Controls.Add(this.labelMultiThermistor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.labelMultiThermocouple);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.checkBoxPSUON);
            this.Controls.Add(this.pictureBoxDisplayScene);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Temperature Measurement - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxPSUON;
        private System.Windows.Forms.Timer timerSampling;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelMultiThermocouple;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBoxDisplayScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMultiThermistor;
        private System.Windows.Forms.Label labelMultiPT100;
        private System.Windows.Forms.Label labelPSUVoltage;
        private System.Windows.Forms.Label labelThermometTemp;
        private System.Windows.Forms.Label label3;
    }
}

