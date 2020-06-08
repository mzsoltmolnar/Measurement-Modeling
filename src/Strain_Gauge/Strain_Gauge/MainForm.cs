using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strain_Gauge
{
    public partial class MainForm : Form
    {
        Measurement measMent = new Measurement(); // measurement object - defining the properties of the strain gauge

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
            labelPSUVoltage.Text = "-";
            timerSampling.Enabled = true;
        }

        private void timerSampling_Tick(object sender, EventArgs e) // updating the UI
        {
            double value;
            if (checkBoxPowerON.Checked) value = measMent.GetMeasurement();
            else value = measMent.AddNoise(0.0f);

            // display measurement
            labelMeterVoltage.Text = value.ToString("0.0000");
            labelDispMeter.Text = measMent.displacement.ToString("0.00");
        }

        private void checkBoxPowerON_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPowerON.Checked)
            {
                labelPSUVoltage.Text = "5.00";
                strainGauge.Image = measMent.GetLayout(1);
            }
            else
            {
                labelPSUVoltage.Text = "-";
                strainGauge.Image = measMent.GetLayout(0);
            }
        }

        // incrementing and decrementing the displacement
        private void buttonDecDisp_Click(object sender, EventArgs e)
        {
            measMent.DecrementDisp();
        }

        private void buttonIncDisp_Click(object sender, EventArgs e)
        {
            measMent.IncrementDisp();
        }
    }
}
