using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyImplementation
{
    internal class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paying with Cash...");
        }
    }
}
