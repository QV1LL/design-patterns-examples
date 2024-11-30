using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    internal class TreeIterator : Iterator<IView>
    {
        private Layout iterableItem;
        private int _iterator = 0;

        public TreeIterator(Layout iterableItem)
        {
            this.iterableItem = iterableItem;
        }

        public bool HasMore()
        {
            if (this._iterator < iterableItem.GetItems().Count())
                return true;

            return false;
        }

        public IView Next()
        {
            if (HasMore())
                return iterableItem.GetItems()[this._iterator++];

            return null;
        }
    }
}
