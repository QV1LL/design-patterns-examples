using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeImplementation
{
    internal class Monster : ICloneable
    {
        private string? _name;

        private int _health;

        public Monster() 
        { 

        }

        public Monster(string name, int health)
        {
            this._health = health;
            this._name = name;
        }
        
        public Monster(Monster prototype)
        {
            this._name = prototype._name;
            this._health = prototype._health;
        }

        public object Clone()
        {
            return new Monster(this);
        }
    }
}
