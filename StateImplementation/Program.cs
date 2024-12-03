using System;

namespace StateImplementation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Player player = new Player();

            player.Stop();
            player.Walk();
            player.Run();
            player.Jump();
            player.Run();
            player.Walk();
            player.Walk();
            player.Jump();
            player.Stop();
        }
    }
}