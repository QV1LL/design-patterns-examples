using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    internal class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon(Character character)
        {
            Console.WriteLine(character._name + " fights using knife!");
        }
    }
}
