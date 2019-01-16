using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeVsValueTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of value type
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a : {0} , b : {1}",a,b));

            //exaple of reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0] {0} , array1[0] {1}",array1[0],array2[0]));
        }
    }
}
