﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementation
{
    internal interface IObserver
    {
        public void Update(ISubject subject);
    }
}
