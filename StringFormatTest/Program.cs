using System;

namespace StringFormatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Formatting");

            string name = "Aidan";
            string message = "Welcome " + name;


            Console.WriteLine(message);

            int answer = 100 / 25;

            Console.WriteLine("The answer is " + answer);

            message = "Welcome " + name + "\n The answer is " + answer;

            Console.WriteLine(message);


            message = "press the \"red\" button";
            Console.WriteLine(message);
            message = "one\ttwo\tthree\tfour";
            Console.WriteLine(message);


            string path = "C:\\my documents\\aidan\\files\\test.txt";
            Console.WriteLine(path);



            // String.Format
            message = String.Format("my name is {0}\n the answer is {1}", name, answer);
            Console.WriteLine(message);

            double price = 1.2345678;


            message = String.Format("The price is {0:C2}", price);
            Console.WriteLine(message);
            Console.WriteLine("my name is {0}\n the answer is {1}", name, answer);


            // Templated strings
            message = $"my name is { name }\n the answer is { answer }";

            Console.WriteLine(message);


            Random r = new Random();


            int r1 = r.Next(100);
            int r2 = r.Next(100);
            message = $"{ r1 } + { r2 } = { r1 + r2 }";

            Console.WriteLine(message);


            int r3 = r.Next(10);


            message = $"The value is {r3} it is { (r3 > 5 ? "big" : "small") }";


            Console.WriteLine(message);


            path = @"c:\my documents\files\test.txt";


            Console.WriteLine(path);


            message = @"
                A raw string 
                can span 
                multiple lines

                ";



            Console.WriteLine(message);



message = $@"my name is { name }
the answer is { answer }
path is c:\my documents\files\
";


            Console.WriteLine(message);






































        }
    }
}
