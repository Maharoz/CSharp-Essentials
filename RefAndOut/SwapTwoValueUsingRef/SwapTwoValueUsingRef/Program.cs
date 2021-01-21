using System;

namespace SwapTwoValueUsingRef
{
    public class swap
    {
        public void swapRef(ref int a , ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;int y = 20;
            swap s = new swap();
            Console.WriteLine("x and y before call " + x +" " + y);
            s.swapRef(ref x, ref y);
            Console.WriteLine("x and y after call " + x + " " + y);


        }
    }
}
