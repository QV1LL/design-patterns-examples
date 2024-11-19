using System;
using System.Collections.Generic;

namespace ProxyImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = new CardPayment();
            IPayment paymentProxy = new PaymentProxy(payment);

            paymentProxy.Pay();
        }
    }
}