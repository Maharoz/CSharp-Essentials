using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> iOb;

            iOb = new Generic<int>(102);
            iOb.ShowType();

            int v = iOb.GetOb();
            Console.WriteLine("value: " + v);
            Console.WriteLine();

            Generic<string> strOB = new Generic<string>("Generics add power");
            strOB.ShowType();

            string str = strOB.GetOb();
            Console.WriteLine("value " + str);
        }
    }
}
