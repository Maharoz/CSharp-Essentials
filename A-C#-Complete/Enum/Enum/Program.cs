using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] Values = (short[]) System.Enum.GetValues(typeof(Gender));

            //Printing the value of Enum
            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }
        }


    }

    public enum Gender:short
    {
        Unknown = 1,
        Male =5,
        Female=23
    }

}

  
