using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee {Id = 101, Name = "Maharoz"},
                new Employee {Id = 101, Name = "John"}
            };

            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = listEmployees.Select(selector);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
           
        }
    }
}
