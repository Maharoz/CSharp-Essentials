using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating 
            var timeSpan = new TimeSpan(1, 2, 3);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration " + duration);

            //properties
            Console.WriteLine("Minutes:" + timeSpan.Minutes );
            Console.WriteLine("Total Minutes:" + timeSpan.TotalMinutes);

            

        }
    }
}
