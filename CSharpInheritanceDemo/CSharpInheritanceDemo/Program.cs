using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceDemo
{
    class Program
    {   
        static void Main(string[] args)
        {
            var text = new Text();
            //inherited properties
            text.Width = 100;
            //inherited properties 
            text.Copy();
        }
    }
}
