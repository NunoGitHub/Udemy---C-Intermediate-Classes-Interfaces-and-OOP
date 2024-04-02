﻿namespace Composition
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dbMigrator = new DbMigartor(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}