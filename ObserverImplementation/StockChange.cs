using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation
{
    internal class StockChange : ISubject
    {
        private double _price = 0d;
        public double Price 
        { 
            get { return this._price; } 
        }

        public void SetPrice(double price)
        {
            this._price = price;
            Console.WriteLine("New price is: " + price);

            this.NotifyObservers();
        }

        private List<IObserver> observers = new List<IObserver>();

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(this);
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
