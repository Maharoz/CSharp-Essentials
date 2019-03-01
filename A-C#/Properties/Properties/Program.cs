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
            private int _passMark = 35;

            public int PassMark
            {
                get
                {
                    return this._passMark;
                }
            }

        public string Name
        {
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
            }

                this._Name = value;
            }
            get
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
        }

         

            public int Id
            {
            set { 
                if (value <= 0)
                {
                    throw new Exception("Student id cannot be negative");
                }

                this._id = value;
            }
            get { return this._id; }
        }

           
        }
    public class Program
    {
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.Id = 101;
            c1.Name = "Maharoz";
          
            Console.WriteLine("Student id is {0}",c1.Id);
            
        }
    }
}
