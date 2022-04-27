using Microsoft.Data.Sqlite;
using System;

namespace SqliteDbHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sqlite DB Hello World");

            SqliteConnection connection;
            string connectionString = "Data Source=C:/data/cso/csharp/usersdb.db";

            connection = new SqliteConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM users";

            SqliteCommand command = new SqliteCommand(sql, connection);
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
            }
            reader.Close();
            connection.Close();
        }
    }
}
