namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            string server = "localhost";
            string database = "tweet";
            string user = "root";
            string password = "";
            string port = "3306";
            string sslM = "none";

            string connectionS = $"server={server};port={port};user id={user};password={password};database={database};SslMode={sslM}";

            try
            {
                using (SqlConnection conection = new SqlConnection(connectionS, TimeSpan.FromSeconds(30)))
                {
                    conection.Open();
                    conection.Query("select * from tweets");
                    conection.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


            try
            {
                using (OracleConnection conection = new OracleConnection(connectionS, TimeSpan.FromSeconds(30)))
                {
                    conection.Open();
                    conection.Query("select * from tweets");
                    conection.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }



            try
            {
                using (SqlConnection conection = new SqlConnection(connectionS, TimeSpan.FromSeconds(30)))
                {
                    var dbCommand = new DbCommand(conection, "select * from tweets");
                    dbCommand.Execute();
                    
                    Console.Write(dbCommand);
                }
                using (OracleConnection conection = new OracleConnection(connectionS, TimeSpan.FromSeconds(30)))
                {
                    var dbCommand = new DbCommand(conection, "select * from tweets");
                    dbCommand.Execute();

                    Console.Write(dbCommand);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }
    }
}