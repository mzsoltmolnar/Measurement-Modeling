using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tempMeas.Properties;

namespace solarCell
{
    public partial class MainForm : Form
    {

        Measurement measMent = new Measurement(); // measurement object - defining the properties of the temperature sensors

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) // initialize the UI objects
        {
            checkBoxPSUON.BackColor = Color.Red;
            timerSampling.Enabled = true;
        }

        private void timerSampling_Tick(object sender, EventArgs e) // updating the UI
        {
            if (checkBoxPSUON.Checked)
            {
                checkBoxPSUON.BackColor = Color.LimeGreen;
                pictureBoxDisplayScene.Image = Resources.img_0;
                labelPSUVoltage.Text = "60.0";

                measMent.TempIncrement(0.0099); // increment the temperature if the power is on
            }
            else
            {
                checkBoxPSUON.BackColor = Color.Red;
                pictureBoxDisplayScene.Image = Resources.annotations;
                labelPSUVoltage.Text = "";

                measMent.TempDecrement(0.001); // decrement the temperature if the power is off
            }

            labelThermometTemp.Text = measMent.GetTemperature().ToString("0.00");

            labelMultiPT100.Text = measMent.GetPT100().ToString("0.0");
            labelMultiThermistor.Text = measMent.GetThermistor().ToString("0.00");
            labelMultiThermocouple.Text = measMent.GetThermocouple().ToString("0.00");

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }
    }
}
