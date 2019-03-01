using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
        public class Student
        {
            private int _id;
            private string _Name;
            private int _PassMark = 35;

            public void setName(string Name)
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("Name cannot be null or empty");
            }
            }

            public string getName()
            {
                if (string.IsNullOrEmpty(this._Name))
                {
                    return "No name";
                }
                else
                {
                    return this._Name;
                }
            }

            public void setId(int Id)
            {
                if (_id < 0)
                {
                    throw new Exception("Student id cannot be negative");
                }

                this._id = Id;
            }

            public int getId()
            {
                return this._id;
            }
        }
    public class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.setId(101);
            //c1.setName(null);
            Console.WriteLine("Student id is {0}",c1.getId());
            Console.WriteLine("Student name is {0}", c1.getName());
        }
    }
}
