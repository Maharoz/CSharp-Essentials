using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Customer
    {
         string _firstName;
         string _lastName;

         public Customer()
             : this("No FirstName given","No last name given")
         {

         }

         //Constructor Have no return type
         //Constructor have same name as class
         public Customer(string FirstName, string LastName)
         {
             this._firstName = FirstName;
             this._lastName = LastName;
         }

         //Method
         public void PrintFullName()
         {
             Console.WriteLine("FullName = {0}", this._firstName + " " + this._lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        //Constructing object of customer
         Customer C1 = new Customer();
         C1.PrintFullName();
         //constructor overloading
         Customer C2 = new Customer("TEST", "TEST");
         C2.PrintFullName();
        }
    }
}
