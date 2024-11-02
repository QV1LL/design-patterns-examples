using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    internal class ConcreateEnemy1Factory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new ConcreateEnemy1();
        }
    }
}
