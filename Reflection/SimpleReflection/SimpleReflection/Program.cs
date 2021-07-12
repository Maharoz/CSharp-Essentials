using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReflection
{
    class Program
    {

        class MyClass
        {
            int x;
            int y;

            public MyClass(int i, int j)
            {
                x = i;
                y = j;
            }

            public int Sum()
            {
                return x + y;
            }

            public bool IsBetween(int i)
            {
                if (x < i && i < y) return true;
                else return false;
            }

            public void Set(int a, int b)
            {
                x = a;
                y = b;
            }

            public void Set(double a, double b)
            {
                x = (int)a;
                y = (int)b;
            }

            public void Show()
            {
                Console.WriteLine("x : {0}, y : {1}",x, y);
            }


        }


        static void Main(string[] args)
        {
            Type t = typeof(MyClass); //get a Type object representing MyClass;

            Console.WriteLine("Analyzing methods in " + t.Name);
            Console.WriteLine();

            Console.WriteLine("Method supported: ");

            MethodInfo[] mi = t.GetMethods();

            foreach(MethodInfo m in mi)
            {
                Console.WriteLine(" "+ m.ReturnType.Name+ " " +  m.Name + "(");

                ParameterInfo[] pi = m.GetParameters();

                for(int i =0; i< pi.Length; i++)
                {
                    Console.WriteLine(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.WriteLine(", ");
                }
                Console.WriteLine(") ");
                Console.WriteLine();
            }
        }
    }
}
