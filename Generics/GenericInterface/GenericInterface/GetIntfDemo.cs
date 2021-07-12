using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public class GetIntfDemo
    {
        public static int InPlusTwo(int v)
        {
            return v + 2;
        }
        public static double DoublePlusTwo(double v)
        {
            return v + 2.0;
        }

        public static ThreeD ThreeDPlusTwO(ThreeD v)
        {
            if (v == null) return new ThreeD(0, 0, 0);
            else
            {
                return new ThreeD(v.x + 2, v.y + 2, v.z + 2);

            }
        }
    }
}
