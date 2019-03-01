using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];

            customer[0] = new Customer
            {
                Name = "Maharoz",
                Gender = Gender.Male

            };
            customer[1] = new Customer
            {
                Name = "Maharoz Mugdho",
                Gender = Gender.Female

            };
            customer[2] = new Customer
            {
                Name = "Maharoz Alam",
                Gender = Gender.Unknown

            };
        }

        public static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                case Gender.Unknown:
                    return "Unknown";
                default:
                    return "Invalid Data";
            }
           

        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
