using System.Collections.Generic;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class HandKindMatcher : IHandKindMatcher
    {
        public bool Match(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(x => x.Rank);
            return cardGroup.Any(x => x.Count() == 4);
        }

        public HandType HandType => HandType.FourOfAKind;
    }
}