﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorImplementation
{
    internal interface IMediator
    {
        void Notify(object sender, string eventDetails);
    }
}
