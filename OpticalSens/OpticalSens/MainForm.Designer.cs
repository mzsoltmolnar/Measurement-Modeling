namespace OpticalSens
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
            this.groupBoxObjMat = new System.Windows.Forms.GroupBox();
            this.radioButtonPlastic = new System.Windows.Forms.RadioButton();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonWood = new System.Windows.Forms.RadioButton();
            this.radioButtonFe = new System.Windows.Forms.RadioButton();
            this.labelVoltMet = new System.Windows.Forms.Label();
            this.labelPSUVolt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRuler = new System.Windows.Forms.Label();
            this.buttonIncDist = new System.Windows.Forms.Button();
            this.buttonDecDist = new System.Windows.Forms.Button();
            this.timerSample = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPWRON = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlSensor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxIndicator = new System.Windows.Forms.PictureBox();
            this.pictureBoxDisplayScene = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxInstable2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIndicator2 = new System.Windows.Forms.PictureBox();
            this.buttonObstruct = new System.Windows.Forms.Button();
            this.buttonUnobstruct = new System.Windows.Forms.Button();
            this.labelVoltMet2 = new System.Windows.Forms.Label();
            this.labelPSUVolt2 = new System.Windows.Forms.Label();
            this.checkBoxPWRON2 = new System.Windows.Forms.CheckBox();
            this.pictureBoxDisplayScene2 = new System.Windows.Forms.PictureBox();
            this.groupBoxObjMat.SuspendLayout();
            this.tabControlSensor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Optical Sensor Measurement Modeling";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(912, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 19;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // groupBoxObjMat
            // 
            this.groupBoxObjMat.Controls.Add(this.radioButtonPlastic);
            this.groupBoxObjMat.Controls.Add(this.radioButtonAl);
            this.groupBoxObjMat.Controls.Add(this.radioButtonWood);
            this.groupBoxObjMat.Controls.Add(this.radioButtonFe);
            this.groupBoxObjMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxObjMat.Location = new System.Drawing.Point(1001, 61);
            this.groupBoxObjMat.Name = "groupBoxObjMat";
            this.groupBoxObjMat.Size = new System.Drawing.Size(186, 133);
            this.groupBoxObjMat.TabIndex = 21;
            this.groupBoxObjMat.TabStop = false;
            this.groupBoxObjMat.Text = "Target object material";
            // 
            // radioButtonPlastic
            // 
            this.radioButtonPlastic.AutoSize = true;
            this.radioButtonPlastic.Location = new System.Drawing.Point(6, 104);
            this.radioButtonPlastic.Name = "radioButtonPlastic";
            this.radioButtonPlastic.Size = new System.Drawing.Size(152, 20);
            this.radioButtonPlastic.TabIndex = 3;
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
            // radioButtonWood
            // 
            this.radioButtonWood.AutoSize = true;
            this.radioButtonWood.Location = new System.Drawing.Point(6, 78);
            this.radioButtonWood.Name = "radioButtonWood";
            this.radioButtonWood.Size = new System.Drawing.Size(146, 20);
            this.radioButtonWood.TabIndex = 2;
            this.radioButtonWood.Text = "radioButtonWood";
            this.radioButtonWood.UseVisualStyleBackColor = true;
            this.radioButtonWood.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
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
            this.labelVoltMet.BackColor = System.Drawing.Color.DarkGray;
            this.labelVoltMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVoltMet.Location = new System.Drawing.Point(626, 167);
            this.labelVoltMet.Name = "labelVoltMet";
            this.labelVoltMet.Size = new System.Drawing.Size(56, 24);
            this.labelVoltMet.TabIndex = 22;
            this.labelVoltMet.Text = "labelVoltMet";
            this.labelVoltMet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPSUVolt
            // 
            this.labelPSUVolt.BackColor = System.Drawing.Color.DarkGray;
            this.labelPSUVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPSUVolt.Location = new System.Drawing.Point(775, 269);
            this.labelPSUVolt.Name = "labelPSUVolt";
            this.labelPSUVolt.Size = new System.Drawing.Size(65, 25);
            this.labelPSUVolt.TabIndex = 23;
            this.labelPSUVolt.Text = "labelPSUVolt";
            this.labelPSUVolt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(618, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "V";
            // 
            // labelRuler
            // 
            this.labelRuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRuler.Location = new System.Drawing.Point(78, 377);
            this.labelRuler.Name = "labelRuler";
            this.labelRuler.Size = new System.Drawing.Size(128, 20);
            this.labelRuler.TabIndex = 25;
            this.labelRuler.Text = "labelRuler";
            this.labelRuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIncDist
            // 
            this.buttonIncDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncDist.Location = new System.Drawing.Point(30, 357);
            this.buttonIncDist.Name = "buttonIncDist";
            this.buttonIncDist.Size = new System.Drawing.Size(42, 40);
            this.buttonIncDist.TabIndex = 26;
            this.buttonIncDist.Text = "<";
            this.buttonIncDist.UseVisualStyleBackColor = true;
            this.buttonIncDist.Click += new System.EventHandler(this.buttonIncDist_Click);
            // 
            // buttonDecDist
            // 
            this.buttonDecDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecDist.Location = new System.Drawing.Point(212, 357);
            this.buttonDecDist.Name = "buttonDecDist";
            this.buttonDecDist.Size = new System.Drawing.Size(42, 40);
            this.buttonDecDist.TabIndex = 27;
            this.buttonDecDist.Text = ">";
            this.buttonDecDist.UseVisualStyleBackColor = true;
            this.buttonDecDist.Click += new System.EventHandler(this.buttonDecDist_Click);
            // 
            // timerSample
            // 
            this.timerSample.Tick += new System.EventHandler(this.timerSample_Tick);
            // 
            // checkBoxPWRON
            // 
            this.checkBoxPWRON.AutoSize = true;
            this.checkBoxPWRON.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxPWRON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPWRON.Location = new System.Drawing.Point(848, 295);
            this.checkBoxPWRON.Name = "checkBoxPWRON";
            this.checkBoxPWRON.Size = new System.Drawing.Size(129, 17);
            this.checkBoxPWRON.TabIndex = 31;
            this.checkBoxPWRON.Text = "checkBoxPWRON";
            this.checkBoxPWRON.UseVisualStyleBackColor = false;
            this.checkBoxPWRON.CheckedChanged += new System.EventHandler(this.checkBoxPWRON_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Distance [mm]:";
            // 
            // tabControlSensor
            // 
            this.tabControlSensor.Controls.Add(this.tabPage1);
            this.tabControlSensor.Controls.Add(this.tabPage2);
            this.tabControlSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlSensor.Location = new System.Drawing.Point(12, 36);
            this.tabControlSensor.Name = "tabControlSensor";
            this.tabControlSensor.SelectedIndex = 0;
            this.tabControlSensor.Size = new System.Drawing.Size(983, 493);
            this.tabControlSensor.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelVoltMet);
            this.tabPage1.Controls.Add(this.checkBoxPWRON);
            this.tabPage1.Controls.Add(this.labelPSUVolt);
            this.tabPage1.Controls.Add(this.pictureBoxIndicator);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonDecDist);
            this.tabPage1.Controls.Add(this.labelRuler);
            this.tabPage1.Controls.Add(this.buttonIncDist);
            this.tabPage1.Controls.Add(this.pictureBoxDisplayScene);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diffuse-reflective sensor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(851, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "V";
            // 
            // pictureBoxIndicator
            // 
            this.pictureBoxIndicator.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxIndicator.Location = new System.Drawing.Point(799, 307);
            this.pictureBoxIndicator.Name = "pictureBoxIndicator";
            this.pictureBoxIndicator.Size = new System.Drawing.Size(12, 12);
            this.pictureBoxIndicator.TabIndex = 30;
            this.pictureBoxIndicator.TabStop = false;
            // 
            // pictureBoxDisplayScene
            // 
            this.pictureBoxDisplayScene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDisplayScene.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDisplayScene.Image")));
            this.pictureBoxDisplayScene.InitialImage = null;
            this.pictureBoxDisplayScene.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDisplayScene.Name = "pictureBoxDisplayScene";
            this.pictureBoxDisplayScene.Size = new System.Drawing.Size(968, 454);
            this.pictureBoxDisplayScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplayScene.TabIndex = 18;
            this.pictureBoxDisplayScene.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBoxInstable2);
            this.tabPage2.Controls.Add(this.pictureBoxIndicator2);
            this.tabPage2.Controls.Add(this.buttonObstruct);
            this.tabPage2.Controls.Add(this.buttonUnobstruct);
            this.tabPage2.Controls.Add(this.labelVoltMet2);
            this.tabPage2.Controls.Add(this.labelPSUVolt2);
            this.tabPage2.Controls.Add(this.checkBoxPWRON2);
            this.tabPage2.Controls.Add(this.pictureBoxDisplayScene2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Retroreflective sensor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(697, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(476, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "V";
            // 
            // pictureBoxInstable2
            // 
            this.pictureBoxInstable2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxInstable2.Location = new System.Drawing.Point(624, 282);
            this.pictureBoxInstable2.Name = "pictureBoxInstable2";
            this.pictureBoxInstable2.Size = new System.Drawing.Size(12, 12);
            this.pictureBoxInstable2.TabIndex = 38;
            this.pictureBoxInstable2.TabStop = false;
            // 
            // pictureBoxIndicator2
            // 
            this.pictureBoxIndicator2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxIndicator2.Location = new System.Drawing.Point(591, 264);
            this.pictureBoxIndicator2.Name = "pictureBoxIndicator2";
            this.pictureBoxIndicator2.Size = new System.Drawing.Size(12, 12);
            this.pictureBoxIndicator2.TabIndex = 37;
            this.pictureBoxIndicator2.TabStop = false;
            // 
            // buttonObstruct
            // 
            this.buttonObstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonObstruct.Location = new System.Drawing.Point(460, 359);
            this.buttonObstruct.Name = "buttonObstruct";
            this.buttonObstruct.Size = new System.Drawing.Size(42, 40);
            this.buttonObstruct.TabIndex = 36;
            this.buttonObstruct.Text = ">";
            this.buttonObstruct.UseVisualStyleBackColor = true;
            this.buttonObstruct.Click += new System.EventHandler(this.buttonObstruct_Click);
            // 
            // buttonUnobstruct
            // 
            this.buttonUnobstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUnobstruct.Location = new System.Drawing.Point(241, 359);
            this.buttonUnobstruct.Name = "buttonUnobstruct";
            this.buttonUnobstruct.Size = new System.Drawing.Size(42, 40);
            this.buttonUnobstruct.TabIndex = 35;
            this.buttonUnobstruct.Text = "<";
            this.buttonUnobstruct.UseVisualStyleBackColor = true;
            this.buttonUnobstruct.Click += new System.EventHandler(this.buttonUnobstruct_Click);
            // 
            // labelVoltMet2
            // 
            this.labelVoltMet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelVoltMet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVoltMet2.Location = new System.Drawing.Point(480, 62);
            this.labelVoltMet2.Name = "labelVoltMet2";
            this.labelVoltMet2.Size = new System.Drawing.Size(54, 23);
            this.labelVoltMet2.TabIndex = 34;
            this.labelVoltMet2.Text = "labelVoltMet2";
            this.labelVoltMet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPSUVolt2
            // 
            this.labelPSUVolt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelPSUVolt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPSUVolt2.Location = new System.Drawing.Point(631, 203);
            this.labelPSUVolt2.Name = "labelPSUVolt2";
            this.labelPSUVolt2.Size = new System.Drawing.Size(54, 20);
            this.labelPSUVolt2.TabIndex = 33;
            this.labelPSUVolt2.Text = "labelPSUVolt2";
            this.labelPSUVolt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPWRON2
            // 
            this.checkBoxPWRON2.AutoSize = true;
            this.checkBoxPWRON2.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxPWRON2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPWRON2.Location = new System.Drawing.Point(688, 259);
            this.checkBoxPWRON2.Name = "checkBoxPWRON2";
            this.checkBoxPWRON2.Size = new System.Drawing.Size(136, 17);
            this.checkBoxPWRON2.TabIndex = 32;
            this.checkBoxPWRON2.Text = "checkBoxPWRON2";
            this.checkBoxPWRON2.UseVisualStyleBackColor = false;
            this.checkBoxPWRON2.CheckedChanged += new System.EventHandler(this.checkBoxPWRON2_CheckedChanged);
            // 
            // pictureBoxDisplayScene2
            // 
            this.pictureBoxDisplayScene2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDisplayScene2.Image = global::OpticalSens.Properties.Resources.retro_annotations;
            this.pictureBoxDisplayScene2.InitialImage = null;
            this.pictureBoxDisplayScene2.Location = new System.Drawing.Point(114, 6);
            this.pictureBoxDisplayScene2.Name = "pictureBoxDisplayScene2";
            this.pictureBoxDisplayScene2.Size = new System.Drawing.Size(754, 454);
            this.pictureBoxDisplayScene2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplayScene2.TabIndex = 19;
            this.pictureBoxDisplayScene2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 535);
            this.Controls.Add(this.tabControlSensor);
            this.Controls.Add(this.groupBoxObjMat);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Optical Sensor - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxObjMat.ResumeLayout(false);
            this.groupBoxObjMat.PerformLayout();
            this.tabControlSensor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayScene2)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButtonWood;
        private System.Windows.Forms.RadioButton radioButtonPlastic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlSensor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxDisplayScene2;
        private System.Windows.Forms.CheckBox checkBoxPWRON2;
        private System.Windows.Forms.Label labelVoltMet2;
        private System.Windows.Forms.Label labelPSUVolt2;
        private System.Windows.Forms.Button buttonObstruct;
        private System.Windows.Forms.Button buttonUnobstruct;
        private System.Windows.Forms.PictureBox pictureBoxInstable2;
        private System.Windows.Forms.PictureBox pictureBoxIndicator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

