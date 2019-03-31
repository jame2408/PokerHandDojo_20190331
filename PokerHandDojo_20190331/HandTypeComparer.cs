using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public class HandTypeComparer : IComparer<HandType>
    {
        public int Compare(HandType x, HandType y)
        {
            var priorityLookup = new Dictionary<HandType, int>
            {
                {HandType.FourOfAKind, 9 },
                {HandType.FullHouse, 8 },
            };
            return priorityLookup[x] - priorityLookup[y];
        }
    }
}