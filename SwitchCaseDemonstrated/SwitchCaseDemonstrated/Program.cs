using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemonstrated
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.autumn;
            switch (season)
            {
                case Season.autumn:
                    Console.WriteLine("Its autumn an beautifull season");
                    break;
                case Season.summer:
                    Console.WriteLine("Its summer and it is perfect time to go to beach");
                    break;
                default:
                    Console.WriteLine("I dont understand that season");
                    break;
            }
        }
    }
}
