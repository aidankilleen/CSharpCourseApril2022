using System;
using UserDaoLibrary;

namespace NewishFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Newish Features - Var Keyword");


            string name = "Aidan";

            // name = 27;

            var address = "Cork";

            // address = 27;

            UserDao dao = new UserDao();

            var users = dao.GetUsers();

            foreach (var u in users)
            {
                Console.WriteLine(u);
            }

        }
    }
}
