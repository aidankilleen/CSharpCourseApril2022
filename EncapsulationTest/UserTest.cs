using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationTest
{
    class UserTest
    {

        static void Main(string[] args)
        {

            Console.WriteLine("User Test");

            User u = new User();

            u.Id = 1;
            u.Name = "Alice";
            u.Email = "alice@gmail.com";
            u.Active = false;

            User u2 = new User(2, "Bob", "bob@gmail.com", false);

            User u3 = new User
            {
                Id = 3,
                Name = "Carol",
                Email = "carol@gmail.com",
                Active = true
            };


            User[] users = new User[4];

            users[0] = new User(1, "Alice", "alice@gmail.com", false);

            users[1] = new User
            {
                Id = 2,
                Name = "Bob",
                Email = "bob@gmail.com",
                Active = false
            };

            users[2] = new User();
            users[2].Id = 3;
            users[2].Name = "Carol";
            users[2].Email = "carol@gmail.com";
            users[2].Active = true;


            User[] team = new User[]
            {
                new User { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = false },
                new User { Id = 2, Name = "Bob", Email = "bob@gmail.com", Active = true },
                new User { Id = 3, Name = "Carol", Email = "carol@gmail.com", Active = true },
                new User { Id = 4, Name = "Dan", Email = "dan@gmail.com", Active = false }
            };


            for (int i=0; i < team.Length; i++)
            {
                Console.WriteLine(team[i].Name);
            }

            Console.WriteLine("==============================");

            foreach (User member in team)
            {
                Console.WriteLine(member.Name);
            }









        }
    }
}
