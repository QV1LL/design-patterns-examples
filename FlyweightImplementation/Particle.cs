using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightImplementation
{
    internal class Particle
    {
        private float _x;
        private float _y;

        private ParticleType _type;

        public Particle(float x, float y, ParticleType particleType)
        {
            this._x = x;
            this._y = y;

            this._type = particleType;
        }

        public void Render()
        {
            this._type.Render(this._x, this._y);
        }
    }
}
