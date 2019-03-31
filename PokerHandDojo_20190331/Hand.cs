using System.Collections.Generic;
using System.Linq;

namespace PokerHandDojo_20190331
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            var cardGroup = cards.GroupBy(x => x.Rank);

            if (cardGroup.Any(x => x.Count() == 4))
            {
                HandType = HandType.FourOfAKind;
            }
            else if (IsFullHouse(cardGroup))
            {
                HandType = HandType.FullHouse;
            }
            else
            {
                HandType = HandType.HighCard;
            }
        }

        private static bool IsFullHouse(IEnumerable<IGrouping<int, Card>> cardGroup)
        {
            return cardGroup.Any(x => x.Count() == 3) && cardGroup.Any(x => x.Count() == 2);
        }

        public HandType HandType { get; set; }
    }

    public enum HandType
    {
        FourOfAKind,
        FullHouse,
        HighCard
    }
}