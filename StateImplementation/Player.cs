using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StateImplementation
{
    internal class Player
    {
        private int _health;
        private IPlayerState _playerState;

        public Player(int health = 100)
        {
            this._health = health;
            this._playerState = new IdleState();
        }

        public void Attack(Player other)
        {
            other.GetAttacked(20);
        }

        public void GetAttacked(int damage)
        {
            this._health -= damage;
        }

        public void Walk()
        {
            this._playerState.Walk();
            this._playerState = new WalkingState();
        }

        public void Run()
        {
            this._playerState.Run();
            this._playerState = new RunningState();
        }

        public void Jump()
        {
            this._playerState.Jump();
            this._playerState = new JumpingState();

            // Some jump logic

            // End of jump

            this._playerState = new IdleState();
        }

        public void Stop()
        {
            Console.WriteLine("Player stoped");
            this._playerState = new IdleState();
        }
    }
}
