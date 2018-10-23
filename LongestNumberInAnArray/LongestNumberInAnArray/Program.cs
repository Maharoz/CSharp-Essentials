using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestNumberInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int i, max, n;


            Console.Write("\n\nFind maximum element in an array :\n");
            Console.Write("--------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            max = array[0];
           

            for (i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.Write("Maximum element is : {0}", max);
        }
    }
    
}
