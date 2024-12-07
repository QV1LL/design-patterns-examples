using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    internal class King : Character
    {
        public King(string name, IWeaponBehavior weaponBehavior) : base(name, weaponBehavior)
        {

        }

        public override void Fight()
        {
            _weaponBehavior.UseWeapon(this);
        }
    }
}
