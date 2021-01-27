using System;

namespace ConsoleApp1
{

    sealed class SealedClass
    {
        public int Add(int a ,int b)
        {
            return a + b;   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass slc = new SealedClass();

            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
}
