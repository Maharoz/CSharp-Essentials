using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizeThreadStartDelegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
           object target = Console.ReadLine();
            Number number = new Number();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumber);
            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(target);
        }
    }

    class Number
    {
        public void PrintNumber(object target)
        {

            int number = 0;
            if(int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

