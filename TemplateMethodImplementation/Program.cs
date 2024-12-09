using System;

namespace TemplateMethodImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginContext loginContext = new LoginContext();

            loginContext.Render();
            loginContext.GetUserData();
            
            if (!loginContext.IsUserValid())
            {
                Console.WriteLine("User data is invalid!");
                return;
            }

            ApplicationContext appContext = new ApplicationContext();
            appContext.Render();
            appContext.Start();
        }
    }
}