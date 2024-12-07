using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    internal abstract class Character
    {
        private readonly string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        protected IWeaponBehavior _weaponBehavior;

        protected Character(string name, IWeaponBehavior weaponBehavior) {
            this._weaponBehavior = weaponBehavior;
            this._name = name;
        }

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior)
        {
            this._weaponBehavior = weaponBehavior;
        }

        public abstract void Fight();
    }
}
