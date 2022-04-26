using System;

namespace CommonBaseClass
{

    class Person : Object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   FirstName == person.FirstName &&
                   LastName == person.LastName;
        }
        public override string ToString()
        {
            return $"{ FirstName } { LastName }";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Common Base Class");
            Person p = new Person { FirstName = "Alice", LastName = "Adams" };
            Console.WriteLine(p);

            Person p2 = new Person { FirstName = "Alice", LastName = "Adams" };
            if (p.Equals(p2))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }



        }
    }
}
