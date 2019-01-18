using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = "Maharoz Alam";
            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
