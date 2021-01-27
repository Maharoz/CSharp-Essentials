using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace PausingAThread
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintNumbers()
            {
                for(int i = 1; i< 10; i++)
                {
                    Console.WriteLine(i);
                }
            }


            static void PrintNumberWithDelay()
            {
                Console.WriteLine("Starting...");
                for (int i = 1; i < 10; i++)
                {
                    Sleep(TimeSpan.FromSeconds(2));
                    Console.WriteLine(i);
                }
            }

            Thread t = new Thread(PrintNumberWithDelay);
            t.Start();
            PrintNumbers();
        }
    }
}
