using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            //this is only legal when CalculateRating is declared as protected
            //var rating = this.CalculateRating(excludeOrders: true);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            //following line is illegal if CalculateRating is declared as private

            //var rating = customer.CalculateRating();
        }
    }
}
