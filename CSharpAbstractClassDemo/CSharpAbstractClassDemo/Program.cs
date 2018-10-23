using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAbstractClassDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // below line is illegal beacuse 
            //shape is declared as abstract
            //var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
