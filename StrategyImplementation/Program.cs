using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameArchitectureExample
{
    class Game
    {
        // Implementation of strategy pattern 
        static void Main(string[] args)
        {
            Console.WriteLine("Game started!");

            King king = new King("Arthur", new SwordBehavior());
            king.Fight();

            Knight knight = new Knight("Brave knight", new BowBehavior());
            knight.Fight();
        }
    }
}