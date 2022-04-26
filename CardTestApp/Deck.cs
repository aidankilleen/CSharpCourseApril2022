using System;
using System.Collections.Generic;
using System.Text;

namespace CardTestApp
{
    class Deck
    {
        // member variables (properties)
        private Card[] cards = new Card[52];

        // member functions (methods)
        // constructor(s)
        public Deck()
        {
            int i = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[i++] = new Card(value, suit);
                }
            }
        }
        // Display()
        public void Display()
        {
            for (int i=0; i<cards.Length; i++)
            {
                cards[i].Display();

                if (i == 12 || i == 25 || i == 38 || i == 51)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        // Shuffle()
        public void Shuffle(int count)
        {
            Random r = new Random();

            for (int i=0; i<count; i++)
            {
                int n1 = r.Next(52);
                int n2 = r.Next(52);

                Card t = cards[n1];
                cards[n1] = cards[n2];
                cards[n2] = t;
            }
        }
    }
}
