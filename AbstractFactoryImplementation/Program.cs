using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnemyFactory enemyFactory = new ConcreateEnemy1Factory();

            IEnemy enemy = enemyFactory.CreateEnemy();

            enemy.Attack();
        }
    }
}