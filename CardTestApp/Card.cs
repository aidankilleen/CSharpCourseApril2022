using System;
using System.Collections.Generic;
using System.Text;

namespace CardTestApp
{
    class Card
    {
        // member variables
        private int value; // A=1, 2=2, 3=3,...J=11, Q=12, K=13
        private int suit; // H=1, S=2, D=3, C=4

        // member functions

        // create a card
        // constructor(s)
        public Card()
        {
        }
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        // display a card
        public void Display()
        {
            switch(value)
            {
                case 1:
                    Console.Write(" A");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.Write(" " + value);
                    break;
                case 10:
                    Console.Write("" + value);
                    break;
                case 11:
                    Console.Write(" J");
                    break;
                case 12:
                    Console.Write(" Q");
                    break;
                case 13:
                    Console.Write(" K");
                    break;
                default:
                    Console.Write(" ?");
                    break;
            }


            if (suit == 1)
            {
                Console.Write("H ");
            } else if (suit == 2)
            {
                Console.Write("S ");
            } else if (suit == 3)
            {
                Console.Write("D ");
            } else if (suit == 4)
            {
                Console.Write("C ");
            } else
            {
                Console.Write("? ");
            }

        }

    }
}
