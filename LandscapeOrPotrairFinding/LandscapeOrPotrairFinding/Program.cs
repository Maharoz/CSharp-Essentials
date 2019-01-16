using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeOrPotrairFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height and the width of the image");
                var a = Console.ReadLine();
            var height = Convert.ToInt32(a);
            var b = Console.ReadLine();
            var width = Convert.ToInt32(b);
            var orientation = (height > width) ? "landscape" : "potrait";
            Console.WriteLine("the picture is in " + orientation);

        }
    }
}
