using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 500
            };
            Customer c2 = new Customer
            {
                ID = 110,
                Name = "Richard",
                Salary = 5000
            };

            Customer c3 = new Customer
            {
                ID = 125,
                Name = "Max",
                Salary = 500
            };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c2);

            //Customer c = customers[0];

            foreach (var c in customers)
            {          
                Console.WriteLine("ID = {0} , NAME = {1} , Salary = {2}", c.ID, c.Name, c.Salary);
            }
            

        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
