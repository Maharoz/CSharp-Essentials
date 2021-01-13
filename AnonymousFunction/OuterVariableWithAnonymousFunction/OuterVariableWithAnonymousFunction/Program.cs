using System;

namespace OuterVariableWithAnonymousFunction
{
    delegate int CountIt(int end);
    class Program
    {
        static CountIt Counter()
        {
            int sum = 0;

            CountIt ctObj = delegate (int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };
            return ctObj;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            CountIt count = Counter();

            int result;

            result = count(3);
            Console.WriteLine("Summation of 3 is:" + result);
            Console.WriteLine();

            result = count(5);
            Console.WriteLine("Summation of 5 is:" + result);
        }
    }
}
