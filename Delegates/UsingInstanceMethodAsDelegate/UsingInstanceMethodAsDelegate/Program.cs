using System;

namespace UsingInstanceMethodAsDelegate
{
    class Program
    {
        delegate string StrMod(string str);

        
        static void Main(string[] args)
        {
            StringOp so = new StringOp();
            StrMod strOp = so.ReplaceSpaces;
            string str;

            str = strOp("This is test");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            strOp = so.Removespace;
            str = strOp("This is test");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            strOp = so.reverse;
            str = strOp("This is test");
            Console.WriteLine("Resulting string: " + str);
        }
    }
}
