using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public interface ISeries<T>
    {
        T GetNext();
        void Reset();
        void SetStart(T v);
    }
}
