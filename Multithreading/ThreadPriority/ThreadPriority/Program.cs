using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;
using static System.Diagnostics.Process;

namespace ThreadPriority
{
    class ThreadSample
    {
        private bool _isStopped = false;
        public void Stop()
        {
            _isStopped = true;
        }
        public void CountNumbers()
        {
            long counter = 0;

            while (!_isStopped)
            {
                counter++;
            }

            Console.WriteLine($"{CurrentThread.Name} with" +
                $"{CurrentThread.Priority,11} priority" +
                $"has a count = {counter,13:NO}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            static void RunThreads()
            {
                var sample = new ThreadSample();

                var threadOne = new Thread(sample.CountNumbers);
                threadOne.Name = "ThreadOne";
                var threadTwo = new Thread(sample.CountNumbers);
                threadTwo.Name = "ThreadTwo";

                threadOne.Priority = System.Threading.ThreadPriority.Highest;
                threadTwo.Priority = System.Threading.ThreadPriority.Lowest;
                threadOne.Start();
                threadTwo.Start();

                Sleep(TimeSpan.FromSeconds(2));
                sample.Stop();
            }



            WriteLine($"Current thread priority: {CurrentThread.Priority}");
            WriteLine("Running on all cores available");
            RunThreads();
            Sleep(TimeSpan.FromSeconds(2));
            WriteLine("Running on a single core");
            GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            RunThreads();


        }
    }
}
