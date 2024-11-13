using System;
using System.Collections.Generic;

namespace FacadeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseFacade databaseFacade = new DatabaseFacade();
            databaseFacade.ExecuteQuery("Select * from database");
        }
    }
}