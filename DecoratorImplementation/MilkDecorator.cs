using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorImplementation
{
    internal class MilkDecorator : IProduct
    {
        private readonly IProduct _product;
        private readonly int _milkPrice = 5;

        public MilkDecorator(IProduct product)
        {
            this._product = product;
        }

        public int GetPrice()
        {
            return _product.GetPrice() + this._milkPrice;
        }
    }
}
