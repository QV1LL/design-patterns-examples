using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyImplementation
{
    internal class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paying with card...");
        }
    }
}
