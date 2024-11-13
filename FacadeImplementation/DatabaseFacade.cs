using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeImplementation
{
    internal class DatabaseFacade
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private QueryExecutor queryExecutor;

        public void ExecuteQuery(string _query)
        {
            queryExecutor = new QueryExecutor(_query);

            databaseConnection.Connect();
            queryExecutor.Execute();
            databaseConnection.Disconnect();
        }
    }
}
