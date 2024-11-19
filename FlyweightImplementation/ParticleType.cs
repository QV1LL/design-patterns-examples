using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightImplementation
{
    internal class ParticleType
    {
        private string _texture;
        private string _color;

        public ParticleType(string texture, string color)
        {
            _texture = texture;
            _color = color;
        }

        public void Render(float x, float y) {
            Console.WriteLine("Rendering " + this._color +  " particle at coordinates: " 
                + x + ", " + y + ". Texture: " + this._texture);
        }
    }
}
