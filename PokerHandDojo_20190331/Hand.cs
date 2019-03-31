using System.Collections.Generic;

namespace PokerHandDojo_20190331
{
    public class Hand
    {
        public Hand(IEnumerable<Card> cards)
        {
            HandType = HandType.FourOfAKind;
        }

        public HandType HandType { get; set; }
    }

    public enum HandType
    {
        FourOfAKind
    }
}