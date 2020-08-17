using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Theres two ways we can pass a logger object
            // Method 1
            var dbMigrator = new DbMigrator(new Logger());

            // Method 2
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}
