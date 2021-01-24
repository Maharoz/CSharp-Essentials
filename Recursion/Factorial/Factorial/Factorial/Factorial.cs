using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    public class Factorial
    {
        public int FactR(int n)
        {
            int result;

            if (n == 1) return 1;

            result = FactR(n - 1) * n;
            return result;
        }

        public int FactI(int n)
        {
            int t, result;

            result = 1;
            for (t = 1; t <= n; t++)
            {
                result *= t;
               
            }

            return result;
        }
    }
}
