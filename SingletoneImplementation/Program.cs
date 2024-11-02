using System;
using System.Collections.Generic;

namespace SingletoneImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger logger = Logger.Instance;

            logger.LogInformation("Hello world!");
        }
    }
}
