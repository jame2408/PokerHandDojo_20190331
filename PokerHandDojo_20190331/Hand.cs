using System.Collections.Generic;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            if (new FourOfAKindMatcher().Match(cards))
            {
                HandType = HandType.FourOfAKind;
                return;
            }
            var cardGroup = cards.GroupBy(x => x.Rank);
            if (cardGroup.Any(x => x.Count() == 3) && cardGroup.Any(x => x.Count() == 2))
            {
                HandType = HandType.FullHouse;
            }
            else
            {
                HandType = HandType.HighCard;
            }
        }

        public HandType HandType { get; set; }
    }

    public class FourOfAKindMatcher
    {
        public bool Match(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(x => x.Rank);
            return cardGroup.Any(x => x.Count() == 4);
        }
    }

    public enum HandType
    {
        FourOfAKind,
        FullHouse,
        HighCard
    }
}