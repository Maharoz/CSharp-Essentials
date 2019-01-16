using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberValidityChecker
{
    class Program
    {
        static void Main(string[] args)
        {
           //where console asks you to put a number between 1 to 10.
           //if you are right it will say valid otherwise invalid
            Console.WriteLine("Please enter a number between 1 to 10");
            var a = Console.ReadLine();
            var number = Convert.ToInt32(a);
            if(number >= 1 && number <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
