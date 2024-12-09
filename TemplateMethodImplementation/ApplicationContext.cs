using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodImplementation
{
    internal class ApplicationContext : Context
    {
        protected override void DrawContent()
        {
            Console.WriteLine("Rendering a application window...");
        }

        public void Start()
        {
            Console.WriteLine("Appication is started...");
        }
    }
}
