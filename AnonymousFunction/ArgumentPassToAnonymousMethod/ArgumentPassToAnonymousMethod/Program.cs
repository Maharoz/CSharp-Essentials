using System;

namespace ArgumentPassToAnonymousMethod
{
    delegate void CountIt(int end);
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            CountIt count = delegate (int end)
            {
                for (int i = 0; i < end; i++)
                {
                    Console.WriteLine(i);
                }
            };


            count(3);
            Console.WriteLine();
            count(5);
        }
    }
}
