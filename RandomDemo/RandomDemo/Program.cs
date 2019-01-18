using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //for(var i=0; i< 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10));
            //}
             const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for(int i=0;i<passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));

            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
