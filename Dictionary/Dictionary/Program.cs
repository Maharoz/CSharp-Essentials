using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                ID = 101,
                Name ="Mark",
                Salary =500
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

            Customer[] customers = new Customer[3];
            customers[0] = c1;
            customers[1] = c2;
            customers[2] = c3;
            Dictionary<int , Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int , Customer> kvp in dict)
            {
                Console.WriteLine("Key= {0}",kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID = {0} ,Name = {1} ,Salary = {2}", cust.ID,cust.Name,cust.Salary);

            }


            ////Creating the dictionary
            //Dictionary<int,Customer> dictionartCustomers = new Dictionary<int, Customer>();
            ////Adding data to dictionary
            //dictionartCustomers.Add(c1.ID,c1);
            //dictionartCustomers.Add(c2.ID, c2);
            //dictionartCustomers.Add(c3.ID, c3);

            ////TryGetValue added

            //Customer cust;
            //if (dictionartCustomers.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID= {0}, Name= {1} , Salary= {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("The Key is not found");
            //}

            ////Count added
            //Console.WriteLine("Total Items = {0}",dictionartCustomers.Count(kvp =>kvp.Value.Salary>4000));

            ////Remove added
            //dictionartCustomers.Remove(110);

            ////Clear added
            //dictionartCustomers.Clear();

            //Customer customer101 = dictionartCustomers[101];

            //Console.WriteLine("Id = {0} , Name = {1} , salary = {2}",customer101.ID,customer101.Name,customer101.Salary);

            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionartCustomers)
            //{
            //    //printing the values
            //   Console.WriteLine("ID ={0}", customerKeyValuePair);
            //   Customer cust = customerKeyValuePair.Value;
            //   Console.WriteLine("ID = {0},Name={1} and salary = {2}",cust.ID,cust.Name,cust.Salary);
            //   Console.WriteLine("--------------------------------------------");
            //}

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
