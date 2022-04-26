using System;

namespace StaticInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Math.PI);


            string number = "99";

            double d = 9.9999;

            int n = (int)d;
            // n = (int)number;

            n = int.Parse(number);

            Console.WriteLine(DateTime.Now);


            Console.WriteLine($"The answer is { n }");

            Console.WriteLine();


            Console.WriteLine("Static Investigation");

            Message m1 = new Message("M1", "This is m 1");


            Console.WriteLine(Message.Count);

            Console.WriteLine(m1.Title);
            

            Message m2 = new Message("M2", "This is m 2");

            Message.DisplayCount();

            Message m3 = new Message("M3", "This is m 3");

            Console.WriteLine(Message.Count);



            // Console.WriteLine(m1.Count);







        }
    }
}
