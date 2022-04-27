using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoTest
{
    class UserDao
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
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string email = reader.GetString(2);
                bool active = reader.GetInt32(3) == 1;

                User user = new User(id, name, email, active);

                users.Add(user);

            }
            reader.Close();
            return users;
        }

        public User GetUser(int id)
        {
            User user = null;

            string sql = $"SELECT * FROM users WHERE id = {id}";

            SqliteCommand command = new SqliteCommand(sql, connection);

            SqliteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string name = reader.GetString(1);
                string email = reader.GetString(2);
                bool active = reader.GetInt32(3) == 1;

                user = new User(id, name, email, active);
            }

            return user;
        }

        public User AddUser(User userToAdd)
        {
            string sql = $@"INSERT INTO users 
                            (name, email, active)
                            VALUES(
                                '{ userToAdd.Name }', 
                                '{ userToAdd.Email }', 
                                 { (userToAdd.Active ? 1 : 0)})";

            SqliteCommand command = new SqliteCommand(sql, connection);
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
                            SET name = '{ userToUpdate.Name }', 
                                email = '{ userToUpdate.Email }', 
                                active = { (userToUpdate.Active ? 1 : 0 )} 
                            WHERE id = { userToUpdate.Id }";
            SqliteCommand command = new SqliteCommand(sql, connection);

            command.ExecuteNonQuery();
            return userToUpdate;
        }

        public void DeleteUser(int id)
        {
            string sql = $"DELETE FROM users WHERE id = {id}";
            SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
