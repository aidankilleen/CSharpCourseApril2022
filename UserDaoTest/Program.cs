using System;
using System.Collections.Generic;

namespace UserDaoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User DAO Test");
           
            UserDao dao = new UserDao();

            try
            {
                User notFound = dao.GetUser(99999);
                Console.WriteLine(notFound);

            } catch(UserDaoException ex)
            {
                Console.WriteLine("User 99999 not found");
            }

            try
            {
                dao.DeleteUser(2);

            } catch (UserDaoException)
            {
                // do absolutely nothing!!!
            }

            User newUser = new User { 
                    Name = "New User", 
                    Email = "new.user@gmail.com", 
                    Active = true
            };

            User addedUser = dao.AddUser(newUser);
            Console.WriteLine(addedUser);

            List<User> users = dao.GetUsers();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("================");
            User u = dao.GetUser(3);
            Console.WriteLine(u);

            u.Name = "CHANGED";
            u.Email = "changed@gmail.com";
            u.Active = !u.Active;

            dao.UpdateUser(u);

            dao.Close();
        }
    }
}
