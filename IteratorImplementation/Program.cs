using System;

namespace IteratorImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Layout layoutItem = new Layout();
            layoutItem.AddItem((new Layout()).AddItem(new ViewItem()))
                .AddItem(new ViewItem())
                .AddItem(new ViewItem());

            IterateLayout(layoutItem);
        }

        static void IterateLayout(IView item)
        {
            if (item == null)
            {
                return;
            }

            if (item is Layout)
            {
                var iterator = ((Layout)item).GetIterator();

                while(iterator.HasMore())
                {
                    IView view = iterator.Next();

                    view.Render();

                    if (view is Layout) IterateLayout(view);
                }
            }
        }
    }
}