using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    internal class ConcreateEnemy2Factory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new ConcreateEnemy2();
        }
    }
}
