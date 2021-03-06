using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            var matchers = new IHandKindMatcher[]
            {
                new FourOfAKindMatcher(),
                new FullHouseMatcher(),
            };
            foreach (var matcher in matchers)
            {
                if (matcher.Match(cards))
                {
                    HandType = matcher.HandType;
                    return;
                }
            }

            HandType = HandType.HighCard;
        }

        public HandType HandType { get; }
    }
}