using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 3;
            Console.WriteLine(a+b);
            Console.WriteLine(a+b*c); //multiplication will work first
        }
    }
}
