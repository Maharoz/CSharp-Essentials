using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class Person
    {
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
