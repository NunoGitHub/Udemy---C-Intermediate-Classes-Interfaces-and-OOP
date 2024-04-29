namespace Extensibility
{
    public partial class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migrating start at {DateTime.Now}");
            //Detail migrating db
            _logger.LogInfo($"Migrating finished at {DateTime.Now}");
        }
    }
}