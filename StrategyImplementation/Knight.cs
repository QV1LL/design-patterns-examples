using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    internal class Knight : Character
    {
        public Knight(string name, IWeaponBehavior weaponBehavior) : base(name, weaponBehavior) 
        {
            
        }

        public void Fight()
        {
            _weaponBehavior.UseWeapon(this);
        }
    }
}
