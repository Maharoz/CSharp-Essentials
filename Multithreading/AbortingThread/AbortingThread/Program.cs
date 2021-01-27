using System;
using System.Threading;

namespace AbortingThread
{
	class Program
	{

		static void Main(string[] args)
		{
			
				Console.WriteLine("Starting program...");
				Thread t = new Thread(PrintNumbersWithDelay);
				t.Start();
				Thread.Sleep(TimeSpan.FromSeconds(6));
				t.Abort();
				Console.WriteLine("A thread has been aborted");
			

			static void PrintNumbersWithDelay()
			{
				Console.WriteLine("Starting...");
				for (int i = 1; i < 10; i++)
				{
					Thread.Sleep(TimeSpan.FromSeconds(2));
					Console.WriteLine(i);
				}
			}
		}
	}
}
