using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Customer
    {
        public abstract void Print();

    }
    public class Program:Customer
    {
        public override void Print()
        {
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();
        }
    }
}
