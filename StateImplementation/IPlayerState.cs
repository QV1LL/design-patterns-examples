using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateImplementation
{
    internal interface IPlayerState
    {
        public void Walk();
        public void Run();
        public void Jump();
    }
}
