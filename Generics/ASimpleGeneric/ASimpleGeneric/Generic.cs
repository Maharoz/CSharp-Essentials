using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleGeneric
{

    public class Generic<T>
    {
        T ob;

        public Generic(T o)
        {
            ob = o;
        }

        public T GetOb()
        {
            return ob;
        }

        public void ShowType()
        {
            Console.WriteLine("Type of T is " + typeof(T));
        }
    }

}
