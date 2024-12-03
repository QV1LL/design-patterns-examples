using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateImplementation
{
    internal class RunningState : IPlayerState
    {
        public void Jump()
        {
            // Cannot jumping while running
        }

        public void Run()
        {
            Console.WriteLine("Continue running");
        }

        public void Walk()
        {
            Console.WriteLine("Start walking");
        }
    }
}
