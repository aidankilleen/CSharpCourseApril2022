using System;
using System.Collections.Generic;
using System.Text;

namespace StaticInvestigation
{
    class Message
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public static int Count = 0;

        public Message(string title, string text)
        {
            Title = title;
            Text = text;
            Count++;
            if (Count % 100 == 0)
            {
                Console.WriteLine($"Created : { Count }");

            }
        }
        ~Message()
        {
            Count--;
            if (Count % 100 == 0)
            {
                Console.WriteLine($"Destructor called : { Count }");

            }
        }

        public static void DisplayCount()
        {

            Console.WriteLine($"The count is { Count }");
        }

        public override string ToString()
        {
            return $"{ Title }\n{ Text }";
        }
    }
}
