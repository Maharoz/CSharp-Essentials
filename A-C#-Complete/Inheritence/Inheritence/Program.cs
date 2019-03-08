using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{


 public class Employee
 {
     public string FirstName;
     public string LastName;
     public string Email;

     public void PrintFullName()
     {
         Console.WriteLine(FirstName + " " + LastName);
     }

 }
    //here FullTimeEmployee is derived class
    // and Employee Parent class
    public class FullTimeEmployee : Employee
 {
     public float YearlySalary;
 }

    //here PartTimeEmployee is derived class
    // and Employee Parent class
    public class PartTimeEmployee : Employee
 {
     public float HourlyRate;
 }

    //multilevel inheritence
    public class MultiLevel : PartTimeEmployee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE =new FullTimeEmployee();
            FTE.FirstName = "Maharoz";
            FTE.LastName = "ALAM";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "ABC";
            PTE.LastName = "SSS";
            PTE.HourlyRate = 1000;
            PTE.PrintFullName();

            MultiLevel A1 = new MultiLevel();
            A1.FirstName = "xyz";
            A1.LastName = "abc";
            A1.PrintFullName();
        }
    }
}
