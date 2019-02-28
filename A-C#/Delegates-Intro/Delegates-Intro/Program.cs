using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Intro
{
    public delegate void HellFunctionoDelegate(string strMessage);
    class Program
    {
        static void Main(string[] args)
        {
            //A delegate is type safe function pointer
            HellFunctionoDelegate del = new HellFunctionoDelegate(Hello);
            del("Hello from delegate");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
