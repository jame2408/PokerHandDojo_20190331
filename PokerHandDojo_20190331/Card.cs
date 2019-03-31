using System;
using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public class Card
    {
        //private Dictionary<string, int> _map = new Dictionary<string, int>()
        //{
        //    {"J", 11}
        //};

        public Card(string card)
        {
            Rank = Int32.Parse(card.Substring(1));
            switch (card[0])
            {
                case 'S':
                    Suit = SuitType.Spade;
                    break;

                case 'H':
                    Suit = SuitType.Heart;
                    break;

                case 'D':
                    Suit = SuitType.Diamond;
                    break;

                case 'C':
                    Suit = SuitType.Club;
                    break;
            }
        }

        public int Rank { get; set; }
        public SuitType Suit { get; set; }
    }

    public enum SuitType
    {
        Spade,
        Heart,
        Diamond,
        Club
    }
}