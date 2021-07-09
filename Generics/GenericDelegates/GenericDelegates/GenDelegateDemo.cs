using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    public class GenDelegateDemo
    {
        public int Sum(int v)
        {
            int result = 0;

            for (int i = v; i > 0; i--)
            {
                result += i;
            }

            return result;
        }

        public string reflect(string str)
        {
            string result = "";

            foreach(char ch in str)
            {
                result = ch + result;
            }
            return result;
        }


    }
}
