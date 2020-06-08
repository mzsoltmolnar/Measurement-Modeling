using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DAQ_system
{
    public partial class MainForm : Form
    {
        const int dispLen = 30; // set the displayed length
        const int overScalePercent = 10; // oversale percent - so that is a bit of space till the diplayed sine wave reaches the limits of the chart
        Measurement measMent = new Measurement();
        DataBuffer dataBuf = new DataBuffer(dispLen);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) // initialize the UI objects
        {
            measMent.LoadData();
            InitChart();
            buttonStop.Enabled = false;
            numericUpDownWeightCount.Enabled = false;
            labelOutputVoltge.Text = "-";
            strainGauge.Image = DAQ_system.Properties.Resources.annotations;
        }

        private void samplingTimer_Tick(object sender, EventArgs e) // calling the UI update function
        {
            this.displayData();
        }

        private void buttonStart_Click(object sender, EventArgs e) // starting the sampling
        {
            timerSampling.Enabled = true;
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;
            numericUpDownWeightCount.Enabled = true;
            comboBoxChannels.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e) // stopping the sampling
        {
            timerSampling.Enabled = false;
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            numericUpDownWeightCount.Enabled = false;
            strainGauge.Image = DAQ_system.Properties.Resources.annotations;
            comboBoxChannels.Enabled = true;
        }

        private void displayData() // displaying the data on the UI
        {
            int index = (int)numericUpDownWeightCount.Value; // read the number of weights

            strainGauge.Image = measMent.GetLayout(index);

            int value = 0;
            if (comboBoxChannels.SelectedIndex < 0) // display an error message if no channel is selected
            {
                object o = new object();
                EventArgs ea = new EventArgs();
                buttonStop_Click(o, ea);
                MessageBox.Show("No input channel selected!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { // if a channel is selected, get the corresponding channel values
                if (comboBoxChannels.SelectedIndex == 0) value = Convert.ToInt32(measMent.GetMeasurement(index) * 1000);
                if (comboBoxChannels.SelectedIndex == 1) value = Convert.ToInt32(measMent.Get10xDivider(4000));
                if (comboBoxChannels.SelectedIndex == 2) value = Convert.ToInt32(measMent.Get2xMultiplier(4000));

                labelOutputVoltge.Text = value.ToString(); // display voltage value on label

                // add values to chart
                chartOutputVoltage.Series[0].Points.Add(value);
                dataBuf.AddBuffer(value);

                // rescale the chart to new values
                double xmax = chartOutputVoltage.ChartAreas[0].AxisX.Maximum;
                double min = xmax - dispLen;
                chartOutputVoltage.ChartAreas[0].AxisX.ScaleView.Zoom(min, xmax);

                int scaleMin = dataBuf.GetMinValue(); // get the min scale value
                int scaleMax = dataBuf.GetMaxValue(); // get the max scale value

                chartOutputVoltage.ChartAreas[0].AxisY.Minimum = dataBuf.GetScaleMin(overScalePercent, scaleMin); // setting the new scale values
                chartOutputVoltage.ChartAreas[0].AxisY.Maximum = dataBuf.GetScaleMax(overScalePercent, scaleMax);
            }
        }

        private void InitChart() // initialising the chart
        {
            chartOutputVoltage.Series.Clear(); // clear chart data
            chartOutputVoltage.Series.Add(""); // clear label text
            chartOutputVoltage.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; // set line chart type
            chartOutputVoltage.Series[0].Color = Color.Lime; // set the line color green-ish
            chartOutputVoltage.Series[0].BorderWidth = 2; // set line thickness

            var chartArea = chartOutputVoltage.ChartAreas[chartOutputVoltage.Series[0].ChartArea];

            chartOutputVoltage.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll; // small scrollbar
            chartOutputVoltage.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false; // the scrollbar is not inside the chart area
            chartOutputVoltage.ChartAreas[0].AxisX.ScrollBar.Enabled = false; // disable the scrollbar (we don't want to see the past measurements)
            chartOutputVoltage.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkGray; // horizontal axis grid division color
            chartOutputVoltage.ChartAreas[0].BackColor = Color.Black; // chart background color
            chartOutputVoltage.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray; // vertical axis grid division color 
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }
    }
}
