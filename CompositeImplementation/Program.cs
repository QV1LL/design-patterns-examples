using System;

namespace CompositeImplementation
{
    internal class Program
    {
        static void Main(string[] args) {
            Package package = new Package();
            package.AddComponent(new Item(20));
            package.AddComponent(new Item(20));

            package.AddComponent(package.Clone());
            package.AddComponent(package.Clone());

            Console.WriteLine(package.GetPrice());
        }
    }
}