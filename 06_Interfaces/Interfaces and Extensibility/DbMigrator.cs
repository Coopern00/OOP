﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        // Dependency injection
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
