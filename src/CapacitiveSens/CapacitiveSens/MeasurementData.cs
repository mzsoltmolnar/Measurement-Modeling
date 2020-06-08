using System;
using System.Drawing;
using CapacitiveSens.Properties;

public class Measurement
{
    public struct Materials
    {
        public double limitUpper; // maximum distance limit
        public double limitLower; // minimum distance limit
        public double senseDistance; // actual sensing distance
    }

    public const int sceneCount = 152; // number of scenes
    public const int matCount = 6;
    public double distance = 0.0f;
    public double voltage = 24.0f;

    private Image[] layout = new Image[sceneCount]; // array of scenes
    private double workingVoltage = 12.0f; // minimum workong voltage
    private readonly Random rnd = new Random();
    public Materials[] mat = new Materials[matCount]; // defining an array of different materials

    private double maxDistance = 15.0f; // maximum distance
    private double outputVoltageDifference = 0.7f; // difference between supply voltage and output voltage

    public Measurement()
    { }

    public void LoadData() // setting the material limits
    {
        // parameters based mostly on this datasheet correction factors:
        // https://www.sensorsincorporated.com/uploaded/Doc/sick_capacitive_proximity_sensor_overview_4abf16.pdf
        // Calculation: Sa = Sn*Kw
        // Sn = 8 mm
        // Random tolerance: +- 0.2 mm
        // Fe material
        mat[0].limitLower = 7.8f;
        mat[0].limitUpper = 8.2f;
        mat[0].senseDistance = 0;
        // Al material
        mat[1].limitLower = 7.8f;
        mat[1].limitUpper = 8.2f;
        mat[1].senseDistance = 0;
        // Plastic material
        mat[2].limitLower = 3.0f;
        mat[2].limitUpper = 3.4f;
        mat[2].senseDistance = 0;
        // Ceramic material
        mat[3].limitLower = 3.8f;
        mat[3].limitUpper = 4.2f;
        mat[3].senseDistance = 0;
        // Wood material
        mat[4].limitLower = 3.4f;
        mat[4].limitUpper = 3.8f;
        mat[4].senseDistance = 0;
        // Paper material
        mat[5].limitLower = 3.0f;
        mat[5].limitUpper = 3.4f;
        mat[5].senseDistance = 0;

        // loading scenes from resources
        // this code was generated
        {
            layout[0] = Resources.annotations;
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
            layout[101] = Resources.scene_0101;
            layout[102] = Resources.scene_0102;
            layout[103] = Resources.scene_0103;
            layout[104] = Resources.scene_0104;
            layout[105] = Resources.scene_0105;
            layout[106] = Resources.scene_0106;
            layout[107] = Resources.scene_0107;
            layout[108] = Resources.scene_0108;
            layout[109] = Resources.scene_0109;
            layout[110] = Resources.scene_0110;
            layout[111] = Resources.scene_0111;
            layout[112] = Resources.scene_0112;
            layout[113] = Resources.scene_0113;
            layout[114] = Resources.scene_0114;
            layout[115] = Resources.scene_0115;
            layout[116] = Resources.scene_0116;
            layout[117] = Resources.scene_0117;
            layout[118] = Resources.scene_0118;
            layout[119] = Resources.scene_0119;
            layout[120] = Resources.scene_0120;
            layout[121] = Resources.scene_0121;
            layout[122] = Resources.scene_0122;
            layout[123] = Resources.scene_0123;
            layout[124] = Resources.scene_0124;
            layout[125] = Resources.scene_0125;
            layout[126] = Resources.scene_0126;
            layout[127] = Resources.scene_0127;
            layout[128] = Resources.scene_0128;
            layout[129] = Resources.scene_0129;
            layout[130] = Resources.scene_0130;
            layout[131] = Resources.scene_0131;
            layout[132] = Resources.scene_0132;
            layout[133] = Resources.scene_0133;
            layout[134] = Resources.scene_0134;
            layout[135] = Resources.scene_0135;
            layout[136] = Resources.scene_0136;
            layout[137] = Resources.scene_0137;
            layout[138] = Resources.scene_0138;
            layout[139] = Resources.scene_0139;
            layout[140] = Resources.scene_0140;
            layout[141] = Resources.scene_0141;
            layout[142] = Resources.scene_0142;
            layout[143] = Resources.scene_0143;
            layout[144] = Resources.scene_0144;
            layout[145] = Resources.scene_0145;
            layout[146] = Resources.scene_0146;
            layout[147] = Resources.scene_0147;
            layout[148] = Resources.scene_0148;
            layout[149] = Resources.scene_0149;
            layout[150] = Resources.scene_0150;
            layout[151] = Resources.scene_0151;
        }
    }

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

    public void IncrementDist()
    {
        if (distance < maxDistance)
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

    public void ResetDistance()
    {
        distance = maxDistance;
    }

    public void ResetLimits() // generating new random limits within the specified range
    {
        int rndNum = 0;

        for (int i = 0; i < matCount; i++)
        {
            rndNum = rnd.Next(Convert.ToInt32(mat[i].limitLower * 10.0f), Convert.ToInt32(mat[i].limitUpper * 10.0f));
            mat[i].senseDistance = (double)rndNum / 10.0f;
        }
    }

    public double GetOutVoltage(int material) // get output voltage of the sensor
    {
        double value = 0.0f;

        if (GetSensing(material))
        {
            value = voltage - outputVoltageDifference;
        }

        return AddNoise(value);
    }

    public bool GetSensing(int material) // check if the sensor is sensing anything
    {
        bool sense = false;
        int index = 0;
        // check whether the input material is in the predefined material range
        index = (material < 0) ? 0 : material;
        index = (material >= matCount) ? (matCount - 1) : material;

        if (voltage >= workingVoltage) // check the distance limit only if the voltage is over minimal op. voltage
        {
            if (distance <= mat[index].senseDistance) sense = true;
        }

        return sense;
    }

    public Image GetLayout(int index) // get the scene at a specified index
    {
        index = (index >= sceneCount) ? sceneCount : index;
        index = (index < 0) ? 0 : index;
        return layout[index];
    }

    public Image GetLayout() // get the corresponding layout for the actual distance
    {
        int index = Convert.ToInt32(distance * 10.0f) + 1;
        return layout[index];
    }
}