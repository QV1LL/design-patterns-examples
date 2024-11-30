using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    internal interface Iterator<T>
    {
        public T Next();
        public bool HasMore();
    }
}
