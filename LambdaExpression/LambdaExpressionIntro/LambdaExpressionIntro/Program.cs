using System;

namespace LambdaExpressionIntro
{
    class Program
    {
        delegate int Incr(int v);
        delegate bool IsEven(int v);
        static void Main(string[] args)
        {
            Incr incr = count =>count + 2;
            Console.WriteLine("Use incr lambda Expression: ");
            int x = -10;
            while (x <= 0)
            {
                Console.WriteLine(x +" ");
                x = incr(x);
            }

            Console.WriteLine("\n");

            IsEven isEven = n => n % 2 == 0;
            Console.WriteLine("Use isEven lambda expression:");

            for(int i = 1; i <= 10; i++)
            {
                if (isEven(i))
                {
                    Console.WriteLine(i +" is even");
                }
            }
        }
    }
}
