using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pressure_Meas
{
    public partial class MainForm : Form
    {
        Measurement measMent = new Measurement(); // measurement object - defining the properties of the pressure transducer
    
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) // initialize the UI objects
        {
            measMent.LoadData();
            checkBoxPWRON.Text = "ON";
            labelPSUVolt.Text = "";
            timerSampling.Enabled = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void checkBoxPWRON_CheckedChanged(object sender, EventArgs e) // check if the power is turned on
        {
            if (checkBoxPWRON.Checked)
            {
                labelPSUVolt.Text = "24.1";
                checkBoxPWRON.BackColor = Color.LimeGreen;
                pressureTransducer.Image = measMent.GetLayout(1);
            }
            else
            {
                labelPSUVolt.Text = "";
                checkBoxPWRON.BackColor = BackColor;
                pressureTransducer.Image = measMent.GetLayout(0);
            }
        }

        private void timerSampling_Tick(object sender, EventArgs e) // updating the UI
        {
            double value = 0;
            if (checkBoxPWRON.Checked)
            {
                value = measMent.GetMeasurement() * 1000.0f;
            }
            else
            {
                value =  measMent.AddNoise(0) * 1000.0f;
            }
            labelAmpMet.Text = value.ToString("0.00");

            labelPresGauge.Text = measMent.pressure.ToString("0.00");
        }

        private void buttonDecPres_Click(object sender, EventArgs e)
        {
            measMent.DecrementPres();
        }

        private void buttonIncPres_Click(object sender, EventArgs e)
        {
            measMent.IncrementPres();
        }
    }
}
