using System;
using System.Data.SqlClient;

namespace DBHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SQL Server Hello World");

            SqlConnection connection;

            string connectionString = "";

            connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT * FROM users";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string email = reader.GetString(2);
                bool active = reader.GetInt32(3) == 1;


                Console.WriteLine($"{ id } { name } {email } { (active ? "Active" : "Inactive") }");
            }
            reader.Close();
            connection.Close();





        }
    }
}
