using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace PokerHandDojo_20190331
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            var matchers = new IHandKindMatcher[]
            {
                new HandKindMatcher(),
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

        public HandType HandType { get; set; }
    }
}