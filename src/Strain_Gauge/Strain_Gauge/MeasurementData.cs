using System;
using System.Drawing;

public class Measurement
{
    public const int sceneCount = 2; // number of scenes
    public int dataSize = sceneCount;
    public double displacement = -1.0f;

    private Image[] layout = new Image[sceneCount];
    private readonly Random rnd = new Random();

    public Measurement()
    { }

    public void LoadData() // loading the scenes
    {
        layout[0] = Strain_Gauge.Properties.Resources.annotations;
        layout[1] = Strain_Gauge.Properties.Resources.setup;
    }

    public double AddNoise(double value) // random measurement noise generation
    {
        int ranNum = rnd.Next(-100, 100);

        if (ranNum > 70) value += 0.0005f;
        if (ranNum < -70) value += -0.0005f;
        if (ranNum > 90) value += 0.001f;
        if (ranNum < -90) value += -0.001f;
        if (ranNum > 98) value += 0.002f;
        if (ranNum < -98) value += -0.002f;

        return value;
    }

    public void IncrementDisp()
    {
        if (displacement < 2.0f)
        {
            int ranNum = rnd.Next(-100, 100);

            if (ranNum < 5 && ranNum > -5) displacement += 0.2f;
            else if (ranNum < 30 && ranNum > -30) displacement += 0.15f;
            else if (ranNum < 90 && ranNum > -90) displacement += 0.05f;
        }
    }

    public void DecrementDisp()
    {
        if (displacement > -1.0f)
        {
            int ranNum = rnd.Next(-100, 100);

            if (ranNum < 5 && ranNum > -5) displacement -= 0.2f;
            else if (ranNum < 30 && ranNum > -30) displacement -= 0.15f;
            else if (ranNum < 90 && ranNum > -90) displacement -= 0.05f;
        }
    }

    public double GetMeasurement() // get the measured strain gauge voltage
    {
        double value = 0.4132f * displacement + 0.0036f;
        return AddNoise(value);
    }

    public Image GetLayout(int index) // get the scene at a specified index
    {
        index = (index >= dataSize) ? sceneCount : index;
        index = (index < 0) ? 0 : index;
        return layout[index];
    }
}