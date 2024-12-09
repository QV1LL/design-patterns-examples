using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodImplementation
{
    internal abstract class Context
    {
        public void Render()
        {
            Setup();
            DrawContent();
        }

        private void Setup()
        {
            Console.WriteLine("Setupping window...");
        }

        public void Refresh()
        {
            Console.WriteLine("Refreshing the window...");
            Render();
        }

        protected abstract void DrawContent();
    }
}
