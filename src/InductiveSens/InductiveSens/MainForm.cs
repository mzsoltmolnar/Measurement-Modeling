using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InductiveSens
{
    public partial class MainForm : Form
    {
        Measurement measMent = new Measurement();

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
            imageInductiveSensor.Image = measMent.GetLayout(0);
            radioButtonFe.Text = "Fe";
            radioButtonAl.Text = "Al";
            checkBoxPWRON.Text = "ON";
            timerSample.Enabled = true;
        }

        private void checkBoxPWRON_CheckedChanged(object sender, EventArgs e)
        // when the power is cycled, the distance is reset to the initial value and sensing limits are reset to a new random value
        {
            measMent.ResetDistance();
            measMent.ResetLimits();
        }

        private void buttonIncDist_Click(object sender, EventArgs e) // when the distance is increased, the sensing limits are reset
        {
            measMent.IncrementDist();
            measMent.ResetLimits();
        }

        private void buttonDecDist_Click(object sender, EventArgs e)
        {
            measMent.DecrementDist();
        }

        private void timerSample_Tick(object sender, EventArgs e) // the timer updates the UI
        {
            if (checkBoxPWRON.Checked)
            {
                checkBoxPWRON.BackColor = Color.LimeGreen;
                imageInductiveSensor.Image = measMent.GetLayout();
                labelPSUVolt.Text = measMent.voltage.ToString("0.0");
                if (measMent.GetSensing(radioButtonFe.Checked ? 0 : 1))
                {
                    pictureBoxIndicator.BackColor = Color.Orange;
                }
                else
                {
                    pictureBoxIndicator.BackColor = BackColor;
                }
                labelVoltMet.Text = measMent.GetOutVoltage(radioButtonFe.Checked ? 0 : 1).ToString("0.00");
            }
            else
            {
                checkBoxPWRON.BackColor = BackColor;
                imageInductiveSensor.Image = measMent.GetLayout(0);
                labelPSUVolt.Text = "";
                pictureBoxIndicator.BackColor = BackColor;
                labelVoltMet.Text = measMent.AddNoise(0.0f).ToString("0.00");
            }
            labelCaliper.Text = measMent.distance.ToString("0.00");
        }

        private void buttonIncVoltage_Click(object sender, EventArgs e)
        {
            measMent.IncrementVoltage();
            measMent.ResetDistance();
            measMent.ResetLimits();
        }

        private void buttonDecVoltage_Click(object sender, EventArgs e)
        {
            measMent.DecrementVoltage();
            measMent.ResetDistance();
            measMent.ResetLimits();
        }

        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
            measMent.ResetDistance();
            measMent.ResetLimits();
        }

        private void radioButtonFe_CheckedChanged(object sender, EventArgs e)
        {
            measMent.ResetDistance();
            measMent.ResetLimits();
        }
    }
}
