using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorImplementation
{
    internal class ViewItem : IView
    {
        public void Render()
        {
            Console.WriteLine("Some user interface element...");
        }
    }
}
