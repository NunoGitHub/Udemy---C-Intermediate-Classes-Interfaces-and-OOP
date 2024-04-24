using MySql.Data.MySqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace DatabaseConnection
{
    public class Tweets
    {
        public string username {  get; set; }
        public string tweet_content { get; set; }
        public int number_favourites { get; set; }
    }
    public class SqlConnection : DbConnection
    {
        private MySqlConnection? _connection;
        

        public SqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
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
            try
            {
                _connection.Close();
                Console.WriteLine("Connection is closed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
           
        }

        // 'using' statement in C# is a convenient way to ensure that resources are released when they are no longer needed, and it works by calling the Dispose method on the object when the 'using' block is completed
        public override void Dispose()
        {
            _connection?.Dispose();

        }

        public override void Open()
        {
            if (_connection != null && _connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    _connection.Open();
                    Console.WriteLine("Connection successfull");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    throw;
                }
            }
            else if (_connection?.State == System.Data.ConnectionState.Open)
            {

                Console.WriteLine("connection already open");
            }
            else if (_connection == null)
            {
                Console.WriteLine("connection is null");
            }


        }

        public override void Query(string query)
        {
            // if (_connection == null || _connection.State != System.Data.ConnectionState.Open) throw new InvalidOperationException("Database is not open");
            
            try
            {
                List<Tweets> tweets = new List<Tweets>();
                using (var command = new MySqlCommand(query, _connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        
                        List<string> jsonDBArray = new();
                        JsonElement? jsonElement = null;
                        List<JsonElement?>? jsonArray = new List<JsonElement?>();
                        Dictionary<string, object?>? jsonObject = new Dictionary<string, object?>();
                        //number of column
                        int fieldCount = reader.FieldCount;

                        while (reader.Read())
                        {
                            // Console.WriteLine(reader["username"].ToString());
                            for (int i = 0; i < fieldCount; i++)
                            {
                               // Console.Write($"{reader.GetValue(i)} ");

                                var columnName = reader.GetName(i);
                                var columnValue = reader.GetValue(i);
                                if (jsonObject.ContainsKey(columnName))
                                {
                                    // Atualiza o valor existente
                                    jsonObject[columnName] = columnValue;
                                }
                                else
                                {
                                    // Adiciona a nova chave e valor
                                    jsonObject.Add(columnName, columnValue);
                                }
                            }

                            jsonElement = JsonSerializer.SerializeToElement(jsonObject);
                            if(!jsonElement.HasValue)
                            {
                                throw new InvalidOperationException("jsonElement is null");
                            }
                            //jsonArray.Add(jsonElement);
                            jsonDBArray.Add(((JsonElement)jsonElement).GetRawText());
                        }

                        // Create MemoryStream to write strings in json
                        using (var memoryStream = new MemoryStream())
                        using (var streamWriter = new StreamWriter(memoryStream))
                        {
                            //write [ in the beginning
                            streamWriter.Write("[");

                            // write in every json object, seperated by ","
                            for (int i = 0; i < jsonDBArray.Count; i++)
                            {
                                streamWriter.Write(jsonDBArray[i]);
                                if (i < jsonDBArray.Count - 1) //do not add "," in the final object
                                {
                                    streamWriter.Write(",");
                                }
                            }

                            //write ] in the final
                            streamWriter.Write("]");

                            // streamWriter.Flush() ensures that all JSON data is completely written to the MemoryStream before attempting to deserialize it. This is crucial to ensure that deserialization is successful and that all data is present and correctly formatted
                            streamWriter.Flush();
                            memoryStream.Position = 0; // Reset to the beginning of the o stream

                            // deserialize the memory stream to object list
                            tweets = JsonSerializer.Deserialize<List<Tweets>>(memoryStream);
                           
                        }

                    }
                }

                if (tweets?.Count==0 || tweets == null)
                {
                    throw new InvalidOperationException("tweets has no elements");
                }
                foreach (var item in tweets)
                {
                    Console.Write(item.username + " ");
                    Console.Write(item.tweet_content + " ");
                    Console.Write(item.number_favourites + "\n");
                    
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