using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //if you debugg following lines will execute first as 
            //default constructor hits
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
