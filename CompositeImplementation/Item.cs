using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeImplementation
{
    internal class Item : IComponent
    {
        private uint _price;

        public Item(uint price)
        {
            _price = price;
        }

        public int GetPrice()
        {
            return (int)this._price;
        }

        public Item Clone()
        {
            return (Item)MemberwiseClone();
        }
    }
}
