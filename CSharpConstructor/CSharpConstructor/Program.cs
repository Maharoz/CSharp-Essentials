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
            var customer = new Customer();//here we have three overloads of customer 
            customer.Id = 1;
            customer.Name = "Maharoz";

            //var order = new Order();
            //customer.Orders = new List<Order>();//without this line programe will give null reference exeption
            //customer.Orders.Add(order);

            //if you debugg following lines will execute first as 
            //default constructor hits
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
