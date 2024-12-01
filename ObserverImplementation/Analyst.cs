using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation
{
    internal class Analyst : IObserver
    {
        private double _currentPrice;
        private bool _isSharesProfit;

        public Analyst(double currentPrice)
        {
            this._currentPrice = currentPrice;
        }

        public bool GetForesight()
        {
            return _isSharesProfit;
        }

        public void Update(ISubject subject)
        {
            if (subject.GetType() != typeof(StockChange))
                return;

            double stockExchangeCurrentPrice = (subject as StockChange).Price;

            this._isSharesProfit = _currentPrice > stockExchangeCurrentPrice;
            this._currentPrice = stockExchangeCurrentPrice;
        }
    }
}
