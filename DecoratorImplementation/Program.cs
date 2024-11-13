using System;

namespace DecoratorImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct coffee = new Coffee(10);

            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);

            Console.WriteLine(coffee.GetPrice());
        }
    }
}