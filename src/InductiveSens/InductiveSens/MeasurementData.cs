using System;
using System.Drawing;
using InductiveSens.Properties;




public class Measurement
{
    public const int size = 101; // the number of animation frames used during modeling
    public int dataSize = size;
    public double distance = 9.9f; // starting distance
    public double voltage = 0.0f;

    private Image[] layout = new Image[size]; // storing the animation frames
    private double workingVoltage = 6.0f; // minimum voltage level when the sensor starts to work
    public double senseFe = 0.0f; // actual limits, with noise added
    public double senseAl = 0.0f;
    private readonly Random rnd = new Random();

    private const double limitFeUpper = 7.5f; // distance limits of the different targets (based on measurements)
    private const double limitFeLower = 6.9f;
    private const double limitAlUpper = 3.6f;
    private const double limitAlLower = 3.0f;



    public Measurement()
    {

    }

    /* loading the images for the animation
     * this code part was auto-generated
    */
    public void LoadData()
    {
        layout[0] = Resources.annotation;
        layout[1] = Resources.scene_0001;
        layout[2] = Resources.scene_0002;
        layout[3] = Resources.scene_0003;
        layout[4] = Resources.scene_0004;
        layout[5] = Resources.scene_0005;
        layout[6] = Resources.scene_0006;
        layout[7] = Resources.scene_0007;
        layout[8] = Resources.scene_0008;
        layout[9] = Resources.scene_0009;
        layout[10] = Resources.scene_0010;
        layout[11] = Resources.scene_0011;
        layout[12] = Resources.scene_0012;
        layout[13] = Resources.scene_0013;
        layout[14] = Resources.scene_0014;
        layout[15] = Resources.scene_0015;
        layout[16] = Resources.scene_0016;
        layout[17] = Resources.scene_0017;
        layout[18] = Resources.scene_0018;
        layout[19] = Resources.scene_0019;
        layout[20] = Resources.scene_0020;
        layout[21] = Resources.scene_0021;
        layout[22] = Resources.scene_0022;
        layout[23] = Resources.scene_0023;
        layout[24] = Resources.scene_0024;
        layout[25] = Resources.scene_0025;
        layout[26] = Resources.scene_0026;
        layout[27] = Resources.scene_0027;
        layout[28] = Resources.scene_0028;
        layout[29] = Resources.scene_0029;
        layout[30] = Resources.scene_0030;
        layout[31] = Resources.scene_0031;
        layout[32] = Resources.scene_0032;
        layout[33] = Resources.scene_0033;
        layout[34] = Resources.scene_0034;
        layout[35] = Resources.scene_0035;
        layout[36] = Resources.scene_0036;
        layout[37] = Resources.scene_0037;
        layout[38] = Resources.scene_0038;
        layout[39] = Resources.scene_0039;
        layout[40] = Resources.scene_0040;
        layout[41] = Resources.scene_0041;
        layout[42] = Resources.scene_0042;
        layout[43] = Resources.scene_0043;
        layout[44] = Resources.scene_0044;
        layout[45] = Resources.scene_0045;
        layout[46] = Resources.scene_0046;
        layout[47] = Resources.scene_0047;
        layout[48] = Resources.scene_0048;
        layout[49] = Resources.scene_0049;
        layout[50] = Resources.scene_0050;
        layout[51] = Resources.scene_0051;
        layout[52] = Resources.scene_0052;
        layout[53] = Resources.scene_0053;
        layout[54] = Resources.scene_0054;
        layout[55] = Resources.scene_0055;
        layout[56] = Resources.scene_0056;
        layout[57] = Resources.scene_0057;
        layout[58] = Resources.scene_0058;
        layout[59] = Resources.scene_0059;
        layout[60] = Resources.scene_0060;
        layout[61] = Resources.scene_0061;
        layout[62] = Resources.scene_0062;
        layout[63] = Resources.scene_0063;
        layout[64] = Resources.scene_0064;
        layout[65] = Resources.scene_0065;
        layout[66] = Resources.scene_0066;
        layout[67] = Resources.scene_0067;
        layout[68] = Resources.scene_0068;
        layout[69] = Resources.scene_0069;
        layout[70] = Resources.scene_0070;
        layout[71] = Resources.scene_0071;
        layout[72] = Resources.scene_0072;
        layout[73] = Resources.scene_0073;
        layout[74] = Resources.scene_0074;
        layout[75] = Resources.scene_0075;
        layout[76] = Resources.scene_0076;
        layout[77] = Resources.scene_0077;
        layout[78] = Resources.scene_0078;
        layout[79] = Resources.scene_0079;
        layout[80] = Resources.scene_0080;
        layout[81] = Resources.scene_0081;
        layout[82] = Resources.scene_0082;
        layout[83] = Resources.scene_0083;
        layout[84] = Resources.scene_0084;
        layout[85] = Resources.scene_0085;
        layout[86] = Resources.scene_0086;
        layout[87] = Resources.scene_0087;
        layout[88] = Resources.scene_0088;
        layout[89] = Resources.scene_0089;
        layout[90] = Resources.scene_0090;
        layout[91] = Resources.scene_0091;
        layout[92] = Resources.scene_0092;
        layout[93] = Resources.scene_0093;
        layout[94] = Resources.scene_0094;
        layout[95] = Resources.scene_0095;
        layout[96] = Resources.scene_0096;
        layout[97] = Resources.scene_0097;
        layout[98] = Resources.scene_0098;
        layout[99] = Resources.scene_0099;
        layout[100] = Resources.scene_0100;
    }

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

    public void IncrementDist()
    {
        if (distance < 9.9f)
        {
            distance += 0.1f;
        }
    }

    public void DecrementDist()
    {
        if (distance > 0.0f)
        {
            distance -= 0.1f;
        }
    }

    public double GetOutVoltage(int material) // read the sensor output value
    {
        double value = 0.0f;

        if (GetSensing(material))
        {
            value = voltage;
        }

        return AddNoise(value);
    }

    public void ResetDistance()
    {
        distance = 9.9f;
    }

    public void ResetLimits() /* resetting the sensing limits for Fe and Al targets. The values are random within
        the predetermined limits */
    {
        int rndNum = rnd.Next(Convert.ToInt32(limitFeLower * 10.0f), Convert.ToInt32(limitFeUpper * 10.0f));
        senseFe = (double)rndNum / 10.0f;

        rndNum = rnd.Next(Convert.ToInt32(limitAlLower * 10.0f), Convert.ToInt32(limitAlUpper * 10.0f));
        senseAl = (double)rndNum / 10.0f;
    }

    public bool GetSensing(int material) // read if the sensor senses the target material
    {
        bool sense = false;

        if (voltage >= workingVoltage) // check the distance limit only if the voltage is over minimal operating voltage
        {
            if (material == 0)
            {
                if (distance <= senseFe) sense = true;
            }

            if (material == 1)
            {
                if (distance <= senseAl) sense = true;
            }
        }

        return sense;
    }

    public void IncrementVoltage()
    {
        if (voltage < 24.0f)
        {
            voltage += 0.5f;
        }
    }

    public void DecrementVoltage()
    {
        if (voltage > 0.0f)
        {
            voltage -= 0.5;
        }
    }


    public Image GetLayout(int index) // get the frame from the specific index
    {
        index = (index >= dataSize) ? size : index;
        index = (index < 0) ? 0 : index;
        return layout[index];
    }

    public Image GetLayout() // get the frame representing the actual distance
    {
        int index = size - Convert.ToInt32(distance * 10.0f) - 1;
        return layout[index];
    }
}