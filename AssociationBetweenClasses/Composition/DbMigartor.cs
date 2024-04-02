namespace Composition
{
    public class DbMigartor
    {
        private readonly Logger _logger;

        public DbMigartor(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating...");
        }
    }
}