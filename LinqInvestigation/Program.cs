using System;
using System.Collections.Generic;
using UserDaoLibrary;
using System.Linq;

namespace LinqInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Investigation");

            UserDao dao = new UserDao();
            List<User> users = dao.GetUsers();

            IEnumerable<User> result = from user in users 
                                       where user.Active == true 
                                       orderby user.Name
                                       select user;


            foreach (User user in result)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine("======================================");

            var activeUsers = users.FindAll(u => u.Active)
                                    .OrderBy(u => u.Name);

            foreach (User user in activeUsers)
            {
                Console.WriteLine(user);
            }

            IEnumerable<(string Name, string Email)> results = from user in users
                                                               where user.Active == true
                                                               orderby user.Name
                                                               select (user.Name, user.Email);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Name} - { item.Email}");
            }

            Console.WriteLine("======================================");

            var activeSubset = users.FindAll(u => u.Active)
                                    .OrderBy(u => u.Name)
                                    .Select(u => (u.Name, u.Email));

            foreach(var tuple in activeSubset)
            {
                Console.WriteLine($"{ tuple.Name } - { tuple.Email }");
            }



            dao.Close();


        }
    }
}
