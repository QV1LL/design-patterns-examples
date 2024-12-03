using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateImplementation
{
    internal class JumpingState : IPlayerState
    {
        public void Jump()
        {
            // Cannot jump while jumping
        }

        public void Run()
        {
            // Cannot run while jumping
        }

        public void Walk()
        {
            // Cannot run while jumping
        }
    }
}
