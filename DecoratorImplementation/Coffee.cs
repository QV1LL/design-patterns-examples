using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorImplementation
{
    internal class Coffee : IProduct
    {
        private int _price;

        public Coffee(int price) 
        {
            this._price = price;
        }

        public int GetPrice()
        {
            return this._price;
        }
    }
}
