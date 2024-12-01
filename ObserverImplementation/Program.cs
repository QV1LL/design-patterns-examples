using ObserverImplementation;
using System;
using System.Collections.Generic;

namespace Project
{
    public class Process
    {
        public static void Main(string[] args)
        {
            StockChange stockChange = new StockChange();
            stockChange.SetPrice(25.5);

            Trader trader1 = new Trader(stockChange.Price);
            Trader trader2 = new Trader(stockChange.Price);

            Analyst analyst = new Analyst(stockChange.Price);

            stockChange.RegisterObserver(analyst);
            stockChange.RegisterObserver(trader1);
            stockChange.RegisterObserver(trader2);

            stockChange.SetPrice(27.6);
            Console.WriteLine("Analyst prediction: " + analyst.GetForesight());


            stockChange.SetPrice(26.6);
            Console.WriteLine("Analyst prediction: " + analyst.GetForesight());


            stockChange.SetPrice(1005.3);
            Console.WriteLine("Analyst prediction: " + analyst.GetForesight());
        }
    }
}