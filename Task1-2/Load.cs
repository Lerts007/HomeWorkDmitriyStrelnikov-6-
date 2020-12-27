using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    class Load
    {
        double[] ArrayLoad;

        public Load(double[] ArrayLoad)
        {
            this.ArrayLoad = ArrayLoad;
        }

        public void Output(out double ResMin)
        {
            ResMin = ArrayLoad[0];
            for (int i = 1; i < ArrayLoad.Length; i++)
            {
                if (ArrayLoad[i] < ResMin) ResMin = ArrayLoad[i];
            }
        }
    }
}
