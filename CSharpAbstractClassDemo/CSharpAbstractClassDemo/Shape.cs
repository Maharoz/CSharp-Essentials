using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAbstractClassDemo
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copied Shape into clipboard");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
        
    }
}
