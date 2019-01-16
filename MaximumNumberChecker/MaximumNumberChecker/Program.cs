using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two number to find maximum");
            var a = Console.ReadLine();
            var number1 = Convert.ToInt32(a);
            var b = Console.ReadLine();
            var number2 = Convert.ToInt32(b);
            //if(number1 > number2)
            //{
            //    Console.WriteLine(string.Format("{0} is maximum",number1));
            //}
            //else
            //{
            //    Console.WriteLine(string.Format("{0} is maximum", number2));
            //}
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("max number is " + max);

        }
    }
}
