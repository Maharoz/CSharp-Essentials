using System;

namespace Ref
{
    public class RefTest
    {
        public void sqr(ref int i)
        {
            i= i * i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RefTest r = new RefTest();
            int a = 10;
            Console.WriteLine("a before call: " +a);

            r.sqr(ref a);

            Console.WriteLine("a after call: " + a);
        }
    }
}
