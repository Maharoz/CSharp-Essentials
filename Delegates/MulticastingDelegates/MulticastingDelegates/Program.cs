using System;

namespace MulticastingDelegates
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
            for (i = s.Length - 1; i >= 0; i--)
                temp += s[i];
            return temp;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            StrMod strOp;
            StrMod replaceSp = ReplaceSpaces;
            StrMod removeSp = Removespace;
            StrMod reverseStr = reverse;
            string str = "This is test";

            strOp = ReplaceSpaces;
            strOp += reverseStr;

            strOp(ref str); 
            Console.WriteLine("Resulting string: " + str );
            Console.WriteLine();

            strOp -= replaceSp;
            strOp += removeSp;

            str = "This is test";

            strOp(ref str);
            Console.WriteLine("Resulting string: " +str);
            Console.WriteLine();

        }
    }
}
