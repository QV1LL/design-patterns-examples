using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateImplementation
{
    internal class IdleState : IPlayerState
    {
        public void Jump()
        {
            Console.WriteLine("Jumping");
        }

        public void Run()
        {
            Console.WriteLine("Start running");
        }

        public void Walk()
        {
            Console.WriteLine("Start walking");
        }
    }
}
