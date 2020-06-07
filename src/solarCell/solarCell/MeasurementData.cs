using System;

public class Measurement
{
    private double voltageOpenCircuit = 4.73f;
    private readonly Random rnd = new Random();


    public Measurement()
    { }

    public double AddNoise(double value) // adding measurement noise
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

    public double GetOutVoltage(double resistance) // load resistance - output voltage function
    {
        // y = 4.629942 + (0.214322 - 4.629942)/(1 + (x/851.8619)^1.992455)   
        double value = 0.0f;
        value = 4.629942f + ((0.214322f - 4.629942f) / (1.0f + Math.Pow((resistance / 851.8619f), 1.992455f)));
        value = (resistance == 0.0f) ? 0.0f : value;
        return AddNoise(value);
    }

    public double GetOutCurrent(double resistance) // load resistance - output current function
    {
        // y = -0.6355472 + (4.053775 - -0.6355472)/(1 + (x/2386.528)^0.7854466)  
        double value = 0.0f;
        value = -0.6355472f + ((4.053775f - -0.6355472f) / (1.0f + Math.Pow((resistance / 2386.528f), 0.7854466)));
        return AddNoise(value);
    }

    public double GetOpenCircuitVoltage() // read the output voltage when no load resistor is connected
    {
        return AddNoise(voltageOpenCircuit);
    }

    public double GetOpenCircuitCurrent() 
    {
        return AddNoise(0.0f); // read the output current when no load resistor is connected (0 + random noise)
    }

}