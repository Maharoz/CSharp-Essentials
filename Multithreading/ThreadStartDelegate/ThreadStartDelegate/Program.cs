using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartDelegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number();
            Thread T1 = new Thread(new ThreadStart(number.PrintNumber));
            T1.Start();
        }
    }

    class Number
    {
        public void PrintNumber()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
