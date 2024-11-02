using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    internal class ConcreateEnemy1 : IEnemy
    {
        public override void Attack()
        {
            Console.WriteLine("Concreate enemy 1 attack!");
        }
    }
}
