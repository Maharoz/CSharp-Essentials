using System;
using System.Threading;

namespace MakingThreadWait
{
    class Program
    {

        static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting...");
            for(int i = 1; i < 10; i++)
            {

                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Thread t = new Thread(PrintNumbersWithDelay);
            t.Start();
            t.Join();
            Console.WriteLine("Thead completed");

        }
    }
}
