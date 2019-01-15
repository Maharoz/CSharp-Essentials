using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i=1;
            byte b = (byte)i;//type conversion
            Console.WriteLine(b);
            */

            /*
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
            */
            try
            {
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch(Exception )
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
         
        }
    }
}
