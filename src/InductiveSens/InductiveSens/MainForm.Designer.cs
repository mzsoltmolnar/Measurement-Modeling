namespace InductiveSens
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
            this.imageInductiveSensor = new System.Windows.Forms.PictureBox();
            this.groupBoxObjMat = new System.Windows.Forms.GroupBox();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonFe = new System.Windows.Forms.RadioButton();
            this.labelVoltMet = new System.Windows.Forms.Label();
            this.labelPSUVolt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCaliper = new System.Windows.Forms.Label();
            this.buttonIncDist = new System.Windows.Forms.Button();
            this.buttonDecDist = new System.Windows.Forms.Button();
            this.buttonIncVoltage = new System.Windows.Forms.Button();
            this.buttonDecVoltage = new System.Windows.Forms.Button();
            this.pictureBoxIndicator = new System.Windows.Forms.PictureBox();
            this.timerSample = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPWRON = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageInductiveSensor)).BeginInit();
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
            this.label4.Size = new System.Drawing.Size(392, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Inductive Sensor Measurement Modeling";
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
            // imageInductiveSensor
            // 
            this.imageInductiveSensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageInductiveSensor.Image = ((System.Drawing.Image)(resources.GetObject("imageInductiveSensor.Image")));
            this.imageInductiveSensor.InitialImage = null;
            this.imageInductiveSensor.Location = new System.Drawing.Point(12, 36);
            this.imageInductiveSensor.Name = "imageInductiveSensor";
            this.imageInductiveSensor.Size = new System.Drawing.Size(786, 454);
            this.imageInductiveSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageInductiveSensor.TabIndex = 18;
            this.imageInductiveSensor.TabStop = false;
            // 
            // groupBoxObjMat
            // 
            this.groupBoxObjMat.Controls.Add(this.radioButtonAl);
            this.groupBoxObjMat.Controls.Add(this.radioButtonFe);
            this.groupBoxObjMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxObjMat.Location = new System.Drawing.Point(804, 36);
            this.groupBoxObjMat.Name = "groupBoxObjMat";
            this.groupBoxObjMat.Size = new System.Drawing.Size(186, 84);
            this.groupBoxObjMat.TabIndex = 21;
            this.groupBoxObjMat.TabStop = false;
            this.groupBoxObjMat.Text = "Sensing object material";
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
            this.radioButtonAl.CheckedChanged += new System.EventHandler(this.radioButtonAl_CheckedChanged);
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
            this.radioButtonFe.CheckedChanged += new System.EventHandler(this.radioButtonFe_CheckedChanged);
            // 
            // labelVoltMet
            // 
            this.labelVoltMet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelVoltMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVoltMet.Location = new System.Drawing.Point(315, 79);
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
            this.labelPSUVolt.Location = new System.Drawing.Point(569, 124);
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
            this.label1.Location = new System.Drawing.Point(690, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "V";
            // 
            // labelCaliper
            // 
            this.labelCaliper.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelCaliper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCaliper.Location = new System.Drawing.Point(134, 383);
            this.labelCaliper.Name = "labelCaliper";
            this.labelCaliper.Size = new System.Drawing.Size(62, 20);
            this.labelCaliper.TabIndex = 25;
            this.labelCaliper.Text = "labelCaliper";
            this.labelCaliper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIncDist
            // 
            this.buttonIncDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncDist.Location = new System.Drawing.Point(210, 435);
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
            this.buttonDecDist.Location = new System.Drawing.Point(281, 435);
            this.buttonDecDist.Name = "buttonDecDist";
            this.buttonDecDist.Size = new System.Drawing.Size(42, 42);
            this.buttonDecDist.TabIndex = 27;
            this.buttonDecDist.Text = ">";
            this.buttonDecDist.UseVisualStyleBackColor = true;
            this.buttonDecDist.Click += new System.EventHandler(this.buttonDecDist_Click);
            // 
            // buttonIncVoltage
            // 
            this.buttonIncVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIncVoltage.Location = new System.Drawing.Point(723, 168);
            this.buttonIncVoltage.Name = "buttonIncVoltage";
            this.buttonIncVoltage.Size = new System.Drawing.Size(30, 30);
            this.buttonIncVoltage.TabIndex = 28;
            this.buttonIncVoltage.Text = "▲";
            this.buttonIncVoltage.UseVisualStyleBackColor = true;
            this.buttonIncVoltage.Click += new System.EventHandler(this.buttonIncVoltage_Click);
            // 
            // buttonDecVoltage
            // 
            this.buttonDecVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecVoltage.Location = new System.Drawing.Point(723, 204);
            this.buttonDecVoltage.Name = "buttonDecVoltage";
            this.buttonDecVoltage.Size = new System.Drawing.Size(30, 30);
            this.buttonDecVoltage.TabIndex = 29;
            this.buttonDecVoltage.Text = "▼";
            this.buttonDecVoltage.UseVisualStyleBackColor = true;
            this.buttonDecVoltage.Click += new System.EventHandler(this.buttonDecVoltage_Click);
            // 
            // pictureBoxIndicator
            // 
            this.pictureBoxIndicator.Location = new System.Drawing.Point(172, 321);
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
            this.checkBoxPWRON.Location = new System.Drawing.Point(618, 198);
            this.checkBoxPWRON.Name = "checkBoxPWRON";
            this.checkBoxPWRON.Size = new System.Drawing.Size(198, 28);
            this.checkBoxPWRON.TabIndex = 31;
            this.checkBoxPWRON.Text = "checkBoxPWRON";
            this.checkBoxPWRON.UseVisualStyleBackColor = true;
            this.checkBoxPWRON.CheckedChanged += new System.EventHandler(this.checkBoxPWRON_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 501);
            this.Controls.Add(this.checkBoxPWRON);
            this.Controls.Add(this.pictureBoxIndicator);
            this.Controls.Add(this.buttonDecVoltage);
            this.Controls.Add(this.buttonIncVoltage);
            this.Controls.Add(this.buttonDecDist);
            this.Controls.Add(this.buttonIncDist);
            this.Controls.Add(this.labelCaliper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPSUVolt);
            this.Controls.Add(this.labelVoltMet);
            this.Controls.Add(this.groupBoxObjMat);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.imageInductiveSensor);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inductive Sensor - zsomoTech Measurement Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageInductiveSensor)).EndInit();
            this.groupBoxObjMat.ResumeLayout(false);
            this.groupBoxObjMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imageInductiveSensor;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.GroupBox groupBoxObjMat;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonFe;
        private System.Windows.Forms.Label labelVoltMet;
        private System.Windows.Forms.Label labelPSUVolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCaliper;
        private System.Windows.Forms.Button buttonIncDist;
        private System.Windows.Forms.Button buttonDecDist;
        private System.Windows.Forms.Button buttonIncVoltage;
        private System.Windows.Forms.Button buttonDecVoltage;
        private System.Windows.Forms.PictureBox pictureBoxIndicator;
        private System.Windows.Forms.Timer timerSample;
        private System.Windows.Forms.CheckBox checkBoxPWRON;
    }
}

