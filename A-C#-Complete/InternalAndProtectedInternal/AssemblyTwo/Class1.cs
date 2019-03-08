using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI
    {
        public void Print()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            //BELOW LINE IS ILLEGAL BECAUSE ID 
            //IS INTERNAL PROPERTY OF PROJECT AssemblyOne
            //A1.ID = 101;
        }
    }
}
