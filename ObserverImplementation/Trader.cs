using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation
{
    internal class Trader : IObserver
    {
        private double _currentPrice;

        public Trader(double currentPrice)
        {
            this._currentPrice = currentPrice;
        }

        public void SellShares()
        {
            Console.WriteLine("Trader sell his shares!");
        }

        public void BuyShares()
        {
            Console.WriteLine("Trader buys new shares!");
        }

        public void Update(ISubject subject)
        {
            if (subject.GetType() != typeof(StockChange))
                return;

            double stockExchangeCurrentPrice = (subject as StockChange).Price;

            if (this._currentPrice < stockExchangeCurrentPrice)
                SellShares();
            else
                BuyShares();

            this._currentPrice = stockExchangeCurrentPrice;
        }
    }
}
