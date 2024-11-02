using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    internal interface IEnemyFactory
    {
        IEnemy CreateEnemy();
    }
}
