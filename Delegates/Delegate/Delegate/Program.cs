using System;

namespace Delegate
{
    class Program
    {
        delegate string StrMod(string str);
    
            //Replace space With hyphen
            public static string ReplaceSpaces(string s)
            {
                Console.WriteLine("Replacing space with hyphen.");
                return s.Replace(' ', '-');
            }

            //Remove space
            public static string Removespace(string s)
            {
                string temp = "";
                int i;
                Console.WriteLine("Removing space");
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ')
                        temp += s[i];
                }

                return temp;
            }

            //Reverse a string
            public static string reverse(string s)
            {
                string temp = "";
                int i, j;
                Console.WriteLine("Reversing string");
                for ( i = s.Length - 1; i >= 0; i--)
                    temp += s[i];
                return temp;
            }
        static void Main(string[] args)
        {
            //StrMod strOp = new StrMod(ReplaceSpaces);
            //string str;

            //str = strOp("This is test");
            //Console.WriteLine("Resulting string: " +str);
            //Console.WriteLine();

            //strOp =new StrMod(Removespace);
            //str = strOp("This is test");
            //Console.WriteLine("Resulting string: " + str);
            //Console.WriteLine();

            //strOp = new StrMod(reverse);
            //str = strOp("This is test");
            //Console.WriteLine("Resulting string: " + str);

            StrMod strOp = ReplaceSpaces;
            string str;

            str = strOp("This is test");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            strOp = Removespace;
            str = strOp("This is test");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            strOp = reverse;
            str = strOp("This is test");
            Console.WriteLine("Resulting string: " + str);


        }
    }
}
