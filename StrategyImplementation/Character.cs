using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    internal abstract class Character
    {
        public string _name;
        protected IWeaponBehavior _weaponBehavior;

        public Character(string name, IWeaponBehavior weaponBehavior) {
            this._weaponBehavior = weaponBehavior;
            this._name = name;
        }

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior)
        {
            this._weaponBehavior = weaponBehavior;
        }
    }
}
