using System;

namespace AnonymousIntro
{
    delegate void CountIt();
    class Program
    {
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i);
                }
            };

            count();
        }
    }
}
