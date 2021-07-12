using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public class ByTwos<T> : ISeries<T>
    {
        T start;
        T val;

        public delegate T incBtTwo(T v);

        incBtTwo incr;

        public ByTwos(incBtTwo incrMeth)
        {
            start = default(T);
            val = default(T);
            incr = incrMeth;
        }


        public T GetNext()
        {
            val = incr(val);
            return val;
        }
        public void Reset()
        {
            val = start;
        }

        public void SetStart(T v)
        {
            start = v;
            val = start;
        }
    }

   
}
