using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritanceDemo
{
    public class Text : PresentationObject //inheritance notation
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to" + url);
        }
    }
}
