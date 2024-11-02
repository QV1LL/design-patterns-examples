using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethodImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnemyFactory enemyFactory = new ConcreateEnemy1Factory();

            Enemy enemy = enemyFactory.CreateEnemy();

            enemy.Attack();
        }
    }
}