using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation
{
    internal interface IObserverItem
    {
        public abstract void RegisterObserver(IObserver observer);
        public abstract void UnregisterObserver(IObserver observer);
    }
}
