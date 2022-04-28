using System;
using System.Collections.Generic;
using UserDaoLibrary;

namespace SharedProjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shared Library Test");

            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();

            foreach(User user in users)
            {
                Console.WriteLine(user);
            }

            dao.Close();
        }
    }
}
