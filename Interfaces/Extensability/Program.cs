namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //I did not change one line of code in dbMigrator and this behaviour is called changing behaviour by extending application instead of changing the code
            //this is called open close principle or OCP which states suffer entities should be open for extention but closed to modification
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbMigratorFile = new DbMigrator(new FileLogger("../../../file.txt"));
            dbMigratorFile.Migrate();
        }
    }
}