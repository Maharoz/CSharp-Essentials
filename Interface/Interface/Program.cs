using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface I1
    {
        void InterfaceMethod();
    }

    public interface I2 {
        void InterfaceMethod();
    }

    public class Program:I1,I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("T1 Interface method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //Implementing Interface
            p.InterfaceMethod();
        }
    }
}
