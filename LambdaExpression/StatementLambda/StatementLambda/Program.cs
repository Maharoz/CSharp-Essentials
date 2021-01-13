using System;

namespace StatementLambda
{
    class Program
    {
        delegate int IntOp(int end);
        static void Main(string[] args)
        {
            IntOp fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                {
                    r = i * r;
                }
                return r;
            };
            Console.WriteLine("The factorial of 3 is" + fact(3));
            Console.WriteLine("The factorial of 3 is" + fact(5));
        }
    }
}
