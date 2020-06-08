using System;
using System.Drawing;

public class Measurement
{
    public const int sceneCount = 11; // number of scenes
    public int period = 12; // sine wave period

    private Image[] layout = new Image[sceneCount];
    private double[] outputData = new Double[sceneCount];
    private readonly Random rnd = new Random();
    private int sineAngle = 0; // sine wave actual angle

    public Measurement()
    { }

    public void LoadData() // loading scenes
    {
        layout[0] = DAQ_system.Properties.Resources.img_0;
        layout[1] = DAQ_system.Properties.Resources.img_1;
        layout[2] = DAQ_system.Properties.Resources.img_2;
        layout[3] = DAQ_system.Properties.Resources.img_3;
        layout[4] = DAQ_system.Properties.Resources.img_4;
        layout[5] = DAQ_system.Properties.Resources.img_5;
        layout[6] = DAQ_system.Properties.Resources.img_6;
        layout[7] = DAQ_system.Properties.Resources.img_7;
        layout[8] = DAQ_system.Properties.Resources.img_8;
        layout[9] = DAQ_system.Properties.Resources.img_9;
        layout[10] = DAQ_system.Properties.Resources.img_10;
        
        String[] data = DAQ_system.Properties.Resources.data.Split(';');
        for (int i = 0; i < data.Length; i++)
        {
            outputData[i] = Double.Parse(data[i], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }
    }

    private double AddNoise(double value) // random measurement noise generation
    {
        int ranNum = rnd.Next(-100, 100);

        if (ranNum > 60) value += 0.001f;
        if (ranNum < -60) value += -0.001f;
        if (ranNum > 90) value += 0.002f;
        if (ranNum < -90) value += -0.002f;
        if (ranNum > 98) value += 0.003f;
        if (ranNum < -98) value += -0.003f;

        return value;
    }

    public double GetMeasurement(int index) // get strain gauge meadurement data
    {
        index = (index >= sceneCount) ? 10 : index;
        index = (index < 0) ? 0 : index;
        return AddNoise(outputData[index]);
    }

    public Image GetLayout(int index) // get the scene at a specified index
    {
        index = (index >= sceneCount) ? 10 : index;
        index = (index < 0) ? 0 : index;
        return layout[index];
    }

    private double DegToRad(double deg) // convert degrees to radians
    {
        return (deg * Math.PI) / 180.0f;
    }

    private double GetSine(int periodDeg) // increment the angle and generate the actual sine wave value
    {
        if (sineAngle < 360) sineAngle += periodDeg;
        else sineAngle = period;
        return Math.Sin(DegToRad((double)sineAngle));
    }

    public double Get10xDivider(double voltage_mV) // get the voltage value from 10x divided input
    {
        return GetSine(period) * (voltage_mV / 10.0);
    }

    public double Get2xMultiplier(double voltage_mV) // get the voltage value from 2x multiplied input
    {
        return GetSine(period) * (voltage_mV * 2.0);
    }
}


public class DataBuffer // data buffer class is used to store the displayed values and rescale the chart according to the min and max values
{
    private int[] buffer = { 0 };
    public readonly int length;

    public DataBuffer(int len) // initialise a data buffer with the specified length
    {
        buffer = new int[len];
        length = len;
    }

    public void AddBuffer(int value) // add new values to the buffer (last value will be overwritten) - sort of FIFO
    {
        for (int i = 0; i < length - 1; i++)
        {
            buffer[i] = buffer[i + 1];
        }
        buffer[length - 1] = value;
    }

    public int GetMaxValue() // get the maximum value stored in the buffer
    {
        int max = Int32.MinValue;
        for (int i = 0; i < length; i++)
            if (buffer[i] > max) max = buffer[i];
        return max;
    }

    public int GetMinValue() // get the minimum value stored in the buffer
    {
        int min = Int32.MaxValue;
        for (int i = 0; i < length; i++)
            if (buffer[i] < min) min = buffer[i];
        return min;
    }

    public int GetScaleMax(double scaleFactorPercent, double maxValue) // get the scale factor that can be used for chart scaling
    {
        int scale = Convert.ToInt32(maxValue + maxValue * (scaleFactorPercent / 100.0f));
        return scale;
    }

    public int GetScaleMin(double scaleFactorPercent, double minValue)
    {
        int scale = Convert.ToInt32(minValue - Math.Abs(minValue) * (scaleFactorPercent / 100.0f));
        return scale;
    }
}