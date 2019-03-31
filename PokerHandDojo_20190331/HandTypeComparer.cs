using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public class HandTypeComparer : IComparer<HandType>
    {
        private readonly Dictionary<HandType, int> _priorityLookup = new Dictionary<HandType, int>
        {
            {HandType.FourOfAKind, 9 },
            {HandType.FullHouse, 8 },
            {HandType.HighCard, 1 },
        };

        public int Compare(HandType x, HandType y)
        {
            return _priorityLookup[x] - _priorityLookup[y];
        }
    }
}