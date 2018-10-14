using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();//creating a List of shapes
            shapes.Add(new Circle());//inserting values on lists
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
