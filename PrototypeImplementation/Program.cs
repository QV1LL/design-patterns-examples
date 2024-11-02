using System;

namespace PrototypeImplementation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Zombie Zombie1 = new Zombie("Alexandr", 100, 200);
            Zombie Zombie2 = (Zombie) Zombie1.Clone();

            Console.WriteLine(Zombie1 == Zombie2);
        }
    }
}