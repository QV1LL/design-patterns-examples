using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodImplementation
{
    internal class LoginContext : Context
    {
        private string? _username;
        private string? _password;

        protected override void DrawContent()
        {
            Console.WriteLine("Rendering a login window...");
        }

        public void GetUserData()
        {
            Console.WriteLine("Username: ");
            this._username = Console.ReadLine();

            Console.WriteLine("Password: ");
            this._password = Console.ReadLine();
        }

        public bool IsUserValid()
        {
            if (this._username == "" || this._password == "")
                return false;

            return true;
        }
    }
}
