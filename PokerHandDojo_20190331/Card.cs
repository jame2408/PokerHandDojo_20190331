using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public class Card
    {
        private readonly Dictionary<char, SuitType> _suitLookup = new Dictionary<char, SuitType>()
        {
            {'S', SuitType.Spade},
            {'D', SuitType.Diamond},
            {'C', SuitType.Club},
            {'H', SuitType.Heart},
        };

        public Card(string card)
        {
            Rank = int.Parse(card.Substring(1));
            Suit = _suitLookup[card[0]];
        }

        public int Rank { get; }
        public SuitType Suit { get; }
    }
}