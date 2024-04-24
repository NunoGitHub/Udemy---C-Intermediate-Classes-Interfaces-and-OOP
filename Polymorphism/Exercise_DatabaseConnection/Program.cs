namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            string server = "localhost";
            string database = "tweet";
            string user = "root";
            string password = "4578";
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


        }
    }
}