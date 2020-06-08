using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitiveSens
{
    public partial class MainForm : Form
    {
        Measurement measMent = new Measurement(); // measurement object - defining the properties of the capacitive sensor

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) // initialize the UI objects
        {
            measMent.LoadData();
            measMent.ResetLimits();
            measMent.ResetDistance();
            pictureBoxDisplayScene.Image = measMent.GetLayout(0);
            radioButtonFe.Text = "Fe";
            radioButtonAl.Text = "Al";
            radioButtonPlastic.Text = "Plastic";
            radioButtonCeramic.Text = "Ceramic";
            radioButtonWood.Text = "Wood";
            radioButtonPaper.Text = "Paper";
            checkBoxPWRON.Text = "ON";
            timerSample.Enabled = true;
        }

        private void checkBoxPWRON_CheckedChanged(object sender, EventArgs e) /* when the power is cycled, reset the distance to the initial value and the limits regenerated */
        {
            measMent.ResetDistance();
            measMent.ResetLimits();
        }

        private void buttonIncDist_Click(object sender, EventArgs e)
        {
            measMent.IncrementDist();
            measMent.ResetLimits();
        }

        private void buttonDecDist_Click(object sender, EventArgs e)
        {
            measMent.DecrementDist();
        }

        private void timerSample_Tick(object sender, EventArgs e) // updating the UI
        {
            int material = 0;
            if (radioButtonFe.Checked) material = 0; // check which material was selected
            if (radioButtonAl.Checked) material = 1;
            if (radioButtonPaper.Checked) material = 2;
            if (radioButtonCeramic.Checked) material = 3;
            if (radioButtonWood.Checked) material = 4;
            if (radioButtonPaper.Checked) material = 5;
                       
            if (checkBoxPWRON.Checked)
            {
                checkBoxPWRON.BackColor = Color.LimeGreen;
                pictureBoxDisplayScene.Image = measMent.GetLayout();
                labelPSUVolt.Text = measMent.voltage.ToString("0.0");
                if (measMent.GetSensing(material))
                {
                    pictureBoxIndicator.BackColor = Color.Orange;
                }
                else
                {
                    pictureBoxIndicator.BackColor = BackColor;
                }
                labelVoltMet.Text = measMent.GetOutVoltage(material).ToString("0.00");
                labelCaliper.Text = measMent.distance.ToString("0.00");
            }
            else
            {
                checkBoxPWRON.BackColor = BackColor;
                pictureBoxDisplayScene.Image = measMent.GetLayout(0);
                labelPSUVolt.Text = "";
                pictureBoxIndicator.BackColor = BackColor;
                labelVoltMet.Text = measMent.AddNoise(0.0f).ToString("0.00");
                labelCaliper.Text = "0.00";
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e) // reset the distance and regenerate the limits if a new material is selected
        {
            measMent.ResetDistance();
            measMent.ResetLimits();
        }
    }
}
