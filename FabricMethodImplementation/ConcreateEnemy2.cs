using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethodImplementation
{
    internal class ConcreateEnemy2 : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Concreate enemy 2 attack!");
        }
    }
}
