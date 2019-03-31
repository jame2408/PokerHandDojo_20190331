using System;

namespace PokerHandDojo_20190331
{
    public class Card
    {
        public Card(string card)
        {
            Rank = Int32.Parse(card.Substring(1));
            Suit = SuitType.Spade;
        }

        public int Rank { get; set; }
        public SuitType Suit { get; set; }
    }

    public enum SuitType
    {
        Spade
    }
}