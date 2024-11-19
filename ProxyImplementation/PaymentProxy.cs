using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyImplementation
{
    internal class PaymentProxy : IPayment
    {
        private IPayment _realService;

        public PaymentProxy(IPayment realService)
        {
            this._realService = realService;
        }

        public void Pay()
        {
            Console.WriteLine("Proxy can do something...");
            Console.WriteLine("Proxy validating some data...");

            this._realService.Pay();
        }
    }
}
