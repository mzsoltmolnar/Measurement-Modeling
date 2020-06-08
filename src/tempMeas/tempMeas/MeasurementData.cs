using System;

public class Measurement
{
    private readonly Random rnd = new Random();
    private double tempUpper = 102.0f; // ending temperature
    private double tempLower = 20.0f; // starting temperature

    public double temperature = 20.0f; // current temperature

    public Measurement()
    { }

    public double AddNoise(double value) // random measurement noise generation 
    {
        int ranNum = rnd.Next(-100, 100);

        if (ranNum > 80) value += 0.01f;
        if (ranNum < -80) value += -0.01f;
        if (ranNum > 90) value += 0.02f;
        if (ranNum < -90) value += -0.02f;
        if (ranNum > 98) value += 0.03f;
        if (ranNum < -98) value += -0.03f;

        return value;
    }

    public void TempIncrement(double rate)
    {
        if (temperature < tempUpper) temperature += rate;
    }

    public void TempDecrement(double rate)
    {
        if (temperature > tempLower) temperature -= rate;
    }

    public double GetThermocouple()
    {
        // Thermistor parameters based on the following document:
        // https://www.pyromation.com/Downloads/Data/emfk_c.pdf
        double value = 0.041f * temperature - 0.019f;
        return AddNoise(value);
    }

    public double GetThermistor()
    {
        // Thermistor parameters based on the following document:
        // https://cdn-learn.adafruit.com/downloads/pdf/thermistor.pdf
        double value = -0.5044277f + ((20.87727f - (-0.5044277f)) / (1 + Math.Pow((temperature / 24.70594f), 2.04913f)));

        return AddNoise(value);
    }

    public double GetPT100()
    {
        // PT-100 parameters based on the following document:
        // https://www.kongsberg.com/globalassets/maritime/km-products/product-documents/tsiec751_ce.pdf
        double value = 0.3851f * temperature + 100.08f;
        return AddNoise(value);
    }

    public double GetTemperature() // get the reference thermometer value
    {
        return AddNoise(temperature);
    }

}