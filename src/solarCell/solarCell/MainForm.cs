using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using solarCell.Properties;

namespace solarCell
{
    public partial class MainForm : Form
    {
        Measurement measMent = new Measurement(); // measurement object - defining the properties of the solar cell

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) // initializing the UI objects values
        {
            checkBoxIlluminationOn.BackColor = Color.Red;
            timerSampling.Enabled = true;
        }

        private void timerSampling_Tick(object sender, EventArgs e) // updating the UI
        {
            if (checkBoxIlluminationOn.Checked)
            {
                checkBoxIlluminationOn.BackColor = Color.LimeGreen;
                pictureBoxDisplayScene.Image = Resources.scene2;

                if (checkBoxDisconnectLoad.Checked)
                {
                    labelVoltMet.Text = measMent.GetOpenCircuitVoltage().ToString("0.00");
                    labelAmpMeter.Text = measMent.GetOpenCircuitCurrent().ToString("0.00");
                }
                else
                {
                    labelVoltMet.Text = measMent.GetOutVoltage(GetResistance()).ToString("0.00");
                    labelAmpMeter.Text = measMent.GetOutCurrent(GetResistance()).ToString("0.00");
                }
            }
            else
            {
                checkBoxIlluminationOn.BackColor = Color.Red;
                pictureBoxDisplayScene.Image = Resources.annotations;
                labelVoltMet.Text = measMent.AddNoise(0.0f).ToString("0.00");
                labelAmpMeter.Text = measMent.AddNoise(0.0f).ToString("0.00");
            }
            labelResistanceValue.Text = GetResistance().ToString();
        }

        private int GetResistance() // getting the resistance value in function of checked checkboxes
        {
            int resistance = 0;
            {
                if (checkBox400k.Checked) resistance += 400000;
                if (checkBox300k.Checked) resistance += 300000;
                if (checkBox200k.Checked) resistance += 200000;
                if (checkBox100k.Checked) resistance += 100000;
                if (checkBox40k.Checked) resistance += 40000;
                if (checkBox30k.Checked) resistance += 30000;
                if (checkBox20k.Checked) resistance += 20000;
                if (checkBox10k.Checked) resistance += 10000;
                if (checkBox4k.Checked) resistance += 4000;
                if (checkBox3k.Checked) resistance += 3000;
                if (checkBox2k.Checked) resistance += 2000;
                if (checkBox1k.Checked) resistance += 1000;
                if (checkBox400.Checked) resistance += 400;
                if (checkBox300.Checked) resistance += 300;
                if (checkBox200.Checked) resistance += 200;
                if (checkBox100.Checked) resistance += 100;
                if (checkBox40.Checked) resistance += 40;
                if (checkBox30.Checked) resistance += 30;
                if (checkBox20.Checked) resistance += 20;
                if (checkBox10.Checked) resistance += 10;
                if (checkBox4.Checked) resistance += 4;
                if (checkBox3.Checked) resistance += 3;
                if (checkBox2.Checked) resistance += 2;
                if (checkBox1.Checked) resistance += 1;
            }
            return resistance;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }
    }
}
