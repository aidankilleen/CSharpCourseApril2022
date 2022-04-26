using System;

namespace CardTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card Test");

            Deck d = new Deck();

            d.Display();
            d.Shuffle(1);
            d.Display();
            d.Shuffle(10);
            d.Display();
            d.Shuffle(100);
            d.Display();
            d.Shuffle(1000000);
            d.Display();

        }
    }
}
