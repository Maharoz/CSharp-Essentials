using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithDoubleParam
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoGen<int, string> tgObj = new TwoGen<int, string>(119, "Alpha beta gama");
            tgObj.showTypes();

            int v = tgObj.getOb1();
            Console.WriteLine("value " + v);

            string s = tgObj.getOb2();
            Console.WriteLine("value " + s);
        }
    }
}
