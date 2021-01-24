using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is test";
            RevStr r = new RevStr();
            Console.WriteLine($"Original string {s}");

            r.DisplayRev(s);
            //Console.WriteLine();
        }
    }
}
