using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithDoubleParam
{
    public class TwoGen<T,V>
    {
        T ob1;
        V ob2;


        public TwoGen(T o1, V o2)
        {
            ob1 = o1;
            ob2 = o2;
        }

        public void showTypes()
        {
            Console.WriteLine("Type Of T is " + typeof(T));
            Console.WriteLine("Type Of V is " + typeof(V));
        }

        public T getOb1()
        {
            return ob1;
        }

        public V getOb2()
        {
            return ob2;
        }
    }
}
