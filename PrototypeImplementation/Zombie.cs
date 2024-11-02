using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeImplementation
{
    internal class Zombie : Monster
    {
        private int _regenaration;

        public Zombie()
        {

        }

        public Zombie(string name, int health, int reganaration) : base(name, health)
        {
            this._regenaration = reganaration;
        }

        public Zombie(Zombie prototype) : base(prototype)
        {
            this._regenaration = prototype._regenaration;
        }

        public object Clone()
        {
            return new Zombie(this);
        }
    }
}
