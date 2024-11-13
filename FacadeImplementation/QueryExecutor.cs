using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeImplementation
{
    internal class QueryExecutor
    {
        private string _query;

        public QueryExecutor(string query)
        {
            _query = query;
        }

        public void Execute()
        {
            Console.WriteLine("Doing query: " + this._query);
        }
    }
}
