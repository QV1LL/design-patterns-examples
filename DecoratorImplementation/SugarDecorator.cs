using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorImplementation
{
    internal class SugarDecorator : IProduct
    {
        private readonly IProduct _product;
        private readonly int _sugarPrice = 2;

        public SugarDecorator(IProduct product)
        {
            this._product = product;
        }

        public int GetPrice()
        {
            return _product.GetPrice() + this._sugarPrice;
        }
    }
}
