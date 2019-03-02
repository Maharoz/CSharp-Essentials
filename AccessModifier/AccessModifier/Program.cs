using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Customer
    {
        protected int ID;

    }

    public class CoorporateCustomer : Customer
    {
        public void printId()
        {
            CoorporateCustomer cc = new CoorporateCustomer();
            cc.ID = 100;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();

            //This is prohibited because _id is private
            //Console.WriteLine(c1._id);
        }
    }
}
