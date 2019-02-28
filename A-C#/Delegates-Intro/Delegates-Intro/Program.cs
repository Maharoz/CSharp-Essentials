using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Intro
{
  
    class Program
    {
        static void Main(string[] args)
        {
           List<Employee> empList = new List<Employee>();

            empList.Add(new Employee()
            {
                ID = 100,
                Name = "Maharoz",
                Salary = 5000,
                Experience = 5
            });

            empList.Add(new Employee()
            {
                ID = 100,
                Name = "Marry",
                Salary = 5000,
                Experience = 5
            });

            empList.Add(new Employee()
            {
                ID = 100,
                Name = "Mike",
                Salary = 4000,
                Experience = 8
            });

            empList.Add(new Employee()
            {
                ID = 100,
                Name = "Andrew",
                Salary = 6000,
                Experience = 4
            });

            empList.Add(new Employee()
            {
                ID = 100,
                Name = "John",
                Salary = 8000,
                Experience = 3
            });
            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList,isPromotable);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
    public delegate bool IsPromotable(Employee empl);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}
