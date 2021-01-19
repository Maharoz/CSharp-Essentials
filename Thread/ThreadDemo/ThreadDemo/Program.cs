using System;
using System.Threading;

namespace ThreadDemo
{

    public class MyThread
    {
        public int Count;
        string thrdName;

        public MyThread(string name){
            Count = 0;
            thrdName = name;
     }

        public void run()
        {
            Console.WriteLine(thrdName + " starting.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + thrdName + ", Count is " + Count);
                Count++;
            } while (Count < 10);

            Console.WriteLine(thrdName + " terminating.");
        }
}
class Program
{
    static void Main(string[] args)
    {
            MyThread mt = new MyThread("Child#1");

            Thread newThrd = new Thread(mt.run);

            newThrd.Start();

            do
            {
                Console.WriteLine(".");
                Thread.Sleep(100);
            } while (mt.Count != 10);

            Console.WriteLine("Main thread ending!");
    }
}
}
