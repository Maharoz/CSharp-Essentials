using System;
using System.Threading;

namespace Theading001
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintNumbers()
            {
                Console.WriteLine("Starting...");
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Thread t = new Thread(PrintNumbers);
            t.Start();
            PrintNumbers();
        }
    }

    
}
