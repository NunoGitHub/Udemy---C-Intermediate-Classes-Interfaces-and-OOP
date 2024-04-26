using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace DatabaseConnection
{
    class OracleConnection : DbConnection
    {
        private MySqlConnection? _connection;

        public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {

            try
            {
                connectionString += $";Connect Timeout={timeOut.TotalSeconds};";
                _connection = new MySqlConnection(connectionString);
                Console.WriteLine("Connection database sucessful");
            }
            catch (SqlException ex) when (ex.Number == -2) // Timeout expired.
            {
                Console.WriteLine("Connection cannot be open within a timeout");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public override void Close()
        {
            Console.WriteLine("Close Connection");
        }

        public override void Dispose()
        {
            Console.WriteLine("Dispose Connection");
        }

        public override void Open()
        {
            Console.WriteLine("Open Connections");
        }

        public override void Query(string query)
        {
            Console.WriteLine("Query inserted = "+ query );
        }
    }
}