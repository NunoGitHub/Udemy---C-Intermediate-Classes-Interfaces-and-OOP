using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DatabaseConnection
{
    public class DbCommand
    {
        public DbConnection _connection;
        private string _sqlInstruction;
        public DbCommand(DbConnection connection, string sqlInstruction)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection), "A DbConnection object is required.");
            }

            if (string.IsNullOrWhiteSpace(sqlInstruction))
            {
                throw new ArgumentException("SQL instruction cannot be null or empty.", nameof(sqlInstruction));
            }

            _connection = connection;
            _sqlInstruction = sqlInstruction;
        }

        public void Execute()
        {
            //to work with sql or other you have to create  a SqlCommend or a OracleCommand like I created to the connection
            _connection.Open();
            Console.WriteLine("Instruction: " + _sqlInstruction);
            _connection.Close();
        }
    }
}