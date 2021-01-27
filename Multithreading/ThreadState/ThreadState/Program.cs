using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace ThreadState
{
    class Program
    {
        
        static void Main(string[] args)
        {
            static void DoNothing()
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }

            static void PrintNumbersWithStatus()
            {
                Console.WriteLine("Starting...");
                Console.WriteLine(CurrentThread.ThreadState.ToString());
                for (int i = 1; i < 10; i++)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    Console.WriteLine(i);
                }
            }

            WriteLine("Starting program...");
            Thread t = new Thread(PrintNumbersWithStatus);
            Thread t2 = new Thread(DoNothing);
            WriteLine(t.ThreadState.ToString());
            t2.Start();
            t.Start();
            for (int i = 1; i < 30; i++)
            {
                WriteLine(t.ThreadState.ToString());
            }
            Sleep(TimeSpan.FromSeconds(6));
            t.Abort();
            WriteLine("A thread has been aborted");
            WriteLine(t.ThreadState.ToString());
            WriteLine(t2.ThreadState.ToString());
        }
    }
}
