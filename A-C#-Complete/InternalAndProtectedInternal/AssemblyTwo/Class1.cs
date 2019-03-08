using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void Print()
        {
            //ID is declared as protected internal
            //so it is accessible from anywhere by deriving that class
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            base.ID = 101;

            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            A2.ID = 101;
        }
    }
}
