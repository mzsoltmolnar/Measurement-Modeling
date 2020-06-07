using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OpticalSens
{
    public partial class MainForm : Form
    {
        Measurement measMent = new Measurement(); // measurement object - defining the properties of the optical sensors

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
            radioButtonPlastic.Text = "Plexiglass";
            radioButtonWood.Text = "Wood";
            checkBoxPWRON.Text = "ON";
            checkBoxPWRON2.Text = "ON";
            timerSample.Enabled = true;
        }


        private void checkBoxPWRON_CheckedChanged(object sender, EventArgs e) // when the power is cycled, reset the distance to the initial value
        {
            measMent.ResetDistance();
        }

        private void checkBoxPWRON2_CheckedChanged(object sender, EventArgs e) // when the power is cycled,  move away the obstructing object
        {
            measMent.ResetObstruction();
        }

        private void buttonIncDist_Click(object sender, EventArgs e)
        {
            measMent.IncrementDist();
        }

        private void buttonDecDist_Click(object sender, EventArgs e)
        {
            measMent.DecrementDist();
        }

        private void timerSample_Tick(object sender, EventArgs e) // updating the UI
        {
            int material = 0;
            if (radioButtonFe.Checked) material = 0;
            if (radioButtonAl.Checked) material = 1;
            if (radioButtonWood.Checked) material = 2;
            if (radioButtonPlastic.Checked) material = 3;

            if (checkBoxPWRON.Checked)
            {
                // tab 1 - Diffuse sensor
                checkBoxPWRON.BackColor = Color.LimeGreen;
                pictureBoxDisplayScene.Image = measMent.GetLayout();
                labelPSUVolt.Text = measMent.voltage.ToString("0.0");
                if (measMent.GetSensing(material))
                {
                    pictureBoxIndicator.BackColor = Color.Orange;
                }
                else
                {
                    pictureBoxIndicator.BackColor = Color.DarkGray;
                }

                labelVoltMet.Text = measMent.GetOutVoltage(material).ToString("0.00");
                //  labelVoltMet.
                labelRuler.Text = measMent.distance.ToString("0.00");
            }
            else
            {
                checkBoxPWRON.BackColor = BackColor;
                pictureBoxDisplayScene.Image = measMent.GetLayout(0);
                labelPSUVolt.Text = "";
                pictureBoxIndicator.BackColor = Color.DarkGray;
                labelVoltMet.Text = measMent.AddNoise(0.0f).ToString("0.00");
                labelRuler.Text = "0.00";
            }

            // tab 2 - Retroreflective sensor
            checkBoxPWRON2.BackColor = Color.LimeGreen;

            if (checkBoxPWRON2.Checked)
            {
                pictureBoxDisplayScene2.Image = measMent.GetRetroreflectLayout(material);
                labelPSUVolt2.Text = measMent.voltage.ToString("0.0");
                if (!measMent.GetRetroSensing(material))
                {
                    pictureBoxIndicator2.BackColor = Color.Orange;
                }
                else
                {
                    pictureBoxIndicator2.BackColor = Color.DarkGray;
                }

                if(measMent.IsRetroInstable(material))
                {
                    pictureBoxInstable2.BackColor = Color.Red;
                }
                else
                {
                    pictureBoxInstable2.BackColor = Color.DarkGray;
                }
                labelVoltMet2.Text = measMent.GetRetroOutVoltage(material).ToString("0.00");
            }
            else
            {
                checkBoxPWRON2.BackColor = BackColor;
                pictureBoxDisplayScene2.Image = measMent.GetRetroreflectLayout(-1);
                labelPSUVolt2.Text = "";
                pictureBoxIndicator2.BackColor = Color.DarkGray;
                pictureBoxInstable2.BackColor = Color.DarkGray;
                labelVoltMet2.Text = measMent.AddNoise(0.0f).ToString("0.00");
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e) // if the material is changed, reset the distance
        {
            measMent.ResetDistance();
            measMent.ResetObstruction();
        }

        private void buttonUnobstruct_Click(object sender, EventArgs e) // moving the obstructing object 
        {
            measMent.RetroreflectUnobstruct();
        }

        private void buttonObstruct_Click(object sender, EventArgs e) // moving the obstructing object 
        {
            measMent.RetroreflectObstruct();
        }
    }
}
