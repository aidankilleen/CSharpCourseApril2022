using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Investigation");

            User[] users = new User[]
            {
                new User(1, "Alice", "alice@gmail.com", false),
                new User(2, "Bob", "bob@gmail.com", true),
                new User(3, "Carol", "carol@gmail.com", false),
                new User(4, "Dan", "dan@gmail.com", true)
            };

            foreach (User u in users)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine("============================");

            ArrayList userList = new ArrayList();

            userList.Add(new User(1, "Alice", "alice@gmail.com", false));
            userList.Add(new User(2, "Bob", "bob@gmail.com", true));
            userList.Add(new User(3, "Carol", "carol@gmail.com", false));
            userList.Add(new User(4, "Dan", "dan@gmail.com", true));
            userList.Add(new User(5, "Eve", "eve@gmail.com", false));
            // userList.Add("not a user object");

            foreach (User u in userList)
            {
                u.Display();
            }

            Console.WriteLine("=======================================");

            List<User> genericUserList = new List<User>();

            genericUserList.Add(new User(1, "Alice", "alice@gmail.com", false));
            genericUserList.Add(new User(2, "Bob", "bob@gmail.com", true));
            genericUserList.Add(new User(3, "Carol", "carol@gmail.com", false));
            genericUserList.Add(new User(4, "Dan", "dan@gmail.com", true));
            genericUserList.Add(new User(5, "Eve", "eve@gmail.com", false));
            // genericUserList.Add("this is not a user object");

            foreach (User u in genericUserList)
            {
                u.Display();
            }

            genericUserList.Reverse();

            foreach (User u in genericUserList)
            {
                u.Display();
            }

            Console.WriteLine(genericUserList.Count);


            Console.WriteLine("================================");

            genericUserList.ForEach(UserAction);


            Console.WriteLine("================================");

            genericUserList.ForEach((user) => {

                Console.WriteLine("User Lambda Expression called");
                Console.WriteLine(user);
            });

        }

        public static void UserAction(User user) {

            Console.WriteLine("User Action Called:");
            Console.WriteLine(user);


        }
    }
}
