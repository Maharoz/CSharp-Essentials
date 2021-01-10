using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInstanceMethodAsDelegate
{
    public class StringOp
    {
        //Replace space With hyphen
        public string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing space with hyphen.");
            return s.Replace(' ', '-');
        }

        //Remove space
        public string Removespace(string s)
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
        public string reverse(string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reversing string");
            for (i = s.Length - 1; i >= 0; i--)
                temp += s[i];
            return temp;
        }
    }
}
