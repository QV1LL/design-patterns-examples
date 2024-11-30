using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandImplementation
{
    internal interface ICommand
    {
        void Execute();
        void Unexecute();
    }

}
