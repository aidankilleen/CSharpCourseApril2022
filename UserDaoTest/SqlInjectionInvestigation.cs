using System;
using System.Collections.Generic;
using System.Text;

namespace UserDaoTest
{
    class SqlInjectionInvestigation
    {

        static void Main(string[] args)
        {

            Console.WriteLine("SQL Injection Investigation");


            UserDao dao = new UserDao();

            
            User userToAdd = new User
            {
                Name = "','',0); drop table users;  --", 
                Email = "someone@gmail.com", 
                Active = false
            };

            User addedUser = dao.AddUser(userToAdd);

            Console.WriteLine(addedUser);

            dao.Close();


        }
    }
}
