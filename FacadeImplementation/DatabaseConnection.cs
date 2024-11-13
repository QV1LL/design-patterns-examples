using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeImplementation
{
    internal class DatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to database...");
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from database...");
        }
    }
}
