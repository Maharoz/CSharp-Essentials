using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        delegate T SomeOp<T>(T v);
        static void Main(string[] args)
        {
            GenDelegateDemo x = new GenDelegateDemo();
            SomeOp<int> indel = x.Sum;
            Console.WriteLine(indel(6));

            SomeOp<string> strDel = x.reflect;
            Console.WriteLine(strDel("I am hungry"));
        }
    }
}
