using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} , I am {1}",to,Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();//creating the object
            //person.Name = "Maharoz";//adding value to Name property
            var person = Person.Parse("mosh");
            person.Introduce("Mosh");//calling introduce method
        }
    }
}
