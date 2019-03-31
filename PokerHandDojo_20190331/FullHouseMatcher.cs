using System.Collections.Generic;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class FullHouseMatcher : IHandKindMatcher
    {
        public bool Match(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(x => x.Rank);
            return (cardGroup.Any(x => x.Count() == 3) && cardGroup.Any(x => x.Count() == 2));
        }

        public HandType HandType => HandType.FullHouse;
    }
}