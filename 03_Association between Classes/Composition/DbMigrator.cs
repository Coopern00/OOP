using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class DbMigrator
    {
        // This field is for an association to the Logger class
        private readonly Logger _logger;

         // Constructor with Logger type parameter
         public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // Calling the Log method of the Logger class
            _logger.Log("We are migrating blah blah blah...");
        }
    }
}
