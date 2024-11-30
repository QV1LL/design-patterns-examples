using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    internal class Layout : IView
    {
        private List<IView> _items;

        public Layout()
        {
            _items = new List<IView>();
        }

        public List<IView> GetItems() {
            return this._items;
        }

        public Layout AddItem(IView item)
        {
            if (item == null) throw new ArgumentNullException("item");

            _items.Add(item);

            return this;
        }

        public void Render()
        {
            Console.WriteLine("Layout item...");
        }

        public TreeIterator GetIterator()
        {
            return new TreeIterator(this);
        }
    }
}
