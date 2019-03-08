using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceClass
{
    class Circle
    {
        static float _PI;
         int _Radius;

        //Static constructors are called before instance constructor
         static Circle()
         {
             Console.WriteLine("Static constructor called");
             Circle._PI = 3.141F;
         }
         public Circle(int Radius)
         {
             Console.WriteLine("Instance constructor called");
            this._Radius = Radius;
         }
        //public static void Print()
        //{

        //}
         public float CalculateArea()
         {
             return Circle._PI * this._Radius * this._Radius;
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Area = c1.CalculateArea();
            //Circle.Print();
            Console.WriteLine("Area = {0}",Area);

            Circle c2 = new Circle(6);
            float Area2 = c2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
        }
    }
}
