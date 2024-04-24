namespace DatabaseConnection
{

    public abstract class DbConnection : IDisposable
    {
        public string? ConnectionString {get; private set; }

        public TimeSpan? TimeOut { get; private set; }

        public DbConnection(string connectionString, TimeSpan timeOut)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or whitespace.", nameof(connectionString));
            ConnectionString = connectionString;
            TimeOut = timeOut;
        }

        public abstract void Open();

        public abstract void Close();

        public abstract void Dispose();

        public abstract void Query(string query);


    }
}