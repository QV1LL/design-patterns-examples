using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    internal interface IWeaponBehavior
    {
        public void UseWeapon(Character character);
    }
}
