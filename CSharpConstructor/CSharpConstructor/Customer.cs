using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id):this() //this will call parameterless constructor first
        {
            this.Id = id;
        }
        public Customer(int id,string name):this(id) //this will call above constructor first
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
