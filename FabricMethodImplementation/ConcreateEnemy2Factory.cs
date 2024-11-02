using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethodImplementation
{
    internal class ConcreateEnemy2Factory : IEnemyFactory
    {
        public Enemy CreateEnemy()
        {
            return new ConcreateEnemy2();
        }
    }
}
