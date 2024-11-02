using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethodImplementation
{
    internal abstract class Enemy
    {
        private int _health;
        private int _damage;

        public abstract void Attack();
    }
}
