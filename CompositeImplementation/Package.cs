using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeImplementation
{
    internal class Package : IComponent
    {
        private List<IComponent> components;

        public Package()
        {
            components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            if (component == null) return;

            this.components.Add(component);
        }

        public int GetPrice()
        {
            int summaryPrice = 0;

            foreach (IComponent component in components)
            {
                summaryPrice += component.GetPrice();
            }

            return summaryPrice;
        }

        public Package Clone()
        {
            Package clone = (Package)MemberwiseClone();
            List<IComponent> components = new List<IComponent>();

            foreach (IComponent component in this.components)
            {
                if (component.GetType() == typeof(Item))
                    components.Add(((Item)component).Clone());

                else if(component.GetType() == typeof(Package))
                    components.Add(((Package)component).Clone());
            }

            clone.components = components;

            return clone;
        }
    }
}
