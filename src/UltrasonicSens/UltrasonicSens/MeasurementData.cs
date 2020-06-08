using System;
using System.Drawing;
using UltrasonicSens.Properties;

public class Measurement
{
    public struct Materials // defining an own struct to store the each material sensing limits
    {
        public double limitOnUpper; // upper and lower limit when the sensor turns on
        public double limitOnLower;
        public double limitOffUpper; // upper and lower limit when the sensor turns off
        public double limitOffLower;
        public double senseOnDistance; // actula on and off sensing distances
        public double senseOffDistance;
    }

    public const int sceneCount = 202; // number of scenes
    public const int matCount = 6; // material count
    public double distance = 0.0f; // initial distance
    public double voltage = 24.0f; // working voltage (this will be displayed on the PSU)

    private Image[] layout = new Image[sceneCount];
    private double workingVoltage = 12.0f;
    private readonly Random rnd = new Random();
    public Materials[] mat = new Materials[matCount];

    private double maxDistance = 199.0f;
    private double outputVoltageDifference = 0.4f; // difference between input and output voltage

    public Measurement()
    { }

    public void LoadData()
    {
        // parameters based mostly on this datasheet correction factors:
        // https://www.sensorsincorporated.com/uploaded/Doc/sick_capacitive_proximity_sensor_overview_4abf16.pdf
        // Calculation: Sa = Sn*Kw
        // Sn = 8 mm
        // Random tolerance: +- 0.2 mm
        // Fe material
        mat[0].limitOnLower = 107.0f;
        mat[0].limitOnUpper = 111.0f;
        mat[0].limitOffLower = 22.0f;
        mat[0].limitOffUpper = 24.0f;
        mat[0].senseOnDistance = 0.0f;
        mat[0].senseOffDistance = 0.0f;
        // Al material
        mat[1].limitOnLower = 107.0f;
        mat[1].limitOnUpper = 111.0f;
        mat[1].limitOffLower = 26.0f;
        mat[1].limitOffUpper = 28.0f;
        mat[1].senseOnDistance = 0.0f;
        mat[1].senseOffDistance = 0.0f;
        // Plastic material
        mat[2].limitOnLower = 106.0f;
        mat[2].limitOnUpper = 110.0f;
        mat[2].limitOffLower = 36.0f;
        mat[2].limitOffUpper = 38.0f;
        mat[2].senseOnDistance = 0.0f;
        mat[2].senseOffDistance = 0.0f;
        // Ceramic material
        mat[3].limitOnLower = 107.0f;
        mat[3].limitOnUpper = 111.0f;
        mat[3].limitOffLower = 34.0f;
        mat[3].limitOffUpper = 36.0f;
        mat[3].senseOnDistance = 0.0f;
        mat[3].senseOffDistance = 0.0f;
        // Wood material
        mat[4].limitOnLower = 106.0f;
        mat[4].limitOnUpper = 110.0f;
        mat[4].limitOffLower = 29.0f;
        mat[4].limitOffUpper = 31.0f;
        mat[4].senseOnDistance = 0.0f;
        mat[4].senseOffDistance = 0.0f;
        // Sponge material
        mat[5].limitOnLower = 93.0f;
        mat[5].limitOnUpper = 97.0f;
        mat[5].limitOffLower = 73.0f;
        mat[5].limitOffUpper = 75.0f;
        mat[5].senseOnDistance = 0.0f;
        mat[5].senseOffDistance = 0.0f;

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
            layout[152] = Resources.scene_0152;
            layout[153] = Resources.scene_0153;
            layout[154] = Resources.scene_0154;
            layout[155] = Resources.scene_0155;
            layout[156] = Resources.scene_0156;
            layout[157] = Resources.scene_0157;
            layout[158] = Resources.scene_0158;
            layout[159] = Resources.scene_0159;
            layout[160] = Resources.scene_0160;
            layout[161] = Resources.scene_0161;
            layout[162] = Resources.scene_0162;
            layout[163] = Resources.scene_0163;
            layout[164] = Resources.scene_0164;
            layout[165] = Resources.scene_0165;
            layout[166] = Resources.scene_0166;
            layout[167] = Resources.scene_0167;
            layout[168] = Resources.scene_0168;
            layout[169] = Resources.scene_0169;
            layout[170] = Resources.scene_0170;
            layout[171] = Resources.scene_0171;
            layout[172] = Resources.scene_0172;
            layout[173] = Resources.scene_0173;
            layout[174] = Resources.scene_0174;
            layout[175] = Resources.scene_0175;
            layout[176] = Resources.scene_0176;
            layout[177] = Resources.scene_0177;
            layout[178] = Resources.scene_0178;
            layout[179] = Resources.scene_0179;
            layout[180] = Resources.scene_0180;
            layout[181] = Resources.scene_0181;
            layout[182] = Resources.scene_0182;
            layout[183] = Resources.scene_0183;
            layout[184] = Resources.scene_0184;
            layout[185] = Resources.scene_0185;
            layout[186] = Resources.scene_0186;
            layout[187] = Resources.scene_0187;
            layout[188] = Resources.scene_0188;
            layout[189] = Resources.scene_0189;
            layout[190] = Resources.scene_0190;
            layout[191] = Resources.scene_0191;
            layout[192] = Resources.scene_0192;
            layout[193] = Resources.scene_0193;
            layout[194] = Resources.scene_0194;
            layout[195] = Resources.scene_0195;
            layout[196] = Resources.scene_0196;
            layout[197] = Resources.scene_0197;
            layout[198] = Resources.scene_0198;
            layout[199] = Resources.scene_0199;
            layout[200] = Resources.scene_0200;
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
            distance += 1.0f;
        }
    }

    public void DecrementDist()
    {
        if (distance > 0.0f)
        {
            distance -= 1.0f;
        }
    }

    public void ResetDistance()
    {
        distance = maxDistance;
    }

    public void ResetLimits()
    {
        int rndNum = 0;

        for (int i = 0; i < matCount; i++) // generating the random limits within the specified range for every material
        {
            rndNum = rnd.Next(Convert.ToInt32(mat[i].limitOnLower), Convert.ToInt32(mat[i].limitOnUpper));
            mat[i].senseOnDistance = (double)rndNum;
            rndNum = rnd.Next(Convert.ToInt32(mat[i].limitOffLower), Convert.ToInt32(mat[i].limitOffUpper));
            mat[i].senseOffDistance = (double)rndNum;
        }
    }

    public double GetOutVoltage(int material) // get the output voltage value
    {
        double value = 0.0f;

        if (GetSensing(material))
        {
            value = voltage - outputVoltageDifference;
        }

        return AddNoise(value);
    }

    public bool GetSensing(int material) // check if the sensor is sensing any material
    {
        bool sense = false;
        int index = 0;
        // check whether the input material is in the predefined material range
        index = (material < 0) ? 0 : material;
        index = (material >= matCount) ? (matCount - 1) : material;

        if (voltage >= workingVoltage) // check the distance limit only if the voltage is over minimal op. voltage
        {
            if ((distance <= mat[index].senseOnDistance) && (distance >= mat[index].senseOffDistance)) sense = true;
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
        int index = Convert.ToInt32(distance) + 1;
        return layout[index];
    }
}