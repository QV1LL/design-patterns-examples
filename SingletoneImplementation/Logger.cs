using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletoneImplementation
{
    internal class Logger
    {
        private static Logger? instance = null;

        private Logger() 
        {
        }

        public static Logger Instance
        {
            get {
                if (instance == null)
                {
                    instance = new Logger();
                }
                    
                return instance;
            }
        }

        public void LogInformation(string message)
        {
            // Logging system...
        }
    }
}
