using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Customer
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            //Console.WriteLine(c1._id);
        }
    }
}
