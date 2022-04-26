using System;

namespace HelloWorld
{
    class Program
    {
        // this is a comment

        /*
         *  this is a c - style comment 
         *  they can span mulitiple lines
         */

        static void Main(string[] args)
        {
                        
            Console.WriteLine("Hello World!");

            int i = 99;

            int answer;
            answer = i + 100;

            double d = i / 99;

            string name = "Aidan";

            bool b = false;

            Random r = new Random();

            int value = r.Next();

            value = r.Next(10);

            Console.WriteLine("The value is " + value);


            // Conditional
            if (value < 3)
            {
                Console.WriteLine("small");
            } else if (value < 7)
            {
                Console.WriteLine("medium");
            } else
            {
                Console.WriteLine("large");
            }


            switch (value)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("medium");
                    break;
                default:
                    Console.WriteLine("big");
                    break;
            }


            string message = "The value is " + (value > 5 ? "Big" : "Small");


            // loops

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }



            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);

                k++;
            }



            int[] list = { 1, 5, 3, 7, 2, 8, 9, 10, 6, 3 };

            for (int n = 0; n < list.Length; n++)
            {
                Console.WriteLine(list[n]);
            }

            Console.WriteLine(list.Length);


            //Console.WriteLine(list[11]);















        }
    }
}
