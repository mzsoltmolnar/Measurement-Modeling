namespace UltrasonicSens
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
            this.buttonAbout = new System.Windows.Forms.Button();
            this.pictureBoxDisplayScene = new System.Windows.Forms.PictureBox();
            this.groupBoxObjMat = new System.Windows.Forms.GroupBox();
            this.radioButtonSponge = new System.Windows.Forms.RadioButton();
            this.radioButtonWood = new System.Windows.Forms.RadioButton();
            this.radioButtonCeramic = new System.Windows.Forms.RadioButton();
            this.radioButtonPlastic = new System.Windows.Forms.RadioButton();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonFe = new System.Windows.Forms.RadioButton();
            this.labelVoltMet = new System.Windows.Forms.Label();
            this.labelPSUVolt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRuler = new System.Windows.Forms.Label();
            this.buttonIncDist = new System.Windows.Forms.Button();
            this.buttonDecDist = new System.Windows.Forms.Button();
            this.pictureBoxIndicator = new System.Windows.Forms.PictureBox();
            this.timerSample = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPWRON = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene)).BeginInit();
            this.groupBoxObjMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ultrasonic Sensor Measurement Modeling";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(723, 7);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 19;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // pictureBoxDisplayScene
            // 
            this.pictureBoxDisplayScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDisplayScene.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDisplayScene.Image")));
            this.pictureBoxDisplayScene.InitialImage = null;
            this.pictureBoxDisplayScene.Location = new System.Drawing.Point(12, 36);
            this.pictureBoxDisplayScene.Name = "pictureBoxDisplayScene";
            this.pictureBoxDisplayScene.Size = new System.Drawing.Size(786, 454);
            this.pictureBoxDisplayScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplayScene.TabIndex = 18;
            this.pictureBoxDisplayScene.TabStop = false;
            // 
            // groupBoxObjMat
            // 
            this.groupBoxObjMat.Controls.Add(this.radioButtonSponge);
            this.groupBoxObjMat.Controls.Add(this.radioButtonWood);
            this.groupBoxObjMat.Controls.Add(this.radioButtonCeramic);
            this.groupBoxObjMat.Controls.Add(this.radioButtonPlastic);
            this.groupBoxObjMat.Controls.Add(this.radioButtonAl);
            this.groupBoxObjMat.Controls.Add(this.radioButtonFe);
            this.groupBoxObjMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxObjMat.Location = new System.Drawing.Point(804, 36);
            this.groupBoxObjMat.Name = "groupBoxObjMat";
            this.groupBoxObjMat.Size = new System.Drawing.Size(186, 190);
            this.groupBoxObjMat.TabIndex = 21;
            this.groupBoxObjMat.TabStop = false;
            this.groupBoxObjMat.Text = "Sensing object material";
            // 
            // radioButtonSponge
            // 
            this.radioButtonSponge.AutoSize = true;
            this.radioButtonSponge.Location = new System.Drawing.Point(6, 156);
            this.radioButtonSponge.Name = "radioButtonSponge";
            this.radioButtonSponge.Size = new System.Drawing.Size(159, 20);
            this.radioButtonSponge.TabIndex = 5;
            this.radioButtonSponge.Text = "radioButtonSponge";
            this.radioButtonSponge.UseVisualStyleBackColor = true;
            this.radioButtonSponge.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonWood
            // 
            this.radioButtonWood.AutoSize = true;
            this.radioButtonWood.Location = new System.Drawing.Point(6, 130);
            this.radioButtonWood.Name = "radioButtonWood";
            this.radioButtonWood.Size = new System.Drawing.Size(146, 20);
            this.radioButtonWood.TabIndex = 4;
            this.radioButtonWood.Text = "radioButtonWood";
            this.radioButtonWood.UseVisualStyleBackColor = true;
            this.radioButtonWood.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonCeramic
            // 
            this.radioButtonCeramic.AutoSize = true;
            this.radioButtonCeramic.Location = new System.Drawing.Point(6, 104);
            this.radioButtonCeramic.Name = "radioButtonCeramic";
            this.radioButtonCeramic.Size = new System.Drawing.Size(162, 20);
            this.radioButtonCeramic.TabIndex = 3;
            this.radioButtonCeramic.Text = "radioButtonCeramic";
            this.radioButtonCeramic.UseVisualStyleBackColor = true;
            this.radioButtonCeramic.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonPlastic
            // 
            this.radioButtonPlastic.AutoSize = true;
            this.radioButtonPlastic.Location = new System.Drawing.Point(6, 78);
            this.radioButtonPlastic.Name = "radioButtonPlastic";
            this.radioButtonPlastic.Size = new System.Drawing.Size(152, 20);
            this.radioButtonPlastic.TabIndex = 2;
            this.radioButtonPlastic.Text = "radioButtonPlastic";
            this.radioButtonPlastic.UseVisualStyleBackColor = true;
            this.radioButtonPlastic.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Location = new System.Drawing.Point(6, 52);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(119, 20);
            this.radioButtonAl.TabIndex = 1;
            this.radioButtonAl.Text = "radioButtonAl";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            this.radioButtonAl.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonFe
            // 
            this.radioButtonFe.AutoSize = true;
            this.radioButtonFe.Checked = true;
            this.radioButtonFe.Location = new System.Drawing.Point(6, 26);
            this.radioButtonFe.Name = "radioButtonFe";
            this.radioButtonFe.Size = new System.Drawing.Size(123, 20);
            this.radioButtonFe.TabIndex = 0;
            this.radioButtonFe.TabStop = true;
            this.radioButtonFe.Text = "radioButtonFe";
            this.radioButtonFe.UseVisualStyleBackColor = true;
            this.radioButtonFe.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // labelVoltMet
            // 
            this.labelVoltMet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelVoltMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVoltMet.Location = new System.Drawing.Point(269, 71);
            this.labelVoltMet.Name = "labelVoltMet";
            this.labelVoltMet.Size = new System.Drawing.Size(85, 25);
            this.labelVoltMet.TabIndex = 22;
            this.labelVoltMet.Text = "labelVoltMet";
            this.labelVoltMet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPSUVolt
            // 
            this.labelPSUVolt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelPSUVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPSUVolt.Location = new System.Drawing.Point(515, 114);
            this.labelPSUVolt.Name = "labelPSUVolt";
            this.labelPSUVolt.Size = new System.Drawing.Size(109, 25);
            this.labelPSUVolt.TabIndex = 23;
            this.labelPSUVolt.Text = "labelPSUVolt";
            this.labelPSUVolt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(634, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "V";
            // 
            // labelRuler
            // 
            this.labelRuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRuler.Location = new System.Drawing.Point(555, 459);
            this.labelRuler.Name = "labelRuler";
            this.labelRuler.Size = new System.Drawing.Size(128, 20);
            this.labelRuler.TabIndex = 25;
            this.labelRuler.Text = "labelRuler";
            this.labelRuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIncDist
            // 
            this.buttonIncDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncDist.Location = new System.Drawing.Point(15, 374);
            this.buttonIncDist.Name = "buttonIncDist";
            this.buttonIncDist.Size = new System.Drawing.Size(42, 42);
            this.buttonIncDist.TabIndex = 26;
            this.buttonIncDist.Text = "<";
            this.buttonIncDist.UseVisualStyleBackColor = true;
            this.buttonIncDist.Click += new System.EventHandler(this.buttonIncDist_Click);
            // 
            // buttonDecDist
            // 
            this.buttonDecDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecDist.Location = new System.Drawing.Point(63, 374);
            this.buttonDecDist.Name = "buttonDecDist";
            this.buttonDecDist.Size = new System.Drawing.Size(42, 42);
            this.buttonDecDist.TabIndex = 27;
            this.buttonDecDist.Text = ">";
            this.buttonDecDist.UseVisualStyleBackColor = true;
            this.buttonDecDist.Click += new System.EventHandler(this.buttonDecDist_Click);
            // 
            // pictureBoxIndicator
            // 
            this.pictureBoxIndicator.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxIndicator.Location = new System.Drawing.Point(656, 385);
            this.pictureBoxIndicator.Name = "pictureBoxIndicator";
            this.pictureBoxIndicator.Size = new System.Drawing.Size(18, 19);
            this.pictureBoxIndicator.TabIndex = 30;
            this.pictureBoxIndicator.TabStop = false;
            // 
            // timerSample
            // 
            this.timerSample.Tick += new System.EventHandler(this.timerSample_Tick);
            // 
            // checkBoxPWRON
            // 
            this.checkBoxPWRON.AutoSize = true;
            this.checkBoxPWRON.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPWRON.Location = new System.Drawing.Point(636, 187);
            this.checkBoxPWRON.Name = "checkBoxPWRON";
            this.checkBoxPWRON.Size = new System.Drawing.Size(198, 28);
            this.checkBoxPWRON.TabIndex = 31;
            this.checkBoxPWRON.Text = "checkBoxPWRON";
            this.checkBoxPWRON.UseVisualStyleBackColor = true;
            this.checkBoxPWRON.CheckedChanged += new System.EventHandler(this.checkBoxPWRON_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(555, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Distance [mm]:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxPWRON);
            this.Controls.Add(this.pictureBoxIndicator);
            this.Controls.Add(this.buttonDecDist);
            this.Controls.Add(this.buttonIncDist);
            this.Controls.Add(this.labelRuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPSUVolt);
            this.Controls.Add(this.labelVoltMet);
            this.Controls.Add(this.groupBoxObjMat);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.pictureBoxDisplayScene);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ultrasonic Sensor - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene)).EndInit();
            this.groupBoxObjMat.ResumeLayout(false);
            this.groupBoxObjMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxDisplayScene;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.GroupBox groupBoxObjMat;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonFe;
        private System.Windows.Forms.Label labelVoltMet;
        private System.Windows.Forms.Label labelPSUVolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRuler;
        private System.Windows.Forms.Button buttonIncDist;
        private System.Windows.Forms.Button buttonDecDist;
        private System.Windows.Forms.PictureBox pictureBoxIndicator;
        private System.Windows.Forms.Timer timerSample;
        private System.Windows.Forms.CheckBox checkBoxPWRON;
        private System.Windows.Forms.RadioButton radioButtonSponge;
        private System.Windows.Forms.RadioButton radioButtonWood;
        private System.Windows.Forms.RadioButton radioButtonCeramic;
        private System.Windows.Forms.RadioButton radioButtonPlastic;
        private System.Windows.Forms.Label label2;
    }
}

