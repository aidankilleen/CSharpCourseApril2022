using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaInvestigation
{

    partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }

    class Program
    {
        static bool CheckEven(int i)
        {
            return (i % 2 == 0);
        }

        static bool CheckOdd(int i)
        {
            return (i % 2 == 1);
        }

        delegate bool CheckFunction(int n);

        static void ProcessList(int[] list, CheckFunction checkFunction)
        {
            foreach(int item in list)
            {
                if (checkFunction(item))
                {
                    Console.WriteLine($"{item} matches the check function");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression Investigation");

            int[] list = { 1, 4, 2, 7, 9, 10, 3, 6, 8, 5 };


            ProcessList(list, (i) =>
            {
                if (i % 2 == 1)
                {
                    return true;
                } else
                {
                    return false;
                }
            });
            Console.WriteLine("==========================================");

            ProcessList(list, i => i % 2 == 0);


            List<int> numberList = new List<int>();

            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(6);
            numberList.Add(2);
            numberList.Add(9);
            numberList.Add(4);
            numberList.Add(8);

            Console.WriteLine("==========================================");

            numberList.ForEach(i => Console.WriteLine(i));



            int index = numberList.FindIndex(item => item == 9);


            Console.WriteLine($"index = { index }");


            List<User> users = new List<User>();

            users.Add(new User(15, "Seamore", "harriet@gmail.com", false));
            users.Add(new User(9, "Alice", "alice@gmail.com", false));
            users.Add(new User(99, "Seàn", "fred@gmail.com", false));
            users.Add(new User(46, "Dan", "dan@gmail.com", true));
            users.Add(new User(5, "Eve", "eve@gmail.com", false));
            users.Add(new User(27, "Sean", "ger@gmail.com", false));
            users.Add(new User(15, "Carol", "carol@gmail.com", true));
            users.Add(new User(1, "Bob", "bob@gmail.com", true));


            users.ForEach(user => Console.WriteLine(user));

            index = users.FindIndex(user => user.Name.Equals("Dan"));

            Console.WriteLine($"index = { index }");

            List<User> activeUsers = users.FindAll(user => user.Active);

            activeUsers.ForEach(user => Console.WriteLine(user));

            Console.WriteLine("==================================");
            users.FindAll(user => !user.Active)
                 .ForEach(user => Console.WriteLine(user));


            Console.WriteLine("=================================");

            users.Sort((u1, u2) => u2.Id - u1.Id);

            users.ForEach(u => Console.WriteLine(u));


            users.Sort((u1, u2) => String.Compare(u1.Name, u2.Name));

            Console.WriteLine("=================================");
            users.ForEach(u => Console.WriteLine(u));



        }
    }
}
