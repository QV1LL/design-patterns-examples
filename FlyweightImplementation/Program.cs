using System;
using System.Collections.Generic;

namespace FlyweightImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParticleType myParticleType = new ParticleType("wood", "brown");

            List<Particle> particles = new List<Particle>();

            for (int i  = 0; i < 100; i++)
            {
                Random random = new Random();
                Particle particle = new Particle(random.Next(512), random.Next(512), myParticleType);

                particles.Add(particle);
            }

            foreach (Particle particle in particles)
                particle.Render();
        }
    }
}