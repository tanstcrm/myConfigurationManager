using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FpgaPysical
{
    public class FpgaStatus
    {
        public bool grobalApplied = false;
        public bool[] chStatusList = new bool[65];
        public int[][] dac = new int[6][];
        public int deadTime = 0;
        public int samplingTime = 0;
        public int coincidenceNum = 0;
        public int coincidenceWidth = 0;
        public double[] dacValSlope = { 0.734, 1.22, 1, 217, 0 };
        public double[] dacValIntercept = {2.0455, 1.80, 5.067, 0 };


        public FpgaStatus()
        {
        dac = new int[][]
        {
            new int [] {0,0,0,0},
            new int [] {0,0,0,0},
            new int [] {0,0,0,0},
            new int [] {0,0,0,0},
            new int [] {0,0,0,0},
            new int [] {0,0,0,0}
        };
            for (int i = 0; i < chStatusList.Length; i++)
            {
                chStatusList[i] = false;
            }
        }

        public override string ToString()
        {
            
            string str = "";
            
            for(int j=0; j<dac.Length; j++)
            {
                str += "channel: " + j.ToString() + Environment.NewLine;
                for (int i = 0; i < dac[j].Length; i++)
                { str += "DAC" + i.ToString() + ":" + dac[j][i].ToString() + Environment.NewLine; }
                str += Environment.NewLine;
            }
            

            return str;
        }
    }

    /*
    class SettingManager : FpgaStatus
    {

    }
    */
}
