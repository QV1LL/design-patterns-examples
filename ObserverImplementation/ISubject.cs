using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation
{
    internal interface ISubject
    {
        public void NotifyObservers();
        public void RegisterObserver(IObserver observer);
        public void UnregisterObserver(IObserver observer);
    }
}
