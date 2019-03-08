using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
       protected internal int ID = 101;
    }

    public class AssemblyOneClassII
    {
        public void SampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
        }
    }
}
