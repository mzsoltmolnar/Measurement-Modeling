using System;
using System.Drawing;

public class Measurement
{
    public const int sceneCount = 2; // number of scenes
    public double pressure = 0.0f;

    private Image[] layout = new Image[sceneCount]; // array of scenes
    private readonly Random rnd = new Random();

    public Measurement()
    { }

    public void LoadData() // loading the scenes
    {
        layout[0] = Pressure_Meas.Properties.Resources.annotations;
        layout[1] = Pressure_Meas.Properties.Resources.setup;
    }

    public double AddNoise(double value) // random measurement noise generation
    {
        int ranNum = rnd.Next(-100, 100);

        if (ranNum > 70) value += 0.0001f;
        if (ranNum < -70) value += -0.0001f;
        if (ranNum > 90) value += 0.0002f;
        if (ranNum < -90) value += -0.0002f;
        if (ranNum > 98) value += 0.0003f;
        if (ranNum < -98) value += -0.0003f;

        return value;
    }

    // incrementing and decrementing pressure within the limits. Random noise added to represent a real life scenario.
    public void IncrementPres()
    {
        if (pressure < 0.75f)
        {
            int ranNum = rnd.Next(-100, 100);

            if (ranNum < 10 && ranNum > -10) pressure += 0.15f;
            else if (ranNum < 40 && ranNum > -40) pressure += 0.10f;
            else if (ranNum < 90 && ranNum > -90) pressure += 0.05f;
        }
    }

    public void DecrementPres()
    {
        if (pressure > -0.2f)
        {
            int ranNum = rnd.Next(-100, 100);

            if (ranNum < 10 && ranNum > -10) pressure -= 0.15f;
            else if (ranNum < 40 && ranNum > -40) pressure -= 0.10f;
            else if (ranNum < 90 && ranNum > -90) pressure -= 0.05f;
        }
    }

    public double GetMeasurement() // get the measured current
    {
        double value = 0.0266666667f * pressure + 0.004f;
        value = (value > 0.020f) ? 0.020f : value;
        value = (value < 0.004f) ? 0.004f : value;
        return AddNoise(value);
    }

    public Image GetLayout(int index)
    {
        index = (index >= sceneCount) ? sceneCount : index;
        index = (index < 0) ? 0 : index;
        return layout[index];
    }
}