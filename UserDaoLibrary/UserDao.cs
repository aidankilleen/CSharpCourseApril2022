using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoLibrary
{
    /// <summary>
    /// UserDao Class - used for reading and writing User objects
    /// Please ensure you call the Close() method when finished
    /// </summary>
    public class UserDao
    {
        private SqliteConnection connection;
        string connectionString = "Data Source=C:/data/cso/csharp/usersdb.db";


        public UserDao()
        {
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            String sql = "SELECT * FROM users";
            SqliteCommand command = new SqliteCommand(sql, connection);
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("id"));
                string name = reader.GetString(reader.GetOrdinal("name"));
                string email = reader.GetString(reader.GetOrdinal("email"));
                bool active = reader.GetInt32(reader.GetOrdinal("active")) == 1;

                User user = new User(id, name, email, active);

                users.Add(user);

            }
            reader.Close();
            return users;
        }

        /// <summary>
        /// Get the requested User from the database
        /// </summary>
        /// <param name="id">id of the requested user</param>
        /// <returns>a User object</returns>
        public User GetUser(int id)
        {
            User user = null;

            string sql = $"SELECT * FROM users WHERE id = {id}";

            SqliteCommand command = new SqliteCommand(sql, connection);

            SqliteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string name = reader.GetString(reader.GetOrdinal("name"));
                string email = reader.GetString(reader.GetOrdinal("email"));
                bool active = reader.GetInt32(reader.GetOrdinal("active")) == 1;

                user = new User(id, name, email, active);
            } else
            {
                throw new UserDaoException($"User { id } not found");
            }

            return user;
        }

        public User AddUser(User userToAdd)
        {
            string sql = $@"INSERT INTO users (name, email, active) 
                            VALUES($name, $email, $active)";

            Console.WriteLine(sql);

            SqliteCommand command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("$name", userToAdd.Name);
            command.Parameters.AddWithValue("$email", userToAdd.Email);
            command.Parameters.AddWithValue("$active", userToAdd.Active ? 1 : 0);

            command.ExecuteNonQuery();

            // Get the id of the new record
            sql = "SELECT last_insert_rowid()";

            command = new SqliteCommand(sql, connection);

            SqliteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                userToAdd.Id = reader.GetInt32(0);
            }

            reader.Close();
            return userToAdd;
        }

        public User UpdateUser(User userToUpdate)
        {
            string sql = $@"UPDATE users 
                            SET name = $name, 
                                email = $email, 
                                active = $active 
                            WHERE id = $id";
            SqliteCommand command = new SqliteCommand(sql, connection);

            command.Parameters.AddWithValue("$name", userToUpdate.Name);
            command.Parameters.AddWithValue("$email", userToUpdate.Email);
            command.Parameters.AddWithValue("$active", userToUpdate.Active ? 1 : 0);
            command.Parameters.AddWithValue("$id", userToUpdate.Id);

            command.ExecuteNonQuery();
            return userToUpdate;
        }

        public void DeleteUser(int id)
        {
            string sql = $"DELETE FROM users WHERE id = { id }";
            SqliteCommand command = new SqliteCommand(sql, connection);
            if (command.ExecuteNonQuery() == 0)
            {
                throw new UserDaoException($"User { id } not found");
            }



        }

        public void Close()
        {
            connection.Close();
        }
    }
}
